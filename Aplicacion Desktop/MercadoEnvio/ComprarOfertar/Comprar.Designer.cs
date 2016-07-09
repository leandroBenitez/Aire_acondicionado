namespace MercadoEnvio.ComprarOfertar
{
    partial class Comprar
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
            this.presentacion = new System.Windows.Forms.Label();
            this.articulo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.combo_cantidad = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_valor = new System.Windows.Forms.Label();
            this.cost_envio = new System.Windows.Forms.Label();
            this.total_real = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.check_envio = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // presentacion
            // 
            this.presentacion.AutoSize = true;
            this.presentacion.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentacion.ForeColor = System.Drawing.Color.Maroon;
            this.presentacion.Location = new System.Drawing.Point(36, 9);
            this.presentacion.Name = "presentacion";
            this.presentacion.Size = new System.Drawing.Size(333, 23);
            this.presentacion.TabIndex = 2;
            this.presentacion.Text = "Mercado Envíos - Confirmación de compra";
            // 
            // articulo
            // 
            this.articulo.AutoSize = true;
            this.articulo.Location = new System.Drawing.Point(37, 49);
            this.articulo.Name = "articulo";
            this.articulo.Size = new System.Drawing.Size(44, 13);
            this.articulo.TabIndex = 3;
            this.articulo.Text = "Artículo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirme la cantidad:";
            // 
            // combo_cantidad
            // 
            this.combo_cantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_cantidad.FormattingEnabled = true;
            this.combo_cantidad.Location = new System.Drawing.Point(149, 76);
            this.combo_cantidad.Name = "combo_cantidad";
            this.combo_cantidad.Size = new System.Drawing.Size(44, 21);
            this.combo_cantidad.TabIndex = 5;
            this.combo_cantidad.SelectedIndexChanged += new System.EventHandler(this.combo_cantidad_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(68, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Costo envio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(243, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total:";
            // 
            // label_valor
            // 
            this.label_valor.AutoSize = true;
            this.label_valor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_valor.Location = new System.Drawing.Point(334, 77);
            this.label_valor.Name = "label_valor";
            this.label_valor.Size = new System.Drawing.Size(41, 15);
            this.label_valor.TabIndex = 11;
            this.label_valor.Text = "costo";
            // 
            // cost_envio
            // 
            this.cost_envio.AutoSize = true;
            this.cost_envio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_envio.Location = new System.Drawing.Point(334, 102);
            this.cost_envio.Name = "cost_envio";
            this.cost_envio.Size = new System.Drawing.Size(83, 15);
            this.cost_envio.TabIndex = 12;
            this.cost_envio.Text = "costo_envio";
            // 
            // total_real
            // 
            this.total_real.AutoSize = true;
            this.total_real.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_real.Location = new System.Drawing.Point(334, 129);
            this.total_real.Name = "total_real";
            this.total_real.Size = new System.Drawing.Size(35, 15);
            this.total_real.TabIndex = 13;
            this.total_real.Text = "total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Envio disponible:";
            // 
            // check_envio
            // 
            this.check_envio.AutoSize = true;
            this.check_envio.Location = new System.Drawing.Point(130, 104);
            this.check_envio.Name = "check_envio";
            this.check_envio.Size = new System.Drawing.Size(15, 14);
            this.check_envio.TabIndex = 15;
            this.check_envio.UseVisualStyleBackColor = true;
            this.check_envio.CheckedChanged += new System.EventHandler(this.check_envio_CheckedChanged);
            // 
            // Comprar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 196);
            this.Controls.Add(this.check_envio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.total_real);
            this.Controls.Add(this.cost_envio);
            this.Controls.Add(this.label_valor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.combo_cantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.articulo);
            this.Controls.Add(this.presentacion);
            this.Name = "Comprar";
            this.Text = "Confirmar compra";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label presentacion;
        private System.Windows.Forms.Label articulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox combo_cantidad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_valor;
        private System.Windows.Forms.Label cost_envio;
        private System.Windows.Forms.Label total_real;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox check_envio;

    }
}