/*
*	User - Angel Yajure 
* 	Aqui está todo lo referente al desafio 1.
	 * 	Por cierto... el ";c" y el ":D" son carita triste y carita feliz :).
*/

using System;
using System.IO;

namespace taller_de_Angel_Yajure___Persistencia
{
    public class Desafio1
    {
        public static void Ejecutar()
        {
            Console.WriteLine ("\n===--- Validaro de Seguridad---===");
            
            Console.WriteLine ("Por favor, ingrese su usuario (user) y contraseña (password)");
            string entry = Console.ReadLine();
            string[] parts = entry.Split(';');

            if (parts.Length == 2)
            {
                string user = parts[0].Trim();
                string password = parts[1].Trim();
                
                if (password.Contains("123"))
                {
                    Console.WriteLine ("Atencion! -=- Su contraseña no es la más segura ;c");
                    	using (StreamWriter sw = new StreamWriter("seguridad.txt", true))
                    	{
                        	sw.WriteLine (DateTime.Now.ToString()+": Clave vulnerable detectada del usuario: "+user);
                    	}
                    Console.WriteLine("El evento ha sido registrado y guardado en seguridad.txt");
                }
                else
                {
                    Console.WriteLine(":D Acceso validado. Su contraseña (password) cumple los estándares.");
                }
            }
            else
            {
                Console.WriteLine("ERROR! : El formato de los datos debe ser: usuario;clave (separados por punto y coma)");
            }
        }
    }
}
