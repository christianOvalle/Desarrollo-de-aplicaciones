/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package EjercicioLibros;


public class Libro extends Publicacion {
    
  private int NumeroDePaginas;

    public int getNumeroDePaginas() {
        return NumeroDePaginas;
    }

    public void setNumeroDePaginas(int NumeroDePaginas) {
        this.NumeroDePaginas = NumeroDePaginas;
    }
  
    public void MostraPaginas(){
    
    System.out.println("Numero de paginas: "+getNumeroDePaginas());
      
    }
    
    public Libro(){}
    
    public Libro(int NumPag){
    
    setNumeroDePaginas(NumPag);
    MostraPaginas();
       
    }
    
    
    
}
