<!DOCTYPE html>
<html>
<head>
    <title>Delete Order Records</title>
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
<script>
    const urlParams = new URLSearchParams(window.location.search);
    const message = urlParams.get('message');
    if (message) {
        alert(message);
    }
</script>
<script type="text/javascript">
    function deleteOrder(orderID) {
        var confirmed = confirm("Are you sure you want to delete this order?");
        if (confirmed) {
            document.getElementById('orderID').value = orderID;
            document.getElementById('deleteForm').submit();
        }
    }
</script>
<table class="fixed" width="90%" border="1">
    <?php
    require_once("Logined.php");
    require_once("meun.php");
    ?>
    <tr>
        <td>orderID</td>
        <td>dealerID</td>
        <td>salesManagerID</td>
        <td>orderDateTime</td>
        <td>deliveryAddress</td>
        <td>deliveryDate</td>
        <td>orderStatus</td>
        <td style="text-align:right;">shipCost</td>
        <td>Delete</td>
    </tr>

    <?php
    require_once('conn.php');
    $sql = "SELECT * FROM orders";
    $rs = mysqli_query($conn, $sql) or die(mysqli_error($conn));
    while ($rc = mysqli_fetch_assoc($rs)) {
        extract($rc);
        echo <<<EOD
        <tr>
          <td>$orderID</td>
          <td>$dealerID</td>
          <td>$salesManagerID</td>
          <td>$orderDateTime</td>
          <td>$deliveryAddress</td>
          <td>$deliveryDate</td>
          <td>$orderStatus</td>
          <td style="text-align:right;">\$ $shipCost</td>
          <td>
            <button onclick="deleteOrder($orderID)">Delete</button>
          </td>
        </tr>
EOD;
    }
    mysqli_free_result($rs);
    mysqli_close($conn);
    ?>
</table>
<form id="deleteForm" method="post" action="deleteProcess.php">
    <input type="hidden" name="orderID" id="orderID">
</form>
</body>
</html>