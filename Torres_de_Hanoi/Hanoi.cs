using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Hanoi
    {
        /*TODO: Implementar métodos*/
        public void mover_disco(Pila a, Pila b,int movimiento, Pila ini,Pila fin, Pila aux)
        {
            if (a.Top < b.Top)
            {
                if (a.isEmpty())
                {
                    a.push(b.pop());
                }
                else
                {
                    b.push(a.pop());
                }

            }
            else
            {
                if (a.Top > b.Top)
                {
                    if (b.isEmpty())
                    {
                        b.push(a.pop());
                    }
                    else
                    {
                        a.push(b.pop());
                    }

                }
            }
            Console.WriteLine("Situacion de las pilas despues del movimiento " + movimiento);
            Console.WriteLine("Torre INI " + ini.GetElementos());
            Console.WriteLine("Torre AUX " + aux.GetElementos());
            Console.WriteLine("Torre FIN " + fin.GetElementos() + "\n");
        }

        public int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            int m = 0; // Declaramos m, será el número de movimientos utilizados.

            if (n % 2 == 0)
            { 
                // Mientras no haya solución se hace el while
                while (fin.Size != n)
                {
                    mover_disco(ini, aux,m + 1,ini,fin,aux); m++; // Movemos disco de ini a aux o de aux a ini
                    if (fin.Size == n) break;
                    mover_disco(ini, fin,m + 1,ini,fin,aux); m++; // Movemos disco de ini a fin o de fin a ini
                    if (fin.Size == n) break;
                    mover_disco(aux, fin,m + 1,ini,fin,aux); m++; // Movemos disco de aux a ini o de ini a aux
                }

            }
            else
            {
                // Mientras no haya solución se hace el while
                while (fin.Size != n)
                {
                    mover_disco(ini, fin,m + 1,ini,fin,aux); m++; // Movemos disco de ini a fin o de fin a ini
                    if (fin.Size == n) break;
                    mover_disco(ini, aux,m + 1,ini,fin,aux); m++; // Movemos disco de ini a aux o de aux a ini
                    if (fin.Size == n) break;
                    mover_disco(aux, fin,m + 1,ini,fin,aux); m++; // Movemos disco de aux a ini o de ini a aux
                }
                //Siempre en cada llamada a mover_disco se incrementa m por 1
            }
            return m;//Devolvemos los movimientos de discos realizados
        }

        int m = 0; // Declaramos m, será el número de movimientos utilizados.
        public int recursivo(int n, Pila ini, Pila fin, Pila aux)
        {
            if (n == 1)
            {
                mover_disco(ini, fin,m + 1,ini,fin,aux);
                m++;
            }
            else
            {
                recursivo(n - 1, ini, aux, fin);
                mover_disco(ini, fin,m + 1,ini,fin,aux);
                m++;
                recursivo(n - 1, aux, fin, ini);
            }
            return m;
        }
    }
}
