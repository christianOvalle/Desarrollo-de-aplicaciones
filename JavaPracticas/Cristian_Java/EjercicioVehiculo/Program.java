/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package EjercicioVehiculo;

/**
 *
 * @author Infotep2019
 */
public class Program {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
         
        Vehiculo vih = new Vehiculo();
        vih.DatosVehiculo();
        Coche coh = new Coche("Rojo",4,"300KM",2000);
        vih.DatosVehiculo();
        Camioneta cami = new Camioneta("Verde",4,"180MPH",3500,"560");
        vih.DatosVehiculo();
        Bicicleta bici = new Bicicleta("Amarilla",2,"80KM","Urbana");
        vih.DatosVehiculo(); 
        Motocicleta moto = new Motocicleta("Negra",2,"260MPH",2800);
                
        
        
    }
    
}
