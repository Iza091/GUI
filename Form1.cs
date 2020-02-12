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
    public partial class FrmInterfaz : Form
    {
        media_aritmetica frmAritmetica = new media_aritmetica();
        media_armonica frmArmonica = new media_armonica();
        ConversorEnUNO.frmCon frmConv = new ConversorEnUNO.frmCon();
        Excepciones.Form1 frmExep = new Excepciones.Form1();
        public FrmInterfaz()
        {
            InitializeComponent();
        }

        private void aRCHIVOToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        //llamar frmAritmeticas
        private void mEDIAARITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmArmonica.Hide();
            frmAritmetica.MdiParent = this;
            frmAritmetica.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //salir
        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
        //llamar frmArmonica
        private void mEDIAARMONICAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAritmetica.Hide();
            frmArmonica.MdiParent = this;
            frmArmonica.Show();
        }

        private void cONVERSORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAritmetica.Hide();
            frmArmonica .Hide();
            frmConv.MdiParent = this;
            frmConv.Show();
        }

        private void cALCULADORAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAritmetica.Hide();
            frmArmonica.Hide();
            frmConv.Hide();
            frmExep.MdiParent=this;
            frmExep.Show();
        }
    }
}
