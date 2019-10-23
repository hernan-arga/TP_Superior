using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FINTER.NG_Regresivo
{
    public partial class NGRegresivo : Form
    {
        private List<PointF> listaDePuntos;

        public NGRegresivo()
        {
            InitializeComponent();
        }

        public NGRegresivo(List<PointF> listaDePuntos)
        {
            InitializeComponent();
            this.listaDePuntos = listaDePuntos;
            PointF point = listaDePuntos.First();
            //Console.WriteLine(point);
            calcularPolinomioNGRegresivo();
        }

        public void calcularPolinomioNGRegresivo()
        {

        }

        private void NGRegresivo_Load(object sender, EventArgs e)
        {

        }
    }
}
