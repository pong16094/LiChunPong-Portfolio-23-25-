<?php
if(!is_dir('upload/')) {
    mkdir('upload/', 0755, true);
}
$target_dir = "upload/";

$target_file = $target_dir . basename($_FILES["pic"]["name"]);
$uploadOk = 1;
$imageFileType = pathinfo($target_file,PATHINFO_EXTENSION);
// Check if image file is a actual image or fake image
if(isset($_POST["submit"])) {
    $check = getimagesize($_FILES["pic"]["tmp_name"]);
    if($check !== false) {
        $uploadOk = 1;
    } else {
        header("Location: insert.php?message=File+is+not+an+image");
        $uploadOk = 0;
    }
}
// Check if file already exists
if (file_exists($target_file)) {
    header("Location: insert.php?message=Sorry,+file+already+exists");
}
// Check file size
if ($_FILES["pic"]["size"] > 500000) {
    header("Location: insert.php?message=Sorry,+your+file+is+too+large");
}
// Allow certain file formats
if($imageFileType != "jpg" && $imageFileType != "png" && $imageFileType != "jpeg"
&& $imageFileType != "gif" ) {
    header("Location: insert.php?message=Sorry,+only+JPG,+JPEG,+PNG+,GIF+files+are+allowed");
}
// Check if $uploadOk is set to 0 by an error
if ($uploadOk == 0) {
    header("Location: insert.php?message=Sorry,+your+file+was+not+uploaded");
// if everything is ok, try to upload file
} else {
    if (move_uploaded_file($_FILES["pic"]["tmp_name"], $target_file)) {
return;
    } else {
        header("Location: insert.php?message=Sorry,+there+was+an+error+uploading+your+file");
    }
}
?>