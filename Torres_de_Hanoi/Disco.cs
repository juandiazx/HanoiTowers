using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Disco
    {
        /*TODO: 
        Decidir tipo de Valor
        public int Valor { get; set; }
        public String Valor { get; set; }
        */
        public int Valor { get; set; } // Valor del disco

        /* 
         * Constructor del disco
         * Es obligatorio pasarle el valor que tiene el disco.
         */
        public Disco(int valor)
        {
            Valor = valor; // Guardamos el valor
        }
    }
}
