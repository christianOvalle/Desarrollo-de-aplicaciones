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
public class MenuMultiOpciones {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner Obj = new Scanner(System.in);        
        
        boolean Salida = true;
        
        while(Salida){
        System.out.println("1. Tipos de datos");
        System.out.println("2. Operadores");
        System.out.println("3. Comentarios");
        System.out.println("4. Salir");
        
        int Opcion = Obj.nextInt();
       
        switch(Opcion){
        
            case 1:
                System.out.println("1. Enteros \n");               
                System.out.println("2. Real \n");
                System.out.println("3. Caracteres \n");
                System.out.println("4. Logicos \n");
                System.out.println("5. Cadenas \n");
                System.out.println("6. Salir \n");
                Opcion = Obj.nextInt();
                System.out.println("1.Definir \n");               
                System.out.println("2.Acceder \n");                
                Opcion = Obj.nextInt();
                           
                if(Opcion == 1){
                
                System.out.println("Concepto matemático que expresa una cantidad con relación a la unidad de cómputo; resulta de contar los elementos que forman un conjunto.");
                break;
                }
                            
                if(Opcion == 1 ){
                    
                 System.out.println("Int \n");
                 System.out.println("Short \n");
                 System.out.println("Byte \n");
                 System.out.println("Long \n");                    
                
                }
                else if (Opcion == 2){
                
                 System.out.println("Float \n");
                 System.out.println("Short \n");
                
                }
                
                else if(Opcion == 3){
                
                System.out.println("Chart \n");
                
                }
                
                else if(Opcion == 4){
                
                System.out.println("Boolean \n");
                
                }
                
                else if(Opcion == 5){
                
                 System.out.println("String \n");
                
                }
                
                else if(Opcion == 6){
                
                Salida = false;
                
                }
                
                break;
                
            case 2:
                System.out.println("1. Relacionales");
                System.out.println("2. Logicos");
                System.out.println("3.Aritmeticos");
                break;
            case 3:
                System.out.println("1. De una Lineas");
                System.out.println("2. De Varias Lineas");
                
            case 4: 
               Salida = false;
        }
        
        }
    }
    
}
