/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package Pruebas;


import java.util.Scanner;

class Rango{

public static void main (String[] arg){

Scanner myObj = new Scanner(System.in);

int Numero = myObj.nextInt();

if(Numero < 500 || Numero > 700){

System.out.print("No Esta en el rango");

}

else{

System.out.print(Numero);

}

}
}