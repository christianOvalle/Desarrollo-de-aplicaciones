/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package javaapplication1;
import java.util.Scanner;
import java.util.Random;
/**
 *
 * @author Cristhian
 */
public class MininoYMaximo {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       
        Scanner obj = new Scanner(System.in);
        Random random = new Random();
        System.out.println("Ingrese Segundo Numero \n");
        int Numero1 = obj.nextInt();
        System.out.println("Ingrese Primer Numero \n");
        int Numero2 = obj.nextInt();
        
        
        for(int i = 0; i<10; i++){
          
            System.out.print(random.nextInt(Numero1,Numero2)+"-");
            
        }
        }
        
        
    }
    

