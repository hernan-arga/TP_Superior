using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FINTER.Entidades
{
    class Parser
    {
        public List<PointF> paresador(string puntos)
        {
            //Separo los puntos por \n
            List<string> listaDePuntos = puntos.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();

            //Convierto la lista de strings a lista de pointf
            return listaDePuntos.ConvertAll(new Converter<String, PointF>(StringToPointF));
        }

        public PointF StringToPointF(String cadena)
        {
            string[] separadas = cadena.Split(';');
            string valorX = separadas[0];
            string valorY = separadas[1].TrimEnd('\n');
            float x; float y;
            if (float.TryParse(valorX, out x) && float.TryParse(valorY, out y))
            {
                return new PointF(x, y);
            }
            else
            {
                System.Console.WriteLine("Uno de los valores no fue ingresado correctamente");
                System.Windows.Forms.Application.Exit();
                return new PointF(0f, 0f);
            }
            //System.Console.WriteLine(separadas[0]);
            //System.Console.WriteLine(separadas[1]);

        }
    }
}
