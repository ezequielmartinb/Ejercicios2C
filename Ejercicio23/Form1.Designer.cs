namespace Ejercicio23
{
    partial class FormularioConversor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioConversor));
            this.btn_LockCotizacion = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblCotizacion = new System.Windows.Forms.Label();
            this.lblPesoColumna = new System.Windows.Forms.Label();
            this.lblDolarColumna = new System.Windows.Forms.Label();
            this.lblEuroColumna = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDolar = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.txtEuro = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtDolar = new System.Windows.Forms.TextBox();
            this.btnPeso = new System.Windows.Forms.Button();
            this.btnDolar = new System.Windows.Forms.Button();
            this.btnEuro = new System.Windows.Forms.Button();
            this.txtDolarAEuro = new System.Windows.Forms.TextBox();
            this.txtEuroAEuro = new System.Windows.Forms.TextBox();
            this.txtCotizacionEuro = new System.Windows.Forms.TextBox();
            this.txtPesoAEuro = new System.Windows.Forms.TextBox();
            this.txtPesoADolar = new System.Windows.Forms.TextBox();
            this.txtEuroADolar = new System.Windows.Forms.TextBox();
            this.txtDolarADolar = new System.Windows.Forms.TextBox();
            this.txtPesoAPeso = new System.Windows.Forms.TextBox();
            this.txtEuroAPeso = new System.Windows.Forms.TextBox();
            this.txtDolarAPeso = new System.Windows.Forms.TextBox();
            this.txtCotizacionPeso = new System.Windows.Forms.TextBox();
            this.txtCotizacionDolar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_LockCotizacion
            // 
            this.btn_LockCotizacion.BackColor = System.Drawing.SystemColors.Control;
            this.btn_LockCotizacion.ImageIndex = 1;
            this.btn_LockCotizacion.ImageList = this.imageList1;
            this.btn_LockCotizacion.Location = new System.Drawing.Point(232, 112);
            this.btn_LockCotizacion.Name = "btn_LockCotizacion";
            this.btn_LockCotizacion.Size = new System.Drawing.Size(103, 30);
            this.btn_LockCotizacion.TabIndex = 0;
            this.btn_LockCotizacion.UseVisualStyleBackColor = false;
            this.btn_LockCotizacion.Click += new System.EventHandler(this.btn_LockCotizacion_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.SystemColors.ActiveCaption;
            this.imageList1.Images.SetKeyName(0, "internet_lock_locked_padlock_password_secure_security_icon_127078 (1).png");
            this.imageList1.Images.SetKeyName(1, "internet_locked_padlock_password_secure_security_unlock_icon_127083 (1).png");
            // 
            // lblCotizacion
            // 
            this.lblCotizacion.AutoSize = true;
            this.lblCotizacion.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCotizacion.Location = new System.Drawing.Point(84, 112);
            this.lblCotizacion.Name = "lblCotizacion";
            this.lblCotizacion.Size = new System.Drawing.Size(121, 30);
            this.lblCotizacion.TabIndex = 1;
            this.lblCotizacion.Text = "Cotización";
            // 
            // lblPesoColumna
            // 
            this.lblPesoColumna.AutoSize = true;
            this.lblPesoColumna.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPesoColumna.Location = new System.Drawing.Point(669, 150);
            this.lblPesoColumna.Name = "lblPesoColumna";
            this.lblPesoColumna.Size = new System.Drawing.Size(61, 30);
            this.lblPesoColumna.TabIndex = 3;
            this.lblPesoColumna.Text = "Peso";
            // 
            // lblDolarColumna
            // 
            this.lblDolarColumna.AutoSize = true;
            this.lblDolarColumna.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDolarColumna.Location = new System.Drawing.Point(529, 150);
            this.lblDolarColumna.Name = "lblDolarColumna";
            this.lblDolarColumna.Size = new System.Drawing.Size(69, 30);
            this.lblDolarColumna.TabIndex = 4;
            this.lblDolarColumna.Text = "Dólar";
            // 
            // lblEuroColumna
            // 
            this.lblEuroColumna.AutoSize = true;
            this.lblEuroColumna.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEuroColumna.Location = new System.Drawing.Point(396, 151);
            this.lblEuroColumna.Name = "lblEuroColumna";
            this.lblEuroColumna.Size = new System.Drawing.Size(60, 30);
            this.lblEuroColumna.TabIndex = 5;
            this.lblEuroColumna.Text = "Euro";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 30);
            this.label5.TabIndex = 6;
            this.label5.Text = "Peso";
            // 
            // lblDolar
            // 
            this.lblDolar.AutoSize = true;
            this.lblDolar.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDolar.Location = new System.Drawing.Point(12, 210);
            this.lblDolar.Name = "lblDolar";
            this.lblDolar.Size = new System.Drawing.Size(69, 30);
            this.lblDolar.TabIndex = 7;
            this.lblDolar.Text = "Dólar";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEuro.Location = new System.Drawing.Point(12, 180);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(60, 30);
            this.lblEuro.TabIndex = 8;
            this.lblEuro.Text = "Euro";
            // 
            // txtEuro
            // 
            this.txtEuro.Location = new System.Drawing.Point(87, 187);
            this.txtEuro.Name = "txtEuro";
            this.txtEuro.Size = new System.Drawing.Size(127, 23);
            this.txtEuro.TabIndex = 9;
            // 
            // txtPeso
            // 
            this.txtPeso.Location = new System.Drawing.Point(87, 245);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(127, 23);
            this.txtPeso.TabIndex = 10;
            // 
            // txtDolar
            // 
            this.txtDolar.Location = new System.Drawing.Point(87, 216);
            this.txtDolar.Name = "txtDolar";
            this.txtDolar.Size = new System.Drawing.Size(127, 23);
            this.txtDolar.TabIndex = 11;
            // 
            // btnPeso
            // 
            this.btnPeso.Location = new System.Drawing.Point(232, 245);
            this.btnPeso.Name = "btnPeso";
            this.btnPeso.Size = new System.Drawing.Size(103, 23);
            this.btnPeso.TabIndex = 14;
            this.btnPeso.Text = "->";
            this.btnPeso.UseVisualStyleBackColor = true;
            this.btnPeso.Click += new System.EventHandler(this.btnPeso_Click);
            // 
            // btnDolar
            // 
            this.btnDolar.Location = new System.Drawing.Point(232, 214);
            this.btnDolar.Name = "btnDolar";
            this.btnDolar.Size = new System.Drawing.Size(103, 23);
            this.btnDolar.TabIndex = 15;
            this.btnDolar.Text = "->";
            this.btnDolar.UseVisualStyleBackColor = true;
            this.btnDolar.Click += new System.EventHandler(this.btnDolar_Click);
            // 
            // btnEuro
            // 
            this.btnEuro.Location = new System.Drawing.Point(232, 185);
            this.btnEuro.Name = "btnEuro";
            this.btnEuro.Size = new System.Drawing.Size(103, 23);
            this.btnEuro.TabIndex = 16;
            this.btnEuro.Text = "->";
            this.btnEuro.UseVisualStyleBackColor = true;
            this.btnEuro.Click += new System.EventHandler(this.btnEuro_Click);
            // 
            // txtDolarAEuro
            // 
            this.txtDolarAEuro.Location = new System.Drawing.Point(359, 216);
            this.txtDolarAEuro.Name = "txtDolarAEuro";
            this.txtDolarAEuro.Size = new System.Drawing.Size(127, 23);
            this.txtDolarAEuro.TabIndex = 17;
            // 
            // txtEuroAEuro
            // 
            this.txtEuroAEuro.Location = new System.Drawing.Point(359, 184);
            this.txtEuroAEuro.Name = "txtEuroAEuro";
            this.txtEuroAEuro.Size = new System.Drawing.Size(127, 23);
            this.txtEuroAEuro.TabIndex = 18;
            // 
            // txtCotizacionEuro
            // 
            this.txtCotizacionEuro.Location = new System.Drawing.Point(359, 112);
            this.txtCotizacionEuro.Name = "txtCotizacionEuro";
            this.txtCotizacionEuro.ShortcutsEnabled = false;
            this.txtCotizacionEuro.Size = new System.Drawing.Size(127, 23);
            this.txtCotizacionEuro.TabIndex = 19;
            // 
            // txtPesoAEuro
            // 
            this.txtPesoAEuro.Location = new System.Drawing.Point(359, 246);
            this.txtPesoAEuro.Name = "txtPesoAEuro";
            this.txtPesoAEuro.Size = new System.Drawing.Size(127, 23);
            this.txtPesoAEuro.TabIndex = 20;
            // 
            // txtPesoADolar
            // 
            this.txtPesoADolar.Location = new System.Drawing.Point(498, 246);
            this.txtPesoADolar.Name = "txtPesoADolar";
            this.txtPesoADolar.Size = new System.Drawing.Size(127, 23);
            this.txtPesoADolar.TabIndex = 23;
            // 
            // txtEuroADolar
            // 
            this.txtEuroADolar.Location = new System.Drawing.Point(498, 184);
            this.txtEuroADolar.Name = "txtEuroADolar";
            this.txtEuroADolar.Size = new System.Drawing.Size(127, 23);
            this.txtEuroADolar.TabIndex = 22;
            // 
            // txtDolarADolar
            // 
            this.txtDolarADolar.Location = new System.Drawing.Point(498, 216);
            this.txtDolarADolar.Name = "txtDolarADolar";
            this.txtDolarADolar.Size = new System.Drawing.Size(127, 23);
            this.txtDolarADolar.TabIndex = 21;
            // 
            // txtPesoAPeso
            // 
            this.txtPesoAPeso.Location = new System.Drawing.Point(636, 245);
            this.txtPesoAPeso.Name = "txtPesoAPeso";
            this.txtPesoAPeso.Size = new System.Drawing.Size(127, 23);
            this.txtPesoAPeso.TabIndex = 26;
            // 
            // txtEuroAPeso
            // 
            this.txtEuroAPeso.Location = new System.Drawing.Point(636, 183);
            this.txtEuroAPeso.Name = "txtEuroAPeso";
            this.txtEuroAPeso.Size = new System.Drawing.Size(127, 23);
            this.txtEuroAPeso.TabIndex = 25;
            // 
            // txtDolarAPeso
            // 
            this.txtDolarAPeso.Location = new System.Drawing.Point(636, 215);
            this.txtDolarAPeso.Name = "txtDolarAPeso";
            this.txtDolarAPeso.Size = new System.Drawing.Size(127, 23);
            this.txtDolarAPeso.TabIndex = 24;
            // 
            // txtCotizacionPeso
            // 
            this.txtCotizacionPeso.Location = new System.Drawing.Point(636, 112);
            this.txtCotizacionPeso.Name = "txtCotizacionPeso";
            this.txtCotizacionPeso.Size = new System.Drawing.Size(127, 23);
            this.txtCotizacionPeso.TabIndex = 27;
            // 
            // txtCotizacionDolar
            // 
            this.txtCotizacionDolar.Location = new System.Drawing.Point(498, 112);
            this.txtCotizacionDolar.Name = "txtCotizacionDolar";
            this.txtCotizacionDolar.Size = new System.Drawing.Size(127, 23);
            this.txtCotizacionDolar.TabIndex = 28;
            // 
            // FormularioConversor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCotizacionDolar);
            this.Controls.Add(this.txtCotizacionPeso);
            this.Controls.Add(this.txtPesoAPeso);
            this.Controls.Add(this.txtEuroAPeso);
            this.Controls.Add(this.txtDolarAPeso);
            this.Controls.Add(this.txtPesoADolar);
            this.Controls.Add(this.txtEuroADolar);
            this.Controls.Add(this.txtDolarADolar);
            this.Controls.Add(this.txtPesoAEuro);
            this.Controls.Add(this.txtCotizacionEuro);
            this.Controls.Add(this.txtEuroAEuro);
            this.Controls.Add(this.txtDolarAEuro);
            this.Controls.Add(this.btnEuro);
            this.Controls.Add(this.btnDolar);
            this.Controls.Add(this.btnPeso);
            this.Controls.Add(this.txtDolar);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtEuro);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblDolar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblEuroColumna);
            this.Controls.Add(this.lblDolarColumna);
            this.Controls.Add(this.lblPesoColumna);
            this.Controls.Add(this.lblCotizacion);
            this.Controls.Add(this.btn_LockCotizacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormularioConversor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btn_LockCotizacion;
        private ImageList imageList1;
        private Label lblCotizacion;
        private Label lblPesoColumna;
        private Label lblDolarColumna;
        private Label lblEuroColumna;
        private Label label5;
        private Label lblDolar;
        private Label lblEuro;
        private TextBox txtEuro;
        private TextBox txtPeso;
        private TextBox txtDolar;
        private Button btnPeso;
        private Button btnDolar;
        private Button btnEuro;
        private TextBox txtDolarAEuro;
        private TextBox txtEuroAEuro;
        private TextBox txtCotizacionEuro;
        private TextBox txtPesoAEuro;
        private TextBox txtPesoADolar;
        private TextBox txtEuroADolar;
        private TextBox txtDolarADolar;
        private TextBox txtPesoAPeso;
        private TextBox txtEuroAPeso;
        private TextBox txtDolarAPeso;
        private TextBox txtCotizacionPeso;
        private TextBox txtCotizacionDolar;
    }
}