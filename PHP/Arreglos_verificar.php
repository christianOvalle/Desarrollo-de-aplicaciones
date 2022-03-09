<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
<?php
function verificar($arreglos,$valores,$contador){


for($i = 0; $i < count($arreglos); $i++){

 if($valores == $arreglos[$i]){

   $contador = $contador + 1; 
   
 }  

} 
print ("Cantidad de veces que se repite: $contador");
}

echo verificar( [10,20,15,12,25,34,101,12,10],10,0);

?>
    
</body>
</html>