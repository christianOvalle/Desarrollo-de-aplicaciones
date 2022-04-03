/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package javaapplication1;

import java.util.Arrays;
import java.util.Scanner;

/**
 *
 * @author Cristhian
 */
public class DecimalCaracter {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        Scanner obj = new Scanner(System.in);
        String Usuario = obj.next();
        
        String[] Numero = Usuario.split(",");
        
        
        for (int i = 0; i<Numero.length; i++){
        
        System.out.print((char)(Integer.parseInt(Numero[i])));
        
        }
        
        
       
        
       
    }
    
}
