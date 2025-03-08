using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        // Propiedad que representa la cantidad de discos en el palo
        public int Size
        {
            get { return Elementos.Count; }
        }

        // Propiedad que representa el disco que está en la parte superior del palo.
        // Si la pila está vacía, devuelve null.
        public Disco Top
        {
            get
            {
                if (isEmpty())
                    return null;
                return Elementos[Elementos.Count - 1];
            }
        }

        // Lista que almacena los discos presentes en el palo.
        public List<Disco> Elementos { get; set; }

        // Constructor: inicializa la lista de discos.
        public Pila()
        {
            Elementos = new List<Disco>();
        }

        // Método que permite colocar un disco en la pila.
        public void push(Disco d)
        {
            // Aquí se podría agregar lógica para validar el movimiento en el juego,
            // por ejemplo, que el disco que se coloca sea menor que el disco actual en Top.
            Elementos.Add(d);
        }

        // Método que extrae el disco que se encuentra en la parte superior de la pila.
        // Devuelve el disco extraído o null si la pila está vacía.
        public Disco pop()
        {
            if (isEmpty())
                return null;

            // Se obtiene el último disco y se elimina de la lista.
            Disco discoExtraido = Elementos[Elementos.Count - 1];
            Elementos.RemoveAt(Elementos.Count - 1);
            return discoExtraido;
        }

        // Método que verifica si la pila está vacía.
        public bool isEmpty()
        {
            return Elementos.Count == 0;
        }
    }
}
