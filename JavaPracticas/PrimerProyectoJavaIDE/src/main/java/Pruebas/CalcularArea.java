/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package Pruebas;
import java.util.Scanner;

/**
 *
 * @author Infotep2019
 */
public class CalcularArea {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
    Scanner obj = new Scanner(System.in);
    System.out.print("Ingrese el radio de su figura \n");
    double Numero = obj.nextDouble();
    double resultado = Math.PI * Math.pow(Numero,2);
    System.out.print("El area es: "+resultado);
        
        
        
    }
    
}
