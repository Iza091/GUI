namespace GUI
{
    partial class FrmInterfaz
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aRCHIVOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sALIRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aPLICACIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cALCULADORAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fIBONACCIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cAJEROToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tABLASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mEDIAARITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mEDIAARMONICAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dESVIACIONTIPICAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eCUACIONCUADRATICAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cONVERSORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nUMPRIMOToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aRCHIVOToolStripMenuItem,
            this.aPLICACIONESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(785, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aRCHIVOToolStripMenuItem
            // 
            this.aRCHIVOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sALIRToolStripMenuItem});
            this.aRCHIVOToolStripMenuItem.Name = "aRCHIVOToolStripMenuItem";
            this.aRCHIVOToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.aRCHIVOToolStripMenuItem.Text = "ARCHIVO";
            this.aRCHIVOToolStripMenuItem.Click += new System.EventHandler(this.aRCHIVOToolStripMenuItem_Click);
            // 
            // sALIRToolStripMenuItem
            // 
            this.sALIRToolStripMenuItem.Image = global::GUI.Properties.Resources.iconfinder_Cancel_1493282;
            this.sALIRToolStripMenuItem.Name = "sALIRToolStripMenuItem";
            this.sALIRToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F4)));
            this.sALIRToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.sALIRToolStripMenuItem.Text = "SALIR";
            this.sALIRToolStripMenuItem.Click += new System.EventHandler(this.sALIRToolStripMenuItem_Click);
            // 
            // aPLICACIONESToolStripMenuItem
            // 
            this.aPLICACIONESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cALCULADORAToolStripMenuItem,
            this.nUMPRIMOToolStripMenuItem,
            this.fIBONACCIToolStripMenuItem,
            this.cAJEROToolStripMenuItem,
            this.tABLASToolStripMenuItem,
            this.toolStripSeparator1,
            this.mEDIAARITToolStripMenuItem,
            this.mEDIAARMONICAToolStripMenuItem,
            this.dESVIACIONTIPICAToolStripMenuItem,
            this.eCUACIONCUADRATICAToolStripMenuItem,
            this.toolStripSeparator2,
            this.cONVERSORToolStripMenuItem});
            this.aPLICACIONESToolStripMenuItem.Name = "aPLICACIONESToolStripMenuItem";
            this.aPLICACIONESToolStripMenuItem.Size = new System.Drawing.Size(100, 20);
            this.aPLICACIONESToolStripMenuItem.Text = "APLICACIONES";
            // 
            // cALCULADORAToolStripMenuItem
            // 
            this.cALCULADORAToolStripMenuItem.Name = "cALCULADORAToolStripMenuItem";
            this.cALCULADORAToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.cALCULADORAToolStripMenuItem.Text = "CALCULADORA MULTIFUNCION";
            this.cALCULADORAToolStripMenuItem.Click += new System.EventHandler(this.cALCULADORAToolStripMenuItem_Click);
            // 
            // fIBONACCIToolStripMenuItem
            // 
            this.fIBONACCIToolStripMenuItem.Name = "fIBONACCIToolStripMenuItem";
            this.fIBONACCIToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.fIBONACCIToolStripMenuItem.Text = "FIBONACCI";
            // 
            // cAJEROToolStripMenuItem
            // 
            this.cAJEROToolStripMenuItem.Name = "cAJEROToolStripMenuItem";
            this.cAJEROToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.cAJEROToolStripMenuItem.Text = "CAJERO";
            // 
            // tABLASToolStripMenuItem
            // 
            this.tABLASToolStripMenuItem.Name = "tABLASToolStripMenuItem";
            this.tABLASToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.tABLASToolStripMenuItem.Text = "TABLAS";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(244, 6);
            // 
            // mEDIAARITToolStripMenuItem
            // 
            this.mEDIAARITToolStripMenuItem.Name = "mEDIAARITToolStripMenuItem";
            this.mEDIAARITToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.mEDIAARITToolStripMenuItem.Text = "MEDIA ARITMETICA";
            this.mEDIAARITToolStripMenuItem.Click += new System.EventHandler(this.mEDIAARITToolStripMenuItem_Click);
            // 
            // mEDIAARMONICAToolStripMenuItem
            // 
            this.mEDIAARMONICAToolStripMenuItem.Name = "mEDIAARMONICAToolStripMenuItem";
            this.mEDIAARMONICAToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.mEDIAARMONICAToolStripMenuItem.Text = "MEDIA ARMONICA";
            this.mEDIAARMONICAToolStripMenuItem.Click += new System.EventHandler(this.mEDIAARMONICAToolStripMenuItem_Click);
            // 
            // dESVIACIONTIPICAToolStripMenuItem
            // 
            this.dESVIACIONTIPICAToolStripMenuItem.Name = "dESVIACIONTIPICAToolStripMenuItem";
            this.dESVIACIONTIPICAToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.dESVIACIONTIPICAToolStripMenuItem.Text = "DESVIACION TIPICA";
            // 
            // eCUACIONCUADRATICAToolStripMenuItem
            // 
            this.eCUACIONCUADRATICAToolStripMenuItem.Name = "eCUACIONCUADRATICAToolStripMenuItem";
            this.eCUACIONCUADRATICAToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.eCUACIONCUADRATICAToolStripMenuItem.Text = "ECUACION CUADRATICA";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(244, 6);
            // 
            // cONVERSORToolStripMenuItem
            // 
            this.cONVERSORToolStripMenuItem.Image = global::GUI.Properties.Resources._62_256;
            this.cONVERSORToolStripMenuItem.Name = "cONVERSORToolStripMenuItem";
            this.cONVERSORToolStripMenuItem.Size = new System.Drawing.Size(247, 22);
            this.cONVERSORToolStripMenuItem.Text = "CONVERSOR";
            this.cONVERSORToolStripMenuItem.Click += new System.EventHandler(this.cONVERSORToolStripMenuItem_Click);
            // 
            // nUMPRIMOToolStripMenuItem
            // 
            this.nUMPRIMOToolStripMenuItem.Name = "nUMPRIMOToolStripMenuItem";
            this.nUMPRIMOToolStripMenuItem.Size = new System.Drawing.Size(244, 6);
            // 
            // FrmInterfaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 469);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmInterfaz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INTERFAZ DE DOCUMENTOS MULTIPLES";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aRCHIVOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sALIRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aPLICACIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cALCULADORAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fIBONACCIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cAJEROToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tABLASToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mEDIAARITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mEDIAARMONICAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dESVIACIONTIPICAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eCUACIONCUADRATICAToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cONVERSORToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator nUMPRIMOToolStripMenuItem;
    }
}

