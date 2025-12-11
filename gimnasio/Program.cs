using System;

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
            MostrarTitulo(); 

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
                        int opcionUsuario;
                        if (int.TryParse(Console.ReadLine(), out opcionUsuario) && opcionUsuario >= 1 && opcionUsuario <= totalUsuarios)
                        {
                            int indiceUsuario = opcionUsuario - 1;

                            Console.WriteLine("Clases:");
                            for (int i = 0; i < 4; i++)
                            {
                                Console.WriteLine($"{i + 1}. {clases[i]} ({cupos[i]}/10)");
                            }
                            Console.Write("Elige una clase (1-4): ");
                            int opcionClase;
                            if (int.TryParse(Console.ReadLine(), out opcionClase) && opcionClase >= 1 && opcionClase <= 4)
                            {
                                int indiceClase = opcionClase - 1;

                                if (cupos[indiceClase] < 10)
                                {
                                    for (int r = 0; r < 2; r++)
                                    {
                                        if (reservas[indiceUsuario, r] == -1)
                                        {
                                            reservas[indiceUsuario, r] = indiceClase;
                                            cupos[indiceClase]++;
                                            Console.WriteLine("Reserva realizada.");
                                            break;
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Clase llena.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Opcion de clase no valida.");
                            }
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Opcion de usuario no valida.");
                            Console.ReadKey();
                        }
                    }
                }
                else if (opcion == 3)
                {
                    Console.WriteLine("=== Reporte de Reservas ===");

                    for (int i = 0; i < totalUsuarios; i++)
                    {
                        Console.Write($"{usuarios[i]}: ");
                        bool tieneReserva = false;
                        for (int r = 0; r < 2; r++)
                        {
                            if (reservas[i, r] != -1)
                            {
                                Console.Write($"{clases[reservas[i, r]]} ");
                                tieneReserva = true;
                            }
                        }
                        if (!tieneReserva)
                        {
                            Console.Write("Sin reservas");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("\nCupos por clase:");
                    for (int i = 0; i < 4; i++)
                    {
                        Console.WriteLine($"{clases[i]}: {cupos[i]}/10");
                    }

                    int maxPersonas = cupos[0];
                    int indiceMasPopular = 0;
                    for (int i = 1; i < 4; i++)
                    {
                        if (cupos[i] > maxPersonas)
                        {
                            maxPersonas = cupos[i];
                            indiceMasPopular = i;
                        }
                    }
                    Console.WriteLine($"\nClase mas popular: {clases[indiceMasPopular]} ({maxPersonas} personas)");

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

    static void MostrarTitulo()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("┌────────────────────────────────┐");
        Console.WriteLine("│ GIMNASIO - SISTEMA DE RESERVAS │");
        Console.WriteLine("└────────────────────────────────┘");
        Console.ResetColor();
        Console.WriteLine();
    }
}