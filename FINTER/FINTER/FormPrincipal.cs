using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            String puntos = campoDeValores.Text;
            listaDeTuplasDePuntos = paresador(puntos);

            Form lagrange = new Lagrange.FormLagrange(listaDeTuplasDePuntos);   
            lagrange.ShowDialog();
            //System.Console.WriteLine(listaDePuntos.F);
        }

        private List<PointF> paresador(string puntos)
        {            
            //Separo los puntos por \n
            List<string> listaDePuntos = puntos.Split(new[] { "\n" }, StringSplitOptions.RemoveEmptyEntries).ToList();

            //Convierto la lista de strings a lista de pointf
            return listaDePuntos.ConvertAll(new Converter<String, PointF>(StringToPointF));
        }

        //Parseador de string a pointf
        private PointF StringToPointF(String cadena)
        {
            string[] separadas = cadena.Split(';');
            string valorX = separadas[0];
            string valorY = separadas[1].TrimEnd('\n');
            float x; float y;
            if (float.TryParse(valorX, out x) && float.TryParse(valorY, out y))
            {
                return new PointF(x, y);
            }
            else
            {
                System.Console.WriteLine("Uno de los valores no fue ingresado correctamente");
                System.Windows.Forms.Application.Exit();
                return new PointF(0f, 0f);
            }
            //System.Console.WriteLine(separadas[0]);
            //System.Console.WriteLine(separadas[1]);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NGProgresivo_Click(object sender, EventArgs e)
        {
            String puntos = campoDeValores.Text;
            listaDeTuplasDePuntos = paresador(puntos);

            Form NGProgresivo = new NG_Progresivo.NGProgresivo(listaDeTuplasDePuntos);
            NGProgresivo.ShowDialog();
        }

        private void NGRegresivo_Click(object sender, EventArgs e)
        {
            String puntos = campoDeValores.Text;
            listaDeTuplasDePuntos = paresador(puntos);

            Form NGRegresivo = new NG_Progresivo.NGProgresivo(listaDeTuplasDePuntos);
            NGRegresivo.ShowDialog();
        }
    }
}
