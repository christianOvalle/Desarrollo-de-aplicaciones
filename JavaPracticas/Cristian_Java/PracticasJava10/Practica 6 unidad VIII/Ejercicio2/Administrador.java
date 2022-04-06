
package ejercicio2;


public class Administrador extends Persona{
    
    private String puesto;
    
    public void administrar(){
    
        System.out.println("Administrador{");
        System.out.println("Nombre: " + getNombre());
        System.out.println("Domicilio: " + getDomicilio());
        System.out.println("Horario: " + getHorario());
        System.out.println("Puesto: " + this.puesto);          
        System.out.println("Administrando...");
        System.out.println("}");
       
    }
    
    public Administrador(String nombre,String domicilio,String horario, String puesto){
    
    setNombre(nombre);
    setDomicilio(domicilio);
    setHorario(horario);
    this.puesto = puesto;
    
    administrar();
    
    
    }
    
}
