namespace MercadoEnvio.ABM_Visibilidad
{
    partial class ModificacionVisibilidad
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
            this.label1 = new System.Windows.Forms.Label();
            this.Buscar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textPrecio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textPorcentaje = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textEnvio = new System.Windows.Forms.TextBox();
            this.textTipo = new System.Windows.Forms.TextBox();
            this.Limpiar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tablaVisibilidad = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PorcentajeEnvio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_volver = new System.Windows.Forms.Button();
            this.button_modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVisibilidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar \r\ntipo:";
            // 
            // Buscar
            // 
            this.Buscar.Location = new System.Drawing.Point(531, 170);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(75, 23);
            this.Buscar.TabIndex = 2;
            this.Buscar.Text = "Buscar";
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(396, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingresar\r\nprecio:";
            // 
            // textPrecio
            // 
            this.textPrecio.Location = new System.Drawing.Point(479, 16);
            this.textPrecio.Name = "textPrecio";
            this.textPrecio.Size = new System.Drawing.Size(100, 20);
            this.textPrecio.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label3.Location = new System.Drawing.Point(6, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingresar \r\nporcentaje:";
            // 
            // textPorcentaje
            // 
            this.textPorcentaje.Location = new System.Drawing.Point(90, 57);
            this.textPorcentaje.Name = "textPorcentaje";
            this.textPorcentaje.Size = new System.Drawing.Size(100, 20);
            this.textPorcentaje.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(396, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ingresar\r\nenvio:";
            // 
            // textEnvio
            // 
            this.textEnvio.Location = new System.Drawing.Point(479, 51);
            this.textEnvio.Name = "textEnvio";
            this.textEnvio.Size = new System.Drawing.Size(100, 20);
            this.textEnvio.TabIndex = 8;
            this.textEnvio.TextChanged += new System.EventHandler(this.textEnvio_TextChanged);
            // 
            // textTipo
            // 
            this.textTipo.Location = new System.Drawing.Point(90, 19);
            this.textTipo.Name = "textTipo";
            this.textTipo.Size = new System.Drawing.Size(100, 20);
            this.textTipo.TabIndex = 11;
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(12, 170);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(75, 23);
            this.Limpiar.TabIndex = 12;
            this.Limpiar.Text = "Limpiar";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label10.ForeColor = System.Drawing.Color.Maroon;
            this.label10.Location = new System.Drawing.Point(136, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(293, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "MODIFICACIÓN DE VISIBILIDAD";
            // 
            // tablaVisibilidad
            // 
            this.tablaVisibilidad.AllowUserToAddRows = false;
            this.tablaVisibilidad.AllowUserToDeleteRows = false;
            this.tablaVisibilidad.AllowUserToResizeColumns = false;
            this.tablaVisibilidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaVisibilidad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Tipo,
            this.Precio,
            this.Porcentaje,
            this.PorcentajeEnvio});
            this.tablaVisibilidad.Location = new System.Drawing.Point(12, 209);
            this.tablaVisibilidad.Name = "tablaVisibilidad";
            this.tablaVisibilidad.Size = new System.Drawing.Size(594, 217);
            this.tablaVisibilidad.TabIndex = 19;
            this.tablaVisibilidad.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Click_En_Seleccionar);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textPrecio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textTipo);
            this.groupBox1.Controls.Add(this.textPorcentaje);
            this.groupBox1.Controls.Add(this.textEnvio);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 99);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Width = 30;
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.MaxInputLength = 32768;
            this.Tipo.Name = "Tipo";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Porcentaje
            // 
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.Name = "Porcentaje";
            // 
            // PorcentajeEnvio
            // 
            this.PorcentajeEnvio.HeaderText = "Porcentaje Envio";
            this.PorcentajeEnvio.Name = "PorcentajeEnvio";
            // 
            // button_volver
            // 
            this.button_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button_volver.ForeColor = System.Drawing.Color.Maroon;
            this.button_volver.Location = new System.Drawing.Point(12, 442);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 21;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // button_modificar
            // 
            this.button_modificar.Location = new System.Drawing.Point(531, 442);
            this.button_modificar.Name = "button_modificar";
            this.button_modificar.Size = new System.Drawing.Size(75, 23);
            this.button_modificar.TabIndex = 22;
            this.button_modificar.Text = "Modificar";
            this.button_modificar.UseVisualStyleBackColor = true;
            this.button_modificar.Click += new System.EventHandler(this.button_modificar_Click);
            // 
            // ModificacionVisibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 477);
            this.Controls.Add(this.button_modificar);
            this.Controls.Add(this.button_volver);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tablaVisibilidad);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Buscar);
            this.Name = "ModificacionVisibilidad";
            this.Text = "ModificacionVisibilidad";
            ((System.ComponentModel.ISupportInitialize)(this.tablaVisibilidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textPrecio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textPorcentaje;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textEnvio;
        private System.Windows.Forms.TextBox textTipo;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView tablaVisibilidad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn PorcentajeEnvio;
        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.Button button_modificar;
    }
}