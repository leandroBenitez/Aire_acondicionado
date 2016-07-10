namespace MercadoEnvio.Generar_Publicación
{
    partial class TipoDePubli
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
            this.boton_compra = new System.Windows.Forms.Button();
            this.boton_subasta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.boton_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boton_compra
            // 
            this.boton_compra.Location = new System.Drawing.Point(58, 52);
            this.boton_compra.Name = "boton_compra";
            this.boton_compra.Size = new System.Drawing.Size(154, 29);
            this.boton_compra.TabIndex = 1;
            this.boton_compra.Text = "Compra";
            this.boton_compra.UseVisualStyleBackColor = true;
            this.boton_compra.Click += new System.EventHandler(this.boton_compra_Click);
            // 
            // boton_subasta
            // 
            this.boton_subasta.Location = new System.Drawing.Point(58, 87);
            this.boton_subasta.Name = "boton_subasta";
            this.boton_subasta.Size = new System.Drawing.Size(154, 29);
            this.boton_subasta.TabIndex = 2;
            this.boton_subasta.Text = "Subasta";
            this.boton_subasta.UseVisualStyleBackColor = true;
            this.boton_subasta.Click += new System.EventHandler(this.boton_subasta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Seleccione un tipo de publicación:";
            // 
            // boton_salir
            // 
            this.boton_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_salir.ForeColor = System.Drawing.Color.Red;
            this.boton_salir.Location = new System.Drawing.Point(177, 134);
            this.boton_salir.Name = "boton_salir";
            this.boton_salir.Size = new System.Drawing.Size(77, 23);
            this.boton_salir.TabIndex = 3;
            this.boton_salir.Text = "Cancelar";
            this.boton_salir.UseVisualStyleBackColor = true;
            this.boton_salir.Click += new System.EventHandler(this.boton_salir_Click);
            // 
            // TipoDePubli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 169);
            this.Controls.Add(this.boton_salir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boton_subasta);
            this.Controls.Add(this.boton_compra);
            this.Name = "TipoDePubli";
            this.Text = "Tipo de Publicación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button boton_compra;
        private System.Windows.Forms.Button boton_subasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boton_salir;
    }
}