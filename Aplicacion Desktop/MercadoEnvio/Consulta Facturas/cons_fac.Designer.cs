namespace MercadoEnvio.Consulta_Facturas
{
    partial class cons_fac
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
            this.listado = new System.Windows.Forms.DataGridView();
            this.id_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textDestinatario = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textDescripcion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textImporte2 = new System.Windows.Forms.TextBox();
            this.textImporte1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textAnio2 = new System.Windows.Forms.TextBox();
            this.textMes2 = new System.Windows.Forms.TextBox();
            this.textAnio1 = new System.Windows.Forms.TextBox();
            this.textMes1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textDia2 = new System.Windows.Forms.TextBox();
            this.textDia1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listado
            // 
            this.listado.AllowUserToAddRows = false;
            this.listado.AllowUserToDeleteRows = false;
            this.listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_factura,
            this.desc_fecha,
            this.desc_total,
            this.id_usuario});
            this.listado.Location = new System.Drawing.Point(259, 213);
            this.listado.Margin = new System.Windows.Forms.Padding(2);
            this.listado.Name = "listado";
            this.listado.RowTemplate.Height = 24;
            this.listado.Size = new System.Drawing.Size(445, 300);
            this.listado.TabIndex = 11;
            // 
            // id_factura
            // 
            this.id_factura.HeaderText = "Nro Factura";
            this.id_factura.Name = "id_factura";
            this.id_factura.ReadOnly = true;
            // 
            // desc_fecha
            // 
            this.desc_fecha.HeaderText = "Fecha";
            this.desc_fecha.Name = "desc_fecha";
            this.desc_fecha.ReadOnly = true;
            // 
            // desc_total
            // 
            this.desc_total.HeaderText = "Importe";
            this.desc_total.Name = "desc_total";
            this.desc_total.ReadOnly = true;
            // 
            // id_usuario
            // 
            this.id_usuario.HeaderText = "Usuario";
            this.id_usuario.Name = "id_usuario";
            this.id_usuario.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "CONSULTA DE FACTURAS";
            this.label1.UseCompatibleTextRendering = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonBuscar);
            this.groupBox1.Controls.Add(this.textDestinatario);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textDescripcion);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.textImporte2);
            this.groupBox1.Controls.Add(this.textImporte1);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textAnio2);
            this.groupBox1.Controls.Add(this.textMes2);
            this.groupBox1.Controls.Add(this.textAnio1);
            this.groupBox1.Controls.Add(this.textMes1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textDia2);
            this.groupBox1.Controls.Add(this.textDia1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(804, 158);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de Búsqueda";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 24);
            this.button1.TabIndex = 24;
            this.button1.Text = "Limpiar Filtros";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(710, 128);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(88, 24);
            this.buttonBuscar.TabIndex = 23;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textDestinatario
            // 
            this.textDestinatario.Location = new System.Drawing.Point(323, 102);
            this.textDestinatario.Name = "textDestinatario";
            this.textDestinatario.Size = new System.Drawing.Size(475, 20);
            this.textDestinatario.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(323, 86);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(264, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Destinatario (Puede ser solo una parte del destinatario)";
            // 
            // textDescripcion
            // 
            this.textDescripcion.Location = new System.Drawing.Point(323, 46);
            this.textDescripcion.Name = "textDescripcion";
            this.textDescripcion.Size = new System.Drawing.Size(475, 20);
            this.textDescripcion.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(323, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(264, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Descipción (Puede ser solo un parte de la descripción)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(133, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "-";
            // 
            // textImporte2
            // 
            this.textImporte2.Location = new System.Drawing.Point(149, 118);
            this.textImporte2.Name = "textImporte2";
            this.textImporte2.Size = new System.Drawing.Size(96, 20);
            this.textImporte2.TabIndex = 17;
            // 
            // textImporte1
            // 
            this.textImporte1.Location = new System.Drawing.Point(31, 118);
            this.textImporte1.Name = "textImporte1";
            this.textImporte1.Size = new System.Drawing.Size(96, 20);
            this.textImporte1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Intervalo de importes";
            // 
            // textAnio2
            // 
            this.textAnio2.Location = new System.Drawing.Point(164, 69);
            this.textAnio2.Name = "textAnio2";
            this.textAnio2.Size = new System.Drawing.Size(20, 20);
            this.textAnio2.TabIndex = 14;
            // 
            // textMes2
            // 
            this.textMes2.Location = new System.Drawing.Point(120, 68);
            this.textMes2.Name = "textMes2";
            this.textMes2.Size = new System.Drawing.Size(20, 20);
            this.textMes2.TabIndex = 13;
            // 
            // textAnio1
            // 
            this.textAnio1.Location = new System.Drawing.Point(164, 42);
            this.textAnio1.Name = "textAnio1";
            this.textAnio1.Size = new System.Drawing.Size(20, 20);
            this.textAnio1.TabIndex = 12;
            // 
            // textMes1
            // 
            this.textMes1.Location = new System.Drawing.Point(120, 42);
            this.textMes1.Name = "textMes1";
            this.textMes1.Size = new System.Drawing.Size(20, 20);
            this.textMes1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "/";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(146, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "/";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "/";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "/";
            // 
            // textDia2
            // 
            this.textDia2.Location = new System.Drawing.Point(84, 69);
            this.textDia2.Name = "textDia2";
            this.textDia2.Size = new System.Drawing.Size(18, 20);
            this.textDia2.TabIndex = 3;
            // 
            // textDia1
            // 
            this.textDia1.Location = new System.Drawing.Point(84, 42);
            this.textDia1.Name = "textDia1";
            this.textDia1.Size = new System.Drawing.Size(18, 20);
            this.textDia1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Intervalo de fechas (Se cargan ambas fechas o ninguna)";
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(741, 513);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 14;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // cons_fac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 548);
            this.Controls.Add(this.buttonVolver);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listado);
            this.Name = "cons_fac";
            this.Text = "cons_fac";
            ((System.ComponentModel.ISupportInitialize)(this.listado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textImporte2;
        private System.Windows.Forms.TextBox textImporte1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textAnio2;
        private System.Windows.Forms.TextBox textMes2;
        private System.Windows.Forms.TextBox textAnio1;
        private System.Windows.Forms.TextBox textMes1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textDia2;
        private System.Windows.Forms.TextBox textDia1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textDestinatario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textDescripcion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_total;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_usuario;
    }
}