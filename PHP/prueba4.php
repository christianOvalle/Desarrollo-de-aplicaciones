<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
<?php

$arreglo = array(10,25,35,21,6);
$suma = 0;
for ($i=0; $i < count($arreglo) ; $i++) { 
    $suma = $arreglo[$i]+$suma;
}

echo ("la suma es: $suma")."<br>";

$i = 0;

while ($i < count($arreglo)) {

    echo $arreglo[$i]."<br>";
    $i++;
}



?>
</body>
</html>