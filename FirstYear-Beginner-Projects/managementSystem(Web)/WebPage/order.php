<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Make order</title>
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
<script>
    // Get the message from the URL parameter
    const urlParams = new URLSearchParams(window.location.search);
    const message = urlParams.get('message');

    // Display the message if it exists
    if (message) {
        alert(message);
    }
</script>
<script>
    function validateDate() {
        var inputDate = document.getElementById("dateInput").value;
        var today = new Date();
        var minDate = new Date(today.setDate(today.getDate() + 2));

        if (new Date(inputDate) < minDate) {
            alert("Please select a date that is at least two days ahead of today.");
            return false;
        }

        return true;
    }
</script>
<table class="fixed" width="90%" border="1">
    <?php
    require_once('Logined.php');
    require_once("meun.php");
    ?>

    <form method="Post" action="ordermake.php" onsubmit="return validateDate()">
        <tr>
            <td colspan="3">Delivery Address<input type="text" size="80" name="address" required></td>
            <td>Delivery Date<input type="date" name="date" id="dateInput" required></td>
        </tr>

        <tr>
            <td>Spare Part Number</td>
            <td>Spare Part Image</td>
            <td>Name</td>
            <td style="text-align:right;">Price</td>
            <td>OrderQty</td>
        </tr>

        <tr>
            <?php
            require_once('conn.php');   # or use : include 'conn.php';
            $sql = "SELECT * FROM item";
            $rs = mysqli_query($conn, $sql) or die(mysqli_error($conn));
            while ($rc = mysqli_fetch_assoc($rs)) {
                extract($rc);
                echo <<<EOD
        <tr>
        <td>$sparePartNum</td>
          <td> <img src="/upload/$sparePartImage"  width="70" height="60"> </td>
          <td >$sparePartName</td>
          <td style="text-align:right;">\$ $price</td>
          <td><input type="number" name="$sparePartNum" min="0" " ></td>
        </tr>
EOD;
            }
            mysqli_free_result($rs);
            mysqli_close($conn);;
            ?>
        </tr>
        <tr style="text-align:right;">
            <td colspan="8"><input type="submit" value="Submit""></td>
        </tr>
    </form>
</table>

</body>
</html>