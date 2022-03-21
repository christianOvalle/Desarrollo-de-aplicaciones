<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    
<?php

$Arreglo = [10,20,45,41,12];
$SumaNumeros = 0;

echo ("Numero de arreglos"."<br>"."<br>");

for ($i=0; $i <count($Arreglo) ; $i++) { 

    echo  ($Arreglo[$i]."<br>");
    $SumaNumeros += $Arreglo[$i];

}
echo ("<hr/>");
echo ("La suma es: $SumaNumeros");

echo ("<hr/>");



function OperacionesAritmeticas($valor1,$valor2){


    
$Resultado = $valor1 + $valor2;
$Resultado1 = $valor1 * $valor2;
$Resultado2 = $valor1 - $valor2;
$Resultado3 = $valor1 / $valor2;


print ("La suma es: $Resultado"."<br>");
print ("La Multiplicacion es: $Resultado1"."<br>");
print ("La Resta es: $Resultado2"."<br>");
print ("La La division es: $Resultado3"."<br>");

}

echo OperacionesAritmeticas(20,10);









?>




</body>
</html>