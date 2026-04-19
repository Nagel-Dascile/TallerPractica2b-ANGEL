/*
 * User - Angel Yajure
 * 
 * Y ya profe, aquí está el último challenge (desafio). No se nota que me gusta usar terminos en ingles eh JAJAJAJA.
 */
using System;
using System.Collections.Generic;
using System.IO;

namespace taller_de_Angel_Yajure___Persistencia
{
    public class Desafio03
    {
        public static void Ejecutar()
        {
            Console.WriteLine("\n----=== Inspector de Inventario ===----");
            
            string RouteArchive = "inventary.txt";
            List<string> Inventary = new List<string>();

            if (File.Exists(RouteArchive))
            {
                Inventary.AddRange(File.ReadAllLines(RouteArchive));
                Console.WriteLine("---=== Se cargaron " +Inventary.Count+ " los productos del archivo.");
            }
            
            Console.WriteLine("Ingrese el nombre del nuevo producto que desee guardar en el inventario");
            string NewProduct = Console.ReadLine();

            if (!string.IsNullOrEmpty(NewProduct))
            {
                Inventary.Add(NewProduct);
                Console.WriteLine("El producto: '" +NewProduct+ "' ha sido añadido a la lista temporal.");
            }

            using (StreamWriter sw = new StreamWriter(RouteArchive, false))
            {
                foreach (string item in Inventary)
                {
                    sw.WriteLine(item);
                }
            }

            // 4. REPORTE FINAL
            Console.WriteLine("\n---=== Estado actual del inventario ===---");
            foreach (string item in Inventary)
            {
                Console.WriteLine("- " + item);
            }
            Console.WriteLine("-===-===-===-");
        }
    }
}