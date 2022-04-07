/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package OperacionesMultiples;

/**
 *
 * @author Infotep2019
 */
public class Dividir extends Operacion {

    @Override
    public void ejecutar() {
         // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/OverriddenMethodBody
          
         if(getNumero1()>=0 && getNumero2()>=0 ){
         resultado = getNumero1() / getNumero2();
        
         }
         else{
         System.out.println("No se puede dividir por cero");
    }
    }

    
}
