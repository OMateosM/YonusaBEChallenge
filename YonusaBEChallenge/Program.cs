using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YonusaBEChallenge
{
    class Program
    { 
        static void Main(string[] args)
        {
            List<StringBuilder> lstPalabras = new List<StringBuilder>();
            string strMensajeSalida = string.Empty;
            //? Leemos un archivo txt para la entrada de informacion
            File objFile = new File();

            Console.WriteLine("\n\tIndique la ubicacion de un archivo .txt para iniciar\n");
            string strPath = Console.ReadLine();
            ////lstPalabras=objFile.leerEntrada(@"D:\EntrevistaYonusa\Entrada.txt");
            lstPalabras = objFile.leerEntrada(strPath);

            //? Verificamos que la lista no este vacia y contamos
            if (!lstPalabras.Count.Equals(0) || lstPalabras.Any())
            {
                Count objContar = new Count(lstPalabras);
                strMensajeSalida=objContar.ContarPalabras();
                Console.WriteLine(strMensajeSalida);
            }
        }
    }
}
