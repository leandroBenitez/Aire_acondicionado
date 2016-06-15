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
            this.Col_IdCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_IdUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_IdCalif = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewComprasSinCalificar = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComprasSinCalificar)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(181, 226);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 0;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // Col_IdCompra
            // 
            this.Col_IdCompra.HeaderText = "Compra";
            this.Col_IdCompra.Name = "Col_IdCompra";
            // 
            // Col_IdUsuario
            // 
            this.Col_IdUsuario.HeaderText = "Usuario";
            this.Col_IdUsuario.Name = "Col_IdUsuario";
            // 
            // Col_IdCalif
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Col_IdCalif.DefaultCellStyle = dataGridViewCellStyle1;
            this.Col_IdCalif.HeaderText = "Calificación";
            this.Col_IdCalif.Name = "Col_IdCalif";
            // 
            // dataGridViewComprasSinCalificar
            // 
            this.dataGridViewComprasSinCalificar.AllowUserToAddRows = false;
            this.dataGridViewComprasSinCalificar.AllowUserToDeleteRows = false;
            this.dataGridViewComprasSinCalificar.AllowUserToResizeColumns = false;
            this.dataGridViewComprasSinCalificar.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewComprasSinCalificar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewComprasSinCalificar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewComprasSinCalificar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_IdCalif,
            this.Col_IdUsuario,
            this.Col_IdCompra});
            this.dataGridViewComprasSinCalificar.Location = new System.Drawing.Point(41, 43);
            this.dataGridViewComprasSinCalificar.Name = "dataGridViewComprasSinCalificar";
            this.dataGridViewComprasSinCalificar.Size = new System.Drawing.Size(343, 150);
            this.dataGridViewComprasSinCalificar.TabIndex = 1;
            this.dataGridViewComprasSinCalificar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewComprasSinCalificar_CellContentClick);
            // 
            // HistorialComprasSinCalificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 261);
            this.Controls.Add(this.dataGridViewComprasSinCalificar);
            this.Controls.Add(this.buttonVolver);
            this.Name = "HistorialComprasSinCalificar";
            this.Text = "Compras sin calificar";
            this.Load += new System.EventHandler(this.HistorialEstrellasPorOtorgar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewComprasSinCalificar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_IdCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_IdUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_IdCalif;
        private System.Windows.Forms.DataGridView dataGridViewComprasSinCalificar;
    }
}