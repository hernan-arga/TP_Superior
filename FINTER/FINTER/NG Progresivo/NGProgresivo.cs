using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FINTER.Entidades;


namespace FINTER.NG_Progresivo
{
    public partial class NGProgresivo : Form
    {
        List<double> listaDeDiferencias;
        private List<PointF> listaDePuntos;
        List<double> diferenciasProgesivas;
        private double[] polinomioFinal = { 0 };
        private NGProgresivoSolver NGP = new NGProgresivoSolver();

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
            NGP.listaDePuntos = this.listaDePuntos;
            NGP.resolverPolinomio();

            listaDeDiferencias = NGP.listaDeDiferencias;
            diferenciasProgesivas = NGP.diferenciasProgesivas;
            polinomioFinal = NGP.polinomioFinal;
            PolinomioResultante.Text = NGP.polinomioResultante;
            
            
        }

        private void mostrarPasos_Click(object sender, EventArgs e)
        {
            int PosicionTop = mostrarPasos.Location.Y + 40;
            for(int i = 0; i<diferenciasProgesivas.Count;i++)
            {
                System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                this.Controls.Add(label);
                label.Location = new Point(mostrarPasos.Location.X, PosicionTop);
               
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
