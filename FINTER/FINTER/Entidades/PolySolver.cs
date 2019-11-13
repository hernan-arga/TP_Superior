using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace FINTER.Entidades
{
    abstract public class PolySolver
    {
        public double[] polinomioFinal = { 0 };
        public List<PointF> listaDePuntos;
        public int nombre_metodo;
        public string polinomioResultante = "";


        public double[] multiplicarPolinomios(double[] a, double[] b)
        {
            var result = new double[a.Length + b.Length - 1];
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < b.Length; j++)
                {
                    result[i + j] += a[i] * b[j];
                }
            }
            return result;
        }

        public double[] sumarPolinomios(double[] a, double[] b)
        {

            var result = new double[Math.Max(a.Length, b.Length)];
            for (int i = 0; i < result.Length; i++)
            {

                double val1 = 0;
                if (a.Length > i)
                {
                    val1 = a[i];
                }

                double val2 = 0;
                if (b.Length > i)
                {
                    val2 = b[i];
                }

                result[i] = val1 + val2;

            }
            return result;
        }

        public string PolinomyToString(double[] p)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i] > 0)
                {
                    if (i > 0) sb.Append(" + ");
                }

                if (p[i] < 0)
                {
                    if (i > 0) sb.Append(" ");
                }
                if (p[i] != 0)
                {
                    sb.Append(p[i].ToString());
                    if (i > 0) sb.Append(" x^").Append(i.ToString()).Append(" ");
                }
            }
            return sb.ToString();

        }

        public double EspecializarEnK(double k)
        {
            double resultado = 0;

            for (int i = 0; i < polinomioFinal.Count(); i++)
            {
                resultado += polinomioFinal[i] * Math.Pow(k, i);
                Console.WriteLine(resultado);
                Console.WriteLine();
            }

            return resultado;
        }

        public bool puntoCumpleConPolinomio(PointF punto)
        {
            return this.EspecializarEnK(punto.X) == punto.Y;
        }
        public bool sonEquidistantes()
        {
            float primerDistancia = listaDePuntos.ElementAt(1).X - listaDePuntos.ElementAt(0).X;
            for (int i = 2; i < listaDePuntos.Count; i++)
            {
                if (primerDistancia != listaDePuntos.ElementAt(i).X - listaDePuntos.ElementAt(i - 1).X)
                    return false;
            }
            return true;
        }

        public int gradoPolinomio(double[] polinomio)
        {
            int j = 0;
            for(int i = 0; i < polinomio.Count(); i++)
            {
                if (polinomio[i] != 0)
                {
                    j = i;
                }
            }
            return j;
        }

        abstract public void resolverPolinomio();
    }
}
