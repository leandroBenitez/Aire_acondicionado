namespace MercadoEnvio.Historial_Cliente
{
    partial class HistorialComprasSinCalificar
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
            this.buttonVolver = new System.Windows.Forms.Button();
            this.dataGridViewComprasSinCalificar = new System.Windows.Forms.DataGridView();
            this.buttonPrimerPag = new System.Windows.Forms.Button();
            this.buttonPaginaAnt = new System.Windows.Forms.Button();
            this.buttonPaginaSgte = new System.Windows.Forms.Button();
            this.buttonUltimaPag = new System.Windows.Forms.Button();
            this.Col_IdCalif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_descCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_descCantidadEstrellas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_IdCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComprasSinCalificar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(584, 275);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(94, 23);
            this.buttonVolver.TabIndex = 0;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // dataGridViewComprasSinCalificar
            // 
            this.dataGridViewComprasSinCalificar.AllowUserToAddRows = false;
            this.dataGridViewComprasSinCalificar.AllowUserToDeleteRows = false;
            this.dataGridViewComprasSinCalificar.AllowUserToResizeColumns = false;
            this.dataGridViewComprasSinCalificar.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComprasSinCalificar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewComprasSinCalificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComprasSinCalificar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_IdCalif,
            this.Col_descCodigo,
            this.Col_descCantidadEstrellas,
            this.Col_descripcion,
            this.Col_IdUsuario,
            this.Col_IdCompra});
            this.dataGridViewComprasSinCalificar.Location = new System.Drawing.Point(28, 27);
            this.dataGridViewComprasSinCalificar.Name = "dataGridViewComprasSinCalificar";
            this.dataGridViewComprasSinCalificar.Size = new System.Drawing.Size(650, 217);
            this.dataGridViewComprasSinCalificar.TabIndex = 1;
            // 
            // buttonPrimerPag
            // 
            this.buttonPrimerPag.Location = new System.Drawing.Point(28, 275);
            this.buttonPrimerPag.Name = "buttonPrimerPag";
            this.buttonPrimerPag.Size = new System.Drawing.Size(94, 23);
            this.buttonPrimerPag.TabIndex = 2;
            this.buttonPrimerPag.Text = "<< Primer Pág.";
            this.buttonPrimerPag.UseVisualStyleBackColor = true;
            this.buttonPrimerPag.Click += new System.EventHandler(this.buttonPrimerPag_Click);
            // 
            // buttonPaginaAnt
            // 
            this.buttonPaginaAnt.Location = new System.Drawing.Point(164, 275);
            this.buttonPaginaAnt.Name = "buttonPaginaAnt";
            this.buttonPaginaAnt.Size = new System.Drawing.Size(94, 23);
            this.buttonPaginaAnt.TabIndex = 3;
            this.buttonPaginaAnt.Text = "< Página Ant.";
            this.buttonPaginaAnt.UseVisualStyleBackColor = true;
            this.buttonPaginaAnt.Click += new System.EventHandler(this.buttonPaginaAnt_Click);
            // 
            // buttonPaginaSgte
            // 
            this.buttonPaginaSgte.Location = new System.Drawing.Point(303, 275);
            this.buttonPaginaSgte.Name = "buttonPaginaSgte";
            this.buttonPaginaSgte.Size = new System.Drawing.Size(94, 23);
            this.buttonPaginaSgte.TabIndex = 4;
            this.buttonPaginaSgte.Text = "Página Sgte >";
            this.buttonPaginaSgte.UseVisualStyleBackColor = true;
            this.buttonPaginaSgte.Click += new System.EventHandler(this.buttonPaginaSgte_Click);
            // 
            // buttonUltimaPag
            // 
            this.buttonUltimaPag.Location = new System.Drawing.Point(446, 275);
            this.buttonUltimaPag.Name = "buttonUltimaPag";
            this.buttonUltimaPag.Size = new System.Drawing.Size(94, 23);
            this.buttonUltimaPag.TabIndex = 5;
            this.buttonUltimaPag.Text = "Última Pág.";
            this.buttonUltimaPag.UseVisualStyleBackColor = true;
            this.buttonUltimaPag.Click += new System.EventHandler(this.buttonUltimaPag_Click);
            // 
            // Col_IdCalif
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Col_IdCalif.DefaultCellStyle = dataGridViewCellStyle2;
            this.Col_IdCalif.HeaderText = "Nº Calificación";
            this.Col_IdCalif.Name = "Col_IdCalif";
            this.Col_IdCalif.ReadOnly = true;
            // 
            // Col_descCodigo
            // 
            this.Col_descCodigo.HeaderText = "Código";
            this.Col_descCodigo.Name = "Col_descCodigo";
            // 
            // Col_descCantidadEstrellas
            // 
            this.Col_descCantidadEstrellas.HeaderText = "Estrellas";
            this.Col_descCantidadEstrellas.Name = "Col_descCantidadEstrellas";
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
            // HistorialComprasSinCalificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 310);
            this.Controls.Add(this.buttonUltimaPag);
            this.Controls.Add(this.buttonPaginaSgte);
            this.Controls.Add(this.buttonPaginaAnt);
            this.Controls.Add(this.buttonPrimerPag);
            this.Controls.Add(this.dataGridViewComprasSinCalificar);
            this.Controls.Add(this.buttonVolver);
            this.Name = "HistorialComprasSinCalificar";
            this.Text = "Compras sin calificar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComprasSinCalificar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.DataGridView dataGridViewComprasSinCalificar;
        private System.Windows.Forms.Button buttonPrimerPag;
        private System.Windows.Forms.Button buttonPaginaAnt;
        private System.Windows.Forms.Button buttonPaginaSgte;
        private System.Windows.Forms.Button buttonUltimaPag;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_IdCalif;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_descCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_descCantidadEstrellas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_IdCompra;
    }
}