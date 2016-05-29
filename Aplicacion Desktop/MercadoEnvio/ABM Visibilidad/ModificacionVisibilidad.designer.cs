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
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.SeleccionarClick = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionar tipo";
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(121, 42);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(121, 21);
            this.comboTipo.TabIndex = 1;
            // 
            // SeleccionarClick
            // 
            this.SeleccionarClick.Location = new System.Drawing.Point(167, 110);
            this.SeleccionarClick.Name = "SeleccionarClick";
            this.SeleccionarClick.Size = new System.Drawing.Size(75, 23);
            this.SeleccionarClick.TabIndex = 2;
            this.SeleccionarClick.Text = "Seleccionar";
            this.SeleccionarClick.UseVisualStyleBackColor = true;
            this.SeleccionarClick.Click += new System.EventHandler(this.SeleccionarClick_Click);
            // 
            // ModificacionVisibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.SeleccionarClick);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.label1);
            this.Name = "ModificacionVisibilidad";
            this.Text = "ModificacionVisibilidad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.Button SeleccionarClick;
    }
}