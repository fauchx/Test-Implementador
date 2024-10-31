using System;
using System.Collections.Generic;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                bool bucle = true;
                string resp;
                while (bucle)
                {
                    string option = Gestion.selectOption();
                    switch (option)
                    {
                        case "1":
                            Gestion.agregarCarro();
                            break;
                        case "2":
                            Gestion.consultarCarros();
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Por favor, seleccione una opción válida.");
                            break;
                    }

                    Console.WriteLine("¿Desea realizar otra consulta? (Si / No)");
                    resp = Console.ReadLine()?.ToLower();
                    if (!resp.Equals("si", StringComparison.OrdinalIgnoreCase))
                        bucle = false;
                }
            }
            catch (Exception exc)
            {
                Console.WriteLine($"Error: {exc.Message}");
            }
        }
    }

}