// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

int numero;
int digito;
int soma = 0;

Console.Write("Informe o número: ");
numero = Convert.ToInt32(Console.ReadLine());

while(numero > 0){
   //Ex:1234
   digito = numero % 10;//Vai trazer o ultimo numero digitado ex: 4
   soma = soma + digito;
   numero = numero / 10;//Vai trazer o restante do numero digitado ex: 123
}
Console.WriteLine("Soma = " + soma);
Console.ReadLine();
