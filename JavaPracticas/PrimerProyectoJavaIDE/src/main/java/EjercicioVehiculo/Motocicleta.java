/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package EjercicioVehiculo;

/**
 *
 * @author Infotep2019
 */
public class Motocicleta extends Bicicleta {
     
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
   
    
    public void DatosCamioneta(){
    
    System.out.println("Motocicleta \n");   
    System.out.println("{");
    System.out.println("El color de la Motocicleta es: "+getColor());
    System.out.println("Numero de ruedas del Motocicleta son: "+getRueda());
    System.out.println("la Velocidad de la Motocicleta es: "+getVelocidad());
    System.out.println("La cilindrada de la Motocicleta es: "+getCilindrada());
    System.out.println("}");
    System.out.println("__________________________________________________");
    System.out.println(" ");
         
    }
    
    public Motocicleta(String Color, int Ruedas, String Velocidad, double cilindrada){
    
    setColor(Color);
    setRueda(Ruedas);
    this.velocidad = Velocidad;
    this.cilindrada = cilindrada;
    
    DatosCamioneta();
    }
    
}
