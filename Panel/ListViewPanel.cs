using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;
using static MedicalClinic.Panel.ClinicPanel;

namespace MedicalClinic.Panel
{
    public class ListViewPanel  : MetroPanel
    {
        public ListViewPanel(int panelPosition)
        { 
            initializeComponent();
        }

        private void initializeComponent()
        {
            this.clinic_listview = new System.Windows.Forms.ListView();
            this.btn_delete = new MetroFramework.Controls.MetroButton();
            this.btn_edit = new MetroFramework.Controls.MetroButton();
            this.btn_new = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // panel_clinicInside
            // 
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.clinic_listview);
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
            // clinic_listview
            // 
            this.clinic_listview.Location = new System.Drawing.Point(3, 3);
            this.clinic_listview.Name = "clinic_listview";
            this.clinic_listview.Size = new System.Drawing.Size(408, 274);
            this.clinic_listview.TabIndex = 2;
            this.clinic_listview.UseCompatibleStateImageBehavior = false;
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(299, 283);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(112, 32);
            this.btn_new.TabIndex = 3;
            this.btn_new.Text = "Novo";
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(181, 283);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(112, 32);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "Editar";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(63, 283);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(112, 32);
            this.btn_delete.TabIndex = 3;
            this.btn_delete.Text = "Deletar";
        }

        private void loadSchedule()
        {

        }

        private void loadDoctor()
        {

        }

        private void loadPacient()
        {

        }

        private void loadHealthCare()
        {

        }

        private void loadPrescription()
        {

        }

        private MetroFramework.Controls.MetroButton btn_delete;
        private MetroFramework.Controls.MetroButton btn_edit;
        private MetroFramework.Controls.MetroButton btn_new;
        private System.Windows.Forms.ListView clinic_listview;
    }
}
