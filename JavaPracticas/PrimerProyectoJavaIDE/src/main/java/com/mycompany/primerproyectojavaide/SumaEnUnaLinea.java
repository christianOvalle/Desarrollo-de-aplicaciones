/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package com.mycompany.primerproyectojavaide;
import java.util.Scanner;
/**
 *
 * @author Infotep2019
 */
public class SumaEnUnaLinea {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       
        Scanner Objeto = new Scanner(System.in);
        System.out.println("Ingrese lo que desea realizar \n\n");
        String Usuario = Objeto.next();
        
       
        
        
        if(Usuario.charAt("+)){
        
        System.out.println("Va a sumar Los proximos numeros que digitara \n ");
        System.out.println("Primer numero \n");
        int numero1 = Objeto.nextInt();
        System.out.println("Segundo numero \n");
        int numero2 = Objeto.nextInt();
        int resultado = numero2 + numero1; 
        System.out.println("La suma es igual a "+resultado);
        
        }
        /*else if(Restar == true){
        
        System.out.println("Va a Restar Los proximos numeros que digitos \n ");
        System.out.println("Primer numero \n");
        int numero1 = Objeto.nextInt();
        System.out.println("Segundo numero \n");
        int numero2 = Objeto.nextInt();
        int resultado = numero2 - numero1; 
        System.out.println("La Resta es igual a "+resultado);
        
        }
        
        
        
        
        
        
        
       /* String[] Arreglo  = Usuario.split("");
        
        for(int i = 0; i <= Arreglo.length; i++){ 
        
        System.out.println(Arreglo[i]);
        
        if(Arreglo[i] == "+"){
        
        System.out.println("Va a sumar Los proximos numeros que digitara \n ");
        System.out.println("Primer numero \n");
        int numero1 = Objeto.nextInt();
        System.out.println("Segundo numero \n");
        int numero2 = Objeto.nextInt();
        int resultado = numero2 + numero1; 
        System.out.println("La suma es igual a "+resultado);
        }
        }*/

}}      
    
        
        
        
        
    

