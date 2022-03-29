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
public class Menu {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        
        Scanner obj = new Scanner(System.in);
        boolean salir = false;
           
        
        System.out.print("Bienvenido al cuestionario \n");
        
        System.out.print("Eliga Una Opcion \n");
        
        System.out.println("1.¿Por qué java lo consideran un lenguaje multiplataforma?");
        System.out.println("2.¿Quién fue el creador de java?");
        System.out.println("3.¿Quién fue el creador de java?");
        System.out.println("4.¿Cuáles sistemas operativos soportan JAVA?");
        System.out.println("5.¿Qué aplicación desea realizar como su proyecto final de java?");
        System.out.println("5.¿Qué aplicación desea realizar como su proyecto final de java?");
        System.out.println("6.¿Qué es la programación orientada a objeto? ");
        System.out.println("7.¿Cuál es la última versión de java?");
        System.out.println("8.¿Cuál es la diferencia entre java y javascript?");
        System.out.println("9.¿Qué es el JDK?");
        System.out.println("10.Salir");
         
        int opcion= obj.nextInt();
        while(opcion>0 && salir == false){
            
            
        System.out.print("Eliga Una Opcion \n");
                 
        
        System.out.println("1.¿Por qué java lo consideran un lenguaje multiplataforma?");
        System.out.println("2.¿Quién fue el creador de java?");
        System.out.println("3.¿Quién fue el creador de java?");
        System.out.println("4.¿Cuáles sistemas operativos soportan JAVA?");
        System.out.println("5.¿Qué aplicación desea realizar como su proyecto final de java?");
        System.out.println("5.¿Qué aplicación desea realizar como su proyecto final de java?");
        System.out.println("6.¿Qué es la programación orientada a objeto? ");
        System.out.println("7.¿Cuál es la última versión de java?");
        System.out.println("8.¿Cuál es la diferencia entre java y javascript?");
        System.out.println("9.¿Qué es el JDK?");
        System.out.println("10.Salir");
         
        opcion= obj.nextInt();                     
        switch(opcion){
        
            case 1 -> System.out.println("-Ser multiplataforma significa que un programa creado en Java puede ser ejecutado sobre cualquier computador sin importar su estructura (Mac, Unix, Pc");
             
            case 2 -> System.out.println("James Gosling");
             
            case 3 -> System.out.println("Windows 10 (8u51 y superiores),Windows 8.x (escritorio),Windows 7 SP1,Windows Vista SP2,Windows Server 2008 R2 SP1 (64 bits),Windows Server 2012 y 2012 R2 (64 bits) RAM: 128 MB Espacio en disco: 124 MB para JRE; 2 MB para Java Update Procesador: Mínimo Pentium 2 a 266 MHz,Exploradores: Internet Explorer 9 y superior, Firefox");
               
            case 4 -> System.out.println("- Aplicacion de ventas online");
            case 5 -> System.out.println("La Programación Orientada a Objetos es un paradigma de programación que parte del concepto de objetos como base, los cuales contienen información en forma de campos y código en forma de métodos." );
                
            case 6 -> System.out.println("La última versión de Java en su sistema se mostrará como Java 8 con un número de actualización asociado (por ejemplo, Java 8 Update 111)");
                
            case 7 -> System.out.println("Java es un lenguaje de programación orientado a objetos puros (OOP), mientras que JavaScript está basado en prototipos y, puede emular la programación orientada a objetos. JavaScript es gestionado por ECMAScript, una organización sin ánimo de lucro.");
                 
            case 8 -> System.out.println("Java Development Kit es un software que provee herramientas de desarrollo para la creación de programas en Java. Puede instalarse en una computadora local o en una unidad de red.");
            case 9 -> System.out.println("Bay");
            case 10 -> salir = true;
            default -> System.out.println("Opcion Invalida");
            
        }
        
        
      
        }
    }   

        
        
}
