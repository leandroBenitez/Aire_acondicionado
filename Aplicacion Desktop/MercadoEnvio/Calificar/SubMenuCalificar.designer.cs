namespace MercadoEnvio.Calificaciones
{
    partial class SubMenuCalificar
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
            this.button_calificar = new System.Windows.Forms.Button();
            this.button_informe_compra = new System.Windows.Forms.Button();
            this.button_volver = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_calificar
            // 
            this.button_calificar.Location = new System.Drawing.Point(47, 48);
            this.button_calificar.Name = "button_calificar";
            this.button_calificar.Size = new System.Drawing.Size(75, 23);
            this.button_calificar.TabIndex = 0;
            this.button_calificar.Text = "Calificar";
            this.button_calificar.UseVisualStyleBackColor = true;
            this.button_calificar.Click += new System.EventHandler(this.button_calificar_Click);
            // 
            // button_informe_compra
            // 
            this.button_informe_compra.Location = new System.Drawing.Point(34, 89);
            this.button_informe_compra.Name = "button_informe_compra";
            this.button_informe_compra.Size = new System.Drawing.Size(103, 31);
            this.button_informe_compra.TabIndex = 1;
            this.button_informe_compra.Text = "Informe Compras";
            this.button_informe_compra.UseVisualStyleBackColor = true;
            this.button_informe_compra.Click += new System.EventHandler(this.button_informe_Click);
            // 
            // button_volver
            // 
            this.button_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button_volver.ForeColor = System.Drawing.Color.Maroon;
            this.button_volver.Location = new System.Drawing.Point(47, 200);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 4;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(34, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Informe Subastas";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SubMenuCalificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 247);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.button_informe_compra);
            this.Controls.Add(this.button_calificar);
            this.Name = "SubMenuCalificar";
            this.Text = "SubMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_calificar;
        private System.Windows.Forms.Button button_informe_compra;
        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.Button button1;
    }
}