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
            this.dataGridViewCompras = new System.Windows.Forms.DataGridView();
            this.Col_idCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_DescFec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_DescCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_idPubl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonVolverAlMenu = new System.Windows.Forms.Button();
            this.buttonPrimerPag = new System.Windows.Forms.Button();
            this.buttonPaginaAnt = new System.Windows.Forms.Button();
            this.buttonPaginaSgte = new System.Windows.Forms.Button();
            this.buttonUltimaPag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompras)).BeginInit();
            this.SuspendLayout();
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.dataGridViewCompras.Location = new System.Drawing.Point(28, 27);
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
            this.dataGridViewCompras.Size = new System.Drawing.Size(529, 261);
            this.dataGridViewCompras.TabIndex = 3;
            // 
            // Col_idCompra
            // 
            this.Col_idCompra.HeaderText = "Compra";
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
            this.Col_idPubl.HeaderText = "Publicación";
            this.Col_idPubl.Name = "Col_idPubl";
            // 
            // Col_idUsuario
            // 
            this.Col_idUsuario.HeaderText = "Usuario";
            this.Col_idUsuario.Name = "Col_idUsuario";
            // 
            // buttonVolverAlMenu
            // 
            this.buttonVolverAlMenu.Location = new System.Drawing.Point(475, 312);
            this.buttonVolverAlMenu.Name = "buttonVolverAlMenu";
            this.buttonVolverAlMenu.Size = new System.Drawing.Size(82, 23);
            this.buttonVolverAlMenu.TabIndex = 5;
            this.buttonVolverAlMenu.Text = "Volver";
            this.buttonVolverAlMenu.UseVisualStyleBackColor = true;
            this.buttonVolverAlMenu.Click += new System.EventHandler(this.buttonVolverAlMenu_Click);
            // 
            // buttonPrimerPag
            // 
            this.buttonPrimerPag.Location = new System.Drawing.Point(28, 312);
            this.buttonPrimerPag.Name = "buttonPrimerPag";
            this.buttonPrimerPag.Size = new System.Drawing.Size(84, 23);
            this.buttonPrimerPag.TabIndex = 6;
            this.buttonPrimerPag.Text = "<< Primer Pág.";
            this.buttonPrimerPag.UseVisualStyleBackColor = true;
            this.buttonPrimerPag.Click += new System.EventHandler(this.buttonPrimerPag_Click);
            // 
            // buttonPaginaAnt
            // 
            this.buttonPaginaAnt.Location = new System.Drawing.Point(144, 312);
            this.buttonPaginaAnt.Name = "buttonPaginaAnt";
            this.buttonPaginaAnt.Size = new System.Drawing.Size(83, 23);
            this.buttonPaginaAnt.TabIndex = 7;
            this.buttonPaginaAnt.Text = "< Página Ant.";
            this.buttonPaginaAnt.UseVisualStyleBackColor = true;
            this.buttonPaginaAnt.Click += new System.EventHandler(this.buttonPaginaAnt_Click);
            // 
            // buttonPaginaSgte
            // 
            this.buttonPaginaSgte.Location = new System.Drawing.Point(259, 312);
            this.buttonPaginaSgte.Name = "buttonPaginaSgte";
            this.buttonPaginaSgte.Size = new System.Drawing.Size(83, 23);
            this.buttonPaginaSgte.TabIndex = 8;
            this.buttonPaginaSgte.Text = "Página Sgte >";
            this.buttonPaginaSgte.UseVisualStyleBackColor = true;
            this.buttonPaginaSgte.Click += new System.EventHandler(this.buttonPaginaSgte_Click);
            // 
            // buttonUltimaPag
            // 
            this.buttonUltimaPag.Location = new System.Drawing.Point(367, 312);
            this.buttonUltimaPag.Name = "buttonUltimaPag";
            this.buttonUltimaPag.Size = new System.Drawing.Size(84, 23);
            this.buttonUltimaPag.TabIndex = 9;
            this.buttonUltimaPag.Text = "Última Pág. >>";
            this.buttonUltimaPag.UseVisualStyleBackColor = true;
            this.buttonUltimaPag.Click += new System.EventHandler(this.buttonUltimaPag_Click);
            // 
            // HistorialCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 352);
            this.Controls.Add(this.buttonUltimaPag);
            this.Controls.Add(this.buttonPaginaSgte);
            this.Controls.Add(this.buttonPaginaAnt);
            this.Controls.Add(this.buttonPrimerPag);
            this.Controls.Add(this.buttonVolverAlMenu);
            this.Controls.Add(this.dataGridViewCompras);
            this.Name = "HistorialCompras";
            this.Text = "Historial compras";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCompras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCompras;
        private System.Windows.Forms.Button buttonVolverAlMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_idCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_DescFec;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_DescCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_idPubl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_idUsuario;
        private System.Windows.Forms.Button buttonPrimerPag;
        private System.Windows.Forms.Button buttonPaginaAnt;
        private System.Windows.Forms.Button buttonPaginaSgte;
        private System.Windows.Forms.Button buttonUltimaPag;
    }
}