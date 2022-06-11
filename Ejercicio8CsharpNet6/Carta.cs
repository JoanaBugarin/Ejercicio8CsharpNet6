using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8CsharpNet6
{
    public class Carta
    {
        private int _numero;
        private string _palo = "";

        public int Numero
        {
            get { return _numero; }
            set
            { 
                if (value < 1 || value > 12 || value == 8 || value == 9)
                {
                _numero = 1;
                }
                else
                {
                _numero = value;
                }
            }
        }
        public string Palo
        {
            get { return _palo; }
            set
            {
                if (value == null || value.ToLower() != "espadas" && value.ToLower() != "bastos"
                    && value.ToLower() != "oros" && value.ToLower() != "copas")
                {
                    _palo = "copas";
                }
                else
                {
                    _palo = value;
                }
            }
        }

        public Carta(int numero, string palo)
        {
            Numero = numero;
            Palo = palo;
            
        }
    }
}
