// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Punto 1 //
/*
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
*/
//Punto 4//

Console.WriteLine("Ingrese texto");
string cadena = Console.ReadLine();

int longitud = cadena.Length;

Console.WriteLine("La longitud de la cadena es:"+ cadena.Length);

//Console.Write("Ingrese otro texto");
//string cadena2 = Console.ReadLine();

//Console.Write($"Lo ingresado fue: {cadena} {cadena2}");

//Console.Write(cadena.Substring(0,2));

foreach (var caracteres in cadena)
{
    Console.Write($"{caracteres}\n"); 
}

int ocurrencia = cadena.IndexOf('s');
Console.Write(ocurrencia);

/*
for (int i = 0; i < cadena.Length; i++)
{
    if(System.Char.IsLower(cadena[i]) == true)
    {
        cadena[i] = System.Char.ToUpper(cadena[i]); // ???
    }
}
*/


