using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    namespace Ejercicio_1
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                #region Inicializar variables
                int opcion; int acum = 0; int cont = 0;
                #endregion

                #region Iterar opciones
                do
                {
                    Console.Clear();
                    Console.WriteLine("Titulo 1");
                    Console.WriteLine("1 _ Ingresar Nro");
                    Console.WriteLine("2 _ Calcular y mostrar promedio");
                    Console.WriteLine("Otro - Salir");
                    opcion = Convert.ToInt32(Console.ReadLine());
#endregion

                    #region Verificar opciones y ejecutar
                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("Ingresar el nro");
                            int num = Convert.ToInt32(Console.ReadLine());
                            acum += num;
                            cont++;
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("Titulo pantalla 2");
                            double promedio = 0;
                            if (cont > 0)
                            {
                                promedio = acum / cont;
                                Console.WriteLine($"Promedio: {promedio:F2}");
                            }
                            else
                            {
                                Console.WriteLine("No hubo ingresos");
                            }
                            Console.WriteLine("Presione una tecla para volver");
                            Console.ReadKey();
                            break;
                        default:
                            opcion = -1;
                            break;
                    }
                    #endregion
                    #region Salir o continuar
                } while (opcion != -1);
                Console.WriteLine("Presionar una tecla para finalizar");
                Console.ReadKey();
                #endregion
            }
        }
    }
}
