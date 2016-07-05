namespace MercadoEnvio.ComprarOfertar
{
    partial class Subastar
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ult_monto = new System.Windows.Forms.Label();
            this.ult_fecha = new System.Windows.Forms.Label();
            this.fecha_venc = new System.Windows.Forms.Label();
            this.nuevo_monto = new System.Windows.Forms.TextBox();
            this.check_envio = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.total_real = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // presentacion
            // 
            this.presentacion.AutoSize = true;
            this.presentacion.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentacion.ForeColor = System.Drawing.Color.Maroon;
            this.presentacion.Location = new System.Drawing.Point(36, 9);
            this.presentacion.Name = "presentacion";
            this.presentacion.Size = new System.Drawing.Size(329, 23);
            this.presentacion.TabIndex = 2;
            this.presentacion.Text = "Mercado Envios - Confirmación de oferta";
            // 
            // articulo
            // 
            this.articulo.AutoSize = true;
            this.articulo.Location = new System.Drawing.Point(37, 49);
            this.articulo.Name = "articulo";
            this.articulo.Size = new System.Drawing.Size(41, 13);
            this.articulo.TabIndex = 3;
            this.articulo.Text = "articulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Confirme monto a ofertar:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(290, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(57, 201);
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
            this.label3.Location = new System.Drawing.Point(37, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Monto ultima oferta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha ultima oferta:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Fecha finalizacion:";
            // 
            // ult_monto
            // 
            this.ult_monto.AutoSize = true;
            this.ult_monto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ult_monto.Location = new System.Drawing.Point(143, 76);
            this.ult_monto.Name = "ult_monto";
            this.ult_monto.Size = new System.Drawing.Size(71, 15);
            this.ult_monto.TabIndex = 11;
            this.ult_monto.Text = "ult_monto";
            // 
            // ult_fecha
            // 
            this.ult_fecha.AutoSize = true;
            this.ult_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ult_fecha.Location = new System.Drawing.Point(143, 104);
            this.ult_fecha.Name = "ult_fecha";
            this.ult_fecha.Size = new System.Drawing.Size(66, 15);
            this.ult_fecha.TabIndex = 12;
            this.ult_fecha.Text = "ult_fecha";
            // 
            // fecha_venc
            // 
            this.fecha_venc.AutoSize = true;
            this.fecha_venc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha_venc.Location = new System.Drawing.Point(330, 104);
            this.fecha_venc.Name = "fecha_venc";
            this.fecha_venc.Size = new System.Drawing.Size(35, 15);
            this.fecha_venc.TabIndex = 13;
            this.fecha_venc.Text = "total";
            // 
            // nuevo_monto
            // 
            this.nuevo_monto.Location = new System.Drawing.Point(168, 138);
            this.nuevo_monto.Name = "nuevo_monto";
            this.nuevo_monto.Size = new System.Drawing.Size(100, 20);
            this.nuevo_monto.TabIndex = 14;
            // 
            // check_envio
            // 
            this.check_envio.AutoSize = true;
            this.check_envio.Location = new System.Drawing.Point(130, 172);
            this.check_envio.Name = "check_envio";
            this.check_envio.Size = new System.Drawing.Size(15, 14);
            this.check_envio.TabIndex = 17;
            this.check_envio.UseVisualStyleBackColor = true;
            this.check_envio.CheckedChanged += new System.EventHandler(this.check_envio_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Envio disponible:";
            // 
            // total_real
            // 
            this.total_real.AutoSize = true;
            this.total_real.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_real.Location = new System.Drawing.Point(165, 170);
            this.total_real.Name = "total_real";
            this.total_real.Size = new System.Drawing.Size(35, 15);
            this.total_real.TabIndex = 18;
            this.total_real.Text = "total";
            // 
            // Subastar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 236);
            this.Controls.Add(this.total_real);
            this.Controls.Add(this.check_envio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nuevo_monto);
            this.Controls.Add(this.fecha_venc);
            this.Controls.Add(this.ult_fecha);
            this.Controls.Add(this.ult_monto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.articulo);
            this.Controls.Add(this.presentacion);
            this.Name = "Subastar";
            this.Text = "Confirmar oferta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label presentacion;
        private System.Windows.Forms.Label articulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ult_monto;
        private System.Windows.Forms.Label ult_fecha;
        private System.Windows.Forms.Label fecha_venc;
        private System.Windows.Forms.TextBox nuevo_monto;
        private System.Windows.Forms.CheckBox check_envio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label total_real;

    }
}