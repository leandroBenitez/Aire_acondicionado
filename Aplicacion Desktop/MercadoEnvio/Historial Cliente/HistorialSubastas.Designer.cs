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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonVolverAlMenu = new System.Windows.Forms.Button();
            this.dataGridViewSubastas = new System.Windows.Forms.DataGridView();
            this.Col_idSubasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_descFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_descMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_idPublicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPrimerPag = new System.Windows.Forms.Button();
            this.buttonPaginaAnt = new System.Windows.Forms.Button();
            this.buttonPaginaSgte = new System.Windows.Forms.Button();
            this.buttonUltimaPag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubastas)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVolverAlMenu
            // 
            this.buttonVolverAlMenu.Location = new System.Drawing.Point(475, 290);
            this.buttonVolverAlMenu.Name = "buttonVolverAlMenu";
            this.buttonVolverAlMenu.Size = new System.Drawing.Size(83, 23);
            this.buttonVolverAlMenu.TabIndex = 2;
            this.buttonVolverAlMenu.Text = "Volver";
            this.buttonVolverAlMenu.UseVisualStyleBackColor = true;
            this.buttonVolverAlMenu.Click += new System.EventHandler(this.buttonVolverAlMenu_Click);
            // 
            // dataGridViewSubastas
            // 
            this.dataGridViewSubastas.AllowUserToAddRows = false;
            this.dataGridViewSubastas.AllowUserToDeleteRows = false;
            this.dataGridViewSubastas.AllowUserToResizeColumns = false;
            this.dataGridViewSubastas.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewSubastas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewSubastas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSubastas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewSubastas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubastas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_idSubasta,
            this.Col_descFecha,
            this.Col_descMonto,
            this.Col_idPublicacion,
            this.Col_idUsuario});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSubastas.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewSubastas.Location = new System.Drawing.Point(26, 33);
            this.dataGridViewSubastas.Name = "dataGridViewSubastas";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSubastas.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewSubastas.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewSubastas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewSubastas.Size = new System.Drawing.Size(532, 215);
            this.dataGridViewSubastas.TabIndex = 3;
            // 
            // Col_idSubasta
            // 
            this.Col_idSubasta.HeaderText = "Subasta";
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
            this.Col_idPublicacion.HeaderText = "Publicación";
            this.Col_idPublicacion.Name = "Col_idPublicacion";
            // 
            // Col_idUsuario
            // 
            this.Col_idUsuario.HeaderText = "Usuario";
            this.Col_idUsuario.Name = "Col_idUsuario";
            // 
            // buttonPrimerPag
            // 
            this.buttonPrimerPag.Location = new System.Drawing.Point(26, 290);
            this.buttonPrimerPag.Name = "buttonPrimerPag";
            this.buttonPrimerPag.Size = new System.Drawing.Size(84, 23);
            this.buttonPrimerPag.TabIndex = 4;
            this.buttonPrimerPag.Text = "<< Primer Pág.";
            this.buttonPrimerPag.UseVisualStyleBackColor = true;
            this.buttonPrimerPag.Click += new System.EventHandler(this.buttonPrimerPag_Click);
            // 
            // buttonPaginaAnt
            // 
            this.buttonPaginaAnt.Location = new System.Drawing.Point(140, 290);
            this.buttonPaginaAnt.Name = "buttonPaginaAnt";
            this.buttonPaginaAnt.Size = new System.Drawing.Size(84, 23);
            this.buttonPaginaAnt.TabIndex = 5;
            this.buttonPaginaAnt.Text = "< Página Ant.";
            this.buttonPaginaAnt.UseVisualStyleBackColor = true;
            this.buttonPaginaAnt.Click += new System.EventHandler(this.buttonPaginaAnt_Click);
            // 
            // buttonPaginaSgte
            // 
            this.buttonPaginaSgte.Location = new System.Drawing.Point(255, 290);
            this.buttonPaginaSgte.Name = "buttonPaginaSgte";
            this.buttonPaginaSgte.Size = new System.Drawing.Size(84, 23);
            this.buttonPaginaSgte.TabIndex = 6;
            this.buttonPaginaSgte.Text = "Página Sgte >";
            this.buttonPaginaSgte.UseVisualStyleBackColor = true;
            this.buttonPaginaSgte.Click += new System.EventHandler(this.buttonPaginaSgte_Click);
            // 
            // buttonUltimaPag
            // 
            this.buttonUltimaPag.Location = new System.Drawing.Point(365, 290);
            this.buttonUltimaPag.Name = "buttonUltimaPag";
            this.buttonUltimaPag.Size = new System.Drawing.Size(84, 23);
            this.buttonUltimaPag.TabIndex = 7;
            this.buttonUltimaPag.Text = "Última Pág. >>";
            this.buttonUltimaPag.UseVisualStyleBackColor = true;
            this.buttonUltimaPag.Click += new System.EventHandler(this.buttonUltimaPag_Click);
            // 
            // HistorialSubastas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 325);
            this.Controls.Add(this.buttonUltimaPag);
            this.Controls.Add(this.buttonPaginaSgte);
            this.Controls.Add(this.buttonPaginaAnt);
            this.Controls.Add(this.buttonPrimerPag);
            this.Controls.Add(this.dataGridViewSubastas);
            this.Controls.Add(this.buttonVolverAlMenu);
            this.Name = "HistorialSubastas";
            this.Text = "Historial Subastas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubastas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVolverAlMenu;
        private System.Windows.Forms.DataGridView dataGridViewSubastas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_idSubasta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_descFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_descMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_idPublicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_idUsuario;
        private System.Windows.Forms.Button buttonPrimerPag;
        private System.Windows.Forms.Button buttonPaginaAnt;
        private System.Windows.Forms.Button buttonPaginaSgte;
        private System.Windows.Forms.Button buttonUltimaPag;
    }
}