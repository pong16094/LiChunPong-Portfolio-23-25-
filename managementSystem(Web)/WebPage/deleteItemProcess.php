<?php
var_dump($_POST);
if (isset($_POST['sparePartNum'])) {
    require_once("Logined.php");
    require_once("conn.php");
    $num=$_POST['sparePartNum'];
    $sql = "DELETE FROM `ordersitem` WHERE `sparePartNum`=$num";
    if (mysqli_query($conn, $sql)) {
        $sql = "DELETE FROM `item` WHERE `sparePartNum`=$num";
        if (mysqli_query($conn, $sql)) {
            mysqli_close($conn);
            header("Location:deleteItem.php?message=Delete+Successful");
        } else {
            mysqli_close($conn);
            header("Location:deleteItem.php?message=Delete+Failed");
        }
    } else {
        mysqli_close($conn);
        header("Location:deleteItem.php?message=Delete+Failed");
    }

}else{
    header("Location:deleteItem.php?message=Cannot+find+Item");
}
//not work cause of foregine key
?>
