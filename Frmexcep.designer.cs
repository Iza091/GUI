namespace Excepciones
{
    partial class Form1
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
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.lblnum1 = new System.Windows.Forms.Label();
            this.cbooperaciones = new System.Windows.Forms.ComboBox();
            this.lblnum2 = new System.Windows.Forms.Label();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.lblrespuesta = new System.Windows.Forms.Label();
            this.lbltabla = new System.Windows.Forms.Label();
            this.cbotabla = new System.Windows.Forms.ComboBox();
            this.btnTabla = new System.Windows.Forms.Button();
            this.lblresp_tabla = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(51, 97);
            this.btnCalcular.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(70, 36);
            this.btnCalcular.TabIndex = 0;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // txtnum1
            // 
            this.txtnum1.Location = new System.Drawing.Point(87, 53);
            this.txtnum1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(76, 20);
            this.txtnum1.TabIndex = 1;
            // 
            // lblnum1
            // 
            this.lblnum1.AutoSize = true;
            this.lblnum1.Location = new System.Drawing.Point(40, 53);
            this.lblnum1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblnum1.Name = "lblnum1";
            this.lblnum1.Size = new System.Drawing.Size(41, 13);
            this.lblnum1.TabIndex = 2;
            this.lblnum1.Text = "Num 1:";
            // 
            // cbooperaciones
            // 
            this.cbooperaciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbooperaciones.FormattingEnabled = true;
            this.cbooperaciones.Items.AddRange(new object[] {
            "Suma",
            "Resta",
            "Multiplicacion",
            "Division"});
            this.cbooperaciones.Location = new System.Drawing.Point(175, 52);
            this.cbooperaciones.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cbooperaciones.Name = "cbooperaciones";
            this.cbooperaciones.Size = new System.Drawing.Size(87, 21);
            this.cbooperaciones.TabIndex = 3;
            // 
            // lblnum2
            // 
            this.lblnum2.AutoSize = true;
            this.lblnum2.Location = new System.Drawing.Point(273, 53);
            this.lblnum2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblnum2.Name = "lblnum2";
            this.lblnum2.Size = new System.Drawing.Size(41, 13);
            this.lblnum2.TabIndex = 5;
            this.lblnum2.Text = "Num 2:";
            // 
            // txtnum2
            // 
            this.txtnum2.Location = new System.Drawing.Point(320, 53);
            this.txtnum2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(76, 20);
            this.txtnum2.TabIndex = 4;
            // 
            // lblrespuesta
            // 
            this.lblrespuesta.AutoSize = true;
            this.lblrespuesta.Location = new System.Drawing.Point(130, 108);
            this.lblrespuesta.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblrespuesta.Name = "lblrespuesta";
            this.lblrespuesta.Size = new System.Drawing.Size(70, 13);
            this.lblrespuesta.TabIndex = 6;
            this.lblrespuesta.Text = "Respuesta: ?";
            // 
            // lbltabla
            // 
            this.lbltabla.AutoSize = true;
            this.lbltabla.Location = new System.Drawing.Point(40, 177);
            this.lbltabla.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lbltabla.Name = "lbltabla";
            this.lbltabla.Size = new System.Drawing.Size(37, 13);
            this.lbltabla.TabIndex = 7;
            this.lbltabla.Text = "Tabla:";
            // 
            // cbotabla
            // 
            this.cbotabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbotabla.FormattingEnabled = true;
            this.cbotabla.Location = new System.Drawing.Point(87, 177);
            this.cbotabla.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.cbotabla.Name = "cbotabla";
            this.cbotabla.Size = new System.Drawing.Size(87, 21);
            this.cbotabla.TabIndex = 8;
            // 
            // btnTabla
            // 
            this.btnTabla.Location = new System.Drawing.Point(42, 221);
            this.btnTabla.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnTabla.Name = "btnTabla";
            this.btnTabla.Size = new System.Drawing.Size(90, 36);
            this.btnTabla.TabIndex = 9;
            this.btnTabla.Text = "Mostrar Tabla";
            this.btnTabla.UseVisualStyleBackColor = true;
            this.btnTabla.Click += new System.EventHandler(this.btnTabla_Click);
            // 
            // lblresp_tabla
            // 
            this.lblresp_tabla.AutoSize = true;
            this.lblresp_tabla.Location = new System.Drawing.Point(207, 177);
            this.lblresp_tabla.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.lblresp_tabla.Name = "lblresp_tabla";
            this.lblresp_tabla.Size = new System.Drawing.Size(70, 13);
            this.lblresp_tabla.TabIndex = 10;
            this.lblresp_tabla.Text = "Respuesta: ?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 278);
            this.Controls.Add(this.lblresp_tabla);
            this.Controls.Add(this.btnTabla);
            this.Controls.Add(this.cbotabla);
            this.Controls.Add(this.lbltabla);
            this.Controls.Add(this.lblrespuesta);
            this.Controls.Add(this.lblnum2);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.cbooperaciones);
            this.Controls.Add(this.lblnum1);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.btnCalcular);
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Form1";
            this.Text = "Calculadora Basica";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.Label lblnum1;
        private System.Windows.Forms.ComboBox cbooperaciones;
        private System.Windows.Forms.Label lblnum2;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.Label lblrespuesta;
        private System.Windows.Forms.Label lbltabla;
        private System.Windows.Forms.ComboBox cbotabla;
        private System.Windows.Forms.Button btnTabla;
        private System.Windows.Forms.Label lblresp_tabla;
    }
}

