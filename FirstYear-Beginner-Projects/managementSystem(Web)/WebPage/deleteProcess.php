<!doctype html>
<!-- File : Lab05_2b.php -->
<html>
<head>
    <meta charset="utf-8">
    <title>Lab 05 Task 2</title>
</head>
<body>
<?php
require_once('conn.php');   # or use : include 'conn.php'
$today = date('Y-m-d');
$futureDate = date('Y-m-d', strtotime($today . ' +3 days'));
$sql = "SELECT `deliveryDate` FROM `orders` WHERE orderID='{$_POST['orderID']}'";
$result = mysqli_query($conn, $sql) or die(mysqli_error($conn));
$deliveryDate = mysqli_fetch_assoc($result);
if($deliveryDate['deliveryDate']>=$futureDate){
    $sql = "DELETE FROM ordersitem WHERE orderID='{$_POST['orderID']}'";
    mysqli_query($conn, $sql) or die(mysqli_error($conn));

    $sql = "DELETE FROM orders WHERE orderID='{$_POST['orderID']}'";
    mysqli_query($conn, $sql) or die(mysqli_error($conn));
    mysqli_close($conn);
    header("location:delete.php?message=Record+is+successfully+deleted");
}else{
    header("location:delete.php?message=An+order+can+only+be+deleted+at+least+two+days+before+the+delivery+date.");
}
?>
</body>
</html>