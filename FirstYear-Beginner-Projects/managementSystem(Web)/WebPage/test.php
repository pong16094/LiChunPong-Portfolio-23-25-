<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Edit</title>
</head>

<body>
<table class="fixed" width="90%" id="myTable" border="1">
    <?php
    require_once("salemeun.php");
    ?>

    <tr>
        <td>sparePartNum</td>
        <td>sparePart image</td>
        <td>sparePartName</td>
        <td>SIQ</td>
        <td>Price</td>
        <td>Edit</td>
    </tr>

    <?php
    require_once('conn.php'); // or use: include 'conn.php';
    $sql = "SELECT * FROM item";
    $rs = mysqli_query($conn, $sql) or die(mysqli_error($conn));

    while ($rc = mysqli_fetch_assoc($rs)) {
        extract($rc);
        $escapedSparePartNum = htmlspecialchars($sparePartNum);
        $escapedSparePartName = htmlspecialchars($sparePartName);
        $escapedSparePartImage = htmlspecialchars($sparePartImage);
        $escapedStockItemQty = htmlspecialchars($stockItemQty);
        $escapedPrice = htmlspecialchars($price);

        echo <<<EOD
                <tr>
                    <td>$escapedSparePartNum</td>
                    <td><img src="/upload/$escapedSparePartImage" width="70" height="60"></td>
                    <td>$escapedSparePartName</td>
                    <td>$escapedStockItemQty</td>
                    <td style="text-align:right;">$ $escapedPrice</td>
                    <td>
                        <form action="EditDetail.php" method="POST">
                            <input type="hidden" name="sparePartNum" value="$escapedSparePartNum">
                            <input type="submit" value="Edit">
                        </form>
                    </td>
                </tr>
EOD;
    }

    mysqli_free_result($rs);
    mysqli_close($conn);
    ?>
</table>
</body>
</html>