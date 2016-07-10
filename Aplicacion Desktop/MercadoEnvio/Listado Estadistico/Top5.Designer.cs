namespace MercadoEnvio.Listado_Estadistico
{
    partial class Top5
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxTop5 = new System.Windows.Forms.ComboBox();
            this.comboBoxTrimestre = new System.Windows.Forms.ComboBox();
            this.textBoxAñoTop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewTop5 = new System.Windows.Forms.DataGridView();
            this.buttonSeleccionar = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.Col_nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_MontoCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTop5)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTop5
            // 
            this.comboBoxTop5.FormattingEnabled = true;
            this.comboBoxTop5.Location = new System.Drawing.Point(81, 69);
            this.comboBoxTop5.Name = "comboBoxTop5";
            this.comboBoxTop5.Size = new System.Drawing.Size(387, 21);
            this.comboBoxTop5.TabIndex = 0;
            this.comboBoxTop5.SelectedIndexChanged += new System.EventHandler(this.comboBoxTop5_SelectedIndexChanged);
            // 
            // comboBoxTrimestre
            // 
            this.comboBoxTrimestre.FormattingEnabled = true;
            this.comboBoxTrimestre.Location = new System.Drawing.Point(347, 28);
            this.comboBoxTrimestre.Name = "comboBoxTrimestre";
            this.comboBoxTrimestre.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTrimestre.TabIndex = 1;
            this.comboBoxTrimestre.SelectedIndexChanged += new System.EventHandler(this.comboBoxTrimestre_SelectedIndexChanged);
            // 
            // textBoxAñoTop
            // 
            this.textBoxAñoTop.Location = new System.Drawing.Point(81, 28);
            this.textBoxAñoTop.Name = "textBoxAñoTop";
            this.textBoxAñoTop.Size = new System.Drawing.Size(100, 20);
            this.textBoxAñoTop.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Listado de:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Año:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Trimestre:";
            // 
            // dataGridViewTop5
            // 
            this.dataGridViewTop5.AllowUserToAddRows = false;
            this.dataGridViewTop5.AllowUserToDeleteRows = false;
            this.dataGridViewTop5.AllowUserToResizeColumns = false;
            this.dataGridViewTop5.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTop5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTop5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTop5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_nro,
            this.Col_usuario,
            this.Col_MontoCant,
            this.Col_rubro});
            this.dataGridViewTop5.Location = new System.Drawing.Point(25, 108);
            this.dataGridViewTop5.Name = "dataGridViewTop5";
            this.dataGridViewTop5.Size = new System.Drawing.Size(443, 176);
            this.dataGridViewTop5.TabIndex = 6;
            // 
            // buttonSeleccionar
            // 
            this.buttonSeleccionar.Location = new System.Drawing.Point(25, 290);
            this.buttonSeleccionar.Name = "buttonSeleccionar";
            this.buttonSeleccionar.Size = new System.Drawing.Size(75, 23);
            this.buttonSeleccionar.TabIndex = 7;
            this.buttonSeleccionar.Text = "Seleccionar";
            this.buttonSeleccionar.UseVisualStyleBackColor = true;
            this.buttonSeleccionar.Click += new System.EventHandler(this.buttonSeleccionar_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(218, 290);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 8;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(393, 290);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 9;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // Col_nro
            // 
            this.Col_nro.HeaderText = "Nº";
            this.Col_nro.Name = "Col_nro";
            // 
            // Col_usuario
            // 
            this.Col_usuario.HeaderText = "Usuario";
            this.Col_usuario.Name = "Col_usuario";
            // 
            // Col_MontoCant
            // 
            this.Col_MontoCant.HeaderText = "Monto o Cantidad";
            this.Col_MontoCant.Name = "Col_MontoCant";
            // 
            // Col_rubro
            // 
            this.Col_rubro.HeaderText = "Rubro";
            this.Col_rubro.Name = "Col_rubro";
            // 
            // Top5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 325);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonSeleccionar);
            this.Controls.Add(this.dataGridViewTop5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAñoTop);
            this.Controls.Add(this.comboBoxTrimestre);
            this.Controls.Add(this.comboBoxTop5);
            this.Name = "Top5";
            this.Text = "Top 5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTop5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTop5;
        private System.Windows.Forms.ComboBox comboBoxTrimestre;
        private System.Windows.Forms.TextBox textBoxAñoTop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewTop5;
        private System.Windows.Forms.Button buttonSeleccionar;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_MontoCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_rubro;
    }
}