
package Clases;

import com.sun.jdi.connect.spi.Connection;
import java.sql.DriverManager;


public class Conectar {
  
  Connection cn;
  
  public Connection conexion (){
  
  
      try {
          
          Class.forName("com.mysql.Driver");
          
          cn= (Connection) DriverManager.getConnection("jdbc://localhost/db","root","");
          
          System.out.println("Conectado");
          
      } catch (Exception e) {
          
          
          System.err.println(e.getMessage());
          
      }
      
      return cn;
  
  }
    
}
