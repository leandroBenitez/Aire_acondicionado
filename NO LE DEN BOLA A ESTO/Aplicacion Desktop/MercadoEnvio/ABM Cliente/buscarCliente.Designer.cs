namespace MercadoEnvio.ABM_Usuario
{
    partial class buscarCliente
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
            this.listado = new System.Windows.Forms.DataGridView();
            this.ID_LOGIN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USUARIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APELLIDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPO_DOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOMICILIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NRO_CALLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PISO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOCALIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_POSTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FEC_NAC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboBoxTipoDoc = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.B_Buscar = new System.Windows.Forms.Button();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.B_Limpiar = new System.Windows.Forms.Button();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textDni = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.B_Volver = new System.Windows.Forms.Button();
            this.leyendaBusqueda = new System.Windows.Forms.Label();
            this.buttonMod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "BÚSQUEDA CLIENTE";
            // 
            // listado
            // 
            this.listado.AllowUserToAddRows = false;
            this.listado.AllowUserToDeleteRows = false;
            this.listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_LOGIN,
            this.USUARIO,
            this.APELLIDO,
            this.NOMBRE,
            this.TIPO_DOC,
            this.DNI,
            this.EMAIL,
            this.DOMICILIO,
            this.NRO_CALLE,
            this.PISO,
            this.DPTO,
            this.LOCALIDAD,
            this.COD_POSTAL,
            this.TELEFONO,
            this.FEC_NAC,
            this.Rol,
            this.ID_Cliente});
            this.listado.Location = new System.Drawing.Point(11, 224);
            this.listado.Margin = new System.Windows.Forms.Padding(2);
            this.listado.Name = "listado";
            this.listado.RowTemplate.Height = 24;
            this.listado.Size = new System.Drawing.Size(892, 300);
            this.listado.TabIndex = 10;
            // 
            // ID_LOGIN
            // 
            this.ID_LOGIN.HeaderText = "ID_Login";
            this.ID_LOGIN.Name = "ID_LOGIN";
            this.ID_LOGIN.ReadOnly = true;
            this.ID_LOGIN.Visible = false;
            // 
            // USUARIO
            // 
            this.USUARIO.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.USUARIO.HeaderText = "Usuario";
            this.USUARIO.Name = "USUARIO";
            this.USUARIO.ReadOnly = true;
            this.USUARIO.Width = 68;
            // 
            // APELLIDO
            // 
            this.APELLIDO.HeaderText = "Apellido";
            this.APELLIDO.Name = "APELLIDO";
            // 
            // NOMBRE
            // 
            this.NOMBRE.HeaderText = "Nombre";
            this.NOMBRE.Name = "NOMBRE";
            // 
            // TIPO_DOC
            // 
            this.TIPO_DOC.HeaderText = "Tipo Doc";
            this.TIPO_DOC.Name = "TIPO_DOC";
            // 
            // DNI
            // 
            this.DNI.HeaderText = "Nro Doc";
            this.DNI.Name = "DNI";
            // 
            // EMAIL
            // 
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.Name = "EMAIL";
            // 
            // DOMICILIO
            // 
            this.DOMICILIO.HeaderText = "Domicilio";
            this.DOMICILIO.Name = "DOMICILIO";
            // 
            // NRO_CALLE
            // 
            this.NRO_CALLE.HeaderText = "Numero";
            this.NRO_CALLE.Name = "NRO_CALLE";
            // 
            // PISO
            // 
            this.PISO.HeaderText = "Piso";
            this.PISO.Name = "PISO";
            // 
            // DPTO
            // 
            this.DPTO.HeaderText = "Depto";
            this.DPTO.Name = "DPTO";
            // 
            // LOCALIDAD
            // 
            this.LOCALIDAD.HeaderText = "Localidad";
            this.LOCALIDAD.Name = "LOCALIDAD";
            // 
            // COD_POSTAL
            // 
            this.COD_POSTAL.HeaderText = "Codigo Postal";
            this.COD_POSTAL.Name = "COD_POSTAL";
            // 
            // TELEFONO
            // 
            this.TELEFONO.HeaderText = "Telefono";
            this.TELEFONO.Name = "TELEFONO";
            // 
            // FEC_NAC
            // 
            this.FEC_NAC.HeaderText = "Fecha Nacimiento";
            this.FEC_NAC.Name = "FEC_NAC";
            // 
            // Rol
            // 
            this.Rol.HeaderText = "Rol";
            this.Rol.Name = "Rol";
            this.Rol.ReadOnly = true;
            // 
            // ID_Cliente
            // 
            this.ID_Cliente.HeaderText = "ID_Cliente";
            this.ID_Cliente.Name = "ID_Cliente";
            this.ID_Cliente.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ComboBoxTipoDoc);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textEmail);
            this.groupBox1.Controls.Add(this.B_Buscar);
            this.groupBox1.Controls.Add(this.textApellido);
            this.groupBox1.Controls.Add(this.B_Limpiar);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.textDni);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(11, 47);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(892, 143);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // ComboBoxTipoDoc
            // 
            this.ComboBoxTipoDoc.FormattingEnabled = true;
            this.ComboBoxTipoDoc.Location = new System.Drawing.Point(257, 25);
            this.ComboBoxTipoDoc.Name = "ComboBoxTipoDoc";
            this.ComboBoxTipoDoc.Size = new System.Drawing.Size(71, 21);
            this.ComboBoxTipoDoc.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(199, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Tipo Doc";
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(257, 50);
            this.textEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textEmail.MaxLength = 255;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(120, 20);
            this.textEmail.TabIndex = 4;
            // 
            // B_Buscar
            // 
            this.B_Buscar.Location = new System.Drawing.Point(447, 99);
            this.B_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.B_Buscar.Name = "B_Buscar";
            this.B_Buscar.Size = new System.Drawing.Size(90, 25);
            this.B_Buscar.TabIndex = 5;
            this.B_Buscar.Text = "Buscar";
            this.B_Buscar.UseVisualStyleBackColor = true;
            this.B_Buscar.Click += new System.EventHandler(this.B_Buscar_Click);
            // 
            // textApellido
            // 
            this.textApellido.Location = new System.Drawing.Point(74, 25);
            this.textApellido.Margin = new System.Windows.Forms.Padding(2);
            this.textApellido.MaxLength = 255;
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(120, 20);
            this.textApellido.TabIndex = 3;
            // 
            // B_Limpiar
            // 
            this.B_Limpiar.Location = new System.Drawing.Point(447, 52);
            this.B_Limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.B_Limpiar.Name = "B_Limpiar";
            this.B_Limpiar.Size = new System.Drawing.Size(90, 23);
            this.B_Limpiar.TabIndex = 6;
            this.B_Limpiar.Text = "Limpiar Filtros";
            this.B_Limpiar.UseVisualStyleBackColor = true;
            this.B_Limpiar.Click += new System.EventHandler(this.B_Limpiar_Click);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(74, 49);
            this.textNombre.Margin = new System.Windows.Forms.Padding(2);
            this.textNombre.MaxLength = 255;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(120, 20);
            this.textNombre.TabIndex = 2;
            // 
            // textDni
            // 
            this.textDni.Location = new System.Drawing.Point(417, 28);
            this.textDni.Margin = new System.Windows.Forms.Padding(2);
            this.textDni.MaxLength = 18;
            this.textDni.Name = "textDni";
            this.textDni.Size = new System.Drawing.Size(120, 20);
            this.textDni.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Apellido";
            // 
            // B_Volver
            // 
            this.B_Volver.Location = new System.Drawing.Point(12, 529);
            this.B_Volver.Name = "B_Volver";
            this.B_Volver.Size = new System.Drawing.Size(90, 25);
            this.B_Volver.TabIndex = 9;
            this.B_Volver.Text = "Volver";
            this.B_Volver.UseVisualStyleBackColor = true;
            this.B_Volver.Click += new System.EventHandler(this.B_Volver_Click);
            // 
            // leyendaBusqueda
            // 
            this.leyendaBusqueda.AutoSize = true;
            this.leyendaBusqueda.Location = new System.Drawing.Point(8, 209);
            this.leyendaBusqueda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.leyendaBusqueda.Name = "leyendaBusqueda";
            this.leyendaBusqueda.Size = new System.Drawing.Size(544, 13);
            this.leyendaBusqueda.TabIndex = 8;
            this.leyendaBusqueda.Text = "Para modificar un cliente haga click sobre la flecha de la izquierda (primera col" +
    "umna) en la fila que desea modificar";
            this.leyendaBusqueda.Visible = false;
            // 
            // buttonMod
            // 
            this.buttonMod.Location = new System.Drawing.Point(828, 529);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(75, 23);
            this.buttonMod.TabIndex = 11;
            this.buttonMod.Text = "Modificar";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
            // 
            // buscarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 597);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.listado);
            this.Controls.Add(this.B_Volver);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.leyendaBusqueda);
            this.Name = "buscarCliente";
            this.Text = "modificacionUsuario";
            ((System.ComponentModel.ISupportInitialize)(this.listado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView listado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ComboBoxTipoDoc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button B_Volver;
        private System.Windows.Forms.Label leyendaBusqueda;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Button B_Buscar;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.Button B_Limpiar;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textDni;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_LOGIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APELLIDO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPO_DOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOMICILIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRO_CALLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PISO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOCALIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_POSTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn FEC_NAC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Cliente;
    }
}