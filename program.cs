using System;

class Program
{
    static void Main()
    {
        int opcion = 0;

        while (opcion != 4)
        {
            Console.Clear();
            Console.WriteLine("=== Gimnasio - Sistema de Reservas ===");
            Console.WriteLine("1. Registrar usuarios");
            Console.WriteLine("2. Hacer reservas");
            Console.WriteLine("3. Ver reporte");
            Console.WriteLine("4. Salir");
            Console.Write("\nSelecciona una opcion: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                if (opcion == 4)
                {
                    Console.WriteLine("Saliendo del sistema...");
                }
            }
            else
            {
                Console.WriteLine("Opcion no valida.");
                Console.ReadKey();
            }
        }
    }
}