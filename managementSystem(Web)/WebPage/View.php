<!DOCTYPE html>
<html>
<head>
    <title>View Order Records</title>
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
<table class="fixed" width="90%" border="1">

    <?php
    require_once('Logined.php');
    require "meun.php";
    ?>
    <tr>
        <th>Order ID</th>
        <th>Sales Manager ID</th>
        <th>Sales Manager Contact Name</th>
        <th>Sales Manager Contact Number</th>
        <th>Status</th>
        <th>Quantity</th>
        <th>Order Date & Time</th>
        <th>Delivery Address</th>
        <th>Delivery Date</th>
        <th>Total Price</th>
        <th>Detail</th>
    </tr>

    <?php
    require_once('conn.php');
    session_start();

    // Retrieve sales manager details and store in session
    $salesManagerQuery = "SELECT * FROM `salesmanager`";
    $salesManagerResult = mysqli_query($conn, $salesManagerQuery) or die(mysqli_error($conn));

    $salesManagers = array();
    while ($salesManager = mysqli_fetch_assoc($salesManagerResult)) {
        $salesManagers[$salesManager['salesManagerID']] = array(
            'Name' => $salesManager['contactName'],
            'Number' => $salesManager['contactNumber']
        );
    }
    mysqli_free_result($salesManagerResult);

    // Retrieve total price for each order and store in session
    $totalPriceQuery = "SELECT orderID, SUM(orderQty * sparePartOrderPrice) AS totalPrice FROM ordersitem GROUP BY orderID";
    $totalPriceResult = mysqli_query($conn, $totalPriceQuery) or die(mysqli_error($conn));

    $totalPrices = array();
    while ($totalPrice = mysqli_fetch_assoc($totalPriceResult)) {
        $totalPrices[$totalPrice['orderID']] = $totalPrice['totalPrice'];
    }

    mysqli_free_result($totalPriceResult);

    // Retrieve order records and display in the table
    $orderQuery = "SELECT o.orderID, o.salesManagerID, o.orderStatus, o.orderDateTime, o.deliveryAddress, o.deliveryDate, SUM(oi.orderQty) AS totalQty
               FROM orders o INNER JOIN ordersitem oi ON o.orderID = oi.orderID GROUP BY o.orderID";

    $orderResult = mysqli_query($conn, $orderQuery) or die(mysqli_error($conn));

    while ($order = mysqli_fetch_assoc($orderResult)or die(mysqli_error($conn))){
        $orderID = $order['orderID'];
        $salesManagerID = $order['salesManagerID'];
        $orderStatus = $order['orderStatus'];
        $orderDateTime = $order['orderDateTime'];
        $deliveryAddress = $order['deliveryAddress'];
        $deliveryDate = $order['deliveryDate'];
        $totalQty = $order['totalQty'];
        $totalPrice = isset($totalPrices[$orderID]) ? $totalPrices[$orderID] : 0;


        $DisplayName = ($orderStatus == 'Processing') ? ''  : $salesManagers[$salesManagerID]['Name'];
        $DisplayNumber = ($orderStatus == 'Processing') ? '' : $salesManagers[$salesManagerID]['Number'];
        echo <<<EOD
        <tr>
          <td>$orderID</td>
          <td>$salesManagerID</td>
            <td>$DisplayName</td>
           <td>$DisplayNumber</td>
          <td>$orderStatus</td>
          <td>$totalQty</td>
          <td>$orderDateTime</td>
          <td>$deliveryAddress</td>
          <td>$deliveryDate</td>
          <td>\$ $totalPrice</td>
          <td><a href="orderDeatil.php?orderID=$orderID" onclick="">View Detail</a></td>
        </tr>
EOD;
    }

    mysqli_free_result($orderResult);
    mysqli_close($conn);
    ?>
</table>
</body>
</html>