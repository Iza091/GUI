using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class media_aritmetica : Form
    {
        public media_aritmetica()
        {
            InitializeComponent();
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            string [] serie = txtserie.Text.Split(','); //7,5,8,4,6
            int suma = 0;
            foreach (string valor in serie){
                suma += int.Parse(valor);
                
            }
            double resp = suma / serie.Length;
            lblResp.Text = "Media A: " + Math.Round(resp ,2);

        }
    }
}
