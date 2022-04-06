/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package EjercicioLibros;

/**
 *
 * @author Infotep2019
 */
public class Publicacion {
 
 private String titulo;
 private Double Precio;

    public String getTitulo() {
        return titulo;
    }

    public void setTitulo(String titulo) {
        this.titulo = titulo;
    }

    public Double getPrecio() {
        return Precio;
    }

    public void setPrecio(Double Precio) {
        this.Precio = Precio;
    }
 
    public void MostrarDatos(){
    
        
    System.out.println("Publicacion \n");
    System.out.println("{");
    System.out.println("Titulo: " +getTitulo());
    System.out.println("Precio: " +getPrecio());
    
    }
    
   public Publicacion(){}
    
   public Publicacion(String titulo, Double Precio){
   
   setTitulo(titulo);
   setPrecio(Precio);
   MostrarDatos(); 
    
    }
 
    
    
    
    
}
