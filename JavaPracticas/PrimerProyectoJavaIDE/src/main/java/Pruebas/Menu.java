/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Main.java to edit this template
 */
package javaapplication1;
import  java.util.Scanner;
/**
 *
 * @author Cristhian
 */
public class Menu {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
       
        boolean encendido = true;
        Scanner Objeto = new Scanner(System.in);
        
        while(encendido){
        
        System.out.println("1.Tipos de datos");
        System.out.println("2.Operadores");
        System.out.println("3.Comentarios");
        System.out.println("4.Salir");
        int Opcion1 = Objeto.nextInt();
        switch(Opcion1){
            case 1:
         System.out.println("1.Enteros");
         System.out.println("2.Real");
         System.out.println("3.Caracteres");
         System.out.println("4.Logicos");
         System.out.println("5.Cadenas");
         int Opcion2 = Objeto.nextInt();
         
         if (Opcion2 ==1){
         System.out.println("1.Definir");
         System.out.println("2.Acceder");
         int Opcion3  = Objeto.nextInt();
         if(Opcion3 == 1){
         
         System.out.println("Los números enteros son cualquier número que corresponda al conjunto de los números naturales más sus opuestos incluyendo el número cero (0).");
         break;
         }
         else if(Opcion3 == 2){
         
         System.out.println( "	INT");
         System.out.println("	SHORT");
         System.out.println("	BYTE");
         System.out.println("	LONG");
         break;   
         
         }
         }         
         else if(Opcion2 == 2){
         System.out.println("1.Definir");
         System.out.println("2.Acceder");
         int Opcion3  = Objeto.nextInt();    
         if(Opcion3 == 1){
         System.out.println("Un número real puede ser un número racional o un número irracional. · Otra forma de clasificar los números reales es en algebraicos y trascendentes.");
         break;                
         }         
         else if(Opcion3 == 2){
         
         System.out.println("- FLOAT");
         System.out.println("-DOUBLE");         
         break;   
         
         }        
         }
         
         else if(Opcion2 == 3){
         System.out.println("1.Definir");
         System.out.println("2.Acceder");
         int Opcion3  = Objeto.nextInt();
         if(Opcion3 == 1){
         System.out.println("En programación, una cadena de caracteres, palabras, ristra de caracteres o frase es una secuencia ordenada de elementos que pertenecen a un cierto lenguaje formal o alfabeto análogas a una fórmula o a una oración.");
         break;
         
         }
         else if(Opcion3 == 2){
         
         System.out.println("-CHAR");
         break;
         }
         }
         
         else if(Opcion2 == 4){
         System.out.println("1.Definir");
         System.out.println("2.Acceder");
         int Opcion3  = Objeto.nextInt();
         if(Opcion3 == 1){
         
            System.out.println("Los operadores lógicos se usan para combinar dos valores Booleanos y devolver un resultado verdadero, falso o nulo.");
            break;
         }
         else if(Opcion3 == 2){
         
         System.out.println("BOOLEAN");
         break;
         }
          }
         else if(Opcion2 == 5){
         System.out.println("1.Definir");
         System.out.println("2.Acceder");
         int Opcion3  = Objeto.nextInt();
         if(Opcion3 == 1){
         
         System.out.println("En programación, una cadena de caracteres, palabras, ristra de caracteres o frase es una secuencia ordenada de elementos que pertenecen a un cierto lenguaje formal o alfabeto análogas a una fórmula o a una oración.");   
         break;    
         
         }
         else if(Opcion3 == 2 ){
         
         System.out.println("STRING");
         break;
         }
         }
         
        case 2:
            
         System.out.println("1.Relacionales");
         System.out.println("2.Logicos");
         System.out.println("3.Aritmeticos");      
         Opcion2 = Objeto.nextInt();
         if (Opcion2 ==1){
         System.out.println("1.Definir");
         System.out.println("2.Acceder");       
         int Opcion3  = Objeto.nextInt();
          if(Opcion3 == 1){
         
         System.out.println("Los operadores relacionales son símbolos que se usan para comparar dos valores. Si el resultado de la comparación es correcto la expresión considerada es verdadera, en caso contrario es falsa");   
         break;             
         }
         else if(Opcion3 == 2 ){
         
         System.out.println("<");
         System.out.println(">");
         System.out.println("==");
         System.out.println("!=");
         System.out.println("<=");
         System.out.println(">=");        

         break;
         }
          
        }
         
         if (Opcion2 ==2){
         System.out.println("1.Definir");
         System.out.println("2.Acceder");       
         int Opcion3 = Objeto.nextInt();
          if(Opcion3 == 1){
         
         System.out.println("En lógica, una conectiva lógica, o también conectiva es un símbolo o palabra que se utiliza para conectar dos fórmulas bien formadas o sentencias, de modo que el valor de verdad de la fórmula compuesta depende del valor de verdad de las fórmulas componentes.");   
         break;             
         }
         else if(Opcion3 == 2 ){
         System.out.println("&&");
         System.out.println("||");
         System.out.println("!");      
         break; 
             
         }
         }
        if (Opcion2 ==3){
         System.out.println("1.Definir");
         System.out.println("2.Acceder");       
         int Opcion3 = Objeto.nextInt();
          if(Opcion3 == 1){
         
         System.out.println("Un operador es un signo o símbolo que especifica el tipo de cálculo que se realiza en una expresión. Hay operadores matemáticos, de comparación, lógicos y de referencia.");   
         break;             
         }
         else if(Opcion3 == 2 ){
         System.out.println("+");
         System.out.println("-");
         System.out.println("/");
         System.out.println("%");
         System.out.println("*");   
         break; 
             
         }
          
        }
         case 3:         
         System.out.println("1.De una Linea");
         System.out.println("2.De varias Lineas");
         Opcion2 = Objeto.nextInt();
         if (Opcion2 == 1){
         System.out.println("1.Definir");
         System.out.println("2.Acceder");       
         int Opcion3  = Objeto.nextInt();
          if(Opcion3 == 1){
         
         System.out.println("Para comentariar una sola línea se utiliza la doble diagonal //. El comentario se inicia cuando se encuentra la doble diagonal y continua hasta el final de la línea. Comentarios para documentación.");   
         break;             
         }
          else if(Opcion3 == 2 ){
         System.out.println("//");
         break;
          }
         }
         
        if (Opcion2 == 2){
         System.out.println("1.Definir");
         System.out.println("2.Acceder");       
         int Opcion3  = Objeto.nextInt();
          if(Opcion3 == 1){
         
         System.out.println("Java ofrece tres tipos de comentarios: dos para comentarios regulares en el código fuente y uno para la documentación especial del sistema javadoc. Comentarios de varias líneas. Los comentarios de varias líneas se incluyen entre los símbolos /* y */, como en C y C++.");   
         break;             
         }
         else if(Opcion3 == 2 ){
         System.out.println(" /* y */");
          }
        
        }
         case 4:
             encendido = false;
        }   
    }   
}
    }
