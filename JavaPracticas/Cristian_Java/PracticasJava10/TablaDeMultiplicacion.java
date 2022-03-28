import java.util.Scanner;


class TablaDeMultiplicacion{

public static void main(String[] arg){

Scanner Obj = new Scanner(System.in);
int Numero = Obj.nextInt();
int Resultado = 1;

for(int i = 1; i<=Numero; i++){
	for(int m=1; m<=12; m++){

Resultado = i +" x "+ m + "=" + (i * m);
System.out.print(Resultado);

}	
}
}
}