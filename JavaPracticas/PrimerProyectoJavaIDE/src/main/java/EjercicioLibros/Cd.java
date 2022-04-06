/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package EjercicioLibros;

/**
 *
 * @author Infotep2019
 */
public final class Cd extends Publicacion {

    public Cd() {
    }
   
    private double TimePlay;

          
  
    public double getTimePlay() {
        return TimePlay;
    }

    public void setTimePlay(double TimePlay) {
        this.TimePlay = TimePlay;
    }
    
    public void MostrarTiempo(){
    
        System.out.println("Tiempo de reproducion: "+getTimePlay()); 
        System.out.println("}");
    
    }
    
   
    public Cd(int tiempo){
    
    setTimePlay(tiempo);
    
    MostrarTiempo();
    
    }

    
    
}
