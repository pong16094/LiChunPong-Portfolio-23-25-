<?php
if (isset($_POST['sparePartNum'])) {
    require_once("conn.php");
    $sql = "SELECT * FROM item where sparePartNum={$_POST['sparePartNum']}";
    $rs = mysqli_query($conn, $sql) or die(mysqli_error($conn));
    $row = mysqli_fetch_assoc($rs);
    echo <<<EOD
<h1>Edit spar part {$_POST['sparePartNum']}  Detail</h1>
<form action="EditProcess.php" method="POST" enctype="multipart/form-data">
<input type="hidden" name="sparePartNum" value="{$_POST['sparePartNum']}">
    <div>1.	Spare Part Description <input type="text" name="ssd" value="{$row['sparePartDescription']}" size="80" required> </div>
    <div>2.	Spare Part Image<img src="/upload/{$row['sparePartImage']}"  width="70" height="60"><input type="file" id="pic" name="pic"></div>
    <div>3.	Stock Item Quantity <input type="number" name="siq" value="{$row['stockItemQty']}" min="0" required></div>
    <div>4.	Price<input type="number" name="price" value="{$row['price']}" min="0" required> </div>
    <input type="submit" name="submit" value="Update">
    <a href="Edit1.php"> <input type="button" name="button" value="Back"></a>
</form>
EOD;
} else {
    header("Location:Edit.php");

}
?>