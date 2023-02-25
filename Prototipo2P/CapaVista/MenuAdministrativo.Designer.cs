
namespace CapaVista
{
    partial class MenuAdministrativo
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
            this.registroDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validaciónDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emisiónDePasaporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(76)))), ((int)(((byte)(95)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeDatosToolStripMenuItem,
            this.validaciónDeDatosToolStripMenuItem,
            this.emisiónDePasaporteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroDeDatosToolStripMenuItem
            // 
            this.registroDeDatosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroDeDatosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.registroDeDatosToolStripMenuItem.Name = "registroDeDatosToolStripMenuItem";
            this.registroDeDatosToolStripMenuItem.Size = new System.Drawing.Size(180, 29);
            this.registroDeDatosToolStripMenuItem.Text = "Registro de Datos";
            this.registroDeDatosToolStripMenuItem.Click += new System.EventHandler(this.registroDeDatosToolStripMenuItem_Click);
            // 
            // validaciónDeDatosToolStripMenuItem
            // 
            this.validaciónDeDatosToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.validaciónDeDatosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.validaciónDeDatosToolStripMenuItem.Name = "validaciónDeDatosToolStripMenuItem";
            this.validaciónDeDatosToolStripMenuItem.Size = new System.Drawing.Size(197, 29);
            this.validaciónDeDatosToolStripMenuItem.Text = "Validación de datos";
            // 
            // emisiónDePasaporteToolStripMenuItem
            // 
            this.emisiónDePasaporteToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emisiónDePasaporteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.emisiónDePasaporteToolStripMenuItem.Name = "emisiónDePasaporteToolStripMenuItem";
            this.emisiónDePasaporteToolStripMenuItem.Size = new System.Drawing.Size(214, 29);
            this.emisiónDePasaporteToolStripMenuItem.Text = "Emisión de pasaporte";
            this.emisiónDePasaporteToolStripMenuItem.Click += new System.EventHandler(this.emisiónDePasaporteToolStripMenuItem_Click);
            // 
            // MenuAdministrativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuAdministrativo";
            this.Text = "MenuAdministrativo";
            this.Load += new System.EventHandler(this.MenuAdministrativo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validaciónDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emisiónDePasaporteToolStripMenuItem;
    }
}