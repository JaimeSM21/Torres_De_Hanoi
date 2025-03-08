using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Disco
    {
        // Representa el tamaño o el valor del disco
        public int Valor { get; set; }

        public Disco(int valor)
        {
            Valor = valor;
        }

        public override string ToString()
        {
            return $"Disco de tamaño {Valor}";
        }
    }
}
