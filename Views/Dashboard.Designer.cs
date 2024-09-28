namespace academia_proyecto.Views
{
    partial class Dashboard
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.conferenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.conferenciasToolStripMenuItem,
            this.asistentesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(867, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // conferenciasToolStripMenuItem
            // 
            this.conferenciasToolStripMenuItem.Name = "conferenciasToolStripMenuItem";
            this.conferenciasToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.conferenciasToolStripMenuItem.Text = "Conferencias";
            this.conferenciasToolStripMenuItem.Click += new System.EventHandler(this.conferenciasToolStripMenuItem_Click);
            // 
            // asistentesToolStripMenuItem
            // 
            this.asistentesToolStripMenuItem.Name = "asistentesToolStripMenuItem";
            this.asistentesToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.asistentesToolStripMenuItem.Text = "Asistentes";
            this.asistentesToolStripMenuItem.Click += new System.EventHandler(this.asistentesToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 511);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem conferenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asistentesToolStripMenuItem;
    }
}