using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YonusaBEChallenge
{
    public class Count 
    {
        List<string> _lstPalabrasUnicas = new List<string>();
        List<StringBuilder> _lstPalabrasCompletas = new List<StringBuilder>();

        public Count(List<StringBuilder> lstPalabrasCompletas)
        {
            _lstPalabrasCompletas = lstPalabrasCompletas;
        }

        public string ContarPalabras()
        {
            string strMensaje;
            foreach (StringBuilder Palabra in _lstPalabrasCompletas)
            {
                //? Revisamos si contiene la palabra
                //? Si no esta la agregamos a la lista
                if (!_lstPalabrasUnicas.Contains(Palabra.ToString()))
                {
                    _lstPalabrasUnicas.Add(Palabra.ToString());
                }
            }

            strMensaje= ConteoCompleto();
            return strMensaje;
        }

        public string ConteoCompleto()
        {
            int contador = 0;
            StringBuilder strMensajeSalida = new StringBuilder();
            strMensajeSalida.AppendLine(string.Empty);
            foreach(string strPalabraUnica in _lstPalabrasUnicas)
            {
                foreach(var strPalabraGeneral in _lstPalabrasCompletas)
                {
                    if (strPalabraUnica.Equals(strPalabraGeneral.ToString()))
                    {
                        contador++;
                    }
                }
                
                strMensajeSalida.AppendLine(String.Format(@"{0}: {1} ",strPalabraUnica,contador.ToString("D3")));
                contador = 0;
            }
            strMensajeSalida.AppendLine(string.Format(@"Total words: {0}", _lstPalabrasCompletas.Count.ToString()));
            ////Console.WriteLine(strMensajeSalida.ToString());
            return strMensajeSalida.ToString();
        }
    }
}
