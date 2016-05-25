namespace MercadoEnvio.ABM_Usuario
{
    partial class seleccionRoles
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
            this.button1 = new System.Windows.Forms.Button();
            this.comboNombresRoles = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "SELECCIÓN DE ROL";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(313, 277);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboNombresRoles
            // 
            this.comboNombresRoles.FormattingEnabled = true;
            this.comboNombresRoles.Location = new System.Drawing.Point(123, 49);
            this.comboNombresRoles.Name = "comboNombresRoles";
            this.comboNombresRoles.Size = new System.Drawing.Size(121, 21);
            this.comboNombresRoles.TabIndex = 2;
            this.comboNombresRoles.SelectedIndexChanged += new System.EventHandler(this.comboNombresRoles_SelectedIndexChanged);
            // 
            // seleccionRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 313);
            this.Controls.Add(this.comboNombresRoles);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "seleccionRoles";
            this.Text = "seleccionRoles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.ComboBox comboNombresRoles;
    }
}