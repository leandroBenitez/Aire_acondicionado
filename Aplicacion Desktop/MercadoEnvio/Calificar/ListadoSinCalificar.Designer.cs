namespace MercadoEnvio.Calificar
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
            this.Publicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_seleccionar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.calificacionListado)).BeginInit();
            this.SuspendLayout();
            // 
            // calificacionListado
            // 
            this.calificacionListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.calificacionListado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Publicacion,
            this.Calificación});
            this.calificacionListado.Location = new System.Drawing.Point(13, 24);
            this.calificacionListado.Name = "calificacionListado";
            this.calificacionListado.Size = new System.Drawing.Size(242, 174);
            this.calificacionListado.TabIndex = 0;
            // 
            // Publicacion
            // 
            this.Publicacion.HeaderText = "Publicacion";
            this.Publicacion.Name = "Publicacion";
            // 
            // Calificación
            // 
            this.Calificación.HeaderText = "Calificación";
            this.Calificación.Name = "Calificación";
            // 
            // button_seleccionar
            // 
            this.button_seleccionar.Location = new System.Drawing.Point(180, 223);
            this.button_seleccionar.Name = "button_seleccionar";
            this.button_seleccionar.Size = new System.Drawing.Size(75, 23);
            this.button_seleccionar.TabIndex = 1;
            this.button_seleccionar.Text = "Seleccionar";
            this.button_seleccionar.UseVisualStyleBackColor = true;
            // 
            // ListadoSinCalificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 306);
            this.Controls.Add(this.button_seleccionar);
            this.Controls.Add(this.calificacionListado);
            this.Name = "ListadoSinCalificar";
            this.Text = "ListadoSinCalificar";
            ((System.ComponentModel.ISupportInitialize)(this.calificacionListado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView calificacionListado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calificación;
        private System.Windows.Forms.Button button_seleccionar;
    }
}