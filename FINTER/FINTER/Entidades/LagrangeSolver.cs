using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FINTER.Entidades
{
    class LagrangeSolver : PolySolver
    {
        public List<double[]> listaDeLs;
        public string polinomioResultante = "";

       override public void resolverPolinomio()
        {
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
            polinomioResultante = "P(x) = " + PolinomyToString(polinomioFinal);

            /*foreach (var l in listaDeLs)
            {
                Console.WriteLine(PolinomyToString(l));
            }*/
            
        }

       private List<double[]> calcularLs()
       {
           List<double[]> listaDeLs = new List<double[]>();

           for (int i = 0; i < listaDePuntos.Count; i++)
           {
               listaDeLs.Add(calcularUnL(i));
           }

           return listaDeLs;
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
           }

           return polinomioNumerador;

       }
    }
}
