/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package javaapplication1;
import java.util.Scanner;
/**
 *
 * @author Cristhian
 */
public class Ejercicio9 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
      Scanner Obj = new Scanner(System.in);
      int numero = 1000;
        
     for(int i = 2; i<numero / 2; i++){
                        
         if(numero % i == 0 ){
     
     System.out.println(i+" No es Es Primo");
     
     }
         
         else {
             
             System.out.println(i+" Si es Es Primo");
                 
         }
     }   
        
    }   
    
    
     }
