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
public class Practica2 {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       Scanner obj = new Scanner(System.in);
       boolean Salir = false;
       
       System.out.print("Eliga una opcion \n");
       
       
       System.out.println("1.¿Qué es la JVM? \n");
       System.out.println("2.¿Qué es el bytecode? \n");
       System.out.println("3.¿Qué es el bytecode? \n");
       System.out.println("4.Mencione 10 palabras reservadas del lenguaje java \n");
       
       int Opcion = obj.nextInt();
       while(Opcion>0 && Salir == false ){
       
       System.out.println("1.¿Qué es la JVM? \n");
       System.out.println("2.¿Qué es el bytecode? \n");
       System.out.println("3.¿Qué es el bytecode? \n");
       System.out.println("4.Mencione 10 palabras reservadas del lenguaje java \n");
       System.out.println("5.Salir \n");
       
       Opcion = obj.nextInt();    
       switch(Opcion) { 
           case 1:
               System.out.print("Una máquina virtual Java es una máquina virtual de proceso nativo, es decir, ejecutable en una plataforma específica, capaz de interpretar y ejecutar instrucciones expresadas en un código binario especial, el cual es generado por el compilador del lenguaje Java. \n");
                break;
           case 2:
               System.out.print("El bytecode Java se encuentra dentro del archivo de extensión .class y es el tipo de instrucciones que la máquina virtual Java espera recibir para posteriormente ser compiladas a lenguaje de máquina mediante un compilador JIT a la hora de su ejecución. \n");
                break;
            case 3:
               System.out.print("IntelliJ IDEA, Eclipse IDE, Apache NetBeans. \n");
                break;
             case 4:
               System.out.print("Abstract, assert, Boolean, break, byte, case, catch, char \n");
                break;                   
             case 5:
                 Salir = true;
                 System.out.print("Gracias por Participar \n");                 
                 break;
             default:
                 System.out.print("Opcion Invalida \n");
         }
       }
        
        
        }
    
}
