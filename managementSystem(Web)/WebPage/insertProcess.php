<?php
require_once ("upload.php");
$fileName=$_FILES["pic"]["name"];
require_once ("conn.php");
extract($_POST);
$sql = "SELECT IFNULL(max(sparePartNum), 0)+1 AS nextItemID FROM item;";
$rs = mysqli_query($conn, $sql);
$rc= mysqli_fetch_assoc($rs);
$ItemNum=(int)$rc["nextItemID"];
echo $ItemNum;

$sql="INSERT INTO `item`(`sparePartNum`, `sparePartCategory`, `sparePartName`, `sparePartImage`, `sparePartDescription`, `weight`, `stockItemQty`, `price`) VALUES ($ItemNum,$part_cat,'$item_name','$fileName','$description',$Weight,$STQ,$price)";
if (mysqli_query($conn,$sql)){
    header("Location:insert.php?message=Insert+Successful");
}
else{
    header("Location:insert.php?message=Insert+Failed");
}
?>