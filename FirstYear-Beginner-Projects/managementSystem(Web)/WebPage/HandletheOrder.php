<?php
require_once("Logined.php");
var_dump($_POST);
extract($_POST);
if (!extension_loaded("curl")) {
    die("enable library curl first");
}
$url = "http://127.0.0.1:8080/ship_cost_api/weight/$weight";   # URL is to make GET request to Python RESTful API

$curl = curl_init($url);   # Initialize a cURL session
curl_setopt($curl, CURLOPT_RETURNTRANSFER, true);
$response = curl_exec($curl);   # Perform a cURL session
curl_close($curl);

$weightrs = json_decode($response, true);
var_dump($data1);

$url = "http://127.0.0.1:8080/ship_cost_api/quantity/$qty";   # URL is to make GET request to Python RESTful API

$curl = curl_init($url);   # Initialize a cURL session
curl_setopt($curl, CURLOPT_RETURNTRANSFER, true);
$response = curl_exec($curl);   # Perform a cURL session
curl_close($curl);

$qtyrs = json_decode($response, true);

var_dump($data);

if($weightrs['result']=="rejected"&&$qtyrs['result']=="rejected"){
require_once ("conn.php");
session_start();
$sql="UPDATE `orders` SET `salesManagerID`='{$_SESSION['userID']}',`orderStatus`='Cancelled' WHERE `orderID`={$_POST['orderID']}";
    if (mysqli_query($conn,$sql)){
        mysqli_close($conn);
        header("Location:UpdateOrder.php?message=Update+Successful");
    }
    else{
        mysqli_close($conn);
        header("Location:UpdateOrder.php?message=Update+Failed");
    }
}

if($weightrs['result']=="accepted"&&$qtyrs['result']=="accepted"){
    require_once ("conn.php");
    if($weightrs['cost']>$qtyrs['cost']){
        $shipcost=$qtyrs['cost'];
    }else{
        $shipcost=$weightrs['cost'];
    }
    session_start();
    $sql="UPDATE `orders` SET `salesManagerID`='{$_SESSION['userID']}',`orderStatus`='Shipped',`shipCost`=$shipcost WHERE `orderID`={$_POST['orderID']}";
    if (mysqli_query($conn,$sql)){
        mysqli_close($conn);
        header("Location:UpdateOrder.php?message=Update+Successful");
    }
    else{
        mysqli_close($conn);
        header("Location:UpdateOrder.php?message=Update+Failed");
    }
}
if($weightrs['result']=="accepted"){
    require_once ("conn.php");
    session_start();
    $sql="UPDATE `orders` SET `salesManagerID`='{$_SESSION['userID']}',`orderStatus`='Shipped',`shipCost`={$weightrs['cost']} WHERE `orderID`={$_POST['orderID']}";
    if (mysqli_query($conn,$sql)){
        mysqli_close($conn);
        header("Location:UpdateOrder.php?message=Update+Successful");
    }
    else{
        header("Location:UpdateOrder.php?message=Update+Failed");
    }
}
if($qtyrs['result']=="accepted"){
    require_once ("conn.php");
    session_start();
    $sql="UPDATE `orders` SET `salesManagerID`='{$_SESSION['userID']}',`orderStatus`='Shipped',`shipCost`={$qtyrs['cost']} WHERE `orderID`={$_POST['orderID']}";
    if (mysqli_query($conn,$sql)){
        mysqli_close($conn);
        header("Location:UpdateOrder.php?message=Update+Successful");
    }
    else{
        header("Location:UpdateOrder.php?message=Update+Failed");
    }
}
?>
