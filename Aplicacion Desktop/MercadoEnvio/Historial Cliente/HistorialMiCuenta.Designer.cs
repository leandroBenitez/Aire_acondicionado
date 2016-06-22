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
            this.MostrarComprasCalificadas = new System.Windows.Forms.Button();
            this.MostrarComprasSinCalificar = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MostrarFacturacion
            // 
            this.MostrarFacturacion.Location = new System.Drawing.Point(87, 38);
            this.MostrarFacturacion.Name = "MostrarFacturacion";
            this.MostrarFacturacion.Size = new System.Drawing.Size(117, 23);
            this.MostrarFacturacion.TabIndex = 0;
            this.MostrarFacturacion.Text = "Facturación";
            this.MostrarFacturacion.UseVisualStyleBackColor = true;
            this.MostrarFacturacion.Click += new System.EventHandler(this.MostrarFacturacion_Click);
            // 
            // MostrarCompras
            // 
            this.MostrarCompras.Location = new System.Drawing.Point(87, 67);
            this.MostrarCompras.Name = "MostrarCompras";
            this.MostrarCompras.Size = new System.Drawing.Size(117, 23);
            this.MostrarCompras.TabIndex = 2;
            this.MostrarCompras.Text = "Compras";
            this.MostrarCompras.UseVisualStyleBackColor = true;
            this.MostrarCompras.Click += new System.EventHandler(this.MostrarCompras_Click);
            // 
            // MostrarSubastas
            // 
            this.MostrarSubastas.Location = new System.Drawing.Point(87, 154);
            this.MostrarSubastas.Name = "MostrarSubastas";
            this.MostrarSubastas.Size = new System.Drawing.Size(117, 23);
            this.MostrarSubastas.TabIndex = 3;
            this.MostrarSubastas.Text = "Subastas";
            this.MostrarSubastas.UseVisualStyleBackColor = true;
            this.MostrarSubastas.Click += new System.EventHandler(this.MostrarSubastas_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(87, 183);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(117, 23);
            this.buttonVolver.TabIndex = 4;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // MostrarComprasCalificadas
            // 
            this.MostrarComprasCalificadas.Location = new System.Drawing.Point(87, 96);
            this.MostrarComprasCalificadas.Name = "MostrarComprasCalificadas";
            this.MostrarComprasCalificadas.Size = new System.Drawing.Size(117, 23);
            this.MostrarComprasCalificadas.TabIndex = 5;
            this.MostrarComprasCalificadas.Text = "Compras calificadas";
            this.MostrarComprasCalificadas.UseVisualStyleBackColor = true;
            this.MostrarComprasCalificadas.Click += new System.EventHandler(this.MostrarComprasCalificadas_Click);
            // 
            // MostrarComprasSinCalificar
            // 
            this.MostrarComprasSinCalificar.Location = new System.Drawing.Point(87, 125);
            this.MostrarComprasSinCalificar.Name = "MostrarComprasSinCalificar";
            this.MostrarComprasSinCalificar.Size = new System.Drawing.Size(117, 23);
            this.MostrarComprasSinCalificar.TabIndex = 6;
            this.MostrarComprasSinCalificar.Text = "Compras sin calificar";
            this.MostrarComprasSinCalificar.UseVisualStyleBackColor = true;
            this.MostrarComprasSinCalificar.Click += new System.EventHandler(this.MostrarComprasSinCalificar_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.Color.Crimson;
            this.buttonSalir.Location = new System.Drawing.Point(87, 214);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(119, 23);
            this.buttonSalir.TabIndex = 7;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // HistorialMiCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.MostrarComprasSinCalificar);
            this.Controls.Add(this.MostrarComprasCalificadas);
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
        private System.Windows.Forms.Button MostrarComprasCalificadas;
        private System.Windows.Forms.Button MostrarComprasSinCalificar;
        private System.Windows.Forms.Button buttonSalir;

    }
}