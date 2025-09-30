
namespace CapaVista_Menu
{
    partial class MenuGeneral
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
            this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaBitacoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.identificacionAlumnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresoDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogosToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.salirToolStripMenuItem,
            this.ingresoDeDatosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // catalogosToolStripMenuItem
            // 
            this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.catalogosToolStripMenuItem.Text = "Catalogos";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaBitacoraToolStripMenuItem,
            this.identificacionAlumnoToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            this.seguridadToolStripMenuItem.Click += new System.EventHandler(this.seguridadToolStripMenuItem_Click);
            // 
            // consultaBitacoraToolStripMenuItem
            // 
            this.consultaBitacoraToolStripMenuItem.Name = "consultaBitacoraToolStripMenuItem";
            this.consultaBitacoraToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.consultaBitacoraToolStripMenuItem.Text = "Consulta Bitacora";
            this.consultaBitacoraToolStripMenuItem.Click += new System.EventHandler(this.consultaBitacoraToolStripMenuItem_Click);
            // 
            // identificacionAlumnoToolStripMenuItem
            // 
            this.identificacionAlumnoToolStripMenuItem.Name = "identificacionAlumnoToolStripMenuItem";
            this.identificacionAlumnoToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.identificacionAlumnoToolStripMenuItem.Text = "Identificacion Alumno";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // ingresoDeDatosToolStripMenuItem
            // 
            this.ingresoDeDatosToolStripMenuItem.Name = "ingresoDeDatosToolStripMenuItem";
            this.ingresoDeDatosToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.ingresoDeDatosToolStripMenuItem.Text = "Mantenimiento (CRUD)";
            this.ingresoDeDatosToolStripMenuItem.Click += new System.EventHandler(this.ingresoDeDatosToolStripMenuItem_Click);
            // 
            // MenuGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuGeneral";
            this.Text = "MenuGeneral";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaBitacoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem identificacionAlumnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresoDeDatosToolStripMenuItem;
    }
}