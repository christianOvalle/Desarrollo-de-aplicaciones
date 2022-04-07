/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package EjercicioVehiculo;

/**
 *
 * @author Infotep2019
 */
public class Bicicleta extends Vehiculo {
    
    private String tipo;
    
     public String getTipo() {
        return tipo;
    }

    public void setTipo(String tipo) {
        this.tipo = tipo;
    }
    public void DatosBicicleta(){
    
    System.out.println("Bicicleta \n");   
    System.out.println("{");
    System.out.println("El color de la Bicicleta es: "+getColor());
    System.out.println("Numero de ruedas del Bicicleta son: "+getRueda());
    System.out.println("Tipo de Bicicleta:  "+ getTipo());
    System.out.println("}");
    System.out.println("__________________________________________________");
    System.out.println(" ");
    
    }
    public Bicicleta(){}

   public Bicicleta(String Color, int Ruedas, String Velocidad, String Tipo ){
   
  setColor(Color);
  setRueda(Ruedas);
  this.tipo = Tipo;
  
  DatosBicicleta();
  
       
       
   }
    
    
    
}
