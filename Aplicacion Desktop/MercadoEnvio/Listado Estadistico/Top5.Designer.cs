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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBoxTop5 = new System.Windows.Forms.ComboBox();
            this.comboBoxTrimestre = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewTop5 = new System.Windows.Forms.DataGridView();
            this.Col_nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_desc_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_MontoCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_rubro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.combo_anio = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.combo_rubros = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTop5)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxTop5
            // 
            this.comboBoxTop5.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTop5.FormattingEnabled = true;
            this.comboBoxTop5.Location = new System.Drawing.Point(60, 69);
            this.comboBoxTop5.Name = "comboBoxTop5";
            this.comboBoxTop5.Size = new System.Drawing.Size(250, 21);
            this.comboBoxTop5.TabIndex = 0;
            this.comboBoxTop5.SelectedIndexChanged += new System.EventHandler(this.comboBoxTop5_SelectedIndexChanged);
            // 
            // comboBoxTrimestre
            // 
            this.comboBoxTrimestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTrimestre.FormattingEnabled = true;
            this.comboBoxTrimestre.Location = new System.Drawing.Point(373, 26);
            this.comboBoxTrimestre.Name = "comboBoxTrimestre";
            this.comboBoxTrimestre.Size = new System.Drawing.Size(152, 21);
            this.comboBoxTrimestre.TabIndex = 1;
            this.comboBoxTrimestre.SelectedIndexChanged += new System.EventHandler(this.comboBoxTrimestre_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Listado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Año:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 29);
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTop5.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTop5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTop5.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_nro,
            this.Col_usuario,
            this.Col_desc_fecha,
            this.Col_MontoCant,
            this.Col_rubro});
            this.dataGridViewTop5.Location = new System.Drawing.Point(12, 108);
            this.dataGridViewTop5.MultiSelect = false;
            this.dataGridViewTop5.Name = "dataGridViewTop5";
            this.dataGridViewTop5.RowHeadersVisible = false;
            this.dataGridViewTop5.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewTop5.Size = new System.Drawing.Size(513, 148);
            this.dataGridViewTop5.TabIndex = 6;
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
            // Col_desc_fecha
            // 
            this.Col_desc_fecha.HeaderText = "Fecha";
            this.Col_desc_fecha.Name = "Col_desc_fecha";
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
            // buttonVolver
            // 
            this.buttonVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonVolver.Location = new System.Drawing.Point(450, 274);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 8;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(12, 274);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 9;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // combo_anio
            // 
            this.combo_anio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_anio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_anio.FormattingEnabled = true;
            this.combo_anio.Location = new System.Drawing.Point(60, 24);
            this.combo_anio.Name = "combo_anio";
            this.combo_anio.Size = new System.Drawing.Size(128, 23);
            this.combo_anio.TabIndex = 10;
            this.combo_anio.SelectedIndexChanged += new System.EventHandler(this.combo_anio_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(328, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Rubro:";
            // 
            // combo_rubros
            // 
            this.combo_rubros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_rubros.FormattingEnabled = true;
            this.combo_rubros.Location = new System.Drawing.Point(373, 69);
            this.combo_rubros.Name = "combo_rubros";
            this.combo_rubros.Size = new System.Drawing.Size(152, 21);
            this.combo_rubros.TabIndex = 11;
            this.combo_rubros.SelectedIndexChanged += new System.EventHandler(this.combo_rubros_SelectedIndexChanged);
            // 
            // Top5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 308);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.combo_rubros);
            this.Controls.Add(this.combo_anio);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.dataGridViewTop5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxTrimestre);
            this.Controls.Add(this.comboBoxTop5);
            this.Name = "Top5";
            this.Text = "Listado Estadistico - Top 5";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTop5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTop5;
        private System.Windows.Forms.ComboBox comboBoxTrimestre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridViewTop5;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_desc_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_MontoCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_rubro;
        private System.Windows.Forms.ComboBox combo_anio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox combo_rubros;
    }
}