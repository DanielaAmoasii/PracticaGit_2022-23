using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaGit2022_23DAM_OFCB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //? ---------------   PRACTICA GIT 3.1   ------------------
            //? Daniela Amoasii Marin y Olga F. Civieta Bermejo 2022-23
            string textoTelegrama;
            int numPalabras = 0;
            double coste = 0;
            //Leo el telegrama
            textoTelegrama = txtTelegrama.Text;
            // telegrama urgente?
            if (cbUrgente.Checked)
                tipoTelegrama = 'u';
            else
                tipoTelegrama = 'o';
            //Obtengo el número de palabras que forma el telegrama
            numPalabras = 0;
            for (int i = 0; i < textoTelegrama.Length; i++)
            {
                if (textoTelegrama[i] == ' ' || textoTelegrama[i] == '.' || textoTelegrama[i] == ',')
                {
                    numPalabras++;
                }
            }
            int longCadena = textoTelegrama.Length - 1;
            if (textoTelegrama[longCadena] != '.' || textoTelegrama[longCadena] != ' ')
                numPalabras++;
            //Si el telegrama es ordinario
  
            if (rbO.Checked)
                if (numPalabras <= 10)
                    coste = 2.5;
                else
                    coste = 2.5 + (0.5 * (numPalabras - 10));
            else
            //Si el telegrama es urgente
            if (rbU.Checked)
            {
                if (numPalabras <= 10)
                    coste = 5;
                else
                    coste = 5 + (0.75 * (numPalabras - 10));
            else
                coste = 0;
            txtPrecio.Text = coste.ToString() + " euros";
        }

        private void cbUrgente_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
