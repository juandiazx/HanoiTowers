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
            Console.WriteLine("El Gran Juego de las Torres de Hanoi\n");
            Console.WriteLine("3 torres\n");

            Pila ini = new Pila();
            Pila aux = new Pila();
            Pila fin = new Pila();

            int cantidadDiscos = 0;
            char metodoEscogido = 'I';
            int movimientosHechos = 0;

            while (true)
            {
                Console.WriteLine("Indica el número de discos...");
                try
                {
                    cantidadDiscos = int.Parse(Console.ReadLine());
                    if (cantidadDiscos > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Solo puede ser un valor mayor que 0");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Has puesto un valor no aceptado");
                    continue;
                }
            }

            for (int i = 1; i <= cantidadDiscos; i++)
            {
                ini.push(new Disco(cantidadDiscos - i + 1));
            }
            Console.WriteLine("Has seleccionado " + cantidadDiscos +" discos\n");
            bool continuar = false;
            while (!continuar)
            {
                Console.WriteLine("Indica I para iterativo y R para recursivo...");
                try
                {
                    metodoEscogido = char.Parse(Console.ReadLine());
                    if (metodoEscogido == 'I' || metodoEscogido == 'R')
                    {
                        continuar = true;
                    }
                    else
                    {
                        Console.WriteLine("\nInput incorrecto, debes de introducir una I o R");
                    }
                }
                catch
                {
                    Console.WriteLine("\nInput incorrecto, debes de introducir una I o R");
                }
            }
            
            Console.WriteLine("Has seleccionado el método " + metodoEscogido+"\n");
            Hanoi hanoi = new Hanoi();

            Console.WriteLine("Situacion inicial");
            Console.WriteLine("Torre INI " + ini.GetElementos());
            Console.WriteLine("Torre AUX " + aux.GetElementos());
            Console.WriteLine("Torre FIN " + fin.GetElementos() + "\n");

            if (metodoEscogido == 'I')
            {
                movimientosHechos = hanoi.iterativo(cantidadDiscos, ini, fin, aux);
            }
            else
            {
                movimientosHechos = hanoi.recursivo(cantidadDiscos, ini, fin, aux);
            }

            Console.WriteLine("\nResuelto en " + movimientosHechos + " movimientos");

            Console.WriteLine("\nPresiona cualquier tecla para salir");
            Console.ReadKey();
        }
    }
}
