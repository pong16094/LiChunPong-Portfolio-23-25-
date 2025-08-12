<!DOCTYPE html>
<html>
<head>
    <meta charset="UTF-8">
    <title>Edit Item Info</title>

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
    require_once("Logined.php");
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
          <td>$stockItemQty</td>
          <td style="text-align:right;">\$ $price</td>
          <td> <form action="EditDetail.php" method="POST">
               <input type="hidden" name="sparePartNum" value="$sparePartNum">
               <input type="submit" value="Edit">
               </form>
          </td>
        </tr>
EOD;
    }
    mysqli_free_result($rs);
    mysqli_close($conn);;
    ?>

</table>

</body>
</html>