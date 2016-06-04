namespace MercadoEnvio.Historial_Cliente
{
    partial class HistorialMiCuenta
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
            this.MostrarFacturacion = new System.Windows.Forms.Button();
            this.MostrarCompras = new System.Windows.Forms.Button();
            this.MostrarSubastas = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.MostrarEstrellasOtorgadas = new System.Windows.Forms.Button();
            this.MostrarEstrellasPorOtorgar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MostrarFacturacion
            // 
            this.MostrarFacturacion.Location = new System.Drawing.Point(87, 48);
            this.MostrarFacturacion.Name = "MostrarFacturacion";
            this.MostrarFacturacion.Size = new System.Drawing.Size(117, 23);
            this.MostrarFacturacion.TabIndex = 0;
            this.MostrarFacturacion.Text = "Facturación";
            this.MostrarFacturacion.UseVisualStyleBackColor = true;
            this.MostrarFacturacion.Click += new System.EventHandler(this.MostrarFacturacion_Click);
            // 
            // MostrarCompras
            // 
            this.MostrarCompras.Location = new System.Drawing.Point(87, 135);
            this.MostrarCompras.Name = "MostrarCompras";
            this.MostrarCompras.Size = new System.Drawing.Size(117, 23);
            this.MostrarCompras.TabIndex = 2;
            this.MostrarCompras.Text = "Compras";
            this.MostrarCompras.UseVisualStyleBackColor = true;
            this.MostrarCompras.Click += new System.EventHandler(this.MostrarCompras_Click);
            // 
            // MostrarSubastas
            // 
            this.MostrarSubastas.Location = new System.Drawing.Point(87, 164);
            this.MostrarSubastas.Name = "MostrarSubastas";
            this.MostrarSubastas.Size = new System.Drawing.Size(117, 23);
            this.MostrarSubastas.TabIndex = 3;
            this.MostrarSubastas.Text = "Subastas";
            this.MostrarSubastas.UseVisualStyleBackColor = true;
            this.MostrarSubastas.Click += new System.EventHandler(this.MostrarSubastas_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(87, 193);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(117, 23);
            this.buttonVolver.TabIndex = 4;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // MostrarEstrellasOtorgadas
            // 
            this.MostrarEstrellasOtorgadas.Location = new System.Drawing.Point(87, 77);
            this.MostrarEstrellasOtorgadas.Name = "MostrarEstrellasOtorgadas";
            this.MostrarEstrellasOtorgadas.Size = new System.Drawing.Size(117, 23);
            this.MostrarEstrellasOtorgadas.TabIndex = 5;
            this.MostrarEstrellasOtorgadas.Text = "Estrellas otorgadas";
            this.MostrarEstrellasOtorgadas.UseVisualStyleBackColor = true;
            this.MostrarEstrellasOtorgadas.Click += new System.EventHandler(this.MostrarEstrellasOtorgadas_Click);
            // 
            // MostrarEstrellasPorOtorgar
            // 
            this.MostrarEstrellasPorOtorgar.Location = new System.Drawing.Point(87, 106);
            this.MostrarEstrellasPorOtorgar.Name = "MostrarEstrellasPorOtorgar";
            this.MostrarEstrellasPorOtorgar.Size = new System.Drawing.Size(117, 23);
            this.MostrarEstrellasPorOtorgar.TabIndex = 6;
            this.MostrarEstrellasPorOtorgar.Text = "Estrellas por otorgar";
            this.MostrarEstrellasPorOtorgar.UseVisualStyleBackColor = true;
            this.MostrarEstrellasPorOtorgar.Click += new System.EventHandler(this.MostrarEstrellasPorOtorgar_Click);
            // 
            // HistorialMiCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.MostrarEstrellasPorOtorgar);
            this.Controls.Add(this.MostrarEstrellasOtorgadas);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.MostrarSubastas);
            this.Controls.Add(this.MostrarCompras);
            this.Controls.Add(this.MostrarFacturacion);
            this.Name = "HistorialMiCuenta";
            this.Text = "Mi cuenta";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button MostrarFacturacion;
        private System.Windows.Forms.Button MostrarCompras;
        private System.Windows.Forms.Button MostrarSubastas;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button MostrarEstrellasOtorgadas;
        private System.Windows.Forms.Button MostrarEstrellasPorOtorgar;

    }
}