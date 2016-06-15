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
            this.Col_CantEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_IdCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComprasCalificadas)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(140, 224);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
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
            this.Col_CantEst,
            this.Col_IdUsuario,
            this.Col_IdCompra});
            this.dataGridViewComprasCalificadas.Location = new System.Drawing.Point(58, 40);
            this.dataGridViewComprasCalificadas.Name = "dataGridViewComprasCalificadas";
            this.dataGridViewComprasCalificadas.Size = new System.Drawing.Size(444, 150);
            this.dataGridViewComprasCalificadas.TabIndex = 1;
            // 
            // Col_IdCalif
            // 
            this.Col_IdCalif.HeaderText = "Calificación";
            this.Col_IdCalif.Name = "Col_IdCalif";
            // 
            // Col_CantEst
            // 
            this.Col_CantEst.HeaderText = "Cantidad de estrellas";
            this.Col_CantEst.Name = "Col_CantEst";
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
            // HistorialComprasCalificadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 261);
            this.Controls.Add(this.dataGridViewComprasCalificadas);
            this.Controls.Add(this.buttonVolver);
            this.Name = "HistorialComprasCalificadas";
            this.Text = "Compras calificadas";
            this.Load += new System.EventHandler(this.HistorialComprasCalificadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComprasCalificadas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.DataGridView dataGridViewComprasCalificadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_IdCalif;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_CantEst;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_IdCompra;
    }
}