namespace MercadoEnvio.ComprarOfertar
{
    partial class Publicaciones_subasta
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.check_list = new System.Windows.Forms.CheckedListBox();
            this.boton_limpiar = new System.Windows.Forms.Button();
            this.boton_aplicar = new System.Windows.Forms.Button();
            this.text_libre = new System.Windows.Forms.TextBox();
            this.presentacion = new System.Windows.Forms.Label();
            this.dataGridViewPub = new System.Windows.Forms.DataGridView();
            this.boton_buscar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.id_publi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_costo_envio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_fecha_venc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio_viz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPub)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.check_list);
            this.panel1.Controls.Add(this.boton_limpiar);
            this.panel1.Controls.Add(this.boton_aplicar);
            this.panel1.Location = new System.Drawing.Point(10, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 312);
            this.panel1.TabIndex = 5;
            // 
            // check_list
            // 
            this.check_list.FormattingEnabled = true;
            this.check_list.Location = new System.Drawing.Point(6, 13);
            this.check_list.Name = "check_list";
            this.check_list.Size = new System.Drawing.Size(201, 244);
            this.check_list.TabIndex = 8;
            // 
            // boton_limpiar
            // 
            this.boton_limpiar.Location = new System.Drawing.Point(132, 276);
            this.boton_limpiar.Name = "boton_limpiar";
            this.boton_limpiar.Size = new System.Drawing.Size(75, 23);
            this.boton_limpiar.TabIndex = 7;
            this.boton_limpiar.Text = "Limpiar";
            this.boton_limpiar.UseVisualStyleBackColor = true;
            this.boton_limpiar.Click += new System.EventHandler(this.boton_limpiar_Click);
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
            // text_libre
            // 
            this.text_libre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.text_libre.Location = new System.Drawing.Point(228, 43);
            this.text_libre.Name = "text_libre";
            this.text_libre.Size = new System.Drawing.Size(519, 22);
            this.text_libre.TabIndex = 6;
            // 
            // presentacion
            // 
            this.presentacion.AutoSize = true;
            this.presentacion.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentacion.ForeColor = System.Drawing.Color.Maroon;
            this.presentacion.Location = new System.Drawing.Point(237, 9);
            this.presentacion.Name = "presentacion";
            this.presentacion.Size = new System.Drawing.Size(271, 23);
            this.presentacion.TabIndex = 7;
            this.presentacion.Text = "Mercado Envíos - Subastas online";
            // 
            // dataGridViewPub
            // 
            this.dataGridViewPub.AllowUserToAddRows = false;
            this.dataGridViewPub.AllowUserToDeleteRows = false;
            this.dataGridViewPub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_publi,
            this.descrip,
            this.desc_stock,
            this.desc_precio,
            this.desc_costo_envio,
            this.desc_fecha_venc,
            this.precio_viz});
            this.dataGridViewPub.Location = new System.Drawing.Point(228, 69);
            this.dataGridViewPub.Name = "dataGridViewPub";
            this.dataGridViewPub.ReadOnly = true;
            this.dataGridViewPub.Size = new System.Drawing.Size(600, 284);
            this.dataGridViewPub.TabIndex = 8;
            // 
            // boton_buscar
            // 
            this.boton_buscar.Location = new System.Drawing.Point(753, 42);
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
            this.label5.Location = new System.Drawing.Point(7, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(202, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Filtros de busqueda por Rubro";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(571, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Página Sig. >";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(347, 358);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(79, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "< Página Ant.";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(250, 358);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(91, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "<< Primera Pág.";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(656, 358);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(91, 23);
            this.button4.TabIndex = 14;
            this.button4.Text = "Última Pág. >>";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(432, 358);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(133, 23);
            this.button5.TabIndex = 15;
            this.button5.Text = "Ofertar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Maroon;
            this.button6.Location = new System.Drawing.Point(765, 358);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(63, 23);
            this.button6.TabIndex = 16;
            this.button6.Text = "Volver";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // id_publi
            // 
            this.id_publi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.id_publi.HeaderText = "Cod. Public.";
            this.id_publi.MinimumWidth = 50;
            this.id_publi.Name = "id_publi";
            this.id_publi.ReadOnly = true;
            this.id_publi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.id_publi.Width = 50;
            // 
            // descrip
            // 
            this.descrip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.descrip.HeaderText = "Descripcion";
            this.descrip.MinimumWidth = 10;
            this.descrip.Name = "descrip";
            this.descrip.ReadOnly = true;
            this.descrip.Width = 10;
            // 
            // desc_stock
            // 
            this.desc_stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.desc_stock.HeaderText = "Stock";
            this.desc_stock.MinimumWidth = 40;
            this.desc_stock.Name = "desc_stock";
            this.desc_stock.ReadOnly = true;
            this.desc_stock.Width = 40;
            // 
            // desc_precio
            // 
            this.desc_precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.desc_precio.HeaderText = "Ult. Oferta";
            this.desc_precio.MinimumWidth = 80;
            this.desc_precio.Name = "desc_precio";
            this.desc_precio.ReadOnly = true;
            this.desc_precio.Width = 80;
            // 
            // desc_costo_envio
            // 
            this.desc_costo_envio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.desc_costo_envio.HeaderText = "Costo Envio";
            this.desc_costo_envio.MinimumWidth = 40;
            this.desc_costo_envio.Name = "desc_costo_envio";
            this.desc_costo_envio.ReadOnly = true;
            this.desc_costo_envio.Width = 40;
            // 
            // desc_fecha_venc
            // 
            this.desc_fecha_venc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.desc_fecha_venc.FillWeight = 140F;
            this.desc_fecha_venc.HeaderText = "Fecha Vencimiento";
            this.desc_fecha_venc.MinimumWidth = 10;
            this.desc_fecha_venc.Name = "desc_fecha_venc";
            this.desc_fecha_venc.ReadOnly = true;
            this.desc_fecha_venc.Width = 10;
            // 
            // precio_viz
            // 
            this.precio_viz.HeaderText = "precio_viz";
            this.precio_viz.Name = "precio_viz";
            this.precio_viz.ReadOnly = true;
            this.precio_viz.Visible = false;
            // 
            // Publicaciones_subasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 393);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.boton_buscar);
            this.Controls.Add(this.dataGridViewPub);
            this.Controls.Add(this.presentacion);
            this.Controls.Add(this.text_libre);
            this.Controls.Add(this.panel1);
            this.Name = "Publicaciones_subasta";
            this.Text = "Buscador Publicaciones";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox text_libre;
        private System.Windows.Forms.Label presentacion;
        private System.Windows.Forms.DataGridView dataGridViewPub;
        private System.Windows.Forms.Button boton_buscar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button boton_limpiar;
        private System.Windows.Forms.Button boton_aplicar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.CheckedListBox check_list;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_publi;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_costo_envio;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_fecha_venc;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio_viz;
    }
}