/*
 * 
 * Usuario - Ángel Yajure
 * 
 * Muy buenas profe, aquí el estudiante Angel. Como puede apreciar, manejé todo el taller con "modulación", creo que
 * así se le decía a la técnica de separar partes del código en archivos. Esto lo hice por temas de practicidad
 * y que la verdad no me gusta tener una montaña de código porque siento que uno se pierde muy fácil y no se entiende 
 * el código a la primera. Esto mismo lo estoy aplicando en mi proyecto.
 * 
 * Si no sabe ingles, le recomiendo tener a la mano un traductor porque yo suelo programar usando terminos en ingles
 * para indicar las varaibles. Eso es ya por temas de que siento que escribir las variables en ingles, es más rápido
 * que en español, ya que hay palabras como "usuario" que son más cortas en ingles al ser solo "user".
 * 
 * No creo que usted necesite que documente el código porque aja, es bastante corto y usted sabe más que yo.
 * 
 * Para terminar, siento la demora. Usted sabe como ha estado el tema de la luz, adémas de que ando muy centrado en cálculo
 * y en terminar la lógica de mi proyecto, así que espero que entienda el motivo de mi tardanza y espero que el taller 
 * sea de su agrado.
 * 
 * Feliz tarde, noche, día o cuando sea que revise esto.
 * 
 * Atte. Ángel A. Yajure.
 * 
 * PD: Este archivo contiene lo que hice en clases, el resto de archivos si los hice acá en mi house (casa).
/*/

using System;
using System.IO;

namespace taller_de_Angel_Yajure___Persistencia
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("----=== Taller Seccion B ===----");
			
			string rutaRaiz = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DatosdelIUJO");
			string ReportsRoute = Path.Combine(rutaRaiz, "Reportes");
			
			Console.WriteLine(rutaRaiz);
			Console.WriteLine(ReportsRoute);
			
			if (!Directory.Exists(ReportsRoute))
			{
				Directory.CreateDirectory(ReportsRoute);
				Console.WriteLine("Se ha creado un directorio satisfactoriamente");
			}
			
			Desafio1.Ejecutar();
			Desafio02.Ejecutar();
			Desafio03.Ejecutar();
			
			Console.WriteLine ("Press any key to continue . . . ");
			Console.ReadKey (true);
		}
				
	}
}