using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2G3
{
    class Program
    {
        static void Main(string[] args)
        {
            cola micola = new cola();
            cola caja1 = new cola();
            caja1.encolar(1);
            caja1.encolar(1);
            caja1.encolar(1);
            cola caja2 = new cola();
            caja2.encolar(2);
            caja2.encolar(2);
            cola caja3 = new cola();
            caja3.encolar(3);
            cola caja4 = new cola();
            caja4.encolar(4);
            caja4.encolar(4);


            int opcingreso, opccajero, op3, op1;
            do
            {


                Console.WriteLine("     --------------------------      ");
                Console.WriteLine("              BANCO                  ");
                Console.WriteLine("     --------------------------      ");

                Console.WriteLine("¿Desea ingresar al banco?");
                Console.WriteLine(" 1-Sí              2-No  ");
                opcingreso = Convert.ToInt32(Console.ReadLine());
                if (opcingreso == 1 || opcingreso == 2)
                {
                    if (opcingreso == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Bienvenido, actualmente está en zona de espera, \n Le mostramos nuestra concurrencia actual:");
                        Console.WriteLine("\n");
                        Console.Clear();
                        Console.WriteLine("Contamos con cuatro cajeros ");
                        Console.WriteLine("Cajero 1: ");
                        Console.WriteLine("DISPONIBLE");
                        Console.Write("Cola de espera: ");
                        caja1.mostrar();
                        Console.WriteLine("Cajero 2: ");
                        Console.WriteLine("DISPONIBLE");
                        Console.Write("Cola de espera: ");
                        caja2.mostrar();
                        Console.WriteLine("Cajero 3: ");
                        Console.WriteLine("DISPONIBLE");
                        Console.Write("Cola de espera: ");
                        caja3.mostrar();
                        Console.WriteLine("Cajero 4: ");
                        Console.WriteLine("DISPONIBLE");
                        Console.Write("Cola de espera: ");
                        caja4.mostrar();
                        Console.Write("\n");
                        Console.WriteLine("¿Desea hacer cola en un cajero? o ¿Retirar trámites?");
                        Console.WriteLine("     1-Hacer cola         2-Retirar trámites        ");
                        op1 = Convert.ToInt32(Console.ReadLine());
                        if (op1 == 1)
                        {


                            Console.WriteLine("¿En cuál cajero desea hacer cola?");
                            opccajero = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (opccajero)
                            {
                                case 1:
                                    {
                                        caja1.encolar(1);
                                        Console.WriteLine("Se ha añadido a la cola 1, espere su turno");
                                        Console.WriteLine("Cola actual del cajero 1");
                                        caja1.mostrar();

                                        Console.WriteLine("¿Ha finalizado sus trámites?");
                                        Console.WriteLine(" 1-Sí              2-No  ");
                                        op3 = Convert.ToInt32(Console.ReadLine());

                                        if (op3 == 1)
                                        {
                                            Console.WriteLine("Será removido de la cola, muchas gracias por su preferencia");
                                            caja1.desencolar();
                                            Console.Clear();
                                            Console.WriteLine("Cola actual del cajero 1");
                                            caja1.mostrar();
                                        }

                                        if (op3 == 2)
                                        {
                                            Console.WriteLine("Espere su turno");
                                            Console.Clear();
                                            Console.WriteLine("Cola actual del cajero 1");
                                            caja1.mostrar();
                                        }


                                        break;
                                    }
                                case 2:
                                    {
                                        caja2.encolar(2);
                                        Console.WriteLine("Se ha añadido a la cola 2, espere su turno");
                                        Console.WriteLine("Cola actual del cajero 2");
                                        caja2.mostrar();
                                        Console.WriteLine("¿Ha finalizado sus trámites?");
                                        Console.WriteLine(" 1-Sí              2-No  ");
                                        op3 = Convert.ToInt32(Console.ReadLine());
                                        if (op3 == 1)
                                        {
                                            Console.WriteLine("Será removido de la cola, muchas gracias por su preferencia");
                                            caja2.desencolar();
                                            Console.Clear();
                                            Console.WriteLine("Cola actual del cajero 2");
                                            caja2.mostrar();
                                        }
                                        if (op3 == 2)
                                        {
                                            Console.WriteLine("Espere su turno");
                                            Console.Clear();
                                            Console.WriteLine("Cola actual del cajero 2");
                                            caja2.mostrar();
                                        }
                                        break;
                                    }
                                case 3:
                                    {
                                        caja3.encolar(3);
                                        Console.WriteLine("Se ha añadido a la cola 3, espere su turno");
                                        Console.WriteLine("Cola actual del cajero 3");
                                        caja3.mostrar();
                                        Console.WriteLine("¿Ha finalizado sus trámites?");
                                        Console.WriteLine(" 1-Sí              2-No  ");
                                        op3 = Convert.ToInt32(Console.ReadLine());
                                        if (op3 == 1)
                                        {
                                            Console.WriteLine("Será removido de la cola, muchas gracias por su preferencia");
                                            caja3.desencolar();
                                            Console.Clear();
                                            Console.WriteLine("Cola actual del cajero 3");
                                            caja3.mostrar();
                                        }
                                        if (op3 == 2)
                                        {
                                            Console.WriteLine("Espere su turno");
                                            Console.Clear();
                                            Console.WriteLine("Cola actual del cajero 3");
                                            caja3.mostrar();
                                        }
                                        break;
                                    }
                                case 4:
                                    {
                                        caja4.encolar(4);
                                        Console.WriteLine("Se ha añadido a la cola 4, espere su turno");
                                        Console.WriteLine("Cola actual del cajero 4");
                                        caja4.mostrar();
                                        Console.WriteLine("¿Ha finalizado sus trámites?");
                                        Console.WriteLine(" 1-Sí              2-No  ");
                                        op3 = Convert.ToInt32(Console.ReadLine());
                                        if (op3 == 1)
                                        {
                                            Console.WriteLine("Será removido de la cola, muchas gracias por su preferencia");
                                            caja4.desencolar();
                                            Console.Clear();
                                            Console.WriteLine("Cola actual del cajero 4");
                                            caja4.mostrar();
                                        }
                                        if (op3 == 2)
                                        {
                                            Console.WriteLine("Espere su turno");
                                            Console.Clear();
                                            Console.WriteLine("Cola actual del cajero 4");
                                            caja4.mostrar();
                                        }
                                        break;
                                    }
                                default:
                                    {
                                        break;
                                    }
                            }//sw
                            
                        }
                        if (op1 == 2)
                        {
                            //retiro
                            Console.WriteLine("¿en qué cajero desea retirar sus trámites?");
                            opccajero = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();
                            switch (opccajero)
                            {
                                case 1:
                                    {
                                        Console.WriteLine("Será removido de la cola, muchas gracias por su preferencia");
                                        caja1.desencolar();
                                        Console.Clear();
                                        Console.WriteLine("Cola actual del cajero 1");
                                        caja1.mostrar();
                                        break;
                                    }
                                case 2:
                                    {
                                        Console.WriteLine("Será removido de la cola, muchas gracias por su preferencia");
                                        caja2.desencolar();
                                        Console.Clear();
                                        Console.WriteLine("Cola actual del cajero 2");
                                        caja2.mostrar();
                                        break;
                                    }
                                case 3:
                                    {
                                        Console.WriteLine("Será removido de la cola, muchas gracias por su preferencia");
                                        caja3.desencolar();
                                        Console.Clear();
                                        Console.WriteLine("Cola actual del cajero 3");
                                        caja3.mostrar();
                                        break;
                                    }
                                case 4:
                                    {
                                        Console.WriteLine("Será removido de la cola, muchas gracias por su preferencia");
                                        caja4.desencolar();
                                        Console.Clear();
                                        Console.WriteLine("Cola actual del cajero 4");
                                        caja4.mostrar();
                                        break;
                                    }
                            }//sw
                        }

                    }
                    
                    if (opcingreso == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("ha sido un placer, esperamos tenerle acá pronto");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Las opciones digitadas no existen");
                    Console.ReadKey();
                }
                Console.ReadKey();

            } while (opcingreso != 2);
        }
    }
}
