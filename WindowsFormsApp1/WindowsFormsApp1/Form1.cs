using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //var logica = new LogicaCalculadora();
            LogicaCalculadora logica = new LogicaCalculadora();
            tbResultado.Text = logica.Operar(tbOperando1.Text,
                                             tbOperando2.Text, 
                                             cmbOperador.Text);
            /*
            switch (cmbOperador.Text)
            {
                case "Suma":
                    tbResultado.Text = (Convert.ToDouble(tbOperando1.Text) +
                    Convert.ToDouble(tbOperando2.Text)).ToString();
                    break;
                case "Resta":
                    tbResultado.Text = (Convert.ToDouble(tbOperando1.Text) +
                    Convert.ToDouble(tbOperando2.Text)).ToString();
                    break;
                case "Multiplicación":
                    tbResultado.Text = (Convert.ToDouble(tbOperando1.Text) +
                    Convert.ToDouble(tbOperando2.Text)).ToString();
                    break;
                case "División":
                    tbResultado.Text = (Convert.ToDouble(tbOperando1.Text) +
                    Convert.ToDouble(tbOperando2.Text)).ToString();
                    break;
                default:
                    System.Windows.Forms.MessageBox.Show(
                        "No se ha seleccionado un operador");
                    break;
            }
            */
        }
    }
}
