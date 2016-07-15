namespace MercadoEnvio.Calificaciones
{
    partial class InformeCalificar
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
            this.button_volver = new System.Windows.Forms.Button();
            this.dataGridView_calificaciones = new System.Windows.Forms.DataGridView();
            this.IdCalificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vendedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Publicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.combo_calificacion = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.button_seleccionar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView_historial = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.presentacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_calificaciones)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_historial)).BeginInit();
            this.SuspendLayout();
            // 
            // button_volver
            // 
            this.button_volver.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.button_volver.ForeColor = System.Drawing.Color.Maroon;
            this.button_volver.Location = new System.Drawing.Point(23, 602);
            this.button_volver.Name = "button_volver";
            this.button_volver.Size = new System.Drawing.Size(75, 23);
            this.button_volver.TabIndex = 13;
            this.button_volver.Text = "Volver";
            this.button_volver.UseVisualStyleBackColor = true;
            this.button_volver.Click += new System.EventHandler(this.button_volver_Click);
            // 
            // dataGridView_calificaciones
            // 
            this.dataGridView_calificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_calificaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdCalificacion,
            this.Vendedor,
            this.Publicacion});
            this.dataGridView_calificaciones.Location = new System.Drawing.Point(16, 65);
            this.dataGridView_calificaciones.Name = "dataGridView_calificaciones";
            this.dataGridView_calificaciones.Size = new System.Drawing.Size(346, 176);
            this.dataGridView_calificaciones.TabIndex = 14;
            // 
            // IdCalificacion
            // 
            this.IdCalificacion.HeaderText = "IdCalificacion";
            this.IdCalificacion.Name = "IdCalificacion";
            // 
            // Vendedor
            // 
            this.Vendedor.HeaderText = "Publicacion";
            this.Vendedor.Name = "Vendedor";
            // 
            // Publicacion
            // 
            this.Publicacion.HeaderText = "Vendedor";
            this.Publicacion.Name = "Publicacion";
            // 
            // combo_calificacion
            // 
            this.combo_calificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_calificacion.FormattingEnabled = true;
            this.combo_calificacion.Location = new System.Drawing.Point(220, 25);
            this.combo_calificacion.Name = "combo_calificacion";
            this.combo_calificacion.Size = new System.Drawing.Size(44, 21);
            this.combo_calificacion.TabIndex = 15;
            this.combo_calificacion.SelectedIndexChanged += new System.EventHandler(this.combo_calificacion_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(58, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Seleccione una calificacion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(295, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Total:";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_total.Location = new System.Drawing.Point(335, 261);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(13, 13);
            this.label_total.TabIndex = 18;
            this.label_total.Text = "0";
            // 
            // button_seleccionar
            // 
            this.button_seleccionar.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_seleccionar.Location = new System.Drawing.Point(287, 23);
            this.button_seleccionar.Name = "button_seleccionar";
            this.button_seleccionar.Size = new System.Drawing.Size(75, 23);
            this.button_seleccionar.TabIndex = 19;
            this.button_seleccionar.Text = "Seleccionar";
            this.button_seleccionar.UseVisualStyleBackColor = true;
            this.button_seleccionar.Click += new System.EventHandler(this.button_seleccionar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button_seleccionar);
            this.groupBox1.Controls.Add(this.label_total);
            this.groupBox1.Controls.Add(this.dataGridView_calificaciones);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.combo_calificacion);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(23, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 283);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estrellas asignadas a compras";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_historial);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(23, 350);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(494, 246);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ultimas 5 calificaciones";
            // 
            // dataGridView_historial
            // 
            this.dataGridView_historial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_historial.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridView_historial.Location = new System.Drawing.Point(16, 31);
            this.dataGridView_historial.Name = "dataGridView_historial";
            this.dataGridView_historial.Size = new System.Drawing.Size(444, 184);
            this.dataGridView_historial.TabIndex = 14;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "IdCalificacion";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Publicacion";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Vendedor";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Calificacion";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // presentacion
            // 
            this.presentacion.AutoSize = true;
            this.presentacion.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentacion.ForeColor = System.Drawing.Color.Black;
            this.presentacion.Location = new System.Drawing.Point(167, 9);
            this.presentacion.Name = "presentacion";
            this.presentacion.Size = new System.Drawing.Size(204, 23);
            this.presentacion.TabIndex = 22;
            this.presentacion.Text = "INFORME DE COMPRAS";
            // 
            // InformeCalificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(547, 631);
            this.Controls.Add(this.presentacion);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_volver);
            this.Name = "InformeCalificar";
            this.Text = "InformeCalificar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_calificaciones)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_historial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_volver;
        private System.Windows.Forms.DataGridView dataGridView_calificaciones;
        private System.Windows.Forms.ComboBox combo_calificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Button button_seleccionar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView_historial;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCalificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vendedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Publicacion;
        private System.Windows.Forms.Label presentacion;
    }
}