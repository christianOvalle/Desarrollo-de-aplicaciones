/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package Pruebas;
import java.util.Scanner;

/**
 *
 * @author Cristhian
 */
public class CaracterDecimal {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        Scanner obj = new Scanner(System.in);
        String Usuario = obj.next();
        
        char[] Nombre = Usuario.toCharArray();
        
        for(int i = 0; i<Nombre.length; i++){
        
        System.out.print(((int)Nombre[i]+"-"));
        
        
        }
        
       
        
    }
    
}
