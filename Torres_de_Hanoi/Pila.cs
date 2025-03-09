using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        private Stack<Disco> elementos;
        public string Nombre { get; private set; }

        // 构造函数，初始化柱子, Constructor, inicializa la Pila.
        public Pila(string nombre)
        {
            this.Nombre = nombre;
            this.elementos = new Stack<Disco>();
        }

        //  压入（放入）圆盘, Presionar (poner) en el disco
        public void Push(Disco d)
        {
            if (elementos.Count > 0 && elementos.Peek().Tamano < d.Tamano)
            {
                throw new InvalidOperationException($"No se puede colocar el disco {d.Tamano} en {Nombre}, porque el disco superior es más pequeño.");
            }
            elementos.Push(d);
        }

        //  弹出（取出）圆盘, Expulsar (quitar) el disco
        public Disco Pop()
        {
            if (IsEmpty()) throw new InvalidOperationException($"No se puede quitar de {Nombre}, está vacía.");
            return elementos.Pop();
        }

        //  获取顶部圆盘, Consigue el disco superior
        public Disco Top()
        {
            return elementos.Count > 0 ? elementos.Peek() : null;
        }

        //  检查柱子是否为空, Comprueba si la columna está vacía
        public bool IsEmpty()
        {
            return elementos.Count == 0;
        }
    }
}
