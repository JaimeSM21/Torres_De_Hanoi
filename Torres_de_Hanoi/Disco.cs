using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Disco
    {
        public int Tamano { get; private set; }

        //  构造函数：创建圆盘时指定大小, Constructor: especifique el tamaño al crear el disco
        public Disco(int tamano)
        {
            this.Tamano = tamano;
        }

        //  方便打印圆盘信息, Imprima cómodamente la información del disco
        public override string ToString()
        {
            return $"[{Tamano}]";
        }
    }
}
