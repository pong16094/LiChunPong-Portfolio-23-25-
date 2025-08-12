<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <style>
        table {
            border-collapse: collapse;
            width: 100%;
        }
        th, td {
            padding: 8px;
            text-align: left;
            border-bottom: 1px solid #ddd;
        }
    </style>
</head>
<body>
<?php
session_start();
echo <<<EOD
<tr>
        <th colspan="7"><a href="sale.php">Home page</a></th>
        <th colspan="2">UserID:{$_SESSION['userID']}</th>
        <th colspan="1"><a href="LogOut.php">Log out</a></th>
    </tr>
    <tr>
        <td colspan="2"><a href="insert.php">Insert items’ information</a></td>
        <td colspan="2"><a href="Edit1.php">Edit items’ information</a></td>
        <td colspan="2"><a href="deleteItem.php">Delete item</a></td>
        <td colspan="2"><a href="UpdateOrder.php">Update order records</a></td>
        <td colspan="2"><a href="report.php">Generate report</a></td>
    </tr>
EOD;
session_write_close();
?>
</body>
</html>