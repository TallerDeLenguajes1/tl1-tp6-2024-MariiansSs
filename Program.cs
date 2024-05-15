// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Punto 2 //

int bandera = 1,opcion, numero1, numero2, resultado;

do{
    Console.Write("1:Sumar dos numeros");
    Console.Write("2:Restar dos numeros");
    Console.Write("3:Multiplicar dos numeros");
    Console.Write("4:Dividir dos numeros");
    string opcionS = Console.ReadLine();
    if(int.TryParse(opcionS, out opcion))
    {
        Console.Write("Ingrese el numero 1");
        string num1 = Console.ReadLine();        
        Console.Write("Ingrese el numero 2");
        string num2 = Console.ReadLine();

        if(int.TryParse(num1, out numero1) && int.TryParse(num2, out numero2))
        {
            switch(opcion)
            {
                case 1:
                    resultado = numero1 + numero2;
                    Console.WriteLine("El resultado de la suma es: " + resultado);
                break;
                case 2:
                    resultado = numero1 - numero2;
                    Console.WriteLine("El resultado de la resta es: " + resultado);
                break;
                case 3:
                    resultado = numero1 * numero2;
                    Console.WriteLine("El resultado de la multiplicacion es: " + resultado);
                break;
                case 4:
                    resultado = numero1/numero2;
                    Console.WriteLine("El resultado de la division es: " + resultado);
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



