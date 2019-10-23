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

        public FormLagrange()
        {
            InitializeComponent();
        }

        public FormLagrange(List<PointF> listaDePuntos)
        {
            InitializeComponent();
            this.listaDePuntos = listaDePuntos;
            PointF point = listaDePuntos.First();
            Console.WriteLine(point);
            calcularPolinomioLagrange();
        }

        private void FormLagrange_Load(object sender, EventArgs e)
        {
  
        }

        

        private void calcularPolinomioLagrange()
        {

        }
    }
}
