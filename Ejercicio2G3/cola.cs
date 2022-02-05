using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2G3
{
    class cola
    {
        public nodo primero;
        public nodo ultimo;

        public cola()
        {
            primero = ultimo = null;
        }
        public void encolar(int valor)
        {
            nodo aux = new nodo();
            aux.info = valor;
            if (primero == null)
            {
                primero = ultimo = aux;
                aux.sgte = null;
            }
            else
            {
                ultimo.sgte = aux;
                aux.sgte = null;
                ultimo = aux;
            }
        }

        public void desencolar()
        {
            if (primero == null)
            {
                Console.WriteLine("La cola está vacía");
            }
            else
            {
                primero = primero.sgte;
            }
        }

        public void mostrar()
        {
            if (primero == null)
            {
                Console.WriteLine("Cola vacía");
            }
            else
            {
                nodo puntero;
                puntero = primero;
                do
                {
                    Console.Write("{0}\t", puntero.info);
                    puntero = puntero.sgte;
                } while (puntero != null);
               
            }
            Console.WriteLine("\n");
        }
    }
}
