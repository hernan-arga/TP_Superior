using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using FINTER.Entidades;

namespace FINTER.Entidades
{
    class NGProgresivoSolver : PolySolver
    {
        public List<double> listaDeDiferencias;
        public List<double> diferenciasProgesivas;
        public string polinomioResultante = "";

        override public void resolverPolinomio()
        {
            listaDeDiferencias = calcularDiferencias();
            diferenciasProgesivas = agarrarProgresivas();

            double[] polinomio = { listaDePuntos[0].Y };
            for (int i = 0; i < listaDePuntos.Count() - 1; i++)
            {
                polinomio = sumarPolinomios(polinomio, armarPolinomioGradoSiguiente(i));
            }
            polinomioFinal = sumarPolinomios(polinomio, polinomioFinal);
            polinomioResultante = "P(x) = " + PolinomyToString(polinomio);
            
            
        }

        private double[] armarPolinomioGradoSiguiente(int indice)
        {
            double[] polinomio = { diferenciasProgesivas[indice] };
            for (int i = 0; i <= indice; i++)
            {
                double[] siguientePolinomio = new double[] { -listaDePuntos[i].X, 1 };
                polinomio = multiplicarPolinomios(siguientePolinomio, polinomio);

            }
            return polinomio;
        }

        private List<double> calcularDiferencias()
        {
            double unaDiferencia;
            List<double> listaDeDiferencias = new List<double>();
            for (int i = 1; i < listaDePuntos.Count; i++)
            {
                for (int j = 0; j < listaDePuntos.Count - i; j++)
                {
                    //unaDiferencia = listaDePuntos[j + i].Y - listaDePuntos[j].Y;
                    unaDiferencia = calcularUnaDiferencia(i, j);
                    listaDeDiferencias.Add(unaDiferencia);

                }
            }
            return listaDeDiferencias;
        }

        private double calcularUnaDiferencia(int grado, int indice)
        {
            double unaDiferencia = 0;
            if (grado > 1)
            {
                unaDiferencia = (calcularUnaDiferencia(grado - 1, indice + 1) - calcularUnaDiferencia(grado - 1, indice)) / (listaDePuntos[indice + grado].X - listaDePuntos[indice].X);
            }
            else
            {
                unaDiferencia = (listaDePuntos[indice + 1].Y - listaDePuntos[indice].Y) / (listaDePuntos[indice + 1].X - listaDePuntos[indice].X);
            }
            return unaDiferencia;
        }

        private List<double> agarrarProgresivas()
        {
            List<double> diferenciasProgesivas = new List<double>();
            int indice = 0;
            diferenciasProgesivas.Add(listaDeDiferencias[0]);
            for (int i = 1; i < listaDePuntos.Count - 1; i++)
            {
                diferenciasProgesivas.Add(listaDeDiferencias[indice + listaDePuntos.Count - i]);
                indice = indice + listaDePuntos.Count - i;
            }
            return diferenciasProgesivas;
        }
    }
}
