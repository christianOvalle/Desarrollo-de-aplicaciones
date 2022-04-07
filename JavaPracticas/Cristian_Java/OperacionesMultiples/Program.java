/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package OperacionesMultiples;
import java.util.Scanner;
/**
 *
 * @author Infotep2019
 */
public class Program {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       Scanner obj = new Scanner(System.in);
       
       
       Operacion op = new Operacion();
       //System.out.print("Operaciones Multiples \n");
       System.out.print("Ingrese primer numero \n");
       double num1 = obj.nextDouble();      
       System.out.print("Ingrese primer numero \n");
       double num2 = obj.nextDouble();
      
       System.out.print(" ");
       
       op.Menu();
       op.Operador(obj.nextInt());
       
      
      if(op.getOperacion() == 1){
      
      op = new Resta();
      op.setNumero1(num1);
      op.setNumero2(num2);
      op.ejecutar();
      op.Mostrar();
      }
      
      else if(op.getOperacion()==2){
      
      op = new Suma();
      op.setNumero1(num1);
      op.setNumero2(num2);
      op.ejecutar();
      op.Mostrar();
      
      
      }
      
      else if(op.getOperacion()==3){
      
      op = new Multiplicar();
      op.setNumero1(num1);
      op.setNumero2(num2);
      op.ejecutar();
      op.Mostrar();
      
      
      }
      
      else if(op.getOperacion()==4){
      
      op = new Dividir();
      op.setNumero1(num1);
      op.setNumero2(num2);
      op.ejecutar();
      op.Mostrar();
      
      
      }
           
           
           
           
       }
    
}
