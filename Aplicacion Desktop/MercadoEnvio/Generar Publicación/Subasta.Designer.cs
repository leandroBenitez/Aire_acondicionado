namespace MercadoEnvio.Generar_Publicación
{
    partial class Subasta
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
            this.combo_rubros = new System.Windows.Forms.ComboBox();
            this.desc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_stock = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.text_precio = new System.Windows.Forms.TextBox();
            this.combo_vis = new System.Windows.Forms.ComboBox();
            this.combo_estado_pu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_id_publicacion = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_user = new System.Windows.Forms.Label();
            this.check_envio = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textbox_envio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.fecha_sys = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.boton_finalizar = new System.Windows.Forms.Button();
            this.boton_salir = new System.Windows.Forms.Button();
            this.fecha_vencimiento = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese los datos de su publicación:";
            // 
            // combo_rubros
            // 
            this.combo_rubros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_rubros.FormattingEnabled = true;
            this.combo_rubros.Location = new System.Drawing.Point(347, 145);
            this.combo_rubros.Name = "combo_rubros";
            this.combo_rubros.Size = new System.Drawing.Size(197, 21);
            this.combo_rubros.TabIndex = 4;
            // 
            // desc
            // 
            this.desc.Location = new System.Drawing.Point(99, 76);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(445, 20);
            this.desc.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descripción:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stock:";
            // 
            // text_stock
            // 
            this.text_stock.Location = new System.Drawing.Point(71, 111);
            this.text_stock.Name = "text_stock";
            this.text_stock.Size = new System.Drawing.Size(65, 20);
            this.text_stock.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valor inicial:";
            // 
            // text_precio
            // 
            this.text_precio.Location = new System.Drawing.Point(248, 111);
            this.text_precio.Name = "text_precio";
            this.text_precio.Size = new System.Drawing.Size(75, 20);
            this.text_precio.TabIndex = 10;
            // 
            // combo_vis
            // 
            this.combo_vis.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_vis.FormattingEnabled = true;
            this.combo_vis.Location = new System.Drawing.Point(347, 184);
            this.combo_vis.Name = "combo_vis";
            this.combo_vis.Size = new System.Drawing.Size(197, 21);
            this.combo_vis.TabIndex = 11;
            this.combo_vis.SelectedIndexChanged += new System.EventHandler(this.combo_vis_SelectedIndexChanged);
            // 
            // combo_estado_pu
            // 
            this.combo_estado_pu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_estado_pu.FormattingEnabled = true;
            this.combo_estado_pu.Location = new System.Drawing.Point(347, 223);
            this.combo_estado_pu.Name = "combo_estado_pu";
            this.combo_estado_pu.Size = new System.Drawing.Size(197, 21);
            this.combo_estado_pu.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Codigo de Publicación:";
            // 
            // label_id_publicacion
            // 
            this.label_id_publicacion.AutoSize = true;
            this.label_id_publicacion.Location = new System.Drawing.Point(149, 45);
            this.label_id_publicacion.Name = "label_id_publicacion";
            this.label_id_publicacion.Size = new System.Drawing.Size(70, 13);
            this.label_id_publicacion.TabIndex = 14;
            this.label_id_publicacion.Text = "soyUnCodigo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(334, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Usuario Responsable:";
            // 
            // label_user
            // 
            this.label_user.AutoSize = true;
            this.label_user.Location = new System.Drawing.Point(451, 45);
            this.label_user.Name = "label_user";
            this.label_user.Size = new System.Drawing.Size(73, 13);
            this.label_user.TabIndex = 16;
            this.label_user.Text = "soyUnUsuario";
            // 
            // check_envio
            // 
            this.check_envio.AutoSize = true;
            this.check_envio.Location = new System.Drawing.Point(347, 113);
            this.check_envio.Name = "check_envio";
            this.check_envio.Size = new System.Drawing.Size(53, 17);
            this.check_envio.TabIndex = 17;
            this.check_envio.Text = "Envio";
            this.check_envio.UseVisualStyleBackColor = true;
            this.check_envio.CheckedChanged += new System.EventHandler(this.check_envio_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Costo Envío:";
            // 
            // textbox_envio
            // 
            this.textbox_envio.Enabled = false;
            this.textbox_envio.Location = new System.Drawing.Point(479, 111);
            this.textbox_envio.Name = "textbox_envio";
            this.textbox_envio.Size = new System.Drawing.Size(65, 20);
            this.textbox_envio.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(298, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Rubro:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(270, 187);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Visualización:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Inicio:";
            // 
            // fecha_sys
            // 
            this.fecha_sys.AutoSize = true;
            this.fecha_sys.Location = new System.Drawing.Point(84, 32);
            this.fecha_sys.Name = "fecha_sys";
            this.fecha_sys.Size = new System.Drawing.Size(58, 13);
            this.fecha_sys.TabIndex = 23;
            this.fecha_sys.Text = "una_fecha";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 64);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(68, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Vencimiento:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fecha_vencimiento);
            this.groupBox1.Controls.Add(this.fecha_sys);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(21, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 99);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fechas";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(298, 226);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Estado:";
            // 
            // boton_finalizar
            // 
            this.boton_finalizar.Location = new System.Drawing.Point(420, 265);
            this.boton_finalizar.Name = "boton_finalizar";
            this.boton_finalizar.Size = new System.Drawing.Size(124, 23);
            this.boton_finalizar.TabIndex = 28;
            this.boton_finalizar.Text = "Finalizar";
            this.boton_finalizar.UseVisualStyleBackColor = true;
            this.boton_finalizar.Click += new System.EventHandler(this.boton_finalizar_Click);
            // 
            // boton_salir
            // 
            this.boton_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_salir.ForeColor = System.Drawing.Color.Red;
            this.boton_salir.Location = new System.Drawing.Point(30, 265);
            this.boton_salir.Name = "boton_salir";
            this.boton_salir.Size = new System.Drawing.Size(133, 23);
            this.boton_salir.TabIndex = 29;
            this.boton_salir.Text = "Cancelar";
            this.boton_salir.UseVisualStyleBackColor = true;
            this.boton_salir.Click += new System.EventHandler(this.boton_salir_Click);
            // 
            // fecha_vencimiento
            // 
            this.fecha_vencimiento.CustomFormat = "";
            this.fecha_vencimiento.Location = new System.Drawing.Point(80, 58);
            this.fecha_vencimiento.Name = "fecha_vencimiento";
            this.fecha_vencimiento.Size = new System.Drawing.Size(102, 20);
            this.fecha_vencimiento.TabIndex = 32;
            this.fecha_vencimiento.Value = new System.DateTime(2016, 6, 17, 0, 0, 0, 0);
            // 
            // Subasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 302);
            this.Controls.Add(this.boton_salir);
            this.Controls.Add(this.boton_finalizar);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textbox_envio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.check_envio);
            this.Controls.Add(this.label_user);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label_id_publicacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.combo_estado_pu);
            this.Controls.Add(this.combo_vis);
            this.Controls.Add(this.text_precio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.text_stock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.combo_rubros);
            this.Controls.Add(this.label1);
            this.Name = "Subasta";
            this.Text = "Subasta";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_rubros;
        private System.Windows.Forms.TextBox desc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_stock;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox text_precio;
        private System.Windows.Forms.ComboBox combo_vis;
        private System.Windows.Forms.ComboBox combo_estado_pu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_id_publicacion;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_user;
        private System.Windows.Forms.CheckBox check_envio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textbox_envio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label fecha_sys;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button boton_finalizar;
        private System.Windows.Forms.Button boton_salir;
        private System.Windows.Forms.DateTimePicker fecha_vencimiento;

    }
}