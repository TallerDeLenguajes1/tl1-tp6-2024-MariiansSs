// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// Punto 1 //
int a;
int invertir = 0;


Console.WriteLine("Ingrese un numero");
string texto = Console.ReadLine();

if(int.TryParse(texto, out a))
{
   if(a > 0)
   {
    while(a != 0)
    {
        invertir = invertir * 10 + a % 10;
        a = a / 10;
    }
   }
}
 Console.WriteLine(invertir);

// Punto 2 //

Console.WriteLine("1:Sumar dos numeros");
Console.WriteLine("2:Restar dos numeros");
Console.WriteLine("3:Multiplicar dos numeros");
Console.WriteLine("4:Dividir dos numeros");
string texto2 = Console.ReadLine();
int opcion, numero1, numero2, resultado;

if(int.TryParse(texto2, out opcion))
{
    switch(opcion)
    {
        case 1:
        Console.WriteLine("Ingrese el numero 1");
        string num1 = Console.ReadLine();
        Console.WriteLine("Ingrese el numero 2");
        string num2 = Console.ReadLine();
        if(int.TryParse(num1, out numero1) && int.TryParse(num2, out numero2))
        {
            resultado = numero1 + numero2;
            Console.WriteLine("El resultado de la suma es: " + resultado);
        }
        break;

    }
}


