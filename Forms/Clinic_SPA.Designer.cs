namespace MedicalClinic.Forms
{
    partial class Clinic_SPA
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
            this.btn_goClinic = new MetroFramework.Controls.MetroButton();
            this.btn_goSPA = new MetroFramework.Controls.MetroButton();
            this.panel_initialPanel = new MetroFramework.Controls.MetroPanel();
            this.panel_initialPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_goClinic
            // 
            this.btn_goClinic.Location = new System.Drawing.Point(80, 158);
            this.btn_goClinic.Name = "btn_goClinic";
            this.btn_goClinic.Size = new System.Drawing.Size(195, 82);
            this.btn_goClinic.TabIndex = 0;
            this.btn_goClinic.Text = "Clinica";
            this.btn_goClinic.Click += new System.EventHandler(this.btn_goClinic_Click);
            // 
            // btn_goSPA
            // 
            this.btn_goSPA.Location = new System.Drawing.Point(330, 158);
            this.btn_goSPA.Name = "btn_goSPA";
            this.btn_goSPA.Size = new System.Drawing.Size(195, 82);
            this.btn_goSPA.TabIndex = 0;
            this.btn_goSPA.Text = "SPA";
            this.btn_goSPA.Click += new System.EventHandler(this.btn_goSPA_Click);
            // 
            // panel_initialPanel
            // 
            this.panel_initialPanel.Controls.Add(this.btn_goClinic);
            this.panel_initialPanel.Controls.Add(this.btn_goSPA);
            this.panel_initialPanel.HorizontalScrollbarBarColor = true;
            this.panel_initialPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_initialPanel.HorizontalScrollbarSize = 10;
            this.panel_initialPanel.Location = new System.Drawing.Point(1, 50);
            this.panel_initialPanel.Name = "panel_initialPanel";
            this.panel_initialPanel.Size = new System.Drawing.Size(589, 377);
            this.panel_initialPanel.TabIndex = 1;
            this.panel_initialPanel.VerticalScrollbarBarColor = true;
            this.panel_initialPanel.VerticalScrollbarHighlightOnWheel = false;
            this.panel_initialPanel.VerticalScrollbarSize = 10;
            // 
            // Clinic_SPA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 424);
            this.Controls.Add(this.panel_initialPanel);
            this.Name = "Clinic_SPA";
            this.Text = "Clinic_SPA";
            this.panel_initialPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btn_goClinic;
        private MetroFramework.Controls.MetroButton btn_goSPA;
        public MetroFramework.Controls.MetroPanel panel_initialPanel;
    }
}