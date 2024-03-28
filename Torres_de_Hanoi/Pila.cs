using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size { get; set; }
        /* TODO: Elegir tipo de Top
        public int Top { get; set; }
        public String Top { get; set; }        
        */
        /* TODO: Elegir tipo de Elementos
        public Disco[] Elementos { get; set; }
        public List<Disco> Elementos { get; set; }
        */

        /* TODO: Implementar métodos */
        public int Top { get; set; } // Valor del elemento más alto de la lista

        public List<Disco> Elementos = new List<Disco>(); // Lista de los discos que tiene la pila


        // Constructor de la clase Pila
        public Pila()
        {

        }

        // Coloca disco en la pila
        public void push(Disco d)
        {
            Elementos.Add(d);
            Size++;
            Top = d.Valor;
        }

        // Extrae el disco de arriba de la pila
        public Disco pop()
        {
            Disco eliminado = Elementos[Size - 1];
            Elementos.Remove(Elementos[Size - 1]);
            Size--; // Restamos uno al tamaño de la lista
            if (Size == 0)
            {
                // Si está vacía, Top valdrá 0
                Top = 0;
            }
            else
            {
                // Actualizamos Top
                Top = Elementos[Size - 1].Valor;
            }
            return eliminado;
        }


        // Indica si la pila está vacía o no
        public bool isEmpty()
        {
            if (Size == 0)
            {
                return true;
            }
            return false;
        }

        public string GetElementos()
        {
            return string.Join(", ", Elementos.Select(d => d.Valor));
        }
    }
}
