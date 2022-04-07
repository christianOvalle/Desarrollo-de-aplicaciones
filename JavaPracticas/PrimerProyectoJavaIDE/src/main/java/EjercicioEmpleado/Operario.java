package EjercicioEmpleado;

public class Operario extends Empleados{

    
     public void tostring() {

        System.out.println("Empleado: " + GetNombre()+" -> Operario");
    }
    
    public Operario(String nombre) {
        
        setNombre(nombre);
        tostring();
        
    }
    
    public Operario(){
    
    
    }

}
