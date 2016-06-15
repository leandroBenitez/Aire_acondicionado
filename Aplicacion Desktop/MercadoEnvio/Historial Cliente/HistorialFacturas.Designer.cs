namespace MercadoEnvio.Historial_Cliente
{
    partial class HistorialFacturas
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
            this.buttonVolverAlMenu = new System.Windows.Forms.Button();
            this.dataGridViewFacturas = new System.Windows.Forms.DataGridView();
            this.Col_idFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_descfecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_descTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_idFormaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col_idUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonVolverAlMenu
            // 
            this.buttonVolverAlMenu.Location = new System.Drawing.Point(240, 266);
            this.buttonVolverAlMenu.Name = "buttonVolverAlMenu";
            this.buttonVolverAlMenu.Size = new System.Drawing.Size(111, 23);
            this.buttonVolverAlMenu.TabIndex = 2;
            this.buttonVolverAlMenu.Text = "Volver";
            this.buttonVolverAlMenu.UseVisualStyleBackColor = true;
            this.buttonVolverAlMenu.Click += new System.EventHandler(this.buttonVolverAlMenu_Click);
            // 
            // dataGridViewFacturas
            // 
            this.dataGridViewFacturas.AllowUserToAddRows = false;
            this.dataGridViewFacturas.AllowUserToDeleteRows = false;
            this.dataGridViewFacturas.AllowUserToResizeColumns = false;
            this.dataGridViewFacturas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewFacturas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFacturas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col_idFactura,
            this.Col_descfecha,
            this.Col_descTotal,
            this.Col_idFormaPago,
            this.Col_idUsuario});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewFacturas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewFacturas.Location = new System.Drawing.Point(33, 41);
            this.dataGridViewFacturas.Name = "dataGridViewFacturas";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewFacturas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewFacturas.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewFacturas.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridViewFacturas.Size = new System.Drawing.Size(542, 219);
            this.dataGridViewFacturas.TabIndex = 3;
            // 
            // Col_idFactura
            // 
            this.Col_idFactura.HeaderText = "Factura";
            this.Col_idFactura.Name = "Col_idFactura";
            // 
            // Col_descfecha
            // 
            this.Col_descfecha.HeaderText = "Fecha";
            this.Col_descfecha.Name = "Col_descfecha";
            // 
            // Col_descTotal
            // 
            this.Col_descTotal.HeaderText = "Total";
            this.Col_descTotal.Name = "Col_descTotal";
            // 
            // Col_idFormaPago
            // 
            this.Col_idFormaPago.HeaderText = "Forma de Pago";
            this.Col_idFormaPago.Name = "Col_idFormaPago";
            // 
            // Col_idUsuario
            // 
            this.Col_idUsuario.HeaderText = "Usuario";
            this.Col_idUsuario.Name = "Col_idUsuario";
            // 
            // HistorialFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 308);
            this.Controls.Add(this.dataGridViewFacturas);
            this.Controls.Add(this.buttonVolverAlMenu);
            this.Name = "HistorialFacturas";
            this.Text = "HistorialFacturas";
            this.Load += new System.EventHandler(this.HistorialFacturas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonVolverAlMenu;
        private System.Windows.Forms.DataGridView dataGridViewFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_idFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_descfecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_descTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_idFormaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col_idUsuario;
    }
}