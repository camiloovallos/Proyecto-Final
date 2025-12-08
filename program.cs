using System;

class Program
{
    static void Main()
    {
        int opcion = 0;
        string[] usuarios = new string[15];
        int totalUsuarios = 0;

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
                if (opcion == 1)
                {
                    if (totalUsuarios < 15)
                    {
                        Console.Write("Ingresa el nombre del usuario: ");
                        string nombre = Console.ReadLine();
                        if (nombre != "")
                        {
                            usuarios[totalUsuarios] = nombre;
                            totalUsuarios = totalUsuarios + 1;
                            Console.WriteLine("Usuario registrado.");
                        }
                        else
                        {
                            Console.WriteLine("Nombre no valido.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Maximo de usuarios alcanzado (15).");
                    }
                    Console.ReadKey();
                }
                else if (opcion == 4)
                {
                    Console.WriteLine("Saliendo del sistema...");
                }
                else
                {
                    Console.WriteLine("Opcion no implementada aun.");
                    Console.ReadKey();
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