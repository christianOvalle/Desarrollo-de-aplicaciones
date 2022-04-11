/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package Pruebas;
import java.util.Random;
/**
 *
 * @author Infotep2019
 */
public class numeroRando {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       String[] meses = {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};
       
       Random mese = new Random();
       
       for(int i = 0; i<6; i++){
       
       int R = mese.nextInt(0,12);
       
       System.out.println(meses[R]);
       
       
       }
       
    }
    
}
