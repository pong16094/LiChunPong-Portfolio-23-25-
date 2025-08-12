<?php

    var_dump($_POST);

require_once('conn.php');
session_start();
$today = date('Y-m-d');
$sql = "SELECT IFNULL(max(orderID), 0)+1 AS nextid FROM orders;";
$rs = mysqli_query($conn, $sql);
 $rc= mysqli_fetch_assoc($rs);
$orderNum=(int)$rc["nextid"];
var_dump($_POST);
var_dump($_SESSION);
foreach ($_SESSION as $key => $value) {
    if($key=="info"||$key=="userID"||$key=="logined"){
        continue;
    }
    $num = (int)str_replace("num", "", $key);
    $price = (int)$value["price"];
    $qty = (int)$value["qty"];
    $sql="SELECT `stockItemQty` FROM `item` WHERE `sparePartNum`='$num'";
    $rs=mysqli_query($conn, $sql);
    $rc=mysqli_fetch_assoc($rs);
    $stockItemQty=$rc["stockItemQty"];
    if($stockItemQty>=$qty){
        $stockItemQty=$stockItemQty-$qty;
        $sql="UPDATE `item` SET `stockItemQty`=$stockItemQty WHERE `sparePartNum`='$num'";
        mysqli_query($conn, $sql);
    }else{
        session_destroy();
        header("Location:order.php?message=Not+enough+stock+of+$num");
    }
}

$address=$_SESSION['info']['address'];
$userID=$_SESSION['userID'];
$sql = "INSERT INTO `orders`(`orderID`, `dealerID`, `salesManagerID`, `orderDateTime`, `deliveryAddress`, `deliveryDate`, `orderStatus`, `shipCost`) 
        VALUES ($orderNum, '$userID', null, NOW(), '$address', '{$_SESSION['info']['date']}', 'Processing', 0)";


if (mysqli_query($conn,$sql)){
foreach ($_SESSION as $key => $value) {
    $num = (int)str_replace("num", "", $key);
    $price = (int)$value["price"];
    $qty = (int)$value["qty"];
    $sql = "INSERT INTO `ordersitem` (`orderID`, `sparePartNum`, `orderQty`, `sparePartOrderPrice`) VALUES ('$orderNum', '$num', '$qty', '$price')";
    mysqli_query($conn, $sql);
}
}
mysqli_free_result($rs);
mysqli_close($conn);
session_destroy();
session_start();
$_SESSION['userID']=$userID;
$_SESSION['logined']=true;
header("location:order.php?message=Order+successfully");

?>

