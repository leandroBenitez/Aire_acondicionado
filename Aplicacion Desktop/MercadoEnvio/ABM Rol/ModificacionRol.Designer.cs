namespace MercadoEnvio.ABMRol
{
    partial class ModificacionRol
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboNombresRoles = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.eliminarRol = new System.Windows.Forms.Button();
            this.agregarRol = new System.Windows.Forms.Button();
            this.checkedListBox2 = new System.Windows.Forms.CheckedListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonModificar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.radioButtonH = new System.Windows.Forms.RadioButton();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(195, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificacion de Rol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filtros de Busqueda";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // comboNombresRoles
            // 
            this.comboNombresRoles.FormattingEnabled = true;
            this.comboNombresRoles.Location = new System.Drawing.Point(80, 72);
            this.comboNombresRoles.Name = "comboNombresRoles";
            this.comboNombresRoles.Size = new System.Drawing.Size(154, 21);
            this.comboNombresRoles.TabIndex = 3;
            this.comboNombresRoles.SelectedIndexChanged += new System.EventHandler(this.comboNombresRoles_SelectedIndexChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.HorizontalScrollbar = true;
            this.checkedListBox1.Location = new System.Drawing.Point(22, 151);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.ScrollAlwaysVisible = true;
            this.checkedListBox1.Size = new System.Drawing.Size(201, 199);
            this.checkedListBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(190, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Agregar o Quitar Funcionalidades";
            // 
            // eliminarRol
            // 
            this.eliminarRol.BackColor = System.Drawing.Color.Red;
            this.eliminarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarRol.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.eliminarRol.Location = new System.Drawing.Point(234, 179);
            this.eliminarRol.Name = "eliminarRol";
            this.eliminarRol.Size = new System.Drawing.Size(111, 32);
            this.eliminarRol.TabIndex = 6;
            this.eliminarRol.Text = "Eliminar ---------->";
            this.eliminarRol.UseVisualStyleBackColor = false;
            this.eliminarRol.Click += new System.EventHandler(this.eliminarRol_Click);
            // 
            // agregarRol
            // 
            this.agregarRol.BackColor = System.Drawing.Color.Lime;
            this.agregarRol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarRol.Location = new System.Drawing.Point(234, 242);
            this.agregarRol.Name = "agregarRol";
            this.agregarRol.Size = new System.Drawing.Size(111, 32);
            this.agregarRol.TabIndex = 7;
            this.agregarRol.Text = "<---------- Agregar";
            this.agregarRol.UseVisualStyleBackColor = false;
            this.agregarRol.Click += new System.EventHandler(this.agregarRol_Click);
            // 
            // checkedListBox2
            // 
            this.checkedListBox2.FormattingEnabled = true;
            this.checkedListBox2.Location = new System.Drawing.Point(351, 151);
            this.checkedListBox2.Name = "checkedListBox2";
            this.checkedListBox2.Size = new System.Drawing.Size(201, 199);
            this.checkedListBox2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Funciones del Rol";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Funciones para agregar";
            // 
            // buttonModificar
            // 
            this.buttonModificar.Location = new System.Drawing.Point(468, 356);
            this.buttonModificar.Name = "buttonModificar";
            this.buttonModificar.Size = new System.Drawing.Size(84, 31);
            this.buttonModificar.TabIndex = 11;
            this.buttonModificar.Text = "Modificar";
            this.buttonModificar.UseVisualStyleBackColor = true;
            this.buttonModificar.Click += new System.EventHandler(this.buttonModificar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(326, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Estado:";
            // 
            // radioButtonH
            // 
            this.radioButtonH.AutoSize = true;
            this.radioButtonH.Location = new System.Drawing.Point(375, 76);
            this.radioButtonH.Name = "radioButtonH";
            this.radioButtonH.Size = new System.Drawing.Size(72, 17);
            this.radioButtonH.TabIndex = 15;
            this.radioButtonH.TabStop = true;
            this.radioButtonH.Text = "Habilitado";
            this.radioButtonH.UseVisualStyleBackColor = true;
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Location = new System.Drawing.Point(459, 76);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(84, 17);
            this.radioButtonD.TabIndex = 16;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "Dehabilitado";
            this.radioButtonD.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 28);
            this.button1.TabIndex = 17;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ModificacionRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 397);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButtonD);
            this.Controls.Add(this.radioButtonH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.buttonModificar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkedListBox2);
            this.Controls.Add(this.agregarRol);
            this.Controls.Add(this.eliminarRol);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.comboNombresRoles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ModificacionRol";
            this.Text = "ModificacionRol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboNombresRoles;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button eliminarRol;
        private System.Windows.Forms.Button agregarRol;
        private System.Windows.Forms.CheckedListBox checkedListBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonModificar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton radioButtonH;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.Button button1;
    }
}