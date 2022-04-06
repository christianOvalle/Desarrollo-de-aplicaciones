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
public class Ejercicio4 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
    Scanner Obj = new Scanner(System.in);
    String Numero = Obj.next();
    var comparacion = 0;
    
    if(Numero.contains(".")){
        if(Numero.startsWith("-")){
    System.out.println("Decimal Negativo");
        }
    else {
          System.out.println("Decimal Positivo");  
            }
    }
      
    
    
    
    else if(Integer.parseInt(Numero) < 0 ){
   
    System.out.println(" Negativo "+Numero);
       
    }   
    else if(Integer.parseInt(Numero) > 0){
        
   System.out.println("Positivo "+Numero);
    }
    
    
    if(!Numero.contains(".")){
    
    System.out.println("Numero entero "+Numero);
    
    }   
    char[] Num = Numero.toCharArray();
    int contador = 0;
    
    
    for(int i = 0; i<Num.length; i++){
    
    if(Character.isDigit(Num[i])){
        
        contador ++;          
    }
    
    }
    System.out.println("Numero De Digitos "+contador);
    
    }
    
    }
    
    
    
    

