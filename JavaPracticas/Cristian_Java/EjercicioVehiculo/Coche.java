/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package EjercicioVehiculo;

/**
 *
 * @author Infotep2019
 */
public class Coche extends Vehiculo{
    
    private String velocidad;
    private double cilindrada;

    public String getVelocidad() {
        return velocidad;
    }

    public void setVelocidad(String velocidad) {
        this.velocidad = velocidad;
    }

    public double getCilindrada() {
        return cilindrada;
    }

    public void setCilindrada(double cilindrada) {
        this.cilindrada = cilindrada;
    }
    public void MostrarCoche(){
    
    System.out.println("Coche \n");   
    System.out.println("{");
    System.out.println("El color del Coche es: "+getColor());
    System.out.println("Numero de ruedas del coche son: "+getRueda());
    System.out.println("Velocidad del coche (KM o MPH): "+ getVelocidad());
    System.out.println("Cilindrada del coche: "+getCilindrada()+"cc");
    
    }
   
    public Coche(String color, int Ruedas, String velocidad, double cilindrada ){
        
      setColor(color);
      setRueda(Ruedas);
      this.velocidad = velocidad;
      this.cilindrada = cilindrada;
      
     MostrarCoche();
        
    }  
}
