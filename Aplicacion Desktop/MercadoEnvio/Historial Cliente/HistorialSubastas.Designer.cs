namespace MercadoEnvio.Historial_Cliente
{
    partial class HistorialSubastas
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
            this.buttonVerSubastas = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonVolverAlMenu = new System.Windows.Forms.Button();
            this.dataGridViewSubastas = new System.Windows.Forms.DataGridView();
            this.Col_idSubasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_descFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_descMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_idPublicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubastas)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVerSubastas
            // 
            this.buttonVerSubastas.Location = new System.Drawing.Point(12, 12);
            this.buttonVerSubastas.Name = "buttonVerSubastas";
            this.buttonVerSubastas.Size = new System.Drawing.Size(100, 23);
            this.buttonVerSubastas.TabIndex = 0;
            this.buttonVerSubastas.Text = "Ver subastas";
            this.buttonVerSubastas.UseVisualStyleBackColor = true;
            this.buttonVerSubastas.Click += new System.EventHandler(this.buttonVerSubastas_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(108, 275);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 1;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonVolverAlMenu
            // 
            this.buttonVolverAlMenu.Location = new System.Drawing.Point(354, 275);
            this.buttonVolverAlMenu.Name = "buttonVolverAlMenu";
            this.buttonVolverAlMenu.Size = new System.Drawing.Size(107, 23);
            this.buttonVolverAlMenu.TabIndex = 2;
            this.buttonVolverAlMenu.Text = "Volver al menu";
            this.buttonVolverAlMenu.UseVisualStyleBackColor = true;
            this.buttonVolverAlMenu.Click += new System.EventHandler(this.buttonVolverAlMenu_Click);
            // 
            // dataGridViewSubastas
            // 
            this.dataGridViewSubastas.AllowUserToAddRows = false;
            this.dataGridViewSubastas.AllowUserToDeleteRows = false;
            this.dataGridViewSubastas.AllowUserToResizeColumns = false;
            this.dataGridViewSubastas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewSubastas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSubastas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSubastas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSubastas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubastas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_idSubasta,
            this.Col_descFecha,
            this.Col_descMonto,
            this.Col_idPublicacion,
            this.Col_idUsuario});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSubastas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSubastas.Location = new System.Drawing.Point(26, 51);
            this.dataGridViewSubastas.Name = "dataGridViewSubastas";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSubastas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewSubastas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSubastas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewSubastas.Size = new System.Drawing.Size(532, 197);
            this.dataGridViewSubastas.TabIndex = 3;
            // 
            // Col_idSubasta
            // 
            this.Col_idSubasta.HeaderText = "IdSubasta";
            this.Col_idSubasta.Name = "Col_idSubasta";
            // 
            // Col_descFecha
            // 
            this.Col_descFecha.HeaderText = "Fecha";
            this.Col_descFecha.Name = "Col_descFecha";
            // 
            // Col_descMonto
            // 
            this.Col_descMonto.HeaderText = "Monto";
            this.Col_descMonto.Name = "Col_descMonto";
            // 
            // Col_idPublicacion
            // 
            this.Col_idPublicacion.HeaderText = "IdPublicacion";
            this.Col_idPublicacion.Name = "Col_idPublicacion";
            // 
            // Col_idUsuario
            // 
            this.Col_idUsuario.HeaderText = "IdUsuario";
            this.Col_idUsuario.Name = "Col_idUsuario";
            // 
            // HistorialSubastas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 325);
            this.Controls.Add(this.dataGridViewSubastas);
            this.Controls.Add(this.buttonVolverAlMenu);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonVerSubastas);
            this.Name = "HistorialSubastas";
            this.Text = "HistorialSubastas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubastas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVerSubastas;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonVolverAlMenu;
        private System.Windows.Forms.DataGridView dataGridViewSubastas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_idSubasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_descFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_descMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_idPublicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_idUsuario;
    }
}