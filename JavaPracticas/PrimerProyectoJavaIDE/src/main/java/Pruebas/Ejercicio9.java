/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package Pruebas;

/**
 *
 * @author Cristhian
 */
public class Ejercicio9 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
     
      
      int contador2 = 0;  
      int contador3 = 0;
      int contador5 = 0;
      int contador7 = 0;
      
     for(int i = 1; i<=1000; i++){
                        
        if(i%2 ==0){
        contador2++;
        System.out.println(i+" Es Divisible de 2");
        }
         
         if(i%3 ==0){
        contador3++;
        System.out.println(i+" Es Divisible de 3");
        }
        
        if(i%5 ==0){
        contador5++;
        System.out.println(i+" Es Divisible de 5");
        }
        
        if(i%7 ==0){
        contador7++;
        System.out.println(i+" Es Divisible de 7");
        }
     }
          System.out.println("\n");
         System.out.println(contador2+" Numero son divisibles de 2 ");
         System.out.println(contador3+" Numero son divisibles de 3 ");
         System.out.println(contador5+" Numero son divisibles de 5 ");
         System.out.println(contador7+" Numero son divisibles de 7 ");
     }   
        
    }   
    
    
     
