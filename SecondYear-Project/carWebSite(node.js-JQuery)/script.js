const express = require('express');
const mysql = require('mysql');
const path = require('path');
const bodyParser = require('body-parser');
const crypto = require('crypto');
const nodemailer = require('nodemailer');
const jwt = require('jsonwebtoken');
const bcrypt = require('bcrypt');



require('dotenv').config();

const app = express();
const port = 3000;

app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: true }));
const SECRET_KEY = 'SecretKey';
// MySQL connection pool
const pool = mysql.createPool({
    connectionLimit: 100,
    host: process.env.MYSQL_HOST,
    user: process.env.MYSQL_USER,
    password: process.env.MYSQL_PASSWORD,
    database: process.env.MYSQL_DATABASE,
});

// Serve static files from the "html" directory
app.use(express.static(path.join(__dirname, 'html')));

// Route handling
app.get('/', (req, res) => {
    res.sendFile(path.join(__dirname, 'html', 'Home.html'));
});

app.get('/success', (req, res) => {
    res.sendFile(path.join(__dirname, 'html', 'Login.html'));
});

app.get('/getOrder', (req, res) => {
    pool.query("SELECT * FROM `orders`", (err, results) => {
        if (err) {
            console.error('Error fetching products:', err);
            res.status(500).send('Error fetching products');
            return;
        }
        console.log(results);
        return res.json(results);
    });
});


app.get('/products', (req, res) => {
    pool.query("SELECT * FROM products", (err, results) => {
        if (err) {
            console.error('Error fetching products:', err);
            res.status(500).send('Error fetching products');
            return;
        }
        return res.json(results);
    });
});

app.get('/get-order-details/:orderId', (req, res) => {
    const { orderId } = req.params;

    // Step 1: Fetch order items for the given order ID
    const orderItemsQuery = `
        SELECT
            oi.order_id,
            oi.product_id,
            oi.quantity,
            oi.subtotal,
            p.product_name,
            p.product_price,
            p.product_image,
            o.shipping_address,
            o.status
        FROM
            order_items oi
        JOIN
            products p ON oi.product_id = p.product_id
        JOIN
            orders o ON oi.order_id = o.order_id
        WHERE 
            oi.order_id = ?
    `;

    pool.query(orderItemsQuery, [orderId], (err, orderItemsResult) => {
        if (err) {
            console.error('Error fetching order items:', err);
            return res.status(500).json({ message: 'Error fetching order items' });
        }

        if (orderItemsResult.length === 0) {
            return res.status(404).json({ message: 'Order not found' });
        }

        res.status(200).json(orderItemsResult);

    });
});

app.get('/update-order-status', (req, res) => {
    const { orderId, status } = req.query; // Retrieve parameters from the query string
    console.log(req.query);
    // Validate the input
    if (!orderId || !status) {
        return res.status(400).json({ message: 'Missing orderId or status' });
    }

    // Query to update the order status
    const updateQuery = `
        UPDATE orders
        SET status = ?
        WHERE order_id = ?
    `;

    pool.query(updateQuery, [status, orderId], (err, result) => {
        if (err) {
            console.error('Error updating order status:', err);
            return res.status(500).json({ message: 'Error updating order status' });
        }

        if (result.affectedRows === 0) {
            return res.status(404).json({ message: 'Order not found' });
        }

        res.status(200).json({ message: 'Order status updated successfully' });
    });
});



// Simulating a cart (you could connect this to a database)
let cartItems = [];

// Route to add items to the cart
app.post("/add-to-cart", (req, res) => {
    cartItems = req.body;
    console.log(cartItems);
    res.json({ success: true });
});

// Route to get cart items
app.get("/checkout", (req, res) => {
    res.sendFile(path.join(__dirname, 'html', 'checkOut.html'));
});
app.get("/cart-data", (req, res) => {
    res.json(cartItems); // Send cart data as JSON
});

let TPrice = 0;
app.get("/pay", (req, res) => {
    console.log(req.body);
    res.sendFile(path.join(__dirname, 'html', 'pay.html'));
});

