namespace MercadoEnvio.ABM_Visibilidad
{
    partial class SubMenuVisibilidad
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
            this.button_alta = new System.Windows.Forms.Button();
            this.button_modificacion = new System.Windows.Forms.Button();
            this.button_baja = new System.Windows.Forms.Button();
            this.button_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_alta
            // 
            this.button_alta.Location = new System.Drawing.Point(39, 24);
            this.button_alta.Name = "button_alta";
            this.button_alta.Size = new System.Drawing.Size(132, 30);
            this.button_alta.TabIndex = 0;
            this.button_alta.Text = "Alta Visibilidad";
            this.button_alta.UseVisualStyleBackColor = true;
            this.button_alta.Click += new System.EventHandler(this.button_alta_Click);
            // 
            // button_modificacion
            // 
            this.button_modificacion.Location = new System.Drawing.Point(39, 72);
            this.button_modificacion.Name = "button_modificacion";
            this.button_modificacion.Size = new System.Drawing.Size(132, 53);
            this.button_modificacion.TabIndex = 1;
            this.button_modificacion.Text = "Modificacion\r\nVisibilidad";
            this.button_modificacion.UseVisualStyleBackColor = true;
            this.button_modificacion.Click += new System.EventHandler(this.button_modificacion_Click);
            // 
            // button_baja
            // 
            this.button_baja.Location = new System.Drawing.Point(39, 145);
            this.button_baja.Name = "button_baja";
            this.button_baja.Size = new System.Drawing.Size(132, 30);
            this.button_baja.TabIndex = 2;
            this.button_baja.Text = "Baja Visibilidad";
            this.button_baja.UseVisualStyleBackColor = true;
            this.button_baja.Click += new System.EventHandler(this.button_baja_Click);
            // 
            // button_volver
            // 
            this.button_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button_volver.ForeColor = System.Drawing.Color.Maroon;
            this.button_volver.Location = new System.Drawing.Point(64, 199);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 3;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // SubMenuVisibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 241);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.button_baja);
            this.Controls.Add(this.button_modificacion);
            this.Controls.Add(this.button_alta);
            this.Name = "SubMenuVisibilidad";
            this.Text = "Submenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_alta;
        private System.Windows.Forms.Button button_modificacion;
        private System.Windows.Forms.Button button_baja;
        private System.Windows.Forms.Button button_volver;
    }
}