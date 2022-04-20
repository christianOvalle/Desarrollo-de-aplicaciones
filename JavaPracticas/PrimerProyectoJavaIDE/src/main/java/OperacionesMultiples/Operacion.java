
package OperacionesMultiples;


public class Operacion {
    
    protected double numero1; 
    protected double numero2; 
    protected double operacion; 
    protected double resultado;

    public double getNumero1() {
        return numero1;
    }

    public void setNumero1(double numero1) {
        this.numero1 = numero1;
    }

    public double getNumero2() {
        return numero2;
    }

    public void setNumero2(double numero2) {
        this.numero2 = numero2;
    }
     
     public double getOperacion() {
        return operacion;
    }

    public void setOperacion(int operacion) {
        this.operacion = operacion;
    }
    
    
    
         
  public void Operador(int operacion){
      
  setOperacion(operacion);    
  }
  
  public void Menu(){
  System.out.println("Que operacion desea realizar? \n" );
  
  System.out.println("1. Resta");
  System.out.println("2. Suma");
  System.out.println("3. Multiplicar");
  System.out.println("4. Dividir");
  
  }
  public void ejecutar(){}
  public void Mostrar(){
  System.out.println("Resultado es: "+resultado);
  }
    
}
