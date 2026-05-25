using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ejercicio_2
    {
        public static int acum = 0;
        public static int cont = 0;
        public static void IngresarNumero(int num)
        {
            acum = acum + num;
            cont++;
        }
        public static double CalcularPromedio()
        {
            double Promedio = 0;
            if (cont > 0)
            {
                Promedio = 1.0 * acum / cont;

            }
            return Promedio;
        }
        public static int MostrarPantallaSolicitarOpcionMenu()
        {
            Console.Clear();
            Console.WriteLine("Titulo 1");
            Console.WriteLine("1 - Ingrese nro");
            Console.WriteLine("2 - Calcular y Mostrar Promedio");
            Console.WriteLine("Otro - Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
        public static void MostrarPantallaIngresarNumero()
        {
            Console.Clear();
            Console.WriteLine("Ingrese el nro");
            int num = Convert.ToInt32(Console.ReadLine());
            Ejercicio_2.IngresarNumero(num);
        }
        public static void MostrarPantallaCalcularYMostrarPromedio()
        {
            Console.Clear();
            Console.WriteLine("Titulo Pantalla 2");
            double promedio = Ejercicio_2.CalcularPromedio();
            Console.WriteLine($"Promedio: {promedio}");
            Console.WriteLine("Presione un tecla");
            Console.ReadKey();
        }
    }
}
    
    

