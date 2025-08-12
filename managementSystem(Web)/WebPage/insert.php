<!DOCTYPE html>
<html>
<head>
    <title>Insert Items' Information</title>
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
<table class="fixed" width="90%" border="1">
    <?php
    require "salemeun.php";
    ?>
</table>
<form action="insertProcess.php" method="POST" enctype="multipart/form-data">


    <label for="part_cat">Spare Part Category:</label>
    <input type="number" id="part_cat" name="part_cat" required min=1 max=4><br><br>

    <label for="item_name">Spare Part Name:</label>
    <input type="text" id="item_name" name="item_name" required><br><br>

    <label for="pic"> Insert Image</label><input type="file" id="pic" name="pic"  accept="image/jpeg, image/png" required><br>

    <label for="description">Description:</label>
    <input id="description" name="description" required size="30"><br>

    <label for="Weight">Weight:</label>
    <input type="number" id="Weight" name="Weight" min="1" required><br>

    <label for="STQ">Stock Item Quantity:</label>
    <input type="number" id="STQ" name="STQ" min="0" required><br>

    <label for="price">Item Price:</label>
    <input type="number" id="price" name="price" min="0" required><br><br>

    <input type="submit" value="Insert" name="submit">
</form>
</body>
</html>