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
public class Parte2 {
    public void ingresarDatos(){
    Scanner obj = new Scanner(System.in);
    
    Persona persona = new Persona();
    
    System.out.println("Ingresa Nombre");
    persona.SetName(obj.nextLine());
    System.out.println("Ingresa Apellido");
    persona.Setapellido(obj.nextLine());
    System.out.println("Ingresa Cedula");
    persona.SetCedula(obj.nextLine());
    System.out.println("Ingresa Direccion");
    persona.SetDirecion(obj.nextLine());
    
    System.out.println("Ingresa Edad");
    persona.SetEdad(obj.nextInt());
    
    
    System.out.println("Su Nombre es "+persona.GetName());
    System.out.println("Su Apellido es "+persona.Getapellido());
    System.out.println("Su Cedula es "+persona.GetCedula());
    System.out.println("Su Direccion es "+persona.GetDirecion());
    System.out.println("Su Edad es "+persona.GetEdad());
    System.out.println(persona.Verificador());
    
    
    }    
}
