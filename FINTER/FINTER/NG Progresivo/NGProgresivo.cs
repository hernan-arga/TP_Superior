using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FINTER.NG_Progresivo
{
    public partial class NGProgresivo : Form
    {
        List<double> listaDeDiferencias;
        private List<PointF> listaDePuntos;
        List<double> diferenciasProgesivas;

        public NGProgresivo()
        {
            InitializeComponent();
        }

        public NGProgresivo(List<PointF> listaDePuntos)
        {
            InitializeComponent();
            this.listaDePuntos = listaDePuntos;
            PointF point = listaDePuntos.First();
            Console.WriteLine(point);
            calcularPolinomioNGProgresivo();
        }

        private void NGProgresivo_Load(object sender, EventArgs e)
        {

        }

        private void calcularPolinomioNGProgresivo()
        {
            listaDeDiferencias = calcularDiferencias();
            diferenciasProgesivas = agarrarProgresivas();

            double[] polinomio = {listaDePuntos[0].Y};
            for (int i = 0; i < listaDePuntos.Count()-1; i++)
            {
                polinomio = sumarPolinomios(polinomio, armarPolinomioGradoSiguiente(i));
            }
            PolinomioResultante.Text = "P(x) = " + PolinomyToString(polinomio);
            
            
        }

        private double[] armarPolinomioGradoSiguiente(int indice)
        {
            double[] polinomio = {diferenciasProgesivas[indice]};
            for (int i = 0; i <= indice; i++)
            {
                double[] siguientePolinomio = new double[] { -listaDePuntos[i].X, 1 };
                polinomio = multiplicarPolinomios(siguientePolinomio, polinomio);
                
            }
            return polinomio;
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
                if (p[i] != 0)
                {
                    if (p[i] > 0)
                    {
                        if (i > 0) sb.Append(" + ");
                    }

                    if (p[i] < 0)
                    {
                        if (i > 0) sb.Append(" ");
                    }
                    sb.Append(p[i].ToString());
                    if (i > 0) sb.Append(" x^").Append(i.ToString());
                }
            }

            return sb.ToString();

        }
       

        private List<double> calcularDiferencias()
        {
            double unaDiferencia;
            List<double> listaDeDiferencias = new List<double>();
            for (int i = 1; i < listaDePuntos.Count; i++)
            {
                for(int j = 0; j<listaDePuntos.Count-i; j++)
                {
                    //unaDiferencia = listaDePuntos[j + i].Y - listaDePuntos[j].Y;
                    unaDiferencia = calcularUnaDiferencia(i,j);
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
                unaDiferencia = (calcularUnaDiferencia(grado - 1, indice + 1) - calcularUnaDiferencia(grado - 1, indice))/(listaDePuntos[indice +grado].X-listaDePuntos[indice].X);
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


        private void button1_Click(object sender, EventArgs e)
        {
            int PosicionTop = button1.Location.Y + 40;
            for(int i = 0; i<diferenciasProgesivas.Count;i++)
            {
                System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                this.Controls.Add(label);
                label.Location = new Point(button1.Location.X, PosicionTop);
               
                PosicionTop += 20;
                
                label.AutoSize = true;
                var sb = new StringBuilder();
                sb.Append("f[");
                for (int j = 0; j <= i; j++)
                {
                    if (j > 0) 
                    {
                        sb.Append(", ");
                    }
                    sb.Append("X" + j); 
                }
                sb.Append("] = ");
               // sb.Append(diferenciasProgesivas[i].ToString());
                label.Text = sb.ToString() + diferenciasProgesivas[i].ToString();
                label.BringToFront();

                //label.p
            }
             
            /*for (int i = 0; i < listaDePuntos.Count; i++)
            {
                for (int j=0; j<= i; j++)
                {
           
                    System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                    this.Controls.Add(label);
                    label.Location = new Point(button1.Location.X, PosicionTop);
                    PosicionTop += 20;
                    label.Text = (-listaDePuntos[j].X).ToString();
                    label.BringToFront();
                }
                System.Windows.Forms.Label label2 = new System.Windows.Forms.Label();
                this.Controls.Add(label2);
                label2.Location = new Point(button1.Location.X, PosicionTop);
                PosicionTop += 20;
                label2.Text = ("-");
                label2.BringToFront();
            }*/
        }

        private void PolinomioResultante_Click(object sender, EventArgs e)
        {

        }
    }
}
