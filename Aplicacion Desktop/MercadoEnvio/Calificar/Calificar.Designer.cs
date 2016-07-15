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
            this.Calificación = new System.Windows.Forms.Label();
            this.AceptarButton = new System.Windows.Forms.Button();
            this.presentacion = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.label_descripcion = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_volver = new System.Windows.Forms.Button();
            this.combo_calificacion = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Calificación
            // 
            this.Calificación.AutoSize = true;
            this.Calificación.Location = new System.Drawing.Point(34, 77);
            this.Calificación.Name = "Calificación";
            this.Calificación.Size = new System.Drawing.Size(61, 13);
            this.Calificación.TabIndex = 1;
            this.Calificación.Text = "Puntuación";
            // 
            // AceptarButton
            // 
            this.AceptarButton.Location = new System.Drawing.Point(171, 184);
            this.AceptarButton.Name = "AceptarButton";
            this.AceptarButton.Size = new System.Drawing.Size(75, 23);
            this.AceptarButton.TabIndex = 2;
            this.AceptarButton.Text = "Aceptar";
            this.AceptarButton.UseVisualStyleBackColor = true;
            this.AceptarButton.Click += new System.EventHandler(this.AceptarButton_Click);
            // 
            // presentacion
            // 
            this.presentacion.AutoSize = true;
            this.presentacion.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentacion.ForeColor = System.Drawing.Color.Maroon;
            this.presentacion.Location = new System.Drawing.Point(63, 18);
            this.presentacion.Name = "presentacion";
            this.presentacion.Size = new System.Drawing.Size(90, 23);
            this.presentacion.TabIndex = 8;
            this.presentacion.Text = "Calificar a\r\n";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ForeColor = System.Drawing.Color.Maroon;
            this.labelUsuario.Location = new System.Drawing.Point(148, 18);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(23, 23);
            this.labelUsuario.TabIndex = 9;
            this.labelUsuario.Text = "id";
            // 
            // label_descripcion
            // 
            this.label_descripcion.AutoSize = true;
            this.label_descripcion.Location = new System.Drawing.Point(34, 127);
            this.label_descripcion.Name = "label_descripcion";
            this.label_descripcion.Size = new System.Drawing.Size(63, 13);
            this.label_descripcion.TabIndex = 10;
            this.label_descripcion.Text = "Descripción";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 124);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 20);
            this.textBox1.TabIndex = 11;
            // 
            // button_volver
            // 
            this.button_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button_volver.ForeColor = System.Drawing.Color.Maroon;
            this.button_volver.Location = new System.Drawing.Point(37, 184);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 12;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // combo_calificacion
            // 
            this.combo_calificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_calificacion.FormattingEnabled = true;
            this.combo_calificacion.Location = new System.Drawing.Point(125, 77);
            this.combo_calificacion.Name = "combo_calificacion";
            this.combo_calificacion.Size = new System.Drawing.Size(44, 21);
            this.combo_calificacion.TabIndex = 16;
            // 
            // Calificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.combo_calificacion);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label_descripcion);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.presentacion);
            this.Controls.Add(this.AceptarButton);
            this.Controls.Add(this.Calificación);
            this.Name = "Calificar";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Calificación;
        private System.Windows.Forms.Button AceptarButton;
        private System.Windows.Forms.Label presentacion;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label label_descripcion;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.ComboBox combo_calificacion;

    }
}