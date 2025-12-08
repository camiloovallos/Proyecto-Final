/*
Se desea crear un sistema de gestión para un supermercado "SuperMerc", 
una cadena de supermercados con múltiples sucursales. La empresa necesita un sistema que le permita:
• Registrar las ventas de cada producto en cada sucursal
• Calcular las ventas totales por producto (sumando todas las sucursales)
• Identificar qué producto es el más vendido en toda la tienda
Este sistema ayudará a la gerencia a tomar decisiones sobre inventario, promociones y estrategias de ventas.
*/

using System;

namespace superMerc
{
    class Program
    {
        static void Main()
        {
            int numSucursales = 0;
            string[] sucursales = new string[numSucursales];
            int numProductos = 0;
            string[] productos = new string[numProductos];
            double[,] ventas = new double[numSucursales, numProductos];
            int opciones = 0;

            while (opciones != 5)
            {
                Console.Clear();
                Console.WriteLine("1. Configurar sucursales");
                Console.WriteLine("2. Configurar productos");
                Console.WriteLine("3. Ingresar ventas");
                Console.WriteLine("4. Ver información");
                Console.WriteLine("5. Salir del sistema");
                Console.Write("Ingrese la opción: ");

                while (!int.TryParse(Console.ReadLine(), out opciones) || opciones < 1 || opciones > 5)
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.Write("Error, dato inválido. Digite la opción de nuevo: ");
                    Console.ResetColor();
                }

                switch (opciones)
                {
                    case 1:
                        sucursales = configuracionSucursales(sucursales, numSucursales);
                        Console.Write("Presione enter para continuar...");
                        Console.ReadKey();
                        break;
                    case 2:
                        productos = configuracionproductos(productos, numProductos);
                        Console.Write("Presione enter para continuar...");
                        Console.ReadKey();
                        break;
                    case 3:
                        // Pendiente: ingresar ventas
                        Console.WriteLine("Función no implementada aún.");
                        Console.Write("Presione enter para continuar...");
                        Console.ReadKey();
                        break;
                    case 4:
                        // Pendiente: mostrar información
                        Console.WriteLine("Función no implementada aún.");
                        Console.Write("Presione enter para continuar...");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine("Saliendo del sistema...");
                        break;
                }
            }
        }

        static string[] configuracionSucursales(string[] sucursales, int numSucursales)
        {
            Console.Write("Ingrese el número de sucursales: ");
            while (!int.TryParse(Console.ReadLine(), out numSucursales) || numSucursales < 1)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write("Error, dato inválido. Digite el número de nuevo: ");
                Console.ResetColor();
            }

            Console.WriteLine();
            sucursales = new string[numSucursales];
            for (int i = 0; i < sucursales.Length; i++)
            {
                Console.Write($"Ingrese el nombre de la sucursal {i + 1}: ");
                sucursales[i] = Console.ReadLine()!;
            }

            Console.WriteLine("\nSucursales registradas:");
            foreach (string sucursal in sucursales)
            {
                Console.Write($"\t{sucursal}");
            }
            Console.WriteLine();
            return sucursales;
        }

        static string[] configuracionproductos(string[] productos, int numProductos)
        {
            Console.Write("Ingrese el número de productos: ");
            while (!int.TryParse(Console.ReadLine(), out numProductos) || numProductos < 1)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.Write("Error, dato inválido. Digite el número de nuevo: ");
                Console.ResetColor();
            }

            Console.WriteLine();
            productos = new string[numProductos];
            for (int i = 0; i < productos.Length; i++)
            {
                Console.Write($"Ingrese el nombre del producto {i + 1}: ");
                productos[i] = Console.ReadLine()!;
            }

            Console.WriteLine("\nProductos registrados:");
            foreach (string producto in productos)
            {
                Console.Write($"\t{producto}");
            }
            Console.WriteLine();
            return productos;
        }
    }
}