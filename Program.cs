// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Punto 2 //

int bandera = 1,opcion; 
double numero1 , resultado;

do{
    Console.Write("1:Mostrar Valor Absoluto de un numero\n");
    Console.Write("2:Mostrar el cuadrado de un numero\n");
    Console.Write("3:Mostrar la raiz cuadrada de un numero\n");
    Console.Write("4:Mostrar el seno de un numero\n");
    Console.Write("5:Mostrar el coseno de un numero\n");
    Console.Write("6:Mostrar la parte entera de un numero tipo float\n");
    string opcionS = Console.ReadLine();
    if(int.TryParse(opcionS, out opcion))
    {
        Console.Write("Ingrese un numero");
        string num1 = Console.ReadLine();        

        if(double.TryParse(num1, out numero1))
        {
            switch(opcion)
            {
                case 1:
                    resultado = Math.Abs(numero1);
                    Console.WriteLine("El valor absoluto del numero es: " + resultado);
                break;
                case 2:
                    resultado = Math.Pow(numero1,2);
                    Console.WriteLine("El cuadrado del numero es: " + resultado);
                break;
                case 3:
                    resultado = Math.Sqrt(numero1);
                    Console.WriteLine("La raiz cuadrada del numero es: " + resultado);
                break;
                case 4:
                    resultado = Math.Sin(numero1);
                    Console.WriteLine("El seno del numero es: " + resultado);
                break;
                case 5:
                    resultado = Math.Cos(numero1);
                    Console.WriteLine("El coseno del numero es: " + resultado);
                break;
                case 6:
                    resultado = Math.Floor(numero1);
                    Console.WriteLine("La parte entera del numero es: " + resultado);
                break;
            }
        }
    }
    Console.Write("Desea realizar otra operacion? (0=no, 1=si)");
    string banderaO = Console.ReadLine();
    if(int.TryParse(banderaO, out bandera))
    {
        if(bandera != 0 && bandera != 1)
        {
            Console.Write("Porfavor ingrese una opcion valida");
            bandera = 1;
        }
    }
}
while(bandera != 0);



