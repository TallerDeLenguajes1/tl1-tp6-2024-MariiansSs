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




