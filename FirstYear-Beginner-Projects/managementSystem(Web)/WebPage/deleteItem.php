<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Delete item</title>
    <script>
        // Confirmation dialog for item deletion
        function confirmDelete() {
            return confirm("Are you sure you want to delete this item?");
        }
    </script>
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
<table class="fixed" width="90%" id="myTable" border="1">
    <?php
    require_once('Logined.php');
    require_once('salemeun.php');
    ?>
    <tr>
        <td>Spare Part Number</td>
        <td>Spare Part Image</td>
        <td>Spare Part Name</td>
        <td>Spare Part Description</td>
        <td>Price</td>
        <td>Delete</td>
    </tr>
    <?php
    require_once('conn.php');
    $sql = "SELECT * FROM `item`";
    $rs = mysqli_query($conn, $sql) or die(mysqli_error($conn));
    while ($rc = mysqli_fetch_assoc($rs)) {
        extract($rc);
        echo <<<EOD
        <tr>
        <td>$sparePartNum</td>
        <td> <img src="/upload/$sparePartImage"  width="70" height="60"> </td>
        <td>$sparePartName</td>
        <td>$sparePartDescription</td>
        <td>$price</td>
        <td>
            <form action="deleteItemProcess.php" method="post" onsubmit="return confirmDelete();">
                <input type="hidden" name="sparePartNum" value="$sparePartNum">
                <input type="submit" value="Delete Item">
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