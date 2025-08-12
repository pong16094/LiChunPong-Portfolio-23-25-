<?php
var_dump($_POST);

if (isset($_POST['userID']) && isset($_POST['password'])) {
    require_once("conn.php");
    extract($_POST);
    $sql = "SELECT * FROM `dealer` WHERE `dealerID`='$userID' AND `password`='$password' ";

    $result = mysqli_query($conn, $sql);
    if (mysqli_num_rows($result) > 0) {
        //"Login dealer success";
        session_start();
        $_SESSION['userID'] = $userID;
        $_SESSION['logined'] = true;
        session_write_close();
        header("Location:dealer.php");
    } else {
        $sql = "SELECT * FROM `salesmanager` WHERE `salesManagerID`='$userID'  AND `password`='$password' ";
        $result = mysqli_query($conn, $sql);
        if (mysqli_num_rows($result) > 0) {
            // Login Sales manager success;
            session_start();
            $_SESSION['userID'] = $userID;
            $_SESSION['logined'] = true;
            session_write_close();
            header("Location:sale.php");
        } else {
            echo "incorrect Login";
            header("Location:Login.html");
        }
    }

} else {
    header("Location:Login.html?message=Invalid userName or password");
}

?>