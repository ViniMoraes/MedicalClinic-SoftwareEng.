using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalClinic.Panel
{
    class PacientPanel : MetroPanel
    {
        public PacientPanel()
        {
            initializeComponent();
        }

        private void initializeComponent()
        {
            this.clinic_listviewPacient = new System.Windows.Forms.ListView();
            this.btn_deletePacient = new MetroFramework.Controls.MetroButton();
            this.btn_editPacient = new MetroFramework.Controls.MetroButton();
            this.btn_newPacient = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // panel_clinicInside
            // 
            this.Controls.Add(this.btn_deletePacient);
            this.Controls.Add(this.btn_editPacient);
            this.Controls.Add(this.btn_newPacient);
            this.Controls.Add(this.clinic_listviewPacient);
            this.HorizontalScrollbarBarColor = true;
            this.HorizontalScrollbarHighlightOnWheel = false;
            this.HorizontalScrollbarSize = 10;
            this.Location = new System.Drawing.Point(176, 12);
            this.Name = "panel_clinicInside";
            this.Size = new System.Drawing.Size(414, 321);
            this.TabIndex = 4;
            this.VerticalScrollbarBarColor = true;
            this.VerticalScrollbarHighlightOnWheel = false;
            this.VerticalScrollbarSize = 10;
            // 
            // 
            // clinic_listviewPacient
            // 
            this.clinic_listviewPacient.Location = new System.Drawing.Point(3, 3);
            this.clinic_listviewPacient.Name = "clinic_listviewPacient";
            this.clinic_listviewPacient.Size = new System.Drawing.Size(408, 274);
            this.clinic_listviewPacient.TabIndex = 2;
            this.clinic_listviewPacient.UseCompatibleStateImageBehavior = false;
            // 
            // btn_newPacient
            // 
            this.btn_newPacient.Location = new System.Drawing.Point(299, 283);
            this.btn_newPacient.Name = "btn_newPacient";
            this.btn_newPacient.Size = new System.Drawing.Size(112, 32);
            this.btn_newPacient.TabIndex = 3;
            this.btn_newPacient.Text = "Novo";
            // 
            // btn_editPacient
            // 
            this.btn_editPacient.Location = new System.Drawing.Point(181, 283);
            this.btn_editPacient.Name = "btn_editPacient";
            this.btn_editPacient.Size = new System.Drawing.Size(112, 32);
            this.btn_editPacient.TabIndex = 3;
            this.btn_editPacient.Text = "Editar";
            // 
            // btn_deletePacient
            // 
            this.btn_deletePacient.Location = new System.Drawing.Point(63, 283);
            this.btn_deletePacient.Name = "btn_deletePacient";
            this.btn_deletePacient.Size = new System.Drawing.Size(112, 32);
            this.btn_deletePacient.TabIndex = 3;
            this.btn_deletePacient.Text = "Deletar";
        }


        private MetroFramework.Controls.MetroButton btn_deletePacient;
        private MetroFramework.Controls.MetroButton btn_editPacient;
        private MetroFramework.Controls.MetroButton btn_newPacient;
        private System.Windows.Forms.ListView clinic_listviewPacient;
    }
}
