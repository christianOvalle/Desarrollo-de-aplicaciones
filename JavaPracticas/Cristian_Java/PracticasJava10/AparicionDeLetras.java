/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package javaapplication1;

/**
 *
 * @author Cristhian
 */
public class AparicionDeLetras {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       
        String Texto = "El lenguaje de programación Java fue desarrollado originalmente por James Gosling, de Sun Microsystems (constituida en 1983 y posteriormente adquirida el 27 de enero de 2010 por la compañía Oracle), y publicado en 1995 como un componente fundamental de la plataforma Java de Sun Microsystems";
        int contador = 0;
        char Almacenador;
        
        
        char[] Parrafo = Texto.toCharArray();
        
        for(int i = 0; i<Parrafo.length; i++){
        
            Almacenador = Parrafo[i];
        
        for(int m = 0; m<Parrafo.length; m++){
        
            if(Almacenador == Parrafo[m]){
                
              contador++;
                
                
            }
        
        
        }
        
        System.out.println(Parrafo[i]+" = "+contador);
        contador =0;
        
        
       
       
        
        
    }
    

    }
}