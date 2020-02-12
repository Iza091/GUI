using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excepciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = double.Parse(txtnum1.Text),
                    num2 = double.Parse(txtnum2.Text),
                    respuesta = 0;
                switch (cbooperaciones.SelectedIndex)
                {
                    case 0://suma
                        respuesta = num1 + num2;
                        break;
                    case 1://resta
                        respuesta = num1 - num2;
                        break;
                    case 2://multiplicacion
                        respuesta = num1 * num2;
                        break;
                    case 3://division
                        respuesta = num1 / num2;
                        break;
                }
                lblrespuesta.Text = "Respuesta: " + respuesta;
            }catch(Exception error){
                MessageBox.Show("Por favor ingrese solo numero: "+ error.Message, "Calculadora Basica",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string[] tablas = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
            //cbotabla.Items.AddRange(tablas);
            //for(sbyte i=1; i <= 10; i++) {
                cbotabla.Items.Add("1");
            cbotabla.Items.Add("2");
            cbotabla.Items.Add("3");
            //}
        }

        private void btnTabla_Click(object sender, EventArgs e)
        {
            int ntabla = int.Parse(cbotabla.SelectedItem.ToString());
            string respuesta = "";
            for(sbyte i=1; i<=10; i++) {
                respuesta += ntabla + "X" + i + "=" + (ntabla * i) + "\n";
            }
            lblresp_tabla.Text = respuesta;
        }
    }
}
