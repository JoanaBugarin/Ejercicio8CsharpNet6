using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8CsharpNet6
{
    public class Baraja
    {
        public Stack<Carta> Mazo = new Stack<Carta>();
        public Stack<Carta> CartasFuera = new Stack<Carta>();

        public Baraja()
        {
            for (int carta = 0; carta < 40; carta++)
            {
                Random rand = new Random();
                int numero = rand.Next(1, 12);
                Console.Write($"Ingrese el palo para la carta {carta + 1}: ");
                string palo = Console.ReadLine();
                Carta cartaX = new Carta(numero, palo);
                Mazo.Push(cartaX);
            }

        }

        public void Barajar()
        {
            var orden = new Random();
            Mazo.OrderBy(x => orden.Next(1, 12));
        }

       public void SiguienteCarta()
        {
            if (Mazo.Count() == 0)
            {
                Console.WriteLine("No quedan cartas");
            }
            else
            {
                Console.WriteLine(Mazo.Peek);
                CartasFuera.Push(Mazo.Pop());
            }
        }

        public void CartasDisponibles()
        {
            Console.WriteLine(Mazo.Count());
        }

        public void DarCartas(int pedido)
        {
            if (Mazo.Count() < pedido)
            {
                Console.WriteLine("No hay suficientes cartas.");
            }
            else
            {
                for (int i = 0; i < pedido; i++)
                {
                    CartasFuera.Push(Mazo.Pop());
                }
            }
        }

        public void CartasMonton()
        {
            if (CartasFuera.Count() == 0)
            {
                Console.WriteLine("No han salido cartas aún");
            }
            else
            {
                foreach (Carta carta in CartasFuera)
                {
                    Console.Write($"{carta} ");
                }
            }
        }

        public void MostrarBaraja()
        {
            foreach (Carta carta in Mazo)
            {
                Console.Write($"{carta} ");
            }
        }
    }

    
}
