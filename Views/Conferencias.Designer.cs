namespace academia_proyecto.Views
{
    partial class Conferencias
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_nombre_conf = new System.Windows.Forms.TextBox();
            this.txt_ubicacion_conf = new System.Windows.Forms.TextBox();
            this.txt_descripcion_conf = new System.Windows.Forms.TextBox();
            this.dtp_fecha_conf = new System.Windows.Forms.DateTimePicker();
            this.lst_conferencias = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_guardar_conf = new System.Windows.Forms.Button();
            this.btn_eliminar_conf = new System.Windows.Forms.Button();
            this.btn_editar_conf = new System.Windows.Forms.Button();
            this.btn_reporte_conf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar Conferencia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ubicacion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Descripcion:";
            // 
            // txt_nombre_conf
            // 
            this.txt_nombre_conf.Location = new System.Drawing.Point(205, 87);
            this.txt_nombre_conf.Name = "txt_nombre_conf";
            this.txt_nombre_conf.Size = new System.Drawing.Size(288, 22);
            this.txt_nombre_conf.TabIndex = 5;
            // 
            // txt_ubicacion_conf
            // 
            this.txt_ubicacion_conf.Location = new System.Drawing.Point(205, 171);
            this.txt_ubicacion_conf.Name = "txt_ubicacion_conf";
            this.txt_ubicacion_conf.Size = new System.Drawing.Size(288, 22);
            this.txt_ubicacion_conf.TabIndex = 6;
            // 
            // txt_descripcion_conf
            // 
            this.txt_descripcion_conf.Location = new System.Drawing.Point(205, 210);
            this.txt_descripcion_conf.Name = "txt_descripcion_conf";
            this.txt_descripcion_conf.Size = new System.Drawing.Size(288, 22);
            this.txt_descripcion_conf.TabIndex = 7;
            // 
            // dtp_fecha_conf
            // 
            this.dtp_fecha_conf.Location = new System.Drawing.Point(205, 129);
            this.dtp_fecha_conf.Name = "dtp_fecha_conf";
            this.dtp_fecha_conf.Size = new System.Drawing.Size(288, 22);
            this.dtp_fecha_conf.TabIndex = 8;
            // 
            // lst_conferencias
            // 
            this.lst_conferencias.FormattingEnabled = true;
            this.lst_conferencias.ItemHeight = 16;
            this.lst_conferencias.Location = new System.Drawing.Point(723, 87);
            this.lst_conferencias.Name = "lst_conferencias";
            this.lst_conferencias.Size = new System.Drawing.Size(520, 452);
            this.lst_conferencias.TabIndex = 9;
            this.lst_conferencias.SelectedIndexChanged += new System.EventHandler(this.lst_conferencias_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(718, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(301, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Conferencias Guardadas";
            // 
            // btn_guardar_conf
            // 
            this.btn_guardar_conf.Location = new System.Drawing.Point(264, 271);
            this.btn_guardar_conf.Name = "btn_guardar_conf";
            this.btn_guardar_conf.Size = new System.Drawing.Size(160, 55);
            this.btn_guardar_conf.TabIndex = 11;
            this.btn_guardar_conf.Text = "Guardar";
            this.btn_guardar_conf.UseVisualStyleBackColor = true;
            this.btn_guardar_conf.Click += new System.EventHandler(this.btn_guardar_conf_Click);
            // 
            // btn_eliminar_conf
            // 
            this.btn_eliminar_conf.Location = new System.Drawing.Point(557, 87);
            this.btn_eliminar_conf.Name = "btn_eliminar_conf";
            this.btn_eliminar_conf.Size = new System.Drawing.Size(160, 55);
            this.btn_eliminar_conf.TabIndex = 12;
            this.btn_eliminar_conf.Text = "Eliminar";
            this.btn_eliminar_conf.UseVisualStyleBackColor = true;
            this.btn_eliminar_conf.Click += new System.EventHandler(this.btn_eliminar_conf_Click);
            // 
            // btn_editar_conf
            // 
            this.btn_editar_conf.Location = new System.Drawing.Point(557, 155);
            this.btn_editar_conf.Name = "btn_editar_conf";
            this.btn_editar_conf.Size = new System.Drawing.Size(160, 55);
            this.btn_editar_conf.TabIndex = 13;
            this.btn_editar_conf.Text = "Editar";
            this.btn_editar_conf.UseVisualStyleBackColor = true;
            this.btn_editar_conf.Click += new System.EventHandler(this.btn_editar_conf_Click);
            // 
            // btn_reporte_conf
            // 
            this.btn_reporte_conf.Location = new System.Drawing.Point(33, 484);
            this.btn_reporte_conf.Name = "btn_reporte_conf";
            this.btn_reporte_conf.Size = new System.Drawing.Size(160, 55);
            this.btn_reporte_conf.TabIndex = 14;
            this.btn_reporte_conf.Text = "Ver Reporte";
            this.btn_reporte_conf.UseVisualStyleBackColor = true;
            // 
            // Conferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 554);
            this.Controls.Add(this.btn_reporte_conf);
            this.Controls.Add(this.btn_editar_conf);
            this.Controls.Add(this.btn_eliminar_conf);
            this.Controls.Add(this.btn_guardar_conf);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lst_conferencias);
            this.Controls.Add(this.dtp_fecha_conf);
            this.Controls.Add(this.txt_descripcion_conf);
            this.Controls.Add(this.txt_ubicacion_conf);
            this.Controls.Add(this.txt_nombre_conf);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Conferencias";
            this.Text = "Conferencias";
            this.Load += new System.EventHandler(this.Conferencias_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_nombre_conf;
        private System.Windows.Forms.TextBox txt_ubicacion_conf;
        private System.Windows.Forms.TextBox txt_descripcion_conf;
        private System.Windows.Forms.DateTimePicker dtp_fecha_conf;
        private System.Windows.Forms.ListBox lst_conferencias;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_guardar_conf;
        private System.Windows.Forms.Button btn_eliminar_conf;
        private System.Windows.Forms.Button btn_editar_conf;
        private System.Windows.Forms.Button btn_reporte_conf;
    }
}