app.post('/process-payment', (req, res) => {

    const { userId, totalPrice, shippingAddress } = req.body;
    console.log({ userId, totalPrice, shippingAddress });
    console.log('Received Order Data:', req.body);

    // Step 1: Insert into the Orders table
    const orderQuery = `
        INSERT INTO orders (user_id, total_amount, shipping_address, status)
        VALUES (?, ?, ?, 'Pending')
    `;
    const orderValues = [userId, totalPrice, shippingAddress];

    pool.query(orderQuery, orderValues, (err, orderResult) => {
        if (err) {
            console.error('Error inserting order:', err);
            return res.status(500).json({ message: 'Error processing order' });
        }

        const orderId = orderResult.insertId; // Get the inserted order_id
        console.log('Order inserted with ID:', orderId);

        // Step 2: Insert items into the Order_Items table
        const itemQueries = cartItems.map(item => {
            return new Promise((resolve, reject) => {
                const itemQuery = `
                    INSERT INTO Order_Items (order_id, product_id, product_name, product_price, quantity, subtotal)
            VALUES (?, ?, ?, ?, ?, ?)
                `;
                const itemValues = [
                    orderId,
                    item.product_id,
                    item.name,
                    item.price,
                    item.quantity,
                    item.price * item.quantity
                ];

                pool.query(itemQuery, itemValues, (err, itemResult) => {
                    if (err) {
                        return reject(err);
                    }
                    resolve(itemResult);
                });
            });
        });

        // Execute all item queries
        Promise.all(itemQueries)
            .then(results => {
                console.log('All items inserted successfully:', results);
                return res.status(200).json({
                    message: 'Order and items processed successfully',
                    orderId
                });
            })
            .catch(err => {
                console.error('Error inserting order items:', err);

                // Rollback strategy (optional)
                // Remove the partially inserted order and its items if needed
                pool.query('DELETE FROM Orders WHERE order_id = ?', [orderId], () => {
                    return res.status(500).json({ message: 'Error processing order items' }); // Ensure this is the only response
                });
            });
    });
});
// Validate credentials function
const Login = (email, password, callback) => {
    // Query to find the user by email
    pool.query('SELECT * FROM `users` WHERE `email` = ?', [email], (err, result) => {
        if (err) {
            return callback(err, null); // Handle database errors
        }

        // Check if the user exists
        if (result.length > 0) {
            const user = result[0];
            console.log(result);
            // If passwords match, generate a JWT token
            const token = jwt.sign({ userId: user.user_id }, SECRET_KEY, { expiresIn: '1h' });

            // Return the response with token and user role/status
            return callback(null, {
                valid: true,
                userId: user.user_id,
                role: user.role,
                token: token
            });


        } else {
            // If no user is found with the provided email
            return callback(null, { valid: false, message: 'Invalid email or password' });
        }
    });
}


// Protected route to get user ID (e.g., after the user has logged in)
app.get('/profile', (req, res) => {
    // Get the token from the Authorization header
    const token = req.headers['authorization'];

    if (token) {
        // Verify the JWT token
        jwt.verify(token, SECRET_KEY, (err, decoded) => {
            if (err) {
                return res.status(401).json({ message: 'Invalid or expired token' });
            }
            // Token is valid, so return the user ID
            res.json({ message: 'User is logged in', userId: decoded.userId });
        });
    } else {
        res.status(401).json({ message: 'No token provided' });
    }
});

// Handle login form submission
app.post('/login', (req, res) => {
    const { email, password } = req.body;

    Login(email, password, (err, result) => {
        if (err) {
            console.error('Error during login:', err);
            return res.status(500).json({ message: 'Internal Server Error' });
        }

        console.log('Login Response:', result); // Debug the result here

        if (result.valid) {
            return res.json(result); // Send user info back to the client
        } else {
            return res.status(401).json({ message: result.message });
        }
    });
});

const Register = (fullname, phone, email, password, role, staffid, callback) => {
    // Validate staff ID, email, and name if `staffid` is provided
    if (staffid) {
        pool.query(
            'SELECT * FROM `staff` WHERE `staff_id` = ? AND `email` = ? AND `name` = ?',
            [staffid, email, fullname],
            (err, result) => {
                if (err) {
                    console.error('Error querying staff table:', err);
                    return callback(err, { message: 'Error checking staff data' });
                }
                if (result.length === 0) {
                    // No matching staff record found
                    return callback(null, { valid: false, message: 'Staff data mismatching' });
                }
                // Proceed with registration if staff data matches
                proceedWithRegistration();
            }
        );
    } else {
        // Skip staff validation if no `staffid` is provided
        proceedWithRegistration();
    }

    // Inner function for proceeding with user registration
    function proceedWithRegistration() {
        let status = null;
        let staffidSQL = null;

        // Set additional fields based on the role
        if (role === "vehicle_sales") {
            staffidSQL = staffid;
            role = "vehicle_sales_personnel";
        }
        if (role === "insurance_sales") {
            staffidSQL = staffid;
            status = 'processing';
            role = "insurance_sales_personnel";
        }

        // Insert user into the `users` table
        pool.query(
            `INSERT INTO users (user_id, name, email, password, phone, role, staff_id, status) VALUES (null, ?, ?, ?, ?, ?, ?, ?)`,
            [fullname, email, password, phone, role, staffidSQL, status],
            (err, result) => {
                if (err) {
                    console.error('Error inserting user:', err);
                    return callback(err, { message: 'Error registering user' });
                }
                if (result.affectedRows === 1) {
                    // Registration successful
                    return callback(null, { valid: true });
                } else {
                    // Registration failed for unknown reasons
                    return callback(null, { valid: false, message: 'User not registered' });
                }
            }
        );
    }
};



