<!DOCTYPE html>
<html>
<head>
  <meta charset="UTF-8">
  <title>Update Info</title>
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
  <table width="90%" border="1">
      <?php
      require_once('Logined.php');
      require "meun.php";
      ?>
  </table>
  <form action="dealerUpadteProcess.php" method="post">
    <label for="dealer_password">Passwrod:</label>
    <input type="text" id="dealer_password" name="dealer_password" required><br><br>
    
    <label for="dealer_number">Contact Number:</label>
    <input type="number" id="dealer_number" name="dealer_number" maxlength="8" required><br><br>
    
    <label for="dealer_fax">Fax Number:</label>
    <input type="number" id="dealer_fax" name="dealer_fax" required  maxlength="8"><br><br>
    
    <label for="dealer_address">Dealer Address:</label>
    <input type="text" id="dealer_address" name="dealer_address" required><br><br>
    
    
    
    <input type="submit" value="Update">
  </form>


  
</body>
</html>