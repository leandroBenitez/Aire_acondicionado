namespace MercadoEnvio.Listado_Estadistico
{
    partial class NoVendidos
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
            this.comboBoxVisibilidad = new System.Windows.Forms.ComboBox();
            this.comboBoxMes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewNoVendidos = new System.Windows.Forms.DataGridView();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.combo_anios = new System.Windows.Forms.ComboBox();
            this.Col_nro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_desc_fecha_publi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CantProf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNoVendidos)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxVisibilidad
            // 
            this.comboBoxVisibilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVisibilidad.FormattingEnabled = true;
            this.comboBoxVisibilidad.Location = new System.Drawing.Point(92, 24);
            this.comboBoxVisibilidad.Name = "comboBoxVisibilidad";
            this.comboBoxVisibilidad.Size = new System.Drawing.Size(139, 21);
            this.comboBoxVisibilidad.TabIndex = 0;
            this.comboBoxVisibilidad.SelectedIndexChanged += new System.EventHandler(this.comboBoxVisibilidad_SelectedIndexChanged);
            // 
            // comboBoxMes
            // 
            this.comboBoxMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMes.FormattingEnabled = true;
            this.comboBoxMes.Location = new System.Drawing.Point(353, 64);
            this.comboBoxMes.Name = "comboBoxMes";
            this.comboBoxMes.Size = new System.Drawing.Size(139, 21);
            this.comboBoxMes.TabIndex = 1;
            this.comboBoxMes.SelectedIndexChanged += new System.EventHandler(this.comboBoxMes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Visibilidad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(317, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mes:";
            // 
            // dataGridViewNoVendidos
            // 
            this.dataGridViewNoVendidos.AllowUserToAddRows = false;
            this.dataGridViewNoVendidos.AllowUserToDeleteRows = false;
            this.dataGridViewNoVendidos.AllowUserToResizeColumns = false;
            this.dataGridViewNoVendidos.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNoVendidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewNoVendidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNoVendidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_nro,
            this.Col_Vendedor,
            this.Col_desc_fecha_publi,
            this.vis,
            this.Col_CantProf});
            this.dataGridViewNoVendidos.Location = new System.Drawing.Point(12, 104);
            this.dataGridViewNoVendidos.Name = "dataGridViewNoVendidos";
            this.dataGridViewNoVendidos.ReadOnly = true;
            this.dataGridViewNoVendidos.RowHeadersVisible = false;
            this.dataGridViewNoVendidos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewNoVendidos.Size = new System.Drawing.Size(499, 157);
            this.dataGridViewNoVendidos.TabIndex = 4;
            // 
            // buttonVolver
            // 
            this.buttonVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonVolver.Location = new System.Drawing.Point(435, 267);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 6;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(11, 267);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 7;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Año:";
            // 
            // combo_anios
            // 
            this.combo_anios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_anios.FormattingEnabled = true;
            this.combo_anios.Location = new System.Drawing.Point(92, 64);
            this.combo_anios.Name = "combo_anios";
            this.combo_anios.Size = new System.Drawing.Size(139, 21);
            this.combo_anios.TabIndex = 10;
            this.combo_anios.SelectedIndexChanged += new System.EventHandler(this.combo_anios_SelectedIndexChanged);
            // 
            // Col_nro
            // 
            this.Col_nro.HeaderText = "Nº";
            this.Col_nro.Name = "Col_nro";
            this.Col_nro.ReadOnly = true;
            // 
            // Col_Vendedor
            // 
            this.Col_Vendedor.HeaderText = "Vendedor";
            this.Col_Vendedor.Name = "Col_Vendedor";
            this.Col_Vendedor.ReadOnly = true;
            // 
            // Col_desc_fecha_publi
            // 
            this.Col_desc_fecha_publi.HeaderText = "Fecha";
            this.Col_desc_fecha_publi.Name = "Col_desc_fecha_publi";
            this.Col_desc_fecha_publi.ReadOnly = true;
            // 
            // vis
            // 
            this.vis.HeaderText = "Visualizacion";
            this.vis.Name = "vis";
            this.vis.ReadOnly = true;
            // 
            // Col_CantProf
            // 
            this.Col_CantProf.HeaderText = "Cantidad sin vender";
            this.Col_CantProf.Name = "Col_CantProf";
            this.Col_CantProf.ReadOnly = true;
            // 
            // NoVendidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 302);
            this.Controls.Add(this.combo_anios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.dataGridViewNoVendidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxMes);
            this.Controls.Add(this.comboBoxVisibilidad);
            this.Name = "NoVendidos";
            this.Text = "Ranking - Productos no vendidos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNoVendidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxVisibilidad;
        private System.Windows.Forms.ComboBox comboBoxMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridViewNoVendidos;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox combo_anios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_nro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_desc_fecha_publi;
        private System.Windows.Forms.DataGridViewTextBoxColumn vis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CantProf;
    }
}