    <!DOCTYPE html>
    <html>
    <head>
        <title>View Order Details</title>
        <style>
            table {
                border-collapse: collapse;
                width: 100%;
            }
            th, td {
                padding: 8px;
                text-align: left;
                border-bottom: 1px solid #ddd;
            }
        </style>
    </head>
    <body>
    <h1>Order Details</h1>

    <?php

    require_once('Logined.php');
    require_once('conn.php');
    session_start();


    if (isset($_GET['orderID'])) {
        extract($_GET);
        $orderID = $_GET['orderID'];

        $headerQuery = "SELECT `orderID`, `salesManagerID`, `orderStatus`, `orderDateTime`, `deliveryAddress`, `deliveryDate` FROM `orders` WHERE `orderID` = '$orderID' ";

        $headerResult = mysqli_query($conn, $headerQuery) or die(mysqli_error($conn));

        if (mysqli_num_rows($headerResult) > 0) {
            $order = mysqli_fetch_assoc($headerResult);
            $salesManagerID = $order['salesManagerID'];
            $orderStatus = $order['orderStatus'];
            $orderDateTime = $order['orderDateTime'];
            $deliveryAddress = $order['deliveryAddress'];
            $deliveryDate = $order['deliveryDate'];

            echo <<<EOD
            <h2>Order Information</h2>
            <table>
              <tr>
                <th>Order ID:</th>
                <td>{$order['orderID']}</td>
              </tr>
              <tr>
                <th>Sales Manager ID:</th>
                <td>$salesManagerID</td>
              </tr>
              <tr>
                <th>Order Status:</th>
                <td>$orderStatus</td>
              </tr>
              <tr>
                <th>Order Date & Time:</th>
                <td>$orderDateTime</td>
              </tr>
              <tr>
                <th>Delivery Address:</th>
                <td>$deliveryAddress</td>
              </tr>
              <tr>
                <th>Delivery Date:</th>
                <td>$deliveryDate</td>
              </tr>
            </table>
    
            <h2>Order Items</h2> 
            <table>
            <form action="" method="GET">
    <input type="hidden" name="orderID" value={$_GET['orderID']}>
              <tr>
                <th>Spare Part ID <select name="orderby" id="orderby">
                <option name="orderby" value="asc">asc</option>
                <option name="orderby" value="desc">desc</option>
            </select></th>
                <th colspan="2">Spare Part Name</th>
                <th>Quantity <select name="orderby1" id="orderby1">
                <option name="orderby1" value="asc">asc</option>
                <option name="orderby1" value="desc">desc</option>
            </select></th>
                <th>Unit Price</th>
                <th>Total Price<input type="submit"></th>    
              </tr>
</form>
EOD;

            displayProduct($conn,$_GET['orderID']);

            echo '</table>';
        } else {
            echo "No order found with the provided ID.";
        }

        mysqli_free_result($headerResult);
    } else {
        echo "No order ID provided.";
    }
    mysqli_close($conn);
    ?>
    <br>
    <a href="View.php"><input type="button" value="Back"></a>

    <?php
    function displayProduct($conn, $orderNo) {
        $totalOrderPrice = 0;
        $order="asc";
        $order1="asc";
        if (isset($_GET["orderby"])&&isset($_GET["orderby1"])){
            $order=$_GET['orderby'];
            $order1=$_GET['orderby1'];
        }

        $orderQuery = "SELECT oi.sparePartNum, i.sparePartName, i.sparePartImage, oi.orderQty, oi.sparePartOrderPrice
                   FROM ordersitem oi
                   INNER JOIN item i ON oi.sparePartNum = i.sparePartNum
                   WHERE oi.orderID = $orderNo
                   ORDER BY oi.sparePartNum $order,oi.orderQty $order1 ";

        $detail = mysqli_query($conn, $orderQuery);
        if (!$detail) {
            die(mysqli_error($conn));
        }

        while ($item = mysqli_fetch_assoc($detail)) {
            extract($item);
            $itemTotalPrice = $orderQty * $sparePartOrderPrice;
            $totalOrderPrice += $itemTotalPrice;

            echo <<<EOD
            <tr>
                <td>$sparePartNum</td>
                <td>$sparePartName</td>
                <td><img src="/upload/$sparePartImage" width="70" height="60"></td>
                <td>$orderQty</td>
                <td>\$ $sparePartOrderPrice</td>
                <td>\$ $itemTotalPrice</td>
            </tr>
EOD;
        }

        echo <<<EOD
        <tr>
            <td colspan="5" style="text-align:right;">Total Order Price:</td>
            <td colspan="2">\$ $totalOrderPrice</td>
        </tr>
EOD;
    }

    ?>
    </body>
    </html>