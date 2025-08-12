<!DOCTYPE html>
<html>
<head>
<body>
<h1>Order Details</h1>

<?php
require_once("Logined.php");
require_once('conn.php');
session_start();

if (isset($_POST['orderID'])) {
    extract($_GET);
    $orderID = $_POST['orderID'];

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
            <form action="" method="Post">
    <input type="hidden" name="orderID" value={$_POST['orderID']}>
              <tr>
                <th>Spare Part ID </th>
                <th colspan="2">Spare Part Name</th>
                <th>Quantity</th>
                <th>Unit Price</th>
              </tr>
</form>
EOD;
        list($totalOrderWeight,$totalOrderQty)=displayProduct($conn,$_POST['orderID']);
        echo '</table>';
    } else {
        header("Location: UpdateOrder.php?message=No+order+found+with+the+provided+ID.");
    }

    mysqli_free_result($headerResult);
} else {
    header("Location: UpdateOrder.php?message=No+order+ID+provided.");
}
echo <<<EOD
    <form action="HandletheOrder.php" method="POST">
    <input type="hidden" name="orderID" value={$_POST['orderID']}>
    <input type="hidden" name="weight" value={$totalOrderWeight}>
    <input type="hidden" name="qty" value=$totalOrderQty>
    <input type="submit" value="Update Order">
</form>
EOD;

mysqli_close($conn);
?>
<br>

<a href="UpdateOrder.php"><input type="button" value="Back"></a>

<?php
function displayProduct($conn, $orderNo) {
    $totalOrderPrice = 0;
    $totalOrderQty=0;
    $totalOrderWeight=0;
    $orderQuery = "SELECT oi.sparePartNum, i.sparePartName, i.sparePartImage, oi.orderQty, oi.sparePartOrderPrice,i.weight
                   FROM ordersitem oi
                   INNER JOIN item i ON oi.sparePartNum = i.sparePartNum
                   WHERE oi.orderID = $orderNo
                   ORDER BY oi.sparePartNum asc,oi.orderQty asc ";

    $detail = mysqli_query($conn, $orderQuery);
    if (!$detail) {
        die(mysqli_error($conn));
    }

    while ($item = mysqli_fetch_assoc($detail)) {
        extract($item);
        $itemTotalPrice = $orderQty * $sparePartOrderPrice;
        $totalOrderQty+=$orderQty;
        $totalOrderWeight+=($weight*$orderQty);
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
    return array($totalOrderWeight,$totalOrderQty);
}

?>
</body>
</html>