import java.util.Scanner;

class MayorDeNumeroIngresados{


public static void main(String[] arg){

Scanner myObj = new Scanner(System.in);

int NumeroMayor = 0;

for(int i = 0; i <= 4; i++){

int Numero = myObj.nextInt();
int Valor = Numero;
if(Valor > Valor){

NumeroMayor = Valor;
}

}
System.out.print("El mayor de todos es "+NumeroMayor);

}
}