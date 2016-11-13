using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;
using static MedicalClinic.SlidePanel;

namespace MedicalClinic.Forms
{
    public partial class Clinic_SPA : MetroForm
    {
        static Clinic_SPA clinic_SPAForm;
        public MetroPanel actualPanel { get; set; }
        public Clinic_SPA()
        {
            InitializeComponent();
            actualPanel = panel_initialPanel;
            clinic_SPAForm = this;
        }

        private void btn_goSPA_Click(object sender, EventArgs e)
        {
        }

        private void btn_goClinic_Click(object sender, EventArgs e)
        {
            MetroPanel newPanel = new Panel.ClinicPanel();
            Controls.Add(newPanel);
            SlidePanel.setPanel(Slide.Right, newPanel, actualPanel);
            Controls.Remove(actualPanel);
            actualPanel.Dispose();
            actualPanel = newPanel;
        }

        public static Clinic_SPA get()
        {
            return clinic_SPAForm;
        }
    }
}
