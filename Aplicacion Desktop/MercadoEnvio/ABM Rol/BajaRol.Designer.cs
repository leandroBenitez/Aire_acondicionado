namespace MercadoEnvio.ABMRol
{
    partial class bajaRol
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
            this.nombreRol = new System.Windows.Forms.Label();
            this.comboNombresRoles = new System.Windows.Forms.ComboBox();
            this.botonBaja = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "BAJA DE UN ROL";
            // 
            // nombreRol
            // 
            this.nombreRol.AutoSize = true;
            this.nombreRol.Location = new System.Drawing.Point(30, 60);
            this.nombreRol.Name = "nombreRol";
            this.nombreRol.Size = new System.Drawing.Size(47, 13);
            this.nombreRol.TabIndex = 1;
            this.nombreRol.Text = "Nombre:";
            // 
            // comboNombresRoles
            // 
            this.comboNombresRoles.FormattingEnabled = true;
            this.comboNombresRoles.Location = new System.Drawing.Point(83, 57);
            this.comboNombresRoles.Name = "comboNombresRoles";
            this.comboNombresRoles.Size = new System.Drawing.Size(228, 21);
            this.comboNombresRoles.TabIndex = 2;
            // 
            // botonBaja
            // 
            this.botonBaja.Location = new System.Drawing.Point(256, 105);
            this.botonBaja.Name = "botonBaja";
            this.botonBaja.Size = new System.Drawing.Size(55, 21);
            this.botonBaja.TabIndex = 3;
            this.botonBaja.Text = "Baja";
            this.botonBaja.UseVisualStyleBackColor = true;
            this.botonBaja.Click += new System.EventHandler(this.botonBaja_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 105);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 20);
            this.button1.TabIndex = 4;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bajaRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 143);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.botonBaja);
            this.Controls.Add(this.comboNombresRoles);
            this.Controls.Add(this.nombreRol);
            this.Controls.Add(this.label1);
            this.Name = "bajaRol";
            this.Text = "bajaRol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nombreRol;
        private System.Windows.Forms.ComboBox comboNombresRoles;
        private System.Windows.Forms.Button botonBaja;
        private System.Windows.Forms.Button button1;
    }
}