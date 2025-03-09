using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el número de discos: ");
            int n = int.Parse(Console.ReadLine());

            //  初始化三个柱子, Inicializa tres pilas
            Pila ini = new Pila("INI");
            Pila aux = new Pila("AUX");
            Pila fin = new Pila("FIN");

            //  添加 n 个盘子到 INI, Agrega n discos a INI
            for (int i = n; i > 0; i--)
            {
                ini.Push(new Disco(i));
            }

            Hanoi hanoi = new Hanoi();

            Console.WriteLine("\n Resolviendo con método iterativo...");
            int movimientosIterativo = hanoi.iterativo(n, ini, fin, aux);
            Console.WriteLine($" Total de movimientos (Iterativo): {movimientosIterativo}\n");

            //  重新初始化柱子, Reinicializa la columna
            ini = new Pila("INI");
            aux = new Pila("AUX");
            fin = new Pila("FIN");

            for (int i = n; i > 0; i--)
            {
                ini.Push(new Disco(i));
            }

            Console.WriteLine("\n Resolviendo con método recursivo...");
            int movimientosRecursivo = hanoi.recursivo(n, ini, fin, aux);
            Console.WriteLine($"Total de movimientos (Recursivo): {movimientosRecursivo}\n");

            Console.WriteLine("\n Resolución completa. Presiona cualquier tecla para salir.");
            Console.ReadKey();
        }
    }
}
