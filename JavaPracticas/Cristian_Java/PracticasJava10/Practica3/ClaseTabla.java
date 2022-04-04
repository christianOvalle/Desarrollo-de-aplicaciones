/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package Practica3;


/**
 *
 * @author Infotep2019
 */
public class ClaseTabla {
    
    private int num;
    
    
    public void SetTabla(int num){
        
     this.num = num;
     
     
    }
    
    public int GetTabla(){
    
        for(int i = num; i<=num; i++){
        for(int m = 1; m<=12; m++){
        
        System.out.println(i+" x "+m+" = "+i*m);
                                     
        }       
        
     
     }
    
    return num ;
    
    }
    
    
}
