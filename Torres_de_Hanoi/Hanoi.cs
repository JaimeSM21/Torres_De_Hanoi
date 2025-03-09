using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        //  移动单个圆盘, Mover un solo disco
        public void mover_disco(Pila a, Pila b)
        {
            if (a.IsEmpty())
            {
                Console.WriteLine($"{a.Nombre} está vacía, no se puede mover un disco.");
                return;
            }

            Disco disco = a.Pop();

            if (!b.IsEmpty() && b.Top().Tamano < disco.Tamano)
            {
                Console.WriteLine($"No se puede mover el disco {disco.Tamano} a {b.Nombre}, porque el disco superior es más pequeño.");
                a.Push(disco); // 放回原处, lo pone de nuevo
                return;
            }

            // 执行移动, ejecutar movimiento
            b.Push(disco);
            Console.WriteLine($"Moviendo disco {disco.Tamano} desde {a.Nombre} → {b.Nombre}");
        }

        //  迭代（非递归）解决汉诺塔, Solución iterativa para la Torre de Hanoi
        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int movimientos = 0;
            Pila[] pilas = { ini, fin, aux };

            if (n % 2 == 0)
            {
                Pila temp = fin;
                fin = aux;
                aux = temp;
            }

            int totalMovimientos = (int)Math.Pow(2, n) - 1;
            for (int i = 1; i <= totalMovimientos; i++)
            {
                int desde = (i & i - 1) % 3;
                int hacia = ((i | i - 1) + 1) % 3;
                mover_disco(pilas[desde], pilas[hacia]);
                movimientos++;
            }

            Console.WriteLine($"Solución completada en {movimientos} movimientos.");
            return movimientos;
        }

        //  递归（Recursivo）解决汉诺塔, Resuelve la Torre de forma recursiva
        public int recursivo(int n, Pila ini, Pila fin, Pila aux)
        {
            if (n == 1)
            {
                mover_disco(ini, fin);
                return 1;
            }

            int movimientos = 0;
            movimientos += recursivo(n - 1, ini, aux, fin);  // 先移动 n-1 到 AUX, Primero mueve n-1 a AUX 
            mover_disco(ini, fin);                           // 移动最大盘子到 FIN, Mueve el disco más grande a FIN
            movimientos++;
            movimientos += recursivo(n - 1, aux, fin, ini);  // 递归移动 n-1 盘子到 FIN, Mueve recursivamente n-1 discos a FIN

            return movimientos;
        }
    }
}
