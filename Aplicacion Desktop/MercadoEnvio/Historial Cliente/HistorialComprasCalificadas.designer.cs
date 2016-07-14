namespace MercadoEnvio.Historial_Cliente
{
    partial class HistorialComprasCalificadas
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
            this.buttonVolver = new System.Windows.Forms.Button();
            this.dataGridViewComprasCalificadas = new System.Windows.Forms.DataGridView();
            this.Col_IdCalif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_desc_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_CantEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_IdCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonPrimerPag = new System.Windows.Forms.Button();
            this.buttonPaginaAnt = new System.Windows.Forms.Button();
            this.buttonPaginaSgte = new System.Windows.Forms.Button();
            this.buttonUltimaPag = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComprasCalificadas)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonVolver.Location = new System.Drawing.Point(537, 270);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(92, 23);
            this.buttonVolver.TabIndex = 0;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // dataGridViewComprasCalificadas
            // 
            this.dataGridViewComprasCalificadas.AllowUserToAddRows = false;
            this.dataGridViewComprasCalificadas.AllowUserToDeleteRows = false;
            this.dataGridViewComprasCalificadas.AllowUserToResizeColumns = false;
            this.dataGridViewComprasCalificadas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComprasCalificadas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewComprasCalificadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComprasCalificadas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_IdCalif,
            this.Col_desc_codigo,
            this.Col_CantEst,
            this.Col_descripcion,
            this.Col_IdUsuario,
            this.Col_IdCompra});
            this.dataGridViewComprasCalificadas.Location = new System.Drawing.Point(25, 24);
            this.dataGridViewComprasCalificadas.Name = "dataGridViewComprasCalificadas";
            this.dataGridViewComprasCalificadas.RowHeadersVisible = false;
            this.dataGridViewComprasCalificadas.Size = new System.Drawing.Size(604, 227);
            this.dataGridViewComprasCalificadas.TabIndex = 1;
            // 
            // Col_IdCalif
            // 
            this.Col_IdCalif.HeaderText = "Calificación";
            this.Col_IdCalif.Name = "Col_IdCalif";
            // 
            // Col_desc_codigo
            // 
            this.Col_desc_codigo.HeaderText = "Código";
            this.Col_desc_codigo.Name = "Col_desc_codigo";
            // 
            // Col_CantEst
            // 
            this.Col_CantEst.HeaderText = "Estrellas";
            this.Col_CantEst.Name = "Col_CantEst";
            // 
            // Col_descripcion
            // 
            this.Col_descripcion.HeaderText = "Descripción";
            this.Col_descripcion.Name = "Col_descripcion";
            // 
            // Col_IdUsuario
            // 
            this.Col_IdUsuario.HeaderText = "Usuario";
            this.Col_IdUsuario.Name = "Col_IdUsuario";
            // 
            // Col_IdCompra
            // 
            this.Col_IdCompra.HeaderText = "Compra";
            this.Col_IdCompra.Name = "Col_IdCompra";
            // 
            // buttonPrimerPag
            // 
            this.buttonPrimerPag.Location = new System.Drawing.Point(25, 269);
            this.buttonPrimerPag.Name = "buttonPrimerPag";
            this.buttonPrimerPag.Size = new System.Drawing.Size(92, 23);
            this.buttonPrimerPag.TabIndex = 2;
            this.buttonPrimerPag.Text = "<< Primer Pág.";
            this.buttonPrimerPag.UseVisualStyleBackColor = true;
            this.buttonPrimerPag.Click += new System.EventHandler(this.buttonPrimerPag_Click);
            // 
            // buttonPaginaAnt
            // 
            this.buttonPaginaAnt.Location = new System.Drawing.Point(139, 270);
            this.buttonPaginaAnt.Name = "buttonPaginaAnt";
            this.buttonPaginaAnt.Size = new System.Drawing.Size(92, 23);
            this.buttonPaginaAnt.TabIndex = 3;
            this.buttonPaginaAnt.Text = "< Página Ant.";
            this.buttonPaginaAnt.UseVisualStyleBackColor = true;
            this.buttonPaginaAnt.Click += new System.EventHandler(this.buttonPaginaAnt_Click);
            // 
            // buttonPaginaSgte
            // 
            this.buttonPaginaSgte.Location = new System.Drawing.Point(261, 270);
            this.buttonPaginaSgte.Name = "buttonPaginaSgte";
            this.buttonPaginaSgte.Size = new System.Drawing.Size(92, 23);
            this.buttonPaginaSgte.TabIndex = 4;
            this.buttonPaginaSgte.Text = "Página Sgte >";
            this.buttonPaginaSgte.UseVisualStyleBackColor = true;
            this.buttonPaginaSgte.Click += new System.EventHandler(this.buttonPaginaSgte_Click);
            // 
            // buttonUltimaPag
            // 
            this.buttonUltimaPag.Location = new System.Drawing.Point(396, 270);
            this.buttonUltimaPag.Name = "buttonUltimaPag";
            this.buttonUltimaPag.Size = new System.Drawing.Size(92, 23);
            this.buttonUltimaPag.TabIndex = 5;
            this.buttonUltimaPag.Text = "Última Pág. >>";
            this.buttonUltimaPag.UseVisualStyleBackColor = true;
            this.buttonUltimaPag.Click += new System.EventHandler(this.buttonUltimaPag_Click);
            // 
            // HistorialComprasCalificadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 312);
            this.Controls.Add(this.buttonUltimaPag);
            this.Controls.Add(this.buttonPaginaSgte);
            this.Controls.Add(this.buttonPaginaAnt);
            this.Controls.Add(this.buttonPrimerPag);
            this.Controls.Add(this.dataGridViewComprasCalificadas);
            this.Controls.Add(this.buttonVolver);
            this.Name = "HistorialComprasCalificadas";
            this.Text = "Compras calificadas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComprasCalificadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.DataGridView dataGridViewComprasCalificadas;
        private System.Windows.Forms.Button buttonPrimerPag;
        private System.Windows.Forms.Button buttonPaginaAnt;
        private System.Windows.Forms.Button buttonPaginaSgte;
        private System.Windows.Forms.Button buttonUltimaPag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_IdCalif;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_desc_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CantEst;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_IdCompra;
    }
}