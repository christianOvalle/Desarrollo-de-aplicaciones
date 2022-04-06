/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package Pruebas;
import java.util.*;

/**
 *
 * @author Infotep2019
 */
public class MayorYmenor {


    public static void main(String[] args) {
        
        Scanner myObj = new Scanner(System.in);


int[] Arreglo = new int[4];


for(int i = 0; i <= 3; i++){
int Numero = myObj.nextInt();

 Arreglo[i] = Numero;

}

Arrays.sort(Arreglo);
System.out.print(Arreglo[0]+"\n");
System.out.print(Arreglo[3]+"\n");
}
    }


    
    

