<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Document</title>

</head>
<body>
<script>
    // Get the message from the URL parameter
    const urlParams = new URLSearchParams(window.location.search);
    const message = urlParams.get('message');

    // Display the message if it exists
    if (message) {
        alert(message);
    }
</script>
<table width="90%" border="1" id="myTable">
    <?php
    require_once("Logined.php");
    require_once("salemeun.php");
    ?>
    <tr>
        <td>Order ID</td>
        <td>Sales Manager ID</td>
        <td>Sales Manager Contact Name</td>
        <td>Sales Manager Contact Number</td>
        <td>Status</td>
        <td>Quantity</td>
        <td>Order Date</td>
        <td>Delivery Address</td>
        <td>Delivery Date</td>
        <td>Shipping Cost</td>
        <td>Total Price</td>
        <td>Update</td>
    </tr>

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

        $totalPriceQuery = "SELECT orderID, SUM(orderQty * sparePartOrderPrice) AS totalPrice FROM ordersitem GROUP BY orderID";
        $totalPriceResult = mysqli_query($conn, $totalPriceQuery) or die(mysqli_error($conn));

        $totalPrices = array();
        while ($totalPrice = mysqli_fetch_assoc($totalPriceResult)) {
            $totalPrices[$totalPrice['orderID']] = $totalPrice['totalPrice'];
        }

        mysqli_free_result($totalPriceResult);

        // Retrieve order records and display in the table
        $orderQuery = "SELECT o.orderID, o.salesManagerID, o.orderStatus, o.orderDateTime, o.deliveryAddress, o.deliveryDate,o.shipCost, SUM(oi.orderQty) AS totalQty
               FROM orders o INNER JOIN ordersitem oi ON o.orderID = oi.orderID GROUP BY o.orderID";

        $orderResult = mysqli_query($conn, $orderQuery) or die(mysqli_error($conn));

        while ($order = mysqli_fetch_assoc($orderResult) or die(mysqli_error($conn))) {
            extract($order);
            $totalPrice = isset($totalPrices[$orderID]) ? $totalPrices[$orderID]+$shipCost : 0;


            $DisplayName = ($orderStatus == 'Processing') ? '' : $salesManagers[$salesManagerID]['Name'];
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
          <td>$shipCost</td>
          <td>\$ $totalPrice</td>
EOD;
            if ($orderStatus == 'Processing') {
                echo <<<EOD
          
          <form action="ViewOrderDetail.php" method="post">
          <input type="hidden" name="orderID" value="$orderID">
          <td> <input type="submit" value="View Detail"></td>
</form>
EOD;
            }
            echo "</tr>";

        }

        mysqli_free_result($orderResult);
        mysqli_close($conn);
        ?>
</table>
</body>
</html>