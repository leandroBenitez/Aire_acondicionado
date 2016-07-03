namespace MercadoEnvio.ABM_Usuario
{
    partial class subMenuUsuario
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
            this.buttonAlta = new System.Windows.Forms.Button();
            this.buttonModCliente = new System.Windows.Forms.Button();
            this.buttonModEmpresa = new System.Windows.Forms.Button();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAlta
            // 
            this.buttonAlta.Location = new System.Drawing.Point(32, 24);
            this.buttonAlta.Name = "buttonAlta";
            this.buttonAlta.Size = new System.Drawing.Size(133, 36);
            this.buttonAlta.TabIndex = 0;
            this.buttonAlta.Text = "Alta Usuario";
            this.buttonAlta.UseVisualStyleBackColor = true;
            this.buttonAlta.Click += new System.EventHandler(this.buttonAlta_Click);
            // 
            // buttonModCliente
            // 
            this.buttonModCliente.Location = new System.Drawing.Point(32, 82);
            this.buttonModCliente.Name = "buttonModCliente";
            this.buttonModCliente.Size = new System.Drawing.Size(133, 34);
            this.buttonModCliente.TabIndex = 2;
            this.buttonModCliente.Text = "Modificacion/Baja Cliente";
            this.buttonModCliente.UseVisualStyleBackColor = true;
            this.buttonModCliente.Click += new System.EventHandler(this.buttonModCliente_Click);
            // 
            // buttonModEmpresa
            // 
            this.buttonModEmpresa.Location = new System.Drawing.Point(35, 132);
            this.buttonModEmpresa.Name = "buttonModEmpresa";
            this.buttonModEmpresa.Size = new System.Drawing.Size(130, 34);
            this.buttonModEmpresa.TabIndex = 3;
            this.buttonModEmpresa.Text = "Modificacion/Baja Empresa";
            this.buttonModEmpresa.UseVisualStyleBackColor = true;
            this.buttonModEmpresa.Click += new System.EventHandler(this.buttonModEmpresa_Click);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(58, 188);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 4;
            this.buttonSalir.Text = "Volver";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // subMenuUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 224);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.buttonModEmpresa);
            this.Controls.Add(this.buttonModCliente);
            this.Controls.Add(this.buttonAlta);
            this.Name = "subMenuUsuario";
            this.Text = "subMenuUsuario";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonAlta;
        private System.Windows.Forms.Button buttonModCliente;
        private System.Windows.Forms.Button buttonModEmpresa;
        private System.Windows.Forms.Button buttonSalir;
    }
}