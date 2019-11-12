using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FINTER.Entidades
{
    public class LagrangeSolver : PolySolver
    {
        public List<double[]> listaDeLs;

        public LagrangeSolver()
        {
            nombre_metodo = 1;
        }

        override public void resolverPolinomio()
        {
            double[] reset = { 0 };
            polinomioFinal = reset;

            listaDeLs = calcularLs();

            List<double[]> listaDeFactoresDelPolinomioFinal = new List<double[]>();

            for (int i = 0; i < listaDePuntos.Count; i++)
            {
                double[] imagen = { listaDePuntos.ElementAt(i).Y };
                listaDeFactoresDelPolinomioFinal.Add(multiplicarPolinomios(listaDeLs.ElementAt(i), imagen));
            }


            for (int i = 0; i < listaDeFactoresDelPolinomioFinal.Count; i++)
            {
                polinomioFinal = sumarPolinomios(polinomioFinal, listaDeFactoresDelPolinomioFinal.ElementAt(i));
            }

            for (int i = 0; i < polinomioFinal.Count(); i++)
            {
                polinomioFinal[i] = Math.Round(polinomioFinal[i], 4);
            }

            polinomioResultante = "P(x) = " + PolinomyToString(polinomioFinal);
            
        }

       private List<double[]> calcularLs()
       {
           List<double[]> _ListaDeLs = new List<double[]>();

           for (int i = 0; i < listaDePuntos.Count; i++)
           {
               _ListaDeLs.Add(calcularUnL(i));
           }

           return _ListaDeLs;
       }

       private double[] calcularUnL(int indice)
       {
           double[] polinomioNumerador = { 1 };

           //Calculo el polinomio del numerador
           for (int i = 0; i < listaDePuntos.Count; i++)
           {
               if (i != indice)
               {
                   // (x-3) =  { -3, 1 }
                   double[] siguientePolinomio = new double[] { -listaDePuntos.ElementAt(i).X, 1 };
                   polinomioNumerador = multiplicarPolinomios(siguientePolinomio, polinomioNumerador);
               }
           }

           double[] polinomioDenominador = { 1 };
           //Calculo el polinomio del denominador
           for (int i = 0; i < listaDePuntos.Count; i++)
           {
               if (i != indice)
               {
                   // (1-3) =  { -3, 1 }
                   double[] siguientePolinomio = new double[] { -listaDePuntos.ElementAt(i).X, listaDePuntos.ElementAt(indice).X };
                   polinomioDenominador = multiplicarPolinomios(siguientePolinomio, polinomioDenominador);
               }
           }

           double denominador = polinomioDenominador.Sum();

           for (int i = 0; i < polinomioNumerador.Length; i++)
           {
               polinomioNumerador[i] /= denominador;
               //polinomioNumerador[i] = Math.Round(polinomioNumerador[i] / denominador, 4);
           }

           return polinomioNumerador;

       }
    }
}
