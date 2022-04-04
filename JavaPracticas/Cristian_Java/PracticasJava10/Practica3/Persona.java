/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Practica3;

/**
 *
 * @author Infotep2019
 */
public class Persona {
    
    private String nombre,apellido,cedula,direccion;
    private int edad;
    
       

public void SetName(String nombre){

this.nombre=nombre;
    
}

public String GetName(){

return nombre;


}

public void Setapellido(String apellido){

this.apellido=apellido;
    
}

public String Getapellido(){

return apellido;


}

public void SetCedula(String cedula){

this.cedula=cedula;
    
}

public String GetCedula(){

return cedula;


}

public void SetDirecion(String direccion){

this.direccion=direccion;
    
}

public String GetDirecion(){

return direccion;


}

public void SetEdad(int edad){

this.edad=edad;

}

public int GetEdad(){

return edad;

}
public String Verificador(){

 if(this.edad>18){

return "Es mayor de edad";
}
 else {
 return "No es mayor de edad";
 
 
 }
     
}



}
