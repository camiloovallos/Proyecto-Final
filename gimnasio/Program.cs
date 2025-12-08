using System;

class Program
{
    static void Main()
    {
        int opcion = 0;
        string[] usuarios = new string[15];
        int totalUsuarios = 0;

        string[] clases = { "Yoga", "Spinning", "Zumba", "Crossfit" };
        int[] cupos = { 0, 0, 0, 0 }; 
        int[,] reservas = new int[15, 2]; 

        for (int i = 0; i < 15; i++)
        {
            reservas[i, 0] = -1;
            reservas[i, 1] = -1;
        }

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
                            totalUsuarios++;
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
                else if (opcion == 2)
                {
                    if (totalUsuarios == 0)
                    {
                        Console.WriteLine("No hay usuarios registrados.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Usuarios:");
                        for (int i = 0; i < totalUsuarios; i++)
                        {
                            Console.WriteLine($"{i + 1}. {usuarios[i]}");
                        }
                        Console.Write("Elige un usuario (1-" + totalUsuarios + "): ");
                        int usuarioElegido;
                        if (int.TryParse(Console.ReadLine(), out usuarioElegido) && usuarioElegido >= 1 && usuarioElegido <= totalUsuarios)
                        {
                            Console.WriteLine("Clases:");
                            for (int c = 0; c < 4; c++)
                            {
                                Console.WriteLine($"{c + 1}. {clases[c]}");
                            }
                            Console.WriteLine("Funcion en desarrollo. Presiona Enter.");
                        }
                        else
                        {
                            Console.WriteLine("Opcion no valida.");
                        }
                        Console.ReadKey();
                    }
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