namespace MercadoEnvio.ABM_Empresa
{
    partial class buscarEmpresa
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
            this.RAZON_SOCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CUIT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FEC_CREACION = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUBRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRE_CONTACTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CIUDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOMICILIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NRO_CALLE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PISO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COD_POSTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOCALIDAD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_EMPRESA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textCuit = new System.Windows.Forms.TextBox();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textRazSoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lalalalla = new System.Windows.Forms.Label();
            this.lalala = new System.Windows.Forms.Label();
            this.leyendaBusqueda = new System.Windows.Forms.Label();
            this.B_Limpiar = new System.Windows.Forms.Button();
            this.B_Buscar = new System.Windows.Forms.Button();
            this.B_Volver = new System.Windows.Forms.Button();
            this.buttonMod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "BÚSQUEDA EMPRESA";
            // 
            // listado
            // 
            this.listado.AllowUserToAddRows = false;
            this.listado.AllowUserToDeleteRows = false;
            this.listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_LOGIN,
            this.USUARIO,
            this.RAZON_SOCIAL,
            this.CUIT,
            this.FEC_CREACION,
            this.EMAIL,
            this.RUBRO,
            this.NOMBRE_CONTACTO,
            this.CIUDAD,
            this.DOMICILIO,
            this.NRO_CALLE,
            this.PISO,
            this.DPTO,
            this.COD_POSTAL,
            this.LOCALIDAD,
            this.TELEFONO,
            this.ID_EMPRESA});
            this.listado.Location = new System.Drawing.Point(3, 173);
            this.listado.Margin = new System.Windows.Forms.Padding(2);
            this.listado.Name = "listado";
            this.listado.RowTemplate.Height = 24;
            this.listado.Size = new System.Drawing.Size(1340, 256);
            this.listado.TabIndex = 13;
            // 
            // ID_LOGIN
            // 
            this.ID_LOGIN.HeaderText = "Id_Login";
            this.ID_LOGIN.Name = "ID_LOGIN";
            this.ID_LOGIN.Visible = false;
            // 
            // USUARIO
            // 
            this.USUARIO.HeaderText = "Usuario";
            this.USUARIO.Name = "USUARIO";
            // 
            // RAZON_SOCIAL
            // 
            this.RAZON_SOCIAL.HeaderText = "Razon Social";
            this.RAZON_SOCIAL.Name = "RAZON_SOCIAL";
            // 
            // CUIT
            // 
            this.CUIT.HeaderText = "Cuit";
            this.CUIT.Name = "CUIT";
            // 
            // FEC_CREACION
            // 
            this.FEC_CREACION.HeaderText = "Fecha Creacion";
            this.FEC_CREACION.Name = "FEC_CREACION";
            // 
            // EMAIL
            // 
            this.EMAIL.HeaderText = "Email";
            this.EMAIL.Name = "EMAIL";
            // 
            // RUBRO
            // 
            this.RUBRO.HeaderText = "Rubro";
            this.RUBRO.Name = "RUBRO";
            // 
            // NOMBRE_CONTACTO
            // 
            this.NOMBRE_CONTACTO.HeaderText = "Nombre Contacto";
            this.NOMBRE_CONTACTO.Name = "NOMBRE_CONTACTO";
            // 
            // CIUDAD
            // 
            this.CIUDAD.HeaderText = "Ciudad";
            this.CIUDAD.Name = "CIUDAD";
            // 
            // DOMICILIO
            // 
            this.DOMICILIO.HeaderText = "Domicilio";
            this.DOMICILIO.Name = "DOMICILIO";
            // 
            // NRO_CALLE
            // 
            this.NRO_CALLE.HeaderText = "Nro Calle";
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
            // COD_POSTAL
            // 
            this.COD_POSTAL.HeaderText = "Codigo Postal";
            this.COD_POSTAL.Name = "COD_POSTAL";
            // 
            // LOCALIDAD
            // 
            this.LOCALIDAD.HeaderText = "Localidad";
            this.LOCALIDAD.Name = "LOCALIDAD";
            // 
            // TELEFONO
            // 
            this.TELEFONO.HeaderText = "Telefono";
            this.TELEFONO.Name = "TELEFONO";
            // 
            // ID_EMPRESA
            // 
            this.ID_EMPRESA.HeaderText = "ID_EMPRESA";
            this.ID_EMPRESA.Name = "ID_EMPRESA";
            this.ID_EMPRESA.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textCuit);
            this.groupBox1.Controls.Add(this.textEmail);
            this.groupBox1.Controls.Add(this.textRazSoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lalalalla);
            this.groupBox1.Controls.Add(this.lalala);
            this.groupBox1.Controls.Add(this.leyendaBusqueda);
            this.groupBox1.Controls.Add(this.B_Limpiar);
            this.groupBox1.Controls.Add(this.B_Buscar);
            this.groupBox1.Location = new System.Drawing.Point(11, 37);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1025, 132);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtros de búsqueda";
            // 
            // textCuit
            // 
            this.textCuit.Location = new System.Drawing.Point(410, 56);
            this.textCuit.Margin = new System.Windows.Forms.Padding(2);
            this.textCuit.MaxLength = 20;
            this.textCuit.Name = "textCuit";
            this.textCuit.Size = new System.Drawing.Size(120, 20);
            this.textCuit.TabIndex = 3;
            // 
            // textEmail
            // 
            this.textEmail.Location = new System.Drawing.Point(569, 28);
            this.textEmail.Margin = new System.Windows.Forms.Padding(2);
            this.textEmail.MaxLength = 255;
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(120, 20);
            this.textEmail.TabIndex = 2;
            // 
            // textRazSoc
            // 
            this.textRazSoc.Location = new System.Drawing.Point(410, 28);
            this.textRazSoc.Margin = new System.Windows.Forms.Padding(2);
            this.textRazSoc.MaxLength = 100;
            this.textRazSoc.Name = "textRazSoc";
            this.textRazSoc.Size = new System.Drawing.Size(120, 20);
            this.textRazSoc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Email";
            // 
            // lalalalla
            // 
            this.lalalalla.AutoSize = true;
            this.lalalalla.Location = new System.Drawing.Point(337, 56);
            this.lalalalla.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lalalalla.Name = "lalalalla";
            this.lalalalla.Size = new System.Drawing.Size(25, 13);
            this.lalalalla.TabIndex = 6;
            this.lalalalla.Text = "Cuit";
            // 
            // lalala
            // 
            this.lalala.AutoSize = true;
            this.lalala.Location = new System.Drawing.Point(337, 30);
            this.lalala.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lalala.Name = "lalala";
            this.lalala.Size = new System.Drawing.Size(70, 13);
            this.lalala.TabIndex = 5;
            this.lalala.Text = "Razon Social";
            // 
            // leyendaBusqueda
            // 
            this.leyendaBusqueda.AutoSize = true;
            this.leyendaBusqueda.Location = new System.Drawing.Point(4, 117);
            this.leyendaBusqueda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.leyendaBusqueda.Name = "leyendaBusqueda";
            this.leyendaBusqueda.Size = new System.Drawing.Size(633, 13);
            this.leyendaBusqueda.TabIndex = 4;
            this.leyendaBusqueda.Text = "Para modificar o dar de baja a una empresa haga click sobre la flecha de la izqui" +
    "erda (primera columna) en la fila que desea modificar";
            // 
            // B_Limpiar
            // 
            this.B_Limpiar.Location = new System.Drawing.Point(317, 80);
            this.B_Limpiar.Margin = new System.Windows.Forms.Padding(2);
            this.B_Limpiar.Name = "B_Limpiar";
            this.B_Limpiar.Size = new System.Drawing.Size(90, 25);
            this.B_Limpiar.TabIndex = 5;
            this.B_Limpiar.Text = "Limpiar";
            this.B_Limpiar.UseVisualStyleBackColor = true;
            this.B_Limpiar.Click += new System.EventHandler(this.B_Limpiar_Click);
            // 
            // B_Buscar
            // 
            this.B_Buscar.Location = new System.Drawing.Point(599, 80);
            this.B_Buscar.Margin = new System.Windows.Forms.Padding(2);
            this.B_Buscar.Name = "B_Buscar";
            this.B_Buscar.Size = new System.Drawing.Size(90, 25);
            this.B_Buscar.TabIndex = 4;
            this.B_Buscar.Text = "Buscar";
            this.B_Buscar.UseVisualStyleBackColor = true;
            this.B_Buscar.Click += new System.EventHandler(this.B_Buscar_Click);
            // 
            // B_Volver
            // 
            this.B_Volver.Location = new System.Drawing.Point(12, 434);
            this.B_Volver.Name = "B_Volver";
            this.B_Volver.Size = new System.Drawing.Size(90, 25);
            this.B_Volver.TabIndex = 8;
            this.B_Volver.Text = "Volver";
            this.B_Volver.UseVisualStyleBackColor = true;
            this.B_Volver.Click += new System.EventHandler(this.B_Volver_Click);
            // 
            // buttonMod
            // 
            this.buttonMod.Location = new System.Drawing.Point(1277, 434);
            this.buttonMod.Name = "buttonMod";
            this.buttonMod.Size = new System.Drawing.Size(75, 23);
            this.buttonMod.TabIndex = 14;
            this.buttonMod.Text = "Modificar";
            this.buttonMod.UseVisualStyleBackColor = true;
            this.buttonMod.Click += new System.EventHandler(this.buttonMod_Click);
            // 
            // buscarEmpresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 467);
            this.Controls.Add(this.buttonMod);
            this.Controls.Add(this.B_Volver);
            this.Controls.Add(this.listado);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "buscarEmpresa";
            this.Text = "modificacionEmpresa";
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
        private System.Windows.Forms.Button B_Volver;
        private System.Windows.Forms.TextBox textCuit;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.TextBox textRazSoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lalalalla;
        private System.Windows.Forms.Label lalala;
        private System.Windows.Forms.Label leyendaBusqueda;
        private System.Windows.Forms.Button B_Limpiar;
        private System.Windows.Forms.Button B_Buscar;
        private System.Windows.Forms.Button buttonMod;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_LOGIN;
        private System.Windows.Forms.DataGridViewTextBoxColumn USUARIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAZON_SOCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn CUIT;
        private System.Windows.Forms.DataGridViewTextBoxColumn FEC_CREACION;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUBRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRE_CONTACTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIUDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOMICILIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NRO_CALLE;
        private System.Windows.Forms.DataGridViewTextBoxColumn PISO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn COD_POSTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOCALIDAD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONO;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_EMPRESA;
    }
}