// Handle register form submission
app.post('/register', (req, res) => {
    const { fullname, phone, email, password, role, staffid } = req.body;

    Register(fullname, phone, email, password, role, staffid, (err, result) => {
        if (err) {
            console.error('Error validating credentials:', err);
            return res.status(500).send(result.message || 'Internal server error');
        }

        if (result.valid) {
            return res.status(201).send('true'); // Registration successful
        } else {
            return res.status(400).send(result.message || 'Registration failed');
        }
    });
});



//********reset password */
app.post('/request-reset', (req, res) => {
    const { email } = req.body;

    const token = crypto.randomBytes(20).toString('hex');
    const expires = new Date(Date.now() + 3600000).toISOString().slice(0, 19).replace('T', ' '); // Format for MySQL

    pool.query('UPDATE users SET reset_password_token = ?, reset_password_expires = ? WHERE email = ?', [token, expires, email], (err, result) => {
        if (err) {
            return res.status(500).send('Error generating reset token');
        }

        if (result.warningCount > 0) {
            console.warn('Warning occurred:', result);
        }

        const transporter = nodemailer.createTransport({
            host: 'smtp.gmail.com',
            port: 587,
            secure: false, // true for 465, false for other ports
            auth: {
                user: 'dardarlovecomdom@gmail.com',
                pass: 'whec taax ktht lpag', // Consider using an app password if 2-Step Verification is enabled
            },
        });

        const mail_option = {
            from: email, // Fixed here
            to: email,
            subject: 'Password Reset Request',
            text: `You are receiving this because you (or someone else) have requested the reset of the password for your account.\n\n` +
                `Please click on the following link, or paste this into your browser to complete the process:\n\n` +
                `http://127.0.0.1:3000/reset/${token}\n\n` +
                `If you did not request this, please ignore this email and your password will remain unchanged.`,
        };

        transporter.sendMail(mail_option, (error, info) => {
            if (error) {
                console.log(error);
                return res.status(500).send('Error sending email');
            }
            res.redirect('/success');
        });
    });
});

// Verify Token and Show Reset Form
app.get('/reset/:token', (req, res) => {
    const { token } = req.params;

    pool.query(
        'SELECT * FROM users WHERE reset_password_token = ? AND reset_password_expires > ?',
        [token, Date.now()],
        (err, result) => {
            if (err || result.length === 0) {
                return res.status(400).send('Invalid or expired token');
            }

            // Redirect to the resetpassword.html page with the token as a query parameter
            res.redirect(`/resetpassword.html?token=${token}`);
        }
    );
});

// Update Password
app.post('/reset', (req, res) => {
    const { token, password } = req.body;

    pool.query('SELECT * FROM users WHERE reset_password_token = ? AND reset_password_expires > ?', [token, Date.now()], (err, result) => {
        if (err || result.length === 0) {
            return res.status(400).send('Invalid or expired token');
        }

        // Update password and clear reset token
        pool.query('UPDATE users SET password = ?, reset_password_token = NULL, reset_password_expires = NULL WHERE reset_password_token = ?', [password, token], (err, result) => {
            if (err) {
                return res.status(500).send('Error updating password');
            }
            res.status(200).send('Password has been reset');
        });
    });
});
//*******email sending*******



// Error handling middleware
app.use((err, req, res, next) => {
    console.error(err.stack);
    res.status(500).send('Sorry, internal server error');
});

// Handle 404 errors
app.use((req, res) => {
    res.status(404).send('404 Not Found');
});

// Handle unsupported methods
app.use((req, res) => {
    res.status(405).send('Method Not Allowed');
});

// Start the server
app.listen(port, '127.0.0.1', () => {
    console.log(`Server is running on http://127.0.0.1:${port}`);
});