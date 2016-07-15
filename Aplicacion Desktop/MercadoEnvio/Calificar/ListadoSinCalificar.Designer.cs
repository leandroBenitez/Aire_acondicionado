namespace MercadoEnvio.ListadoCalificaciones
{
    partial class ListadoSinCalificar
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
            this.calificacionListado = new System.Windows.Forms.DataGridView();
            this.button_seleccionar = new System.Windows.Forms.Button();
            this.Volver = new System.Windows.Forms.Button();
            this.idCalificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.calificacionListado)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calificacionListado
            // 
            this.calificacionListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calificacionListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCalificacion,
            this.Publicacion,
            this.Vendedor});
            this.calificacionListado.Location = new System.Drawing.Point(17, 35);
            this.calificacionListado.Name = "calificacionListado";
            this.calificacionListado.Size = new System.Drawing.Size(449, 195);
            this.calificacionListado.TabIndex = 0;
            // 
            // button_seleccionar
            // 
            this.button_seleccionar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.button_seleccionar.Location = new System.Drawing.Point(391, 251);
            this.button_seleccionar.Name = "button_seleccionar";
            this.button_seleccionar.Size = new System.Drawing.Size(75, 23);
            this.button_seleccionar.TabIndex = 1;
            this.button_seleccionar.Text = "Seleccionar";
            this.button_seleccionar.UseVisualStyleBackColor = true;
            this.button_seleccionar.Click += new System.EventHandler(this.button_seleccionar_Click);
            // 
            // Volver
            // 
            this.Volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.Volver.ForeColor = System.Drawing.Color.Maroon;
            this.Volver.Location = new System.Drawing.Point(17, 251);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(75, 23);
            this.Volver.TabIndex = 2;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // idCalificacion
            // 
            this.idCalificacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idCalificacion.HeaderText = "CalificacionID";
            this.idCalificacion.Name = "idCalificacion";
            // 
            // Publicacion
            // 
            this.Publicacion.HeaderText = "Publicacion";
            this.Publicacion.Name = "Publicacion";
            this.Publicacion.Width = 200;
            // 
            // Vendedor
            // 
            this.Vendedor.HeaderText = "Vendedor";
            this.Vendedor.Name = "Vendedor";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.calificacionListado);
            this.groupBox1.Controls.Add(this.Volver);
            this.groupBox1.Controls.Add(this.button_seleccionar);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(483, 289);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Publicidades sin calificar";
            // 
            // ListadoSinCalificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 373);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListadoSinCalificar";
            this.Text = "ListadoSinCalificar";
            ((System.ComponentModel.ISupportInitialize)(this.calificacionListado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView calificacionListado;
        private System.Windows.Forms.Button button_seleccionar;
        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCalificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendedor;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}