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

enum METODO_USADO { LAGRANGE = 1, NGP = 2, NGR = 3 }



namespace FINTER
{
    public partial class Interpolacion : Form
    {
        private List<double> listaDeDiferencias;
        public List<PointF> listaDePuntos;
        private List<double[]> listaDeLs;
        private double[] polinomioFinal = { 0 };
        public PolySolver metodoUtilizado;
        private List<double> diferenciasProgesivas;
        private List<double> diferenciasRegresivas;

        public Interpolacion()
        {
            InitializeComponent();
        }

        public Interpolacion(LagrangeSolver lagrange, List<PointF> listaPuntos)
        {
            InitializeComponent();
            this.listaDePuntos = listaPuntos;

            metodoUtilizado = lagrange;
            if (listaDePuntos.Count != 0)
                 calcularPolinomioLagrange();
        }
        public Interpolacion(NGProgresivoSolver NGP, List<PointF> listaPuntos)
        {
            InitializeComponent();
            this.listaDePuntos = listaPuntos;
            metodoUtilizado = NGP;
            if (listaDePuntos.Count != 0)
                 calcularPolinomioNGProgresivo();
        }

        public Interpolacion(NGRegresivoSolver NGR, List<PointF> listaPuntos)
        {
            InitializeComponent();
            this.listaDePuntos = listaPuntos;
            metodoUtilizado = NGR;
            if (listaDePuntos.Count != 0)
                calcularPolinomioNGRegresivo();
        }

        private void calcularPolinomioLagrange()
        {
            metodoUtilizado.listaDePuntos = this.listaDePuntos;
            metodoUtilizado.resolverPolinomio();
            if (metodoUtilizado.sonEquidistantes())
                equidistantes.Text = "Los Puntos son Equidistantes";
            else
                equidistantes.Text = "Los Puntos no son Equidistantes";
            listaDeLs = ((LagrangeSolver) metodoUtilizado).listaDeLs;
            polinomioFinal = ((LagrangeSolver)metodoUtilizado).polinomioFinal;
            PolinomioResultante.Text = ((LagrangeSolver)metodoUtilizado).polinomioResultante;

            /*foreach (var l in listaDeLs)
            {
                Console.WriteLine(PolinomyToString(l));
            }*/

        }

        private void calcularPolinomioNGProgresivo()
        {
            metodoUtilizado.listaDePuntos = this.listaDePuntos;
            metodoUtilizado.resolverPolinomio();
            if (metodoUtilizado.sonEquidistantes())
                equidistantes.Text = "Los Puntos son Equidistantes";
            else
                equidistantes.Text = "Los Puntos no son Equidistantes";
            listaDeDiferencias = ((NGProgresivoSolver)metodoUtilizado).listaDeDiferencias;
            diferenciasProgesivas = ((NGProgresivoSolver)metodoUtilizado).diferenciasProgesivas;
            polinomioFinal = ((NGProgresivoSolver)metodoUtilizado).polinomioFinal;
            PolinomioResultante.Text = ((NGProgresivoSolver)metodoUtilizado).polinomioResultante;
        }

        private void calcularPolinomioNGRegresivo()
        {
            metodoUtilizado.listaDePuntos = this.listaDePuntos;
            metodoUtilizado.resolverPolinomio();
            if (metodoUtilizado.sonEquidistantes())
                equidistantes.Text = "Los Puntos son Equidistantes";
            else
                equidistantes.Text = "Los Puntos no son Equidistantes";
            listaDeDiferencias = ((NGRegresivoSolver)metodoUtilizado).listaDeDiferencias;
            diferenciasRegresivas = ((NGRegresivoSolver)metodoUtilizado).diferenciasRegresivas;
            polinomioFinal = ((NGRegresivoSolver)metodoUtilizado).polinomioFinal;
            PolinomioResultante.Text = ((NGRegresivoSolver)metodoUtilizado).polinomioResultante;
        }

        private void MostrarPasos_Click_1(object sender, EventArgs e)
        {
            int PosicionTop = MostrarPasos.Location.Y + 40;

            switch(metodoUtilizado.nombre_metodo)
            {
                case 1:
            int numeroDeL = 0;
            listaDeLs = ((LagrangeSolver)metodoUtilizado).listaDeLs;
            foreach (var l in listaDeLs)
            {
                System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                this.Controls.Add(label);
                label.Location = new Point(MostrarPasos.Location.X, PosicionTop);
                PosicionTop += 20;
                label.Text = "L" + numeroDeL + " = " + metodoUtilizado.PolinomyToString(l);
                label.Width = label.Width * 5;
                label.BringToFront();
                numeroDeL += 1;
            }
                break;

                case 2:

                diferenciasProgesivas = ((NGProgresivoSolver)metodoUtilizado).diferenciasProgesivas;
                listaDeDiferencias = ((NGProgresivoSolver)metodoUtilizado).listaDeDiferencias;
                for (int i = 0; i < diferenciasProgesivas.Count; i++)
                {
                    System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                    this.Controls.Add(label);
                    label.Location = new Point(MostrarPasos.Location.X, PosicionTop);

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

                break;

                case 3:

                listaDeDiferencias = ((NGRegresivoSolver)metodoUtilizado).listaDeDiferencias;
                diferenciasRegresivas = ((NGRegresivoSolver)metodoUtilizado).diferenciasRegresivas;
                for (int i = 0; i < diferenciasRegresivas.Count; i++)
                {
                    System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                    this.Controls.Add(label);
                    label.Location = new Point(MostrarPasos.Location.X, PosicionTop);

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
                    label.Text = sb.ToString() + diferenciasRegresivas[i].ToString();
                    label.BringToFront();

                    //label.p
                }


                break;

                default:
                System.Windows.Forms.Label errorLabel = new System.Windows.Forms.Label();
                this.Controls.Add(errorLabel);
                errorLabel.Location = new Point(MostrarPasos.Location.X, PosicionTop);
                errorLabel.Text = "ERROR DESCONOCIDO";
                break;
        }
        }

        private void modificar_Click_1(object sender, EventArgs e)
        {
            resultModif.Visible = false;
            Form modifP = new ModificarPuntos.ModificarPuntos(metodoUtilizado, listaDePuntos, this);
            modifP.Show();

        }

        private void Especializador_Click_1(object sender, EventArgs e)
        {
            double k;
            double resultado = 0;

            if (double.TryParse(ingresarK.Text, out k))
            {
                resultado = metodoUtilizado.EspecializarEnK(k);
                Especializacion.Text = "P(" + k.ToString() + ") = " + resultado.ToString("N4");
            }
            else
            {
                MessageBox.Show("El K ingresado no es valido");
            }
        }

        private void Finalizar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void Interpolacion_Load(object sender, EventArgs e)
        {

        }

      

    }
}
