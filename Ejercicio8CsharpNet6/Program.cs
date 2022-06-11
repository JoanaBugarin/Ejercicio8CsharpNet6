using Ejercicio8CsharpNet6;

Baraja barajaX = new Baraja();
int eleccion;
do
{
    Console.WriteLine();
    Console.WriteLine("Ingrese el numero según la operación que desee realizar");
    Console.WriteLine();
    Console.WriteLine("1 - Barajar");
    Console.WriteLine("2 - Mostrar siguiente carta");
    Console.WriteLine("3 - Mostrar cartas disponibles");
    Console.WriteLine("4 - Dar cartas");
    Console.WriteLine("5 - Mostrar cartas del monton");
    Console.WriteLine("6 - Mostrar baraja");
    Console.WriteLine("7 - Salir");
    eleccion = int.Parse(Console.ReadLine());
    switch (eleccion)
    {
        case 1:
            barajaX.Barajar();
            break;
        case 2:
            barajaX.SiguienteCarta();
            break;
        case 3:
            barajaX.CartasDisponibles();
            break;
        case 4:
            Console.Write("Ingrese la cantidad de cartas deseadas: ");
            int numero = int.Parse(Console.ReadLine());
            barajaX.DarCartas(numero);
            break;
        case 5:
            barajaX.CartasMonton();
            break;
        case 6:
            barajaX.MostrarBaraja();
            break;
        case 7:
            Console.WriteLine("¡Hasta pronto!");
            break;
        default:
            Console.WriteLine("Ingresó un número incorrecto");
            break;
    }
} while (eleccion != 7);
