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

namespace FINTER.ModificarPuntos
{
    public partial class ModificarPuntos : Form
    {
        public List<PointF> listaDePuntosOriginal;
        public List<PointF> listaDePuntosModificada;
        public double[] polinomioOriginal = { 0 };
        PolySolver polysolver;
        bool flagModifPoly = false;


        public ModificarPuntos()
        {
            InitializeComponent();
        }

        public ModificarPuntos(PolySolver metodoUsado, List<PointF> listaPuntosOriginal)
        {
            InitializeComponent();
            puntos.Text = Program.puntos;
            polysolver = metodoUsado;
            listaDePuntosOriginal = listaPuntosOriginal;
            polinomioOriginal = metodoUsado.polinomioFinal;
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            Program.puntos = puntos.Text;
            Parser parser = new Parser();
            listaDePuntosModificada = parser.paresador(puntos.Text);

            if (listaDePuntosModificada.Count() < listaDePuntosOriginal.Count())
            {
                //Menos puntos, re hago el polinomio para saber si hay uno de menor grado
                polysolver.listaDePuntos = listaDePuntosModificada;
                polysolver.resolverPolinomio();
                if (polysolver.polinomioFinal == polinomioOriginal)
                {
                    //No hubo cambios en el polinomio
                    flagModifPoly = false;
                }
                else
                {
                    //Cambio el Grado
                    flagModifPoly = true;
                }
            }
            else
            {
                if (listaDePuntosModificada.All(punto => polysolver.puntoCumpleConPolinomio(punto)))
                {
                    //Cumplen con el Polinomio, se queda
                    flagModifPoly = false;
                }
                else
                {
                    polysolver.listaDePuntos = listaDePuntosModificada;
                    polysolver.resolverPolinomio();
                    flagModifPoly = true;
                    //No cumplen con el Polinomio, creo uno nuevo
                }
            }
            this.Hide();
        }
    }
}
