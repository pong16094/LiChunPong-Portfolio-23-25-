<?php
require_once("Logined.php");
session_start();
var_dump($_POST);
if (isset($_POST['dealer_password'])&&isset($_POST['dealer_number'])&&isset($_POST['dealer_fax'])&&isset($_POST['dealer_address'])){
    extract($_POST);
    require_once('conn.php');
    $userID =$_SESSION['userID'];
$sql ="UPDATE `dealer` SET `password`='$dealer_password',`contactNumber`='$dealer_number',
                    `faxNumber`='$dealer_fax', `deliveryAddress`='$dealer_address' WHERE `dealerID`='$userID'";
if ($result=mysqli_query($conn,$sql)){
        header("Location:Update.php?message=Updated+successfully");
}
}else{
    header("Location:Update.html");
}
?>