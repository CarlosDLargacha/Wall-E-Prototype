using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WallE
{
    public class Acces
    {

        static void Main(string[] args)
        {
            string texto = "Texto de prueba";
            string nombreArchivo = "MiArchivo.txt";

            GuardarTextoEnArchivo(texto, nombreArchivo);
        }

        static void GuardarTextoEnArchivo(string texto, string nombreArchivo)
        {
            string rutaArchivo = Path.Combine("Code", nombreArchivo);

            if (!Directory.Exists("Code"))
            {
                Directory.CreateDirectory("Code");
            }

            if (!File.Exists(rutaArchivo))
            {
                File.Create(rutaArchivo).Dispose();
            }

            File.WriteAllText(rutaArchivo, texto);
        }
        static string LeerTextoDeArchivo(string nombreArchivo)
        {
            string rutaArchivo = Path.Combine("Code", nombreArchivo);

            if (!File.Exists(rutaArchivo))
            {
                throw new FileNotFoundException($"No se encuentra el archivo {nombreArchivo} en la carpeta 'Code'.");
            }

            return File.ReadAllText(rutaArchivo);
        }


    }
}
