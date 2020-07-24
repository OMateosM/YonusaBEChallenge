using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YonusaBEChallenge
{
    public class File 
    {
        List<StringBuilder> _lstSeparada = new List<StringBuilder>();
        public List<StringBuilder> leerEntrada(string strPath)
        {
            string strline;
            int counter = 0;
            Console.WriteLine("Comenzamos a Leer el archivo.");
            try
            {
                ////StreamReader file = new StreamReader(@"D:\EntrevistaYonusa\Entrada.txt");
                StreamReader file = new StreamReader(strPath);
                while ((strline = file.ReadLine()) != null)
                {
                    Console.WriteLine(strline);
                    counter++;
                    //? Separamos las palabras
                    separarPalabras(strline);
                }

                file.Close();
                Console.WriteLine("\n\nTerminamos de Leer el archivo.");

            }
            catch(Exception ex)
            {
                Console.WriteLine(string.Format(@"Tuvimos el siguiente problema: {0}", ex.Message.ToString()));
            }

            return _lstSeparada;
        }

        private void separarPalabras(string line)
        {
            StringBuilder strLineMayus = new StringBuilder();
            strLineMayus.AppendLine(line.ToUpper());

            strLineMayus.Replace(".", "").Replace("!", "").Replace("?", "").Replace(",", "").Replace(";", "");
            strLineMayus.Replace(Environment.NewLine, string.Empty);
            strLineMayus.Replace(Convert.ToChar(12).ToString(), string.Empty);
            strLineMayus.Replace("\t", string.Empty);

            List<StringBuilder> lstSeparaLinea = new List<StringBuilder>();
            lstSeparaLinea = Split(strLineMayus, Convert.ToChar(32));

            foreach(StringBuilder strDato in lstSeparaLinea)
            {
                _lstSeparada.Add(strDato);
            }
            
        }

        private static List<StringBuilder> Split(StringBuilder strEntrada, char cSeparador)
        {
            List<StringBuilder> lstResultado = new List<StringBuilder>();
            StringBuilder strCurrent = new StringBuilder();

            for (int i = 0; i < strEntrada.Length; ++i)
            {
                if (strEntrada[i] == cSeparador)
                {
                    lstResultado.Add(strCurrent);
                    strCurrent = new StringBuilder();
                }
                else
                {
                    strCurrent.Append(strEntrada[i]);
                }
            }

            if (strCurrent.Length > 0)
            {
                lstResultado.Add(strCurrent);
            }

            return lstResultado;
        }
    }
}
