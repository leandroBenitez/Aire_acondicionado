namespace MercadoEnvio
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.presentacion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_user = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.button_ingreso = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // presentacion
            // 
            this.presentacion.AutoSize = true;
            this.presentacion.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentacion.ForeColor = System.Drawing.Color.Maroon;
            this.presentacion.Location = new System.Drawing.Point(12, 18);
            this.presentacion.Name = "presentacion";
            this.presentacion.Size = new System.Drawing.Size(379, 23);
            this.presentacion.TabIndex = 1;
            this.presentacion.Text = "Mercado Envios - Un sistema de compras online";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // textBox_user
            // 
            this.textBox_user.Location = new System.Drawing.Point(145, 68);
            this.textBox_user.MaxLength = 50;
            this.textBox_user.Name = "textBox_user";
            this.textBox_user.Size = new System.Drawing.Size(122, 20);
            this.textBox_user.TabIndex = 1;
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(145, 109);
            this.textBox_pass.MaxLength = 50;
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.PasswordChar = '●';
            this.textBox_pass.Size = new System.Drawing.Size(122, 20);
            this.textBox_pass.TabIndex = 2;
            // 
            // button_ingreso
            // 
            this.button_ingreso.Location = new System.Drawing.Point(289, 151);
            this.button_ingreso.Name = "button_ingreso";
            this.button_ingreso.Size = new System.Drawing.Size(102, 23);
            this.button_ingreso.TabIndex = 3;
            this.button_ingreso.Text = "Ingresar";
            this.button_ingreso.UseVisualStyleBackColor = true;
            this.button_ingreso.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 189);
            this.Controls.Add(this.button_ingreso);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_user);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.presentacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RightToLeftLayout = true;
            this.Text = "Mercado Envios - Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label presentacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_user;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Button button_ingreso;
    }
}

