﻿namespace ConversorEnUNO
{
    partial class frmCon
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
            this.BtnMon = new System.Windows.Forms.Button();
            this.BtnLong = new System.Windows.Forms.Button();
            this.btnPeso = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboAMon = new System.Windows.Forms.ComboBox();
            this.lblRespMo = new System.Windows.Forms.Label();
            this.txtmon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboALong = new System.Windows.Forms.ComboBox();
            this.lblRespLong = new System.Windows.Forms.Label();
            this.btnTemp = new System.Windows.Forms.Button();
            this.lblRespPeso = new System.Windows.Forms.Label();
            this.lblRespTemp = new System.Windows.Forms.Label();
            this.txtlong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboAPes = new System.Windows.Forms.ComboBox();
            this.cboATemp = new System.Windows.Forms.ComboBox();
            this.cboDeMon = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDeLong = new System.Windows.Forms.ComboBox();
            this.cboDePes = new System.Windows.Forms.ComboBox();
            this.cboDeTemp = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BtnMon
            // 
            this.BtnMon.Location = new System.Drawing.Point(489, 25);
            this.BtnMon.Name = "BtnMon";
            this.BtnMon.Size = new System.Drawing.Size(124, 23);
            this.BtnMon.TabIndex = 0;
            this.BtnMon.Text = "Convertir Moneda";
            this.BtnMon.UseVisualStyleBackColor = true;
            this.BtnMon.Click += new System.EventHandler(this.BtnMon_Click);
            // 
            // BtnLong
            // 
            this.BtnLong.Location = new System.Drawing.Point(489, 73);
            this.BtnLong.Name = "BtnLong";
            this.BtnLong.Size = new System.Drawing.Size(124, 23);
            this.BtnLong.TabIndex = 1;
            this.BtnLong.Text = "Convertir Longitud";
            this.BtnLong.UseVisualStyleBackColor = true;
            this.BtnLong.Click += new System.EventHandler(this.BtnLong_Click);
            // 
            // btnPeso
            // 
            this.btnPeso.Location = new System.Drawing.Point(489, 122);
            this.btnPeso.Name = "btnPeso";
            this.btnPeso.Size = new System.Drawing.Size(124, 23);
            this.btnPeso.TabIndex = 2;
            this.btnPeso.Text = "Convertir Peso";
            this.btnPeso.UseVisualStyleBackColor = true;
            this.btnPeso.Click += new System.EventHandler(this.btnPeso_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cboAMon
            // 
            this.cboAMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAMon.FormattingEnabled = true;
            this.cboAMon.Items.AddRange(new object[] {
            "Dolar",
            "Euro",
            "Quetzal",
            "Lempira",
            "Cordoba",
            "Peso CR",
            "Colón SV"});
            this.cboAMon.Location = new System.Drawing.Point(352, 27);
            this.cboAMon.Name = "cboAMon";
            this.cboAMon.Size = new System.Drawing.Size(121, 21);
            this.cboAMon.TabIndex = 5;
            // 
            // lblRespMo
            // 
            this.lblRespMo.AutoSize = true;
            this.lblRespMo.Location = new System.Drawing.Point(619, 29);
            this.lblRespMo.Name = "lblRespMo";
            this.lblRespMo.Size = new System.Drawing.Size(70, 13);
            this.lblRespMo.TabIndex = 6;
            this.lblRespMo.Text = "Respuesta: ?";
            // 
            // txtmon
            // 
            this.txtmon.Location = new System.Drawing.Point(82, 31);
            this.txtmon.Name = "txtmon";
            this.txtmon.Size = new System.Drawing.Size(100, 20);
            this.txtmon.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "A";
            // 
            // cboALong
            // 
            this.cboALong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboALong.FormattingEnabled = true;
            this.cboALong.Items.AddRange(new object[] {
            "Metro",
            "Cm",
            "Pulg",
            "Yardas",
            "Varas",
            "Pies",
            "KMS",
            "Millas"});
            this.cboALong.Location = new System.Drawing.Point(352, 75);
            this.cboALong.Name = "cboALong";
            this.cboALong.Size = new System.Drawing.Size(121, 21);
            this.cboALong.TabIndex = 11;
            // 
            // lblRespLong
            // 
            this.lblRespLong.AutoSize = true;
            this.lblRespLong.Location = new System.Drawing.Point(619, 75);
            this.lblRespLong.Name = "lblRespLong";
            this.lblRespLong.Size = new System.Drawing.Size(70, 13);
            this.lblRespLong.TabIndex = 12;
            this.lblRespLong.Text = "Respuesta: ?";
            // 
            // btnTemp
            // 
            this.btnTemp.Location = new System.Drawing.Point(489, 162);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(124, 23);
            this.btnTemp.TabIndex = 13;
            this.btnTemp.Text = "Convertir Temperatura";
            this.btnTemp.UseVisualStyleBackColor = true;
            this.btnTemp.Click += new System.EventHandler(this.btnTemp_Click);
            // 
            // lblRespPeso
            // 
            this.lblRespPeso.AutoSize = true;
            this.lblRespPeso.Location = new System.Drawing.Point(619, 127);
            this.lblRespPeso.Name = "lblRespPeso";
            this.lblRespPeso.Size = new System.Drawing.Size(70, 13);
            this.lblRespPeso.TabIndex = 14;
            this.lblRespPeso.Text = "Respuesta: ?";
            // 
            // lblRespTemp
            // 
            this.lblRespTemp.AutoSize = true;
            this.lblRespTemp.Location = new System.Drawing.Point(619, 167);
            this.lblRespTemp.Name = "lblRespTemp";
            this.lblRespTemp.Size = new System.Drawing.Size(70, 13);
            this.lblRespTemp.TabIndex = 15;
            this.lblRespTemp.Text = "Respuesta: ?";
            // 
            // txtlong
            // 
            this.txtlong.Location = new System.Drawing.Point(82, 76);
            this.txtlong.Name = "txtlong";
            this.txtlong.Size = new System.Drawing.Size(100, 20);
            this.txtlong.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cantidad:";
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(82, 127);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(100, 20);
            this.txtpeso.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Cantidad:";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(82, 167);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(100, 20);
            this.txtTemp.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Cantidad:";
            // 
            // cboAPes
            // 
            this.cboAPes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAPes.FormattingEnabled = true;
            this.cboAPes.Items.AddRange(new object[] {
            "Gramos",
            "ML",
            "Onzas",
            "KG",
            "Libras",
            "Quitales"});
            this.cboAPes.Location = new System.Drawing.Point(352, 124);
            this.cboAPes.Name = "cboAPes";
            this.cboAPes.Size = new System.Drawing.Size(121, 21);
            this.cboAPes.TabIndex = 23;
            // 
            // cboATemp
            // 
            this.cboATemp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboATemp.FormattingEnabled = true;
            this.cboATemp.Items.AddRange(new object[] {
            "Celcius",
            "Farenheit",
            "Kelvin"});
            this.cboATemp.Location = new System.Drawing.Point(352, 164);
            this.cboATemp.Name = "cboATemp";
            this.cboATemp.Size = new System.Drawing.Size(121, 21);
            this.cboATemp.TabIndex = 25;
            // 
            // cboDeMon
            // 
            this.cboDeMon.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeMon.FormattingEnabled = true;
            this.cboDeMon.Items.AddRange(new object[] {
            "Dolar",
            "Euro",
            "Quetzal",
            "Lempira",
            "Cordoba",
            "Peso CR",
            "Colón SV",
            ""});
            this.cboDeMon.Location = new System.Drawing.Point(207, 29);
            this.cboDeMon.Name = "cboDeMon";
            this.cboDeMon.Size = new System.Drawing.Size(121, 21);
            this.cboDeMon.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(249, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "De";
            // 
            // cboDeLong
            // 
            this.cboDeLong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeLong.FormattingEnabled = true;
            this.cboDeLong.Items.AddRange(new object[] {
            "Metro",
            "Cm",
            "Pulg",
            "Yardas",
            "Varas",
            "Pies",
            "KMS",
            "Millas"});
            this.cboDeLong.Location = new System.Drawing.Point(207, 75);
            this.cboDeLong.Name = "cboDeLong";
            this.cboDeLong.Size = new System.Drawing.Size(121, 21);
            this.cboDeLong.TabIndex = 10;
            // 
            // cboDePes
            // 
            this.cboDePes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDePes.FormattingEnabled = true;
            this.cboDePes.Items.AddRange(new object[] {
            "Gramos",
            "ML",
            "Onzas",
            "KG",
            "Libras",
            "Quitales"});
            this.cboDePes.Location = new System.Drawing.Point(207, 124);
            this.cboDePes.Name = "cboDePes";
            this.cboDePes.Size = new System.Drawing.Size(121, 21);
            this.cboDePes.TabIndex = 22;
            // 
            // cboDeTemp
            // 
            this.cboDeTemp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDeTemp.FormattingEnabled = true;
            this.cboDeTemp.Items.AddRange(new object[] {
            "Celcius",
            "Farenheit",
            "Kelvin"});
            this.cboDeTemp.Location = new System.Drawing.Point(207, 162);
            this.cboDeTemp.Name = "cboDeTemp";
            this.cboDeTemp.Size = new System.Drawing.Size(121, 21);
            this.cboDeTemp.TabIndex = 24;
            // 
            // frmCon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(819, 279);
            this.Controls.Add(this.cboATemp);
            this.Controls.Add(this.cboDeTemp);
            this.Controls.Add(this.cboAPes);
            this.Controls.Add(this.cboDePes);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtlong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRespTemp);
            this.Controls.Add(this.lblRespPeso);
            this.Controls.Add(this.btnTemp);
            this.Controls.Add(this.lblRespLong);
            this.Controls.Add(this.cboALong);
            this.Controls.Add(this.cboDeLong);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmon);
            this.Controls.Add(this.lblRespMo);
            this.Controls.Add(this.cboAMon);
            this.Controls.Add(this.cboDeMon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPeso);
            this.Controls.Add(this.BtnLong);
            this.Controls.Add(this.BtnMon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCon";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnMon;
        private System.Windows.Forms.Button BtnLong;
        private System.Windows.Forms.Button btnPeso;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboAMon;
        private System.Windows.Forms.Label lblRespMo;
        private System.Windows.Forms.TextBox txtmon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboALong;
        private System.Windows.Forms.Label lblRespLong;
        private System.Windows.Forms.Button btnTemp;
        private System.Windows.Forms.Label lblRespPeso;
        private System.Windows.Forms.Label lblRespTemp;
        private System.Windows.Forms.TextBox txtlong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboAPes;
        private System.Windows.Forms.ComboBox cboATemp;
        private System.Windows.Forms.ComboBox cboDeMon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDeLong;
        private System.Windows.Forms.ComboBox cboDePes;
        private System.Windows.Forms.ComboBox cboDeTemp;
    }
}

