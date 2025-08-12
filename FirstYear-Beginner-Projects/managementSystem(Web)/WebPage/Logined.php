<?php
session_start();
if (!isset($_SESSION['logined'])) {
    header("location:Login.html?message=Please Login First!");
}
session_write_close();
?>