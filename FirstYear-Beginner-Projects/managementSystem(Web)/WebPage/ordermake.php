<!doctype html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Order Detail</title>
</head>
<body>
<form method="post" action="makeOrderProcess.php">
    <table>
        <th>Your Order List</th>
        <tr>
            <td>Spare Part Number</td>
            <td>Spare Part Image</td>
            <td>Name</td>
            <td>Price</td>
            <td colspan="2">OrderQty</td>
        </tr>
        <?php
        require_once('Logined.php');
        require_once('conn.php');   # or use : include 'conn.php';
        session_start();
        $sql = "SELECT * FROM item";
        $rs = mysqli_query($conn, $sql);
        $totalprice = 0;
        while ($rc = mysqli_fetch_assoc($rs)) {
            extract($rc);
            if ($_POST[$sparePartNum] != "" && $_POST[$sparePartNum] != 0) {
                echo <<<EOD
        <tr>
        <td>$sparePartNum</td>
          <td> <img src="/upload/$sparePartImage"  width="70" height="60"> </td>
          <td >$sparePartName</td>
          <td style="text-align:right;">\$ $price</td>
          <td colspan="2" style="text-align:center;">$_POST[$sparePartNum]</td>
          <input type="hidden" name=$sparePartNum value="$sparePartNum">
        </tr>   
EOD;
                $totalprice += ($price * $_POST[$sparePartNum]);
                $_SESSION["num" . $sparePartNum]["qty"] = $_POST[$sparePartNum];
                $_SESSION["num" . $sparePartNum]["price"] = $price;

            }
            $_SESSION["info"]["address"] = $_POST['address'];
            $_SESSION["info"]["date"] = $_POST['date'];
        }
        mysqli_free_result($rs);
        mysqli_close($conn);
        session_write_close();
        echo "<tr><td colspan='4'>------------------------------------------------------------------------------------------------------------------------------------------------------</td></tr>";;
        echo "<tr><td colspan='4' style='text-align: right;'>Total Price:$ $totalprice</td></tr>";
        ?>
    </table>
    <input type="submit" value="Submit" name="submit">
    <a href="order.php"><input type="button" value="Back"> </a>
</form>
</body>
</html>
