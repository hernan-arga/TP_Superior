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

            Form lagrange = new Lagrange.FormLagrange(listaDeTuplasDePuntos);   
            lagrange.ShowDialog();
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

            Form NGProgresivo = new NG_Progresivo.NGProgresivo(listaDeTuplasDePuntos);
            NGProgresivo.ShowDialog();
        }

        private void NGRegresivo_Click(object sender, EventArgs e)
        {
            Program.puntos = campoDeValores.Text;
            String puntos = campoDeValores.Text;
            Parser parser = new Parser();
            listaDeTuplasDePuntos = parser.paresador(puntos);

            Form NGRegresivo = new NG_Regresivo.NGRegresivo(listaDeTuplasDePuntos);
            NGRegresivo.ShowDialog();
        }
    }
}
