/*
 * User - Angel Yajure 
 * Date: 19/4/2026
 * Time: 5:34 p. m.
 * 
 * Aquí va todo lo relacionado con el desafío número 2.
 */
using System;
using System.IO;

namespace taller_de_Angel_Yajure___Persistencia
{
    public class Desafio02
    {
        public static void Ejecutar()
        {
            Console.WriteLine("\n----=== Clonador de Imagenes ===----");

            string archiveOrigin = "avatar.jpg";
            string archiveDestiny = "imageClonated.jpg";

            if (File.Exists(archiveOrigin))
            {
                Console.WriteLine("\nIniciando la clonacion...");

                using (FileStream fsReading = new FileStream (archiveOrigin, FileMode.Open, FileAccess.Read))
                {
                    using (FileStream fsWriting = new FileStream (archiveDestiny, FileMode.Create, FileAccess.Write))
                    {
                        byte[] buffer = new byte[1024];
                        int ReadedBytes;

                        while ((ReadedBytes = fsReading.Read(buffer, 0, buffer.Length)) > 0)
						{
    						fsWriting.Write(buffer, 0, ReadedBytes);
						}
                    }
                }

                Console.WriteLine("Se ha realizado la clonacion con exito :D! Revise su carpeta para ver el resultado");
            }
            else
            {
                Console.WriteLine("Error -=- No se ha podido encotrar el archivo "+archiveOrigin);
                Console.WriteLine("Atencion! -=- Debe colocar una imagen llamada 'avatar.jpg' en la misma carpeta del programa");
            }
        }
    }
}