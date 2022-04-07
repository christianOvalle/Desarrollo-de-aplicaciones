package  EjercicioPersona;

public class Profesor extends Persona{
    private String carrera;
    
    public void ensenar() {
    
        System.out.println("Profesor{");
        System.out.println("Nombre: " + getNombre());
        System.out.println("Domicilio: " + getDomicilio());
        System.out.println("Horario: " + getHorario());
        System.out.println("Carrera: " + this.carrera);
        System.out.println("Instruyendo...");
        System.out.println("}");
    
    
    
    }
    
    
    public Profesor(String nombre, String domicilio, String horario, String carrera){
    
    setNombre(nombre);
    setDomicilio(domicilio);
    setHorario(horario);
    this.carrera = carrera;
    ensenar();
    
    
    }
}
