import java.util.Scanner;

class Factorial{


public static void main(String[] arg){

Scanner myObj = new Scanner(System.in);
System.out.println("Ingrese Numero");

int Numero = myObj.nextInt();
int Resultado = 1;


for(int i = Numero; i >=1; i--){

Resultado = Resultado * i; 
System.out.print(i+" x ");

}
System.out.print("= "+Resultado);

}


}