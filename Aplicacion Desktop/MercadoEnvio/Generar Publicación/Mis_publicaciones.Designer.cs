namespace MercadoEnvio.Generar_Publicación
{
    partial class Mis_publicaciones
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
            this.dataGridViewPub = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_publi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo_Publicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc_costo_envio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.boton_modificar = new System.Windows.Forms.Button();
            this.boton_volver = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_estados = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPub)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPub
            // 
            this.dataGridViewPub.AllowUserToAddRows = false;
            this.dataGridViewPub.AllowUserToDeleteRows = false;
            this.dataGridViewPub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dataGridViewPub.Location = new System.Drawing.Point(12, 47);
            this.dataGridViewPub.Name = "dataGridViewPub";
            this.dataGridViewPub.ReadOnly = true;
            this.dataGridViewPub.Size = new System.Drawing.Size(559, 193);
            this.dataGridViewPub.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id Publicacion";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Descripcion";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Tipo publicacion";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Stock";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Precio";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Precio envio";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Publicacion";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Vencimiento";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Rubro";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Visualizacion";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Estado";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // id_publi
            // 
            this.id_publi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.id_publi.HeaderText = "ID publicacion";
            this.id_publi.MinimumWidth = 50;
            this.id_publi.Name = "id_publi";
            this.id_publi.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // descrip
            // 
            this.descrip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.descrip.HeaderText = "Descripcion";
            this.descrip.MinimumWidth = 10;
            this.descrip.Name = "descrip";
            // 
            // Tipo_Publicacion
            // 
            this.Tipo_Publicacion.HeaderText = "Tipo publicacion";
            this.Tipo_Publicacion.Name = "Tipo_Publicacion";
            // 
            // desc_stock
            // 
            this.desc_stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.desc_stock.HeaderText = "Stock";
            this.desc_stock.MinimumWidth = 40;
            this.desc_stock.Name = "desc_stock";
            // 
            // desc_precio
            // 
            this.desc_precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.desc_precio.HeaderText = "Precio";
            this.desc_precio.MinimumWidth = 80;
            this.desc_precio.Name = "desc_precio";
            // 
            // desc_costo_envio
            // 
            this.desc_costo_envio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader;
            this.desc_costo_envio.HeaderText = "Costo Envio";
            this.desc_costo_envio.MinimumWidth = 40;
            this.desc_costo_envio.Name = "desc_costo_envio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Para cambiar el estado de alguna de sus publicaciones, seleccionela y haga click " +
    "en \"Modificar\"";
            // 
            // boton_modificar
            // 
            this.boton_modificar.Location = new System.Drawing.Point(469, 246);
            this.boton_modificar.Name = "boton_modificar";
            this.boton_modificar.Size = new System.Drawing.Size(102, 23);
            this.boton_modificar.TabIndex = 11;
            this.boton_modificar.Text = "Modificar";
            this.boton_modificar.UseVisualStyleBackColor = true;
            this.boton_modificar.Click += new System.EventHandler(this.boton_modificar_Click);
            // 
            // boton_volver
            // 
            this.boton_volver.Location = new System.Drawing.Point(12, 246);
            this.boton_volver.Name = "boton_volver";
            this.boton_volver.Size = new System.Drawing.Size(102, 23);
            this.boton_volver.TabIndex = 12;
            this.boton_volver.Text = "Volver";
            this.boton_volver.UseVisualStyleBackColor = true;
            this.boton_volver.Click += new System.EventHandler(this.boton_volver_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nuevo estado:";
            // 
            // combo_estados
            // 
            this.combo_estados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_estados.FormattingEnabled = true;
            this.combo_estados.Location = new System.Drawing.Point(327, 248);
            this.combo_estados.Name = "combo_estados";
            this.combo_estados.Size = new System.Drawing.Size(116, 21);
            this.combo_estados.TabIndex = 14;
            // 
            // Mis_publicaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 281);
            this.Controls.Add(this.combo_estados);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boton_volver);
            this.Controls.Add(this.boton_modificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewPub);
            this.Name = "Mis_publicaciones";
            this.Text = "Mis Publicaciones";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPub;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_publi;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo_Publicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc_costo_envio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button boton_modificar;
        private System.Windows.Forms.Button boton_volver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_estados;
    }
}