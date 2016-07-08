namespace MercadoEnvio.ABM_Usuario
{
    partial class altaCliente
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
            this.labelCliente = new System.Windows.Forms.Label();
            this.buttonAlta = new System.Windows.Forms.Button();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.comboTipoDoc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textFechaCre = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.textTelefono = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textCP = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textLocalidad = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textDepto = new System.Windows.Forms.TextBox();
            this.textPiso = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textAltura = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textCalle = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboDominio = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textMail = new System.Windows.Forms.TextBox();
            this.textDni = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textRol = new System.Windows.Forms.TextBox();
            this.textPassword = new System.Windows.Forms.TextBox();
            this.textUsername = new System.Windows.Forms.TextBox();
            this.buttonVolver = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.groupBoxCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCliente
            // 
            this.labelCliente.AutoSize = true;
            this.labelCliente.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCliente.Location = new System.Drawing.Point(25, 9);
            this.labelCliente.Name = "labelCliente";
            this.labelCliente.Size = new System.Drawing.Size(182, 26);
            this.labelCliente.TabIndex = 0;
            this.labelCliente.Text = "ALTA DE CLIENTE";
            // 
            // buttonAlta
            // 
            this.buttonAlta.Location = new System.Drawing.Point(282, 469);
            this.buttonAlta.Name = "buttonAlta";
            this.buttonAlta.Size = new System.Drawing.Size(73, 27);
            this.buttonAlta.TabIndex = 38;
            this.buttonAlta.Text = "Alta";
            this.buttonAlta.UseVisualStyleBackColor = true;
            this.buttonAlta.Click += new System.EventHandler(this.buttonAlta_Click);
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Controls.Add(this.fechaNacimiento);
            this.groupBoxCliente.Controls.Add(this.comboTipoDoc);
            this.groupBoxCliente.Controls.Add(this.label8);
            this.groupBoxCliente.Controls.Add(this.textFechaCre);
            this.groupBoxCliente.Controls.Add(this.label18);
            this.groupBoxCliente.Controls.Add(this.label17);
            this.groupBoxCliente.Controls.Add(this.textTelefono);
            this.groupBoxCliente.Controls.Add(this.label16);
            this.groupBoxCliente.Controls.Add(this.textCP);
            this.groupBoxCliente.Controls.Add(this.label15);
            this.groupBoxCliente.Controls.Add(this.textLocalidad);
            this.groupBoxCliente.Controls.Add(this.label14);
            this.groupBoxCliente.Controls.Add(this.textDepto);
            this.groupBoxCliente.Controls.Add(this.textPiso);
            this.groupBoxCliente.Controls.Add(this.label13);
            this.groupBoxCliente.Controls.Add(this.label12);
            this.groupBoxCliente.Controls.Add(this.textAltura);
            this.groupBoxCliente.Controls.Add(this.label11);
            this.groupBoxCliente.Controls.Add(this.textCalle);
            this.groupBoxCliente.Controls.Add(this.label10);
            this.groupBoxCliente.Controls.Add(this.label9);
            this.groupBoxCliente.Controls.Add(this.comboDominio);
            this.groupBoxCliente.Controls.Add(this.label7);
            this.groupBoxCliente.Controls.Add(this.textMail);
            this.groupBoxCliente.Controls.Add(this.textDni);
            this.groupBoxCliente.Controls.Add(this.label6);
            this.groupBoxCliente.Controls.Add(this.textApellido);
            this.groupBoxCliente.Controls.Add(this.label5);
            this.groupBoxCliente.Controls.Add(this.textNombre);
            this.groupBoxCliente.Location = new System.Drawing.Point(17, 159);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(338, 283);
            this.groupBoxCliente.TabIndex = 48;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Datos Cliente";
            // 
            // comboTipoDoc
            // 
            this.comboTipoDoc.FormattingEnabled = true;
            this.comboTipoDoc.Location = new System.Drawing.Point(116, 55);
            this.comboTipoDoc.Name = "comboTipoDoc";
            this.comboTipoDoc.Size = new System.Drawing.Size(83, 21);
            this.comboTipoDoc.TabIndex = 103;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 102;
            this.label8.Text = "Tpo. de Doc:";
            // 
            // textFechaCre
            // 
            this.textFechaCre.Location = new System.Drawing.Point(117, 227);
            this.textFechaCre.Name = "textFechaCre";
            this.textFechaCre.ReadOnly = true;
            this.textFechaCre.Size = new System.Drawing.Size(83, 20);
            this.textFechaCre.TabIndex = 100;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 230);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(100, 13);
            this.label18.TabIndex = 99;
            this.label18.Text = "Fecha de Creacion:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(8, 203);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 13);
            this.label17.TabIndex = 96;
            this.label17.Text = "Fecha Nacimiento:";
            // 
            // textTelefono
            // 
            this.textTelefono.Location = new System.Drawing.Point(116, 173);
            this.textTelefono.Name = "textTelefono";
            this.textTelefono.Size = new System.Drawing.Size(100, 20);
            this.textTelefono.TabIndex = 95;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(49, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 94;
            this.label16.Text = "Telefono:";
            // 
            // textCP
            // 
            this.textCP.Location = new System.Drawing.Point(285, 125);
            this.textCP.Name = "textCP";
            this.textCP.Size = new System.Drawing.Size(38, 20);
            this.textCP.TabIndex = 93;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(255, 128);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 13);
            this.label15.TabIndex = 92;
            this.label15.Text = "CP:";
            // 
            // textLocalidad
            // 
            this.textLocalidad.Location = new System.Drawing.Point(116, 148);
            this.textLocalidad.Name = "textLocalidad";
            this.textLocalidad.Size = new System.Drawing.Size(214, 20);
            this.textLocalidad.TabIndex = 91;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(48, 151);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 90;
            this.label14.Text = "Localidad:";
            // 
            // textDepto
            // 
            this.textDepto.Location = new System.Drawing.Point(219, 125);
            this.textDepto.Name = "textDepto";
            this.textDepto.Size = new System.Drawing.Size(31, 20);
            this.textDepto.TabIndex = 89;
            // 
            // textPiso
            // 
            this.textPiso.Location = new System.Drawing.Point(148, 125);
            this.textPiso.Name = "textPiso";
            this.textPiso.Size = new System.Drawing.Size(34, 20);
            this.textPiso.TabIndex = 88;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(185, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 87;
            this.label13.Text = "Depto.:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(114, 128);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 86;
            this.label12.Text = "Piso:";
            // 
            // textAltura
            // 
            this.textAltura.Location = new System.Drawing.Point(256, 103);
            this.textAltura.Name = "textAltura";
            this.textAltura.Size = new System.Drawing.Size(57, 20);
            this.textAltura.TabIndex = 85;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(213, 106);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 84;
            this.label11.Text = "Altura:";
            // 
            // textCalle
            // 
            this.textCalle.Location = new System.Drawing.Point(117, 103);
            this.textCalle.Name = "textCalle";
            this.textCalle.Size = new System.Drawing.Size(82, 20);
            this.textCalle.TabIndex = 83;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 106);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 82;
            this.label10.Text = "Direccion:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(210, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 81;
            this.label9.Text = "@";
            // 
            // comboDominio
            // 
            this.comboDominio.FormattingEnabled = true;
            this.comboDominio.Location = new System.Drawing.Point(234, 78);
            this.comboDominio.Name = "comboDominio";
            this.comboDominio.Size = new System.Drawing.Size(90, 21);
            this.comboDominio.TabIndex = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "Mail:";
            // 
            // textMail
            // 
            this.textMail.Location = new System.Drawing.Point(116, 80);
            this.textMail.Name = "textMail";
            this.textMail.Size = new System.Drawing.Size(83, 20);
            this.textMail.TabIndex = 78;
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(243, 55);
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(80, 20);
            this.textDni.TabIndex = 77;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 76;
            this.label6.Text = "DNI:";
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(205, 29);
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(119, 20);
            this.textApellido.TabIndex = 75;
            this.textApellido.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Nombre y Apellido:";
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(116, 29);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(83, 20);
            this.textNombre.TabIndex = 73;
            this.textNombre.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textRol);
            this.groupBox1.Controls.Add(this.textPassword);
            this.groupBox1.Controls.Add(this.textUsername);
            this.groupBox1.Controls.Add(this.buttonVolver);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(17, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 104);
            this.groupBox1.TabIndex = 110;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Usuario";
            // 
            // textRol
            // 
            this.textRol.Location = new System.Drawing.Point(102, 68);
            this.textRol.Name = "textRol";
            this.textRol.ReadOnly = true;
            this.textRol.Size = new System.Drawing.Size(83, 20);
            this.textRol.TabIndex = 51;
            // 
            // textPassword
            // 
            this.textPassword.Location = new System.Drawing.Point(102, 41);
            this.textPassword.Name = "textPassword";
            this.textPassword.ReadOnly = true;
            this.textPassword.Size = new System.Drawing.Size(83, 20);
            this.textPassword.TabIndex = 50;
            this.textPassword.UseSystemPasswordChar = true;
            // 
            // textUsername
            // 
            this.textUsername.Location = new System.Drawing.Point(102, 16);
            this.textUsername.Name = "textUsername";
            this.textUsername.ReadOnly = true;
            this.textUsername.Size = new System.Drawing.Size(83, 20);
            this.textUsername.TabIndex = 49;
            // 
            // buttonVolver
            // 
            this.buttonVolver.Location = new System.Drawing.Point(255, 65);
            this.buttonVolver.Name = "buttonVolver";
            this.buttonVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonVolver.TabIndex = 48;
            this.buttonVolver.Text = "Volver";
            this.buttonVolver.UseVisualStyleBackColor = true;
            this.buttonVolver.Click += new System.EventHandler(this.buttonVolver_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Rol a asignar:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // fechaNacimiento
            // 
            this.fechaNacimiento.Location = new System.Drawing.Point(116, 199);
            this.fechaNacimiento.Name = "fechaNacimiento";
            this.fechaNacimiento.Size = new System.Drawing.Size(100, 20);
            this.fechaNacimiento.TabIndex = 108;
            // 
            // altaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 506);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxCliente);
            this.Controls.Add(this.buttonAlta);
            this.Controls.Add(this.labelCliente);
            this.Name = "altaCliente";
            this.Text = "Alta Cliente";
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCliente;
        private System.Windows.Forms.Button buttonAlta;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.ComboBox comboTipoDoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textFechaCre;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textTelefono;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textCP;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textLocalidad;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textDepto;
        private System.Windows.Forms.TextBox textPiso;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textAltura;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textCalle;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboDominio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textMail;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonVolver;
        private System.Windows.Forms.TextBox textRol;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.TextBox textUsername;
        private System.Windows.Forms.DateTimePicker fechaNacimiento;
    }
}