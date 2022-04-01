/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package Pruebas;
import java.util.Arrays;
/**
 *
 * @author Infotep2019
 */
public class Texto {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
       
        String texto = "Java nace en 1991 con el nombre “OAK”, posteriormente cambiado por Green por problemas legales, y finalmente con la denominación actual JAVA. El objetivo de java era crear un lenguaje de programación parecido a C++ en estructura y sintaxis, fuertemente orientado a objetos, pero con una máquina virtual propia.";
       int contador = 0;
       var contadorM = 0;
       var contadorMI =0;
       int espacios = 0;
       //Cantidad de elementos del texto
       for(int i = 0; i <=texto.length(); i++ ){
           
          
       }
              
       System.out.println("Cantidad de elementos: "+texto.length());
       
       //Cantidad de palabras del texto
       String[] Palabras =  texto.split(" ");
        
       System.out.println("Cantidad de palabras: "+Palabras.length);
      
       
       char[] Nuevo = texto.toCharArray();
       
       for(int i = 0; i <=Nuevo.length -1; i++ ){
           
           if(Character.isDigit(Nuevo[i])){
           
                contador ++;          
           }  
           
          
       }
       System.out.println("Numero de digitos: "+contador);
       
       
       
       for(int i = 0; i<=texto.length()-1; i++){
       
       if(Character.isUpperCase(texto.charAt(i))){
       
         contadorM ++;
       }
       
       if(Character.isLowerCase(texto.charAt(i))){
       
           contadorMI ++;
       }
       
       if(Character.isWhitespace(texto.charAt(i))){
       
           espacios ++;
       }
       }
       
       
       System.out.println("Mayusculas: "+contadorM);
       System.out.println("Minusculas: "+contadorMI);
       System.out.println("Espacios: "+espacios);
    }
    
    
}
