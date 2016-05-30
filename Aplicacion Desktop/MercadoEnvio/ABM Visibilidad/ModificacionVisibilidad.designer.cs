namespace MercadoEnvio.ABM_Visibilidad
{
    partial class ModificacionVisibilidad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.Seleccionar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPorcentaje = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textEnvio = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Seleccionar2 = new System.Windows.Forms.Button();
            this.textTipo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar\r\ntipo:";
            // 
            // Seleccionar
            // 
            this.Seleccionar.Location = new System.Drawing.Point(411, 193);
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.Size = new System.Drawing.Size(75, 23);
            this.Seleccionar.TabIndex = 2;
            this.Seleccionar.Text = "Buscar";
            this.Seleccionar.UseVisualStyleBackColor = true;
            this.Seleccionar.Click += new System.EventHandler(this.Seleccionar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingresar\r\nprecio:";
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(386, 107);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(100, 20);
            this.textPrecio.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingresar\r\nporcentaje:";
            // 
            // textPorcentaje
            // 
            this.textPorcentaje.Location = new System.Drawing.Point(108, 107);
            this.textPorcentaje.Name = "textPorcentaje";
            this.textPorcentaje.Size = new System.Drawing.Size(100, 20);
            this.textPorcentaje.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ingresar\r\nenvio:";
            // 
            // textEnvio
            // 
            this.textEnvio.Location = new System.Drawing.Point(386, 36);
            this.textEnvio.Name = "textEnvio";
            this.textEnvio.Size = new System.Drawing.Size(100, 20);
            this.textEnvio.TabIndex = 8;
            this.textEnvio.TextChanged += new System.EventHandler(this.textEnvio_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 266);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // Seleccionar2
            // 
            this.Seleccionar2.Location = new System.Drawing.Point(269, 266);
            this.Seleccionar2.Name = "Seleccionar2";
            this.Seleccionar2.Size = new System.Drawing.Size(75, 23);
            this.Seleccionar2.TabIndex = 10;
            this.Seleccionar2.Text = "Seleccionar";
            this.Seleccionar2.UseVisualStyleBackColor = true;
            this.Seleccionar2.Click += new System.EventHandler(this.Seleccionar2_Click);
            // 
            // textTipo
            // 
            this.textTipo.Location = new System.Drawing.Point(108, 36);
            this.textTipo.Name = "textTipo";
            this.textTipo.Size = new System.Drawing.Size(100, 20);
            this.textTipo.TabIndex = 11;
            // 
            // ModificacionVisibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 327);
            this.Controls.Add(this.textTipo);
            this.Controls.Add(this.Seleccionar2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textEnvio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textPorcentaje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Seleccionar);
            this.Controls.Add(this.label1);
            this.Name = "ModificacionVisibilidad";
            this.Text = "ModificacionVisibilidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Seleccionar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPorcentaje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textEnvio;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Seleccionar2;
        private System.Windows.Forms.TextBox textTipo;
    }
}