<?php
if ($_POST['submit']=="Back"){
    header("location: Edit1.php");
}
if(isset($_FILES['pic']) && $_FILES['pic']['error'] === UPLOAD_ERR_OK){
    echo "file was upload";
    extract($_POST);
    require_once ("upload.php");
    $fileName=$_FILES["pic"]["name"];
    require_once ("conn.php");
    $sql ="UPDATE `item` SET `sparePartImage`='$fileName',`sparePartDescription`='$ssd',`stockItemQty`=$siq,`price`=$price WHERE `sparePartNum`=$sparePartNum";
    if (mysqli_query($conn,$sql)){
        header("Location:Edit1.php?message=Edit+Successful");
    }
    else{
        header("Location:Edit1.php?message=Edit+Failed");
    }
}else{
    //file was not uploaded
    extract($_POST);
    require_once ("conn.php");
    $sql ="UPDATE `item` SET `sparePartDescription`='$ssd',`stockItemQty`=$siq,`price`=$price WHERE `sparePartNum`=$sparePartNum";
    if (mysqli_query($conn,$sql)){
        header("Location:Edit1.php?message=Edit+Successful");
    }
    else{
        header("Location:Edit1.php?message=Edit+Failed");
    };
}
?>
