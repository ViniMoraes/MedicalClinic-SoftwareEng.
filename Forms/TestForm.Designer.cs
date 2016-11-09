namespace MedicalClinic.Forms
{
    partial class TestForm
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
            this.panel_Clinic = new MetroFramework.Controls.MetroPanel();
            this.panel_clinicInside = new MetroFramework.Controls.MetroPanel();
            this.btn_deletePacient = new MetroFramework.Controls.MetroButton();
            this.btn_editPacient = new MetroFramework.Controls.MetroButton();
            this.btn_newPacient = new MetroFramework.Controls.MetroButton();
            this.btn_clinicBack = new MetroFramework.Controls.MetroButton();
            this.btn_clinicPrescription = new MetroFramework.Controls.MetroButton();
            this.btn_clinicHealtPlan = new MetroFramework.Controls.MetroButton();
            this.btn_clinicPacients = new MetroFramework.Controls.MetroButton();
            this.btn_clinicDoctors = new MetroFramework.Controls.MetroButton();
            this.btn_clinicAppointment = new MetroFramework.Controls.MetroButton();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.panel_Clinic.SuspendLayout();
            this.panel_clinicInside.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Clinic
            // 
            this.panel_Clinic.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_Clinic.Controls.Add(this.panel_clinicInside);
            this.panel_Clinic.Controls.Add(this.btn_clinicBack);
            this.panel_Clinic.Controls.Add(this.btn_clinicPrescription);
            this.panel_Clinic.Controls.Add(this.btn_clinicHealtPlan);
            this.panel_Clinic.Controls.Add(this.btn_clinicPacients);
            this.panel_Clinic.Controls.Add(this.btn_clinicDoctors);
            this.panel_Clinic.Controls.Add(this.btn_clinicAppointment);
            this.panel_Clinic.HorizontalScrollbarBarColor = true;
            this.panel_Clinic.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_Clinic.HorizontalScrollbarSize = 10;
            this.panel_Clinic.Location = new System.Drawing.Point(0, 51);
            this.panel_Clinic.Name = "panel_Clinic";
            this.panel_Clinic.Size = new System.Drawing.Size(593, 333);
            this.panel_Clinic.TabIndex = 0;
            this.panel_Clinic.VerticalScrollbarBarColor = true;
            this.panel_Clinic.VerticalScrollbarHighlightOnWheel = false;
            this.panel_Clinic.VerticalScrollbarSize = 10;
            // 
            // panel_clinicInside
            // 
            this.panel_clinicInside.Controls.Add(this.metroLabel4);
            this.panel_clinicInside.Controls.Add(this.metroLabel3);
            this.panel_clinicInside.Controls.Add(this.metroLabel2);
            this.panel_clinicInside.Controls.Add(this.metroLabel1);
            this.panel_clinicInside.Controls.Add(this.dateTimePicker1);
            this.panel_clinicInside.Controls.Add(this.metroTextBox3);
            this.panel_clinicInside.Controls.Add(this.metroTextBox2);
            this.panel_clinicInside.Controls.Add(this.metroTextBox1);
            this.panel_clinicInside.Controls.Add(this.btn_deletePacient);
            this.panel_clinicInside.Controls.Add(this.btn_editPacient);
            this.panel_clinicInside.Controls.Add(this.btn_newPacient);
            this.panel_clinicInside.HorizontalScrollbarBarColor = true;
            this.panel_clinicInside.HorizontalScrollbarHighlightOnWheel = false;
            this.panel_clinicInside.HorizontalScrollbarSize = 10;
            this.panel_clinicInside.Location = new System.Drawing.Point(176, 12);
            this.panel_clinicInside.Name = "panel_clinicInside";
            this.panel_clinicInside.Size = new System.Drawing.Size(414, 321);
            this.panel_clinicInside.TabIndex = 4;
            this.panel_clinicInside.VerticalScrollbarBarColor = true;
            this.panel_clinicInside.VerticalScrollbarHighlightOnWheel = false;
            this.panel_clinicInside.VerticalScrollbarSize = 10;
            // 
            // btn_deletePacient
            // 
            this.btn_deletePacient.Location = new System.Drawing.Point(45, 283);
            this.btn_deletePacient.Name = "btn_deletePacient";
            this.btn_deletePacient.Size = new System.Drawing.Size(112, 32);
            this.btn_deletePacient.TabIndex = 3;
            this.btn_deletePacient.Text = "Deletar";
            // 
            // btn_editPacient
            // 
            this.btn_editPacient.Location = new System.Drawing.Point(181, 283);
            this.btn_editPacient.Name = "btn_editPacient";
            this.btn_editPacient.Size = new System.Drawing.Size(112, 32);
            this.btn_editPacient.TabIndex = 3;
            this.btn_editPacient.Text = "Editar";
            // 
            // btn_newPacient
            // 
            this.btn_newPacient.Location = new System.Drawing.Point(299, 283);
            this.btn_newPacient.Name = "btn_newPacient";
            this.btn_newPacient.Size = new System.Drawing.Size(112, 32);
            this.btn_newPacient.TabIndex = 3;
            this.btn_newPacient.Text = "Novo";
            // 
            // btn_clinicBack
            // 
            this.btn_clinicBack.Location = new System.Drawing.Point(13, 277);
            this.btn_clinicBack.Name = "btn_clinicBack";
            this.btn_clinicBack.Size = new System.Drawing.Size(157, 42);
            this.btn_clinicBack.TabIndex = 2;
            this.btn_clinicBack.Text = "Voltar";
            // 
            // btn_clinicPrescription
            // 
            this.btn_clinicPrescription.Location = new System.Drawing.Point(13, 204);
            this.btn_clinicPrescription.Name = "btn_clinicPrescription";
            this.btn_clinicPrescription.Size = new System.Drawing.Size(157, 42);
            this.btn_clinicPrescription.TabIndex = 2;
            this.btn_clinicPrescription.Text = "Receitas";
            // 
            // btn_clinicHealtPlan
            // 
            this.btn_clinicHealtPlan.Location = new System.Drawing.Point(13, 156);
            this.btn_clinicHealtPlan.Name = "btn_clinicHealtPlan";
            this.btn_clinicHealtPlan.Size = new System.Drawing.Size(157, 42);
            this.btn_clinicHealtPlan.TabIndex = 2;
            this.btn_clinicHealtPlan.Text = "Convênios";
            // 
            // btn_clinicPacients
            // 
            this.btn_clinicPacients.Location = new System.Drawing.Point(13, 108);
            this.btn_clinicPacients.Name = "btn_clinicPacients";
            this.btn_clinicPacients.Size = new System.Drawing.Size(157, 42);
            this.btn_clinicPacients.TabIndex = 2;
            this.btn_clinicPacients.Text = "Pacientes";
            // 
            // btn_clinicDoctors
            // 
            this.btn_clinicDoctors.Location = new System.Drawing.Point(13, 60);
            this.btn_clinicDoctors.Name = "btn_clinicDoctors";
            this.btn_clinicDoctors.Size = new System.Drawing.Size(157, 42);
            this.btn_clinicDoctors.TabIndex = 2;
            this.btn_clinicDoctors.Text = "Médicos";
            // 
            // btn_clinicAppointment
            // 
            this.btn_clinicAppointment.Location = new System.Drawing.Point(13, 12);
            this.btn_clinicAppointment.Name = "btn_clinicAppointment";
            this.btn_clinicAppointment.Size = new System.Drawing.Size(157, 42);
            this.btn_clinicAppointment.TabIndex = 2;
            this.btn_clinicAppointment.Text = "Consulta";
            this.btn_clinicAppointment.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Location = new System.Drawing.Point(137, 19);
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.Size = new System.Drawing.Size(256, 23);
            this.metroTextBox1.TabIndex = 4;
            this.metroTextBox1.Text = "metroTextBox1";
            // 
            // metroTextBox2
            // 
            this.metroTextBox2.Location = new System.Drawing.Point(137, 48);
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.Size = new System.Drawing.Size(256, 23);
            this.metroTextBox2.TabIndex = 4;
            this.metroTextBox2.Text = "metroTextBox1";
            // 
            // metroTextBox3
            // 
            this.metroTextBox3.Location = new System.Drawing.Point(137, 77);
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.Size = new System.Drawing.Size(256, 23);
            this.metroTextBox3.TabIndex = 4;
            this.metroTextBox3.Text = "metroTextBox1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(137, 106);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(50, 23);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(81, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "metroLabel1";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(50, 52);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(81, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "metroLabel1";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(50, 81);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(81, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "metroLabel1";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(50, 107);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(81, 19);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "metroLabel1";
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 386);
            this.Controls.Add(this.panel_Clinic);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.panel_Clinic.ResumeLayout(false);
            this.panel_clinicInside.ResumeLayout(false);
            this.panel_clinicInside.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel panel_Clinic;
        private MetroFramework.Controls.MetroPanel panel_clinicInside;
        private MetroFramework.Controls.MetroButton btn_clinicBack;
        private MetroFramework.Controls.MetroButton btn_clinicPrescription;
        private MetroFramework.Controls.MetroButton btn_clinicHealtPlan;
        private MetroFramework.Controls.MetroButton btn_clinicPacients;
        private MetroFramework.Controls.MetroButton btn_clinicDoctors;
        private MetroFramework.Controls.MetroButton btn_clinicAppointment;
        private MetroFramework.Controls.MetroButton btn_deletePacient;
        private MetroFramework.Controls.MetroButton btn_editPacient;
        private MetroFramework.Controls.MetroButton btn_newPacient;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
    }
}