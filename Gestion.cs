using System;
using System.Collections.Generic;

namespace Test
{
    class Gestion
    {
        public static List<Carro> carros = new List<Carro>();


        public static string selectOption()
        {
            Console.WriteLine("Seleciona una opcion");
            Console.WriteLine("1. Regitrar un carro");
            Console.WriteLine("2. Consultar carros");

            string option = Console.ReadLine();

            while (option != "1" && option != "2")
            {
                Console.WriteLine("Seleccione una opcion valida");
                option = Console.ReadLine();
            }

            return option;
        }

        public static void agregarCarro()
        {
            Console.WriteLine("Ingrese la cantidad de carros a registrar:");
            string count = Console.ReadLine();

            int numCars;
            while (!int.TryParse(count, out numCars))
            {
                Console.WriteLine("Ingrese un número válido.");
                count = Console.ReadLine();
            }

            for (int x = 1; x <= numCars; x++)
            {
                Carro carro = new Carro();
                Console.WriteLine($"Registro de carro número # {x}");
                Console.WriteLine("Introduzca un id:");
                carro.id = Console.ReadLine();
                Console.WriteLine("Introduzca una marca:");
                carro.marca = Console.ReadLine();
                Console.WriteLine("Introduzca un modelo:");
                carro.modelo = Console.ReadLine();
                Console.WriteLine("Introduzca un kilometraje:");
                carro.km = Console.ReadLine();

                carros.Add(carro);
            }
        }

        public static void consultarCarros()
        {
            if (carros.Count == 0)
            {
                Console.WriteLine("No hay carros registrados.");
            }
            else
            {
                Console.WriteLine("Lista de carros registrados:");
                foreach (Carro carro in carros)
                {
                    Console.WriteLine($"Id: {carro.id}, Marca: {carro.marca}, Modelo: {carro.modelo}, Kilometraje: {carro.km}");
                }
            }
        }

    }
}