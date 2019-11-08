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
using FINTER.ModificarPuntos;

namespace FINTER.Lagrange
{
    public partial class FormLagrange : Form
    {
        private List<PointF> listaDePuntos;
        private List<double[]> listaDeLs;
        private double[] polinomioFinal = { 0 };
        private LagrangeSolver lagrange = new LagrangeSolver();

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
            lagrange.listaDePuntos = this.listaDePuntos;
            lagrange.resolverPolinomio();

            listaDeLs = lagrange.listaDeLs;
            polinomioFinal = lagrange.polinomioFinal;
            PolinomioResultante.Text = lagrange.polinomioResultante;

            /*foreach (var l in listaDeLs)
            {
                Console.WriteLine(PolinomyToString(l));
            }*/
            
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
                label.Text = "L" + numeroDeL + " = " + lagrange.PolinomyToString(l);
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
                resultado = lagrange.EspecializarEnK(k);
                Especializacion.Text = "P(" + k.ToString() + ") = " + resultado.ToString("N4"); 
            }
            else
            {
                MessageBox.Show("El K ingresado no es valido");
            }
        }

        private void PolinomioResultante_Click(object sender, EventArgs e)
        {

        }

        private void modificar_Click(object sender, EventArgs e)
        {
            Form modifP = new ModificarPuntos.ModificarPuntos(lagrange, listaDePuntos);
            modifP.Show();
        }

    }
}
