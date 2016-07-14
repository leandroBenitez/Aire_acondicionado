namespace MercadoEnvio.Historial_Cliente
{
    partial class HistorialCalificacionesRecibidas
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
            this.dataGridViewCalificacionesRecibidas = new System.Windows.Forms.DataGridView();
            this.Col_idCalif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CantEstr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_idSubasta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPrimerPag = new System.Windows.Forms.Button();
            this.buttonPaginaAnt = new System.Windows.Forms.Button();
            this.buttonPaginaSgte = new System.Windows.Forms.Button();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.buttonUltimaPag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalificacionesRecibidas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCalificacionesRecibidas
            // 
            this.dataGridViewCalificacionesRecibidas.AllowUserToAddRows = false;
            this.dataGridViewCalificacionesRecibidas.AllowUserToDeleteRows = false;
            this.dataGridViewCalificacionesRecibidas.AllowUserToResizeColumns = false;
            this.dataGridViewCalificacionesRecibidas.AllowUserToResizeRows = false;
            this.dataGridViewCalificacionesRecibidas.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewCalificacionesRecibidas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewCalificacionesRecibidas.CausesValidation = false;
            this.dataGridViewCalificacionesRecibidas.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCalificacionesRecibidas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCalificacionesRecibidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalificacionesRecibidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_idCalif,
            this.Col_Cod,
            this.Col_CantEstr,
            this.Col_Vendedor,
            this.Col_Compra,
            this.Col_idSubasta});
            this.dataGridViewCalificacionesRecibidas.Location = new System.Drawing.Point(21, 23);
            this.dataGridViewCalificacionesRecibidas.Name = "dataGridViewCalificacionesRecibidas";
            this.dataGridViewCalificacionesRecibidas.RowHeadersVisible = false;
            this.dataGridViewCalificacionesRecibidas.Size = new System.Drawing.Size(603, 228);
            this.dataGridViewCalificacionesRecibidas.TabIndex = 0;
            // 
            // Col_idCalif
            // 
            this.Col_idCalif.HeaderText = "Nº Calificación";
            this.Col_idCalif.Name = "Col_idCalif";
            // 
            // Col_Cod
            // 
            this.Col_Cod.HeaderText = "Código";
            this.Col_Cod.Name = "Col_Cod";
            // 
            // Col_CantEstr
            // 
            this.Col_CantEstr.HeaderText = "Estrellas";
            this.Col_CantEstr.Name = "Col_CantEstr";
            // 
            // Col_Vendedor
            // 
            this.Col_Vendedor.HeaderText = "Vendedor";
            this.Col_Vendedor.Name = "Col_Vendedor";
            // 
            // Col_Compra
            // 
            this.Col_Compra.HeaderText = "Compra";
            this.Col_Compra.Name = "Col_Compra";
            // 
            // Col_idSubasta
            // 
            this.Col_idSubasta.HeaderText = "Subasta";
            this.Col_idSubasta.Name = "Col_idSubasta";
            // 
            // buttonPrimerPag
            // 
            this.buttonPrimerPag.Location = new System.Drawing.Point(21, 268);
            this.buttonPrimerPag.Name = "buttonPrimerPag";
            this.buttonPrimerPag.Size = new System.Drawing.Size(89, 23);
            this.buttonPrimerPag.TabIndex = 1;
            this.buttonPrimerPag.Text = "<< Primer Pág.";
            this.buttonPrimerPag.UseVisualStyleBackColor = true;
            // 
            // buttonPaginaAnt
            // 
            this.buttonPaginaAnt.Location = new System.Drawing.Point(154, 268);
            this.buttonPaginaAnt.Name = "buttonPaginaAnt";
            this.buttonPaginaAnt.Size = new System.Drawing.Size(89, 23);
            this.buttonPaginaAnt.TabIndex = 2;
            this.buttonPaginaAnt.Text = "< Página Ant.";
            this.buttonPaginaAnt.UseVisualStyleBackColor = true;
            this.buttonPaginaAnt.Click += new System.EventHandler(this.buttonPaginaAnt_Click);
            // 
            // buttonPaginaSgte
            // 
            this.buttonPaginaSgte.Location = new System.Drawing.Point(281, 268);
            this.buttonPaginaSgte.Name = "buttonPaginaSgte";
            this.buttonPaginaSgte.Size = new System.Drawing.Size(89, 23);
            this.buttonPaginaSgte.TabIndex = 3;
            this.buttonPaginaSgte.Text = "Página sgte >";
            this.buttonPaginaSgte.UseVisualStyleBackColor = true;
            this.buttonPaginaSgte.Click += new System.EventHandler(this.buttonPaginaSgte_Click);
            // 
            // buttonVolver
            // 
            this.buttonVolver.ForeColor = System.Drawing.Color.Maroon;
            this.buttonVolver.Location = new System.Drawing.Point(535, 268);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(89, 23);
            this.buttonVolver.TabIndex = 5;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // buttonUltimaPag
            // 
            this.buttonUltimaPag.Location = new System.Drawing.Point(408, 268);
            this.buttonUltimaPag.Name = "buttonUltimaPag";
            this.buttonUltimaPag.Size = new System.Drawing.Size(89, 23);
            this.buttonUltimaPag.TabIndex = 6;
            this.buttonUltimaPag.Text = "Última pág. >>";
            this.buttonUltimaPag.UseVisualStyleBackColor = true;
            this.buttonUltimaPag.Click += new System.EventHandler(this.buttonUltimaPag_Click);
            // 
            // HistorialCalificacionesRecibidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 307);
            this.Controls.Add(this.buttonUltimaPag);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.buttonPaginaSgte);
            this.Controls.Add(this.buttonPaginaAnt);
            this.Controls.Add(this.buttonPrimerPag);
            this.Controls.Add(this.dataGridViewCalificacionesRecibidas);
            this.Name = "HistorialCalificacionesRecibidas";
            this.Text = "Calificaciones Recibidas";
            this.Load += new System.EventHandler(this.HistorialCalificacionesRecibidas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalificacionesRecibidas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCalificacionesRecibidas;
        private System.Windows.Forms.Button buttonPrimerPag;
        private System.Windows.Forms.Button buttonPaginaAnt;
        private System.Windows.Forms.Button buttonPaginaSgte;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.Button buttonUltimaPag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_idCalif;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CantEstr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_idSubasta;
    }
}