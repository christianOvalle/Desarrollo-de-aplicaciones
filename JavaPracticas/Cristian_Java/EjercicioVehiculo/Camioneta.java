/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package EjercicioVehiculo;

/**
 *
 * @author Infotep2019
 */
public class Camioneta extends Coche {

    private String carga;

    public String getCarga() {
        return carga;
    }

    public void setCarga(String carga) {
        this.carga = carga;
    }
    
                
    public void DatosCamioneta(){
    
    System.out.println("Camioneta \n");   
    System.out.println("{");
    System.out.println("El color de la Camioneta es: "+getColor());
    System.out.println("Numero de ruedas del Camioneta son: "+getRueda());
    System.out.println("Velocidad de la Camioneta (KM o MPH): "+ getVelocidad());
    System.out.println("Cilindrada del Camioneta: "+getCilindrada()+"cc");
    System.out.println("Cilindrada del Camioneta: "+getCarga()+"KG");
    System.out.println("}");
    System.out.println("__________________________________________________");
    System.out.println(" ");
         
    }
    
    public Camioneta(){}
    
    public Camioneta(String color, int Ruedas, String velocidad, double cilindrada, String Carga ){
        
      setColor(color);
      setRueda(Ruedas);
      setVelocidad(velocidad);
      setCilindrada(cilindrada);
      this.carga = Carga;
      
     DatosCamioneta();
        
    }  

    

    
}
