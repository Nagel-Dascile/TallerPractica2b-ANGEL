/*
 * 
 * Usuario - Angel Yajure
 * 
 * 
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
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}