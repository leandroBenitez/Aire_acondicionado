﻿namespace MercadoEnvio.ComprarOfertar
{
    partial class Publicaciones
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
            this.combo_rubros = new System.Windows.Forms.ComboBox();
            this.radio_compra = new System.Windows.Forms.RadioButton();
            this.radio_subasta = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fecha_hasta = new System.Windows.Forms.DateTimePicker();
            this.fecha_desde = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.boton_limpiar = new System.Windows.Forms.Button();
            this.boton_aplicar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.precio_hasta = new System.Windows.Forms.TextBox();
            this.precio_desde = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.text_libre = new System.Windows.Forms.TextBox();
            this.presentacion = new System.Windows.Forms.Label();
            this.dataGridViewPub = new System.Windows.Forms.DataGridView();
            this.boton_buscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.descrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_costo_envio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_fecha_venc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPub)).BeginInit();
            this.SuspendLayout();
            // 
            // combo_rubros
            // 
            this.combo_rubros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_rubros.FormattingEnabled = true;
            this.combo_rubros.Location = new System.Drawing.Point(6, 90);
            this.combo_rubros.Name = "combo_rubros";
            this.combo_rubros.Size = new System.Drawing.Size(163, 21);
            this.combo_rubros.TabIndex = 0;
            // 
            // radio_compra
            // 
            this.radio_compra.AutoSize = true;
            this.radio_compra.Checked = true;
            this.radio_compra.Location = new System.Drawing.Point(38, 31);
            this.radio_compra.Name = "radio_compra";
            this.radio_compra.Size = new System.Drawing.Size(61, 17);
            this.radio_compra.TabIndex = 1;
            this.radio_compra.TabStop = true;
            this.radio_compra.Text = "Compra";
            this.radio_compra.UseVisualStyleBackColor = true;
            this.radio_compra.CheckedChanged += new System.EventHandler(this.radio_compra_CheckedChanged);
            // 
            // radio_subasta
            // 
            this.radio_subasta.AutoSize = true;
            this.radio_subasta.Location = new System.Drawing.Point(38, 54);
            this.radio_subasta.Name = "radio_subasta";
            this.radio_subasta.Size = new System.Drawing.Size(64, 17);
            this.radio_subasta.TabIndex = 2;
            this.radio_subasta.Text = "Subasta";
            this.radio_subasta.UseVisualStyleBackColor = true;
            this.radio_subasta.CheckedChanged += new System.EventHandler(this.radio_subasta_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tipo de publicación";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.boton_limpiar);
            this.panel1.Controls.Add(this.boton_aplicar);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.radio_compra);
            this.panel1.Controls.Add(this.radio_subasta);
            this.panel1.Controls.Add(this.combo_rubros);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 312);
            this.panel1.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fecha_hasta);
            this.groupBox2.Controls.Add(this.fecha_desde);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(6, 195);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 72);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Finalizacion";
            // 
            // fecha_hasta
            // 
            this.fecha_hasta.Location = new System.Drawing.Point(88, 43);
            this.fecha_hasta.Name = "fecha_hasta";
            this.fecha_hasta.Size = new System.Drawing.Size(69, 20);
            this.fecha_hasta.TabIndex = 12;
            // 
            // fecha_desde
            // 
            this.fecha_desde.Location = new System.Drawing.Point(6, 43);
            this.fecha_desde.Name = "fecha_desde";
            this.fecha_desde.Size = new System.Drawing.Size(69, 20);
            this.fecha_desde.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(106, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Hasta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Desde";
            // 
            // boton_limpiar
            // 
            this.boton_limpiar.Location = new System.Drawing.Point(99, 276);
            this.boton_limpiar.Name = "boton_limpiar";
            this.boton_limpiar.Size = new System.Drawing.Size(75, 23);
            this.boton_limpiar.TabIndex = 7;
            this.boton_limpiar.Text = "Limpiar";
            this.boton_limpiar.UseVisualStyleBackColor = true;
            // 
            // boton_aplicar
            // 
            this.boton_aplicar.Location = new System.Drawing.Point(6, 276);
            this.boton_aplicar.Name = "boton_aplicar";
            this.boton_aplicar.Size = new System.Drawing.Size(75, 23);
            this.boton_aplicar.TabIndex = 6;
            this.boton_aplicar.Text = "Aplicar";
            this.boton_aplicar.UseVisualStyleBackColor = true;
            this.boton_aplicar.Click += new System.EventHandler(this.boton_aplicar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.precio_hasta);
            this.groupBox1.Controls.Add(this.precio_desde);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(6, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 72);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Precio";
            // 
            // precio_hasta
            // 
            this.precio_hasta.Location = new System.Drawing.Point(93, 43);
            this.precio_hasta.Name = "precio_hasta";
            this.precio_hasta.Size = new System.Drawing.Size(64, 20);
            this.precio_hasta.TabIndex = 12;
            // 
            // precio_desde
            // 
            this.precio_desde.Location = new System.Drawing.Point(6, 43);
            this.precio_desde.Name = "precio_desde";
            this.precio_desde.Size = new System.Drawing.Size(64, 20);
            this.precio_desde.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Desde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rubro";
            // 
            // text_libre
            // 
            this.text_libre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_libre.Location = new System.Drawing.Point(200, 43);
            this.text_libre.Name = "text_libre";
            this.text_libre.Size = new System.Drawing.Size(506, 22);
            this.text_libre.TabIndex = 6;
            // 
            // presentacion
            // 
            this.presentacion.AutoSize = true;
            this.presentacion.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentacion.ForeColor = System.Drawing.Color.Maroon;
            this.presentacion.Location = new System.Drawing.Point(237, 9);
            this.presentacion.Name = "presentacion";
            this.presentacion.Size = new System.Drawing.Size(264, 23);
            this.presentacion.TabIndex = 7;
            this.presentacion.Text = "Mercado Envios - Compras online";
            // 
            // dataGridViewPub
            // 
            this.dataGridViewPub.AllowUserToAddRows = false;
            this.dataGridViewPub.AllowUserToDeleteRows = false;
            this.dataGridViewPub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.descrip,
            this.desc_stock,
            this.desc_precio,
            this.desc_costo_envio,
            this.desc_fecha_venc});
            this.dataGridViewPub.Location = new System.Drawing.Point(200, 69);
            this.dataGridViewPub.Name = "dataGridViewPub";
            this.dataGridViewPub.ReadOnly = true;
            this.dataGridViewPub.Size = new System.Drawing.Size(587, 312);
            this.dataGridViewPub.TabIndex = 8;
            // 
            // boton_buscar
            // 
            this.boton_buscar.Location = new System.Drawing.Point(712, 42);
            this.boton_buscar.Name = "boton_buscar";
            this.boton_buscar.Size = new System.Drawing.Size(75, 23);
            this.boton_buscar.TabIndex = 10;
            this.boton_buscar.Text = "Buscar";
            this.boton_buscar.UseVisualStyleBackColor = true;
            this.boton_buscar.Click += new System.EventHandler(this.boton_buscar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Filtros de busqueda";
            // 
            // descrip
            // 
            this.descrip.HeaderText = "Descripcion";
            this.descrip.Name = "descrip";
            this.descrip.ReadOnly = true;
            // 
            // desc_stock
            // 
            this.desc_stock.HeaderText = "Stock";
            this.desc_stock.Name = "desc_stock";
            this.desc_stock.ReadOnly = true;
            // 
            // desc_precio
            // 
            this.desc_precio.HeaderText = "Precio";
            this.desc_precio.Name = "desc_precio";
            this.desc_precio.ReadOnly = true;
            // 
            // desc_costo_envio
            // 
            this.desc_costo_envio.HeaderText = "Costo Envio";
            this.desc_costo_envio.Name = "desc_costo_envio";
            this.desc_costo_envio.ReadOnly = true;
            // 
            // desc_fecha_venc
            // 
            this.desc_fecha_venc.HeaderText = "Fecha Vencimiento";
            this.desc_fecha_venc.Name = "desc_fecha_venc";
            this.desc_fecha_venc.ReadOnly = true;
            // 
            // Publicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 393);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boton_buscar);
            this.Controls.Add(this.dataGridViewPub);
            this.Controls.Add(this.presentacion);
            this.Controls.Add(this.text_libre);
            this.Controls.Add(this.panel1);
            this.Name = "Publicaciones";
            this.Text = "Buscador Publicaciones";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_rubros;
        private System.Windows.Forms.RadioButton radio_compra;
        private System.Windows.Forms.RadioButton radio_subasta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox text_libre;
        private System.Windows.Forms.Label presentacion;
        private System.Windows.Forms.TextBox precio_desde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewPub;
        private System.Windows.Forms.Button boton_buscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button boton_limpiar;
        private System.Windows.Forms.Button boton_aplicar;
        private System.Windows.Forms.TextBox precio_hasta;
        private System.Windows.Forms.DateTimePicker fecha_hasta;
        private System.Windows.Forms.DateTimePicker fecha_desde;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_costo_envio;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_fecha_venc;
    }
}