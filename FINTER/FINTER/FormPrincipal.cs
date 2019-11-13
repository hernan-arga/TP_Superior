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

namespace FINTER
{
    public partial class FormPrincipal : Form
    {
        private List<PointF> listaDeTuplasDePuntos;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Lagrange_Click(object sender, EventArgs e)
        {
            //List<PointF> listaDeTuplasDePuntos;
            Program.puntos = campoDeValores.Text;
            String puntos = campoDeValores.Text;
            Parser parser = new Parser();
            listaDeTuplasDePuntos = parser.paresador(puntos);
            LagrangeSolver lagrange = new LagrangeSolver();
            if (listaDeTuplasDePuntos.Count >= 2)
            {
                Form interpolacion = new Interpolacion(lagrange, listaDeTuplasDePuntos);

                interpolacion.ShowDialog();
            }
                //System.Console.WriteLine(listaDePuntos.F);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NGProgresivo_Click(object sender, EventArgs e)
        {
            Program.puntos = campoDeValores.Text;
            String puntos = campoDeValores.Text;
            Parser parser = new Parser();
            listaDeTuplasDePuntos = parser.paresador(puntos);
            NGProgresivoSolver NGP = new NGProgresivoSolver();
            if (listaDeTuplasDePuntos.Count >= 2)
            {
                 Form interpolacion = new Interpolacion(NGP, listaDeTuplasDePuntos);
            
                  interpolacion.ShowDialog();
             }
        }

        private void NGRegresivo_Click(object sender, EventArgs e)
        {
            Program.puntos = campoDeValores.Text;
            String puntos = campoDeValores.Text;
            Parser parser = new Parser();
            listaDeTuplasDePuntos = parser.paresador(puntos);
            NGRegresivoSolver NGR = new NGRegresivoSolver();
            if (listaDeTuplasDePuntos.Count >= 2)
            {  
                Form interpolacion = new Interpolacion(NGR, listaDeTuplasDePuntos);
            
                interpolacion.ShowDialog();
            }
        }
    }
}
