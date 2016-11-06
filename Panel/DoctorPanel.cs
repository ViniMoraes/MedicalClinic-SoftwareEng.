using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;

namespace MedicalClinic.Panel
{
    class DoctorPanel : MetroPanel
    {
        public DoctorPanel()
        {
            initializeComponent();
        }

        private void initializeComponent()
        {
            this.clinic_listviewDoctor = new System.Windows.Forms.ListView();
            this.btn_deleteDoctor = new MetroFramework.Controls.MetroButton();
            this.btn_editDoctor = new MetroFramework.Controls.MetroButton();
            this.btn_newDoctor = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // panel_clinicInside
            // 
            this.Controls.Add(this.btn_deleteDoctor);
            this.Controls.Add(this.btn_editDoctor);
            this.Controls.Add(this.btn_newDoctor);
            this.Controls.Add(this.clinic_listviewDoctor);
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
            // clinic_listviewDoctor
            // 
            this.clinic_listviewDoctor.Location = new System.Drawing.Point(3, 3);
            this.clinic_listviewDoctor.Name = "clinic_listviewDoctor";
            this.clinic_listviewDoctor.Size = new System.Drawing.Size(408, 274);
            this.clinic_listviewDoctor.TabIndex = 2;
            this.clinic_listviewDoctor.UseCompatibleStateImageBehavior = false;
            // 
            // btn_newDoctor
            // 
            this.btn_newDoctor.Location = new System.Drawing.Point(299, 283);
            this.btn_newDoctor.Name = "btn_newDoctor";
            this.btn_newDoctor.Size = new System.Drawing.Size(112, 32);
            this.btn_newDoctor.TabIndex = 3;
            this.btn_newDoctor.Text = "Novo";
            // 
            // btn_editDoctor
            // 
            this.btn_editDoctor.Location = new System.Drawing.Point(181, 283);
            this.btn_editDoctor.Name = "btn_editDoctor";
            this.btn_editDoctor.Size = new System.Drawing.Size(112, 32);
            this.btn_editDoctor.TabIndex = 3;
            this.btn_editDoctor.Text = "Editar";
            // 
            // btn_deleteDoctor
            // 
            this.btn_deleteDoctor.Location = new System.Drawing.Point(63, 283);
            this.btn_deleteDoctor.Name = "btn_deleteDoctor";
            this.btn_deleteDoctor.Size = new System.Drawing.Size(112, 32);
            this.btn_deleteDoctor.TabIndex = 3;
            this.btn_deleteDoctor.Text = "Deletar";
        }

        private MetroFramework.Controls.MetroButton btn_deleteDoctor;
        private MetroFramework.Controls.MetroButton btn_editDoctor;
        private MetroFramework.Controls.MetroButton btn_newDoctor;
        private System.Windows.Forms.ListView clinic_listviewDoctor;
    }
}
