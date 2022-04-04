/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Practica3;
import java.util.Scanner;

/**
 *
 * @author Infotep2019
 */
public class TablaEjercicio {
    
    public void Tabla(){
    Scanner obj = new Scanner(System.in);
    ClaseTabla multi = new ClaseTabla();
    System.out.println("que tabla desea ver");
    
    multi.SetTabla(obj.nextInt());
    
    
    System.out.println(multi.GetTabla());
    
            }
    
   
    
}
