<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    
</body>
</html>
<form action="procesar.php" method="get">
        <label for="">nombre</label>
        <input type="text" name="nombre">
        <input type="submit" value="">



    </form>

<?php
echo $_GET["nombre"];
?>