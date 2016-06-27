namespace MercadoEnvio.Calificaciones
{
    partial class Calificar
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
            this.Calificacion_ComboBox = new System.Windows.Forms.ComboBox();
            this.Calificación = new System.Windows.Forms.Label();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.PruebaTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Calificacion_ComboBox
            // 
            this.Calificacion_ComboBox.FormattingEnabled = true;
            this.Calificacion_ComboBox.Location = new System.Drawing.Point(95, 124);
            this.Calificacion_ComboBox.Name = "Calificacion_ComboBox";
            this.Calificacion_ComboBox.Size = new System.Drawing.Size(121, 21);
            this.Calificacion_ComboBox.TabIndex = 0;
            // 
            // Calificación
            // 
            this.Calificación.AutoSize = true;
            this.Calificación.Location = new System.Drawing.Point(28, 127);
            this.Calificación.Name = "Calificación";
            this.Calificación.Size = new System.Drawing.Size(61, 13);
            this.Calificación.TabIndex = 1;
            this.Calificación.Text = "Puntuación";
            // 
            // AceptarButton
            // 
            this.AceptarButton.Location = new System.Drawing.Point(141, 183);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(75, 23);
            this.AceptarButton.TabIndex = 2;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // PruebaTextBox
            // 
            this.PruebaTextBox.Location = new System.Drawing.Point(141, 229);
            this.PruebaTextBox.Name = "PruebaTextBox";
            this.PruebaTextBox.Size = new System.Drawing.Size(100, 20);
            this.PruebaTextBox.TabIndex = 3;
            // 
            // Calificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.PruebaTextBox);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.Calificación);
            this.Controls.Add(this.Calificacion_ComboBox);
            this.Name = "Calificar";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Calificacion_ComboBox;
        private System.Windows.Forms.Label Calificación;
        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.TextBox PruebaTextBox;

    }
}