<?php
session_start();
echo <<<EOD
<tr>
        <th colspan="4"><a href="dealer.php">Home page</a></th>
<th colspan="2">UserID:{$_SESSION['userID']}</th>
        <th colspan="1"><a href="LogOut.php">Log out</a></th>
    </tr>
    <tr>
        <td ><a href="order.php">Make Order</a></td>
        <td><a href="Update.php">Update Info</a></td>
        <td><a href="View.php">View Order</a></td>
        <td><a href="delete.php">Delete Order record</a></td>
    </tr>
EOD;
session_write_close();
?>