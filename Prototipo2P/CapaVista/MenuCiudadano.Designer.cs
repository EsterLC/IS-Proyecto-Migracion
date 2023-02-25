
namespace CapaVista
{
    partial class MenuCiudadano
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
            this.solicitudDeCitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citaParaMayoresDeEdadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citaParaMenoresDeEdadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelaciónDeCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reprogramarCitaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(76)))), ((int)(((byte)(95)))));
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.solicitudDeCitasToolStripMenuItem,
            this.cancelaciónDeCitaToolStripMenuItem,
            this.reprogramarCitaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(941, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // solicitudDeCitasToolStripMenuItem
            // 
            this.solicitudDeCitasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citaParaMayoresDeEdadToolStripMenuItem,
            this.citaParaMenoresDeEdadToolStripMenuItem});
            this.solicitudDeCitasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.solicitudDeCitasToolStripMenuItem.Name = "solicitudDeCitasToolStripMenuItem";
            this.solicitudDeCitasToolStripMenuItem.Size = new System.Drawing.Size(177, 29);
            this.solicitudDeCitasToolStripMenuItem.Text = "Solicitud de Citas";
            // 
            // citaParaMayoresDeEdadToolStripMenuItem
            // 
            this.citaParaMayoresDeEdadToolStripMenuItem.Name = "citaParaMayoresDeEdadToolStripMenuItem";
            this.citaParaMayoresDeEdadToolStripMenuItem.Size = new System.Drawing.Size(337, 30);
            this.citaParaMayoresDeEdadToolStripMenuItem.Text = "Cita para Mayores de Edad";
            this.citaParaMayoresDeEdadToolStripMenuItem.Click += new System.EventHandler(this.citaParaMayoresDeEdadToolStripMenuItem_Click);
            // 
            // citaParaMenoresDeEdadToolStripMenuItem
            // 
            this.citaParaMenoresDeEdadToolStripMenuItem.Name = "citaParaMenoresDeEdadToolStripMenuItem";
            this.citaParaMenoresDeEdadToolStripMenuItem.Size = new System.Drawing.Size(337, 30);
            this.citaParaMenoresDeEdadToolStripMenuItem.Text = "Cita para Menores de Edad";
            this.citaParaMenoresDeEdadToolStripMenuItem.Click += new System.EventHandler(this.citaParaMenoresDeEdadToolStripMenuItem_Click);
            // 
            // cancelaciónDeCitaToolStripMenuItem
            // 
            this.cancelaciónDeCitaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancelaciónDeCitaToolStripMenuItem.Name = "cancelaciónDeCitaToolStripMenuItem";
            this.cancelaciónDeCitaToolStripMenuItem.Size = new System.Drawing.Size(202, 29);
            this.cancelaciónDeCitaToolStripMenuItem.Text = "Cancelación de Cita";
            this.cancelaciónDeCitaToolStripMenuItem.Click += new System.EventHandler(this.cancelaciónDeCitaToolStripMenuItem_Click);
            // 
            // reprogramarCitaToolStripMenuItem
            // 
            this.reprogramarCitaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reprogramarCitaToolStripMenuItem.Name = "reprogramarCitaToolStripMenuItem";
            this.reprogramarCitaToolStripMenuItem.Size = new System.Drawing.Size(179, 29);
            this.reprogramarCitaToolStripMenuItem.Text = "Reprogramar Cita";
            this.reprogramarCitaToolStripMenuItem.Click += new System.EventHandler(this.reprogramarCitaToolStripMenuItem_Click);
            // 
            // MenuCiudadano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 563);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuCiudadano";
            this.Text = "Menu Ciudadano";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem solicitudDeCitasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citaParaMayoresDeEdadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citaParaMenoresDeEdadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelaciónDeCitaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reprogramarCitaToolStripMenuItem;
    }
}