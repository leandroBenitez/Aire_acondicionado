namespace MercadoEnvio.Historial_Cliente
{
    partial class HistorialCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonVerCompras = new System.Windows.Forms.Button();
            this.dataGridViewCompras = new System.Windows.Forms.DataGridView();
            this.Col_idCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_DescFec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_DescCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_idPubl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonVolverAlMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompras)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVerCompras
            // 
            this.buttonVerCompras.Location = new System.Drawing.Point(28, 12);
            this.buttonVerCompras.Name = "buttonVerCompras";
            this.buttonVerCompras.Size = new System.Drawing.Size(75, 23);
            this.buttonVerCompras.TabIndex = 1;
            this.buttonVerCompras.Text = "Ver compras";
            this.buttonVerCompras.UseVisualStyleBackColor = true;
            this.buttonVerCompras.Click += new System.EventHandler(this.verCompras_Click);
            // 
            // dataGridViewCompras
            // 
            this.dataGridViewCompras.AllowUserToAddRows = false;
            this.dataGridViewCompras.AllowUserToDeleteRows = false;
            this.dataGridViewCompras.AllowUserToResizeColumns = false;
            this.dataGridViewCompras.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewCompras.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCompras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCompras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCompras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_idCompra,
            this.Col_DescFec,
            this.Col_DescCant,
            this.Col_idPubl,
            this.Col_idUsuario});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCompras.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewCompras.Location = new System.Drawing.Point(28, 41);
            this.dataGridViewCompras.Name = "dataGridViewCompras";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCompras.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewCompras.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewCompras.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewCompras.Size = new System.Drawing.Size(529, 208);
            this.dataGridViewCompras.TabIndex = 3;
            // 
            // Col_idCompra
            // 
            this.Col_idCompra.HeaderText = "IdCompra";
            this.Col_idCompra.Name = "Col_idCompra";
            // 
            // Col_DescFec
            // 
            this.Col_DescFec.HeaderText = "Fecha";
            this.Col_DescFec.Name = "Col_DescFec";
            // 
            // Col_DescCant
            // 
            this.Col_DescCant.HeaderText = "Cantidad";
            this.Col_DescCant.Name = "Col_DescCant";
            // 
            // Col_idPubl
            // 
            this.Col_idPubl.HeaderText = "IdPublicación";
            this.Col_idPubl.Name = "Col_idPubl";
            // 
            // Col_idUsuario
            // 
            this.Col_idUsuario.HeaderText = "IdUsuario";
            this.Col_idUsuario.Name = "Col_idUsuario";
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(101, 266);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(90, 23);
            this.buttonLimpiar.TabIndex = 4;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonVolverAlMenu
            // 
            this.buttonVolverAlMenu.Location = new System.Drawing.Point(342, 266);
            this.buttonVolverAlMenu.Name = "buttonVolverAlMenu";
            this.buttonVolverAlMenu.Size = new System.Drawing.Size(106, 23);
            this.buttonVolverAlMenu.TabIndex = 5;
            this.buttonVolverAlMenu.Text = "Volver al menú";
            this.buttonVolverAlMenu.UseVisualStyleBackColor = true;
            this.buttonVolverAlMenu.Click += new System.EventHandler(this.buttonVolverAlMenu_Click);
            // 
            // HistorialCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 301);
            this.Controls.Add(this.buttonVolverAlMenu);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.dataGridViewCompras);
            this.Controls.Add(this.buttonVerCompras);
            this.Name = "HistorialCompras";
            this.Text = "HistorialCompras";
            this.Load += new System.EventHandler(this.HistorialCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVerCompras;
        private System.Windows.Forms.DataGridView dataGridViewCompras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_idCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_DescFec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_DescCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_idPubl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_idUsuario;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonVolverAlMenu;
    }
}