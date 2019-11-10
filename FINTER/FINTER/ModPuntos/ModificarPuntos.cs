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
        FINTER.Interpolacion origen;


        public ModificarPuntos()
        {
            InitializeComponent();
        }

        public ModificarPuntos(PolySolver metodoUsado, List<PointF> listaPuntosOriginal, FINTER.Interpolacion origin)
        {
            InitializeComponent();
            puntos.Text = Program.puntos;
            polysolver = metodoUsado;
            listaDePuntosOriginal = listaPuntosOriginal;
            origen = origin;
            polinomioOriginal = metodoUsado.polinomioFinal;
        }

        private void enviar_Click(object sender, EventArgs e)
        {
            Program.puntos = puntos.Text;
            Parser parser = new Parser();
            listaDePuntosModificada = parser.paresador(puntos.Text);

            polysolver.listaDePuntos = listaDePuntosModificada;

            if (listaDePuntosModificada.Count() < listaDePuntosOriginal.Count())
            {
                //Menos puntos, re hago el polinomio para saber si hay uno de menor grado
                
                polysolver.resolverPolinomio();
                if (polysolver.polinomioResultante.Count() == polinomioOriginal.Count())
                {
                    //No hubo cambios en el polinomio
                    origen.resultModif.Text = "No hubo cambios en el Polinomio";
                    origen.resultModif.Visible = true;
                }
                else
                {
                    //Cambio el Grado
                    origen.resultModif.Text = "Cambio el grado del Polinomio al tener menos puntos";
                    origen.resultModif.Visible = true;
                    origen.PolinomioResultante.Text = polysolver.polinomioResultante;
                }
            }
            else
            {
                if (listaDePuntosModificada.All(punto => polysolver.puntoCumpleConPolinomio(punto)))
                {
                    //Cumplen con el Polinomio, se queda
                    origen.resultModif.Text = "Los nuevos puntos cumplen con el polinomio";
                    origen.resultModif.Visible = true;
                }
                else
                {
                    polysolver.resolverPolinomio();
                    //No cumplen con el Polinomio, creo uno nuevo
                    origen.resultModif.Text = "Los nuevos puntos no cumplen con el polinomio, se calculo un nuevo polinomio";
                    origen.resultModif.Visible = true;
                    origen.PolinomioResultante.Text = polysolver.polinomioResultante;
                }
            }
            origen.listaDePuntos = listaDePuntosModificada;
            origen.metodoUtilizado = polysolver;
            this.Close();
        }
    }
}
