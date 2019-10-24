using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINTER.Lagrange
{
    public partial class FormLagrange : Form
    {
        private List<PointF> listaDePuntos;
        private List<double[]> listaDeLs;
        private double[] polinomioFinal = { 0 };

        public FormLagrange()
        {
            InitializeComponent();
        }

        public FormLagrange(List<PointF> listaDePuntos)
        {
            InitializeComponent();
            this.listaDePuntos = listaDePuntos;
            //PointF point = listaDePuntos.First();
            //Console.WriteLine(point);
            calcularPolinomioLagrange();
        }

        private void FormLagrange_Load(object sender, EventArgs e)
        {
  
        }

        

        private void calcularPolinomioLagrange()
        {
            listaDeLs = calcularLs();

            List<double[]> listaDeFactoresDelPolinomioFinal = new List<double[]>();

            for (int i = 0; i < listaDePuntos.Count; i++)
            {
                double[] imagen = {listaDePuntos.ElementAt(i).Y};
                listaDeFactoresDelPolinomioFinal.Add( multiplicarPolinomios(listaDeLs.ElementAt(i), imagen) );
            }            

          
           for (int i = 0; i < listaDeFactoresDelPolinomioFinal.Count; i++)
			{
                polinomioFinal = sumarPolinomios(polinomioFinal, listaDeFactoresDelPolinomioFinal.ElementAt(i));
			}
            PolinomioResultante.Text = "P(x) = "+PolinomyToString(polinomioFinal);

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
                listaDeLs.Add( calcularUnL(i) );
            }

            return listaDeLs;
        }

        private double[] calcularUnL(int indice)
        {
            double[] polinomioNumerador = {1};

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

        private double[] multiplicarPolinomios(double[] a, double[] b)
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

        private double[] sumarPolinomios(double[] a, double[] b)
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

        private string PolinomyToString(double[] p)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < p.Length; i++)
            {
                if (i > 0) sb.Append(" + ");
                sb.Append(p[i].ToString());
                if (i > 0) sb.Append(" x^").Append(i.ToString());
            }
            return sb.ToString();

        }

        private void MostrarPasos_Click(object sender, EventArgs e)
        {
            int PosicionTop = MostrarPasos.Location.Y+40;
            int numeroDeL = 0;
            foreach (var l in listaDeLs)
            {
                System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                this.Controls.Add(label);
                label.Location = new Point(MostrarPasos.Location.X, PosicionTop);
                PosicionTop += 20;
                label.Text = "L" + numeroDeL + " = " + PolinomyToString(l);
                label.Width = label.Width*5;
                label.BringToFront();
                numeroDeL += 1;
            }
        }

        private void Especializador_Click(object sender, EventArgs e)
        {
            double k;
            double resultado = 0;

            if (double.TryParse(ingresarK.Text, out k))
            {
                for (int i = 0; i < polinomioFinal.Count(); i++)
                {                    
                    resultado += polinomioFinal[i] * Math.Pow(k, i);
                    Console.WriteLine(resultado);
                    Console.WriteLine();
                }
                Especializacion.Text = "P(" + k.ToString() + ") = " + resultado.ToString("N4"); 
            }
            else
            {
                MessageBox.Show("El K ingresado no es valido");
            }
        }

    }
}
