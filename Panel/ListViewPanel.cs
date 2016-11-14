using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetroFramework.Controls;
using static MedicalClinic.Panel.ClinicPanel;
using System.Windows.Forms;

namespace MedicalClinic.Panel
{
	public class ListViewPanel : MetroPanel
	{
		public ListViewPanel(int panelPosition)
		{
			initializeComponent();

			switch (panelPosition)
			{
				case 1:
					loadList("appointment");
					break;
				case 2:
					loadList("doctor");
					break;
				case 3:
					loadList("pacient");
					break;
				case 4:
					loadList("healthplan");
					break;
				case 5:
					loadList("prescription");
					break;
				default:
					loadList("appointment");
					break;
			}

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

			this.btn_new.MouseClick += Btn_new_MouseClick; ;
			this.btn_edit.MouseClick += Btn_edit_MouseClick;

		}

		private void Btn_edit_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ClinicPanel clinicPanel = ClinicPanel.getThis();
			switch (clinicPanel.actualPosition)
			{
				case PanelPosition.Appointment:
					newAppointment(true);
					break;
				case PanelPosition.Doctor:
					newDoctor(true);
					break;
				case PanelPosition.Pacient:
					newPacient(true);
					break;
				case PanelPosition.HealthPlan:
					newHealthPlan(true);
					break;
				case PanelPosition.Prescription:
					newPrescription(true);
					break;
				default:
					break;
			}
		}

		private void Btn_new_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
		{
			ClinicPanel clinicPanel = ClinicPanel.getThis();
			switch (clinicPanel.actualPosition)
			{
				case PanelPosition.Appointment:
					newAppointment(false);
					break;
				case PanelPosition.Doctor:
					newDoctor(false);
					break;
				case PanelPosition.Pacient:
					newPacient(false);
					break;
				case PanelPosition.HealthPlan:
					newHealthPlan(false);
					break;
				case PanelPosition.Prescription:
					newPrescription(false);
					break;
				default:
					break;
			}
		}

		private void newAppointment(bool edit)
		{
			AppointmentPanel appointmentPanel = new AppointmentPanel();
			if (edit)
			{
				//TODO
			}
			else
			{
				ClinicPanel clinicPanel = ClinicPanel.getThis();
				clinicPanel.switchLateralPanel(appointmentPanel, SlidePanel.Slide.Left);
			}
		}

		private void newDoctor(bool edit)
		{
            DoctorPanel appointmentPanel = new DoctorPanel();
            if (edit)
            {
                //TODO
            }
            else
            {
                ClinicPanel clinicPanel = ClinicPanel.getThis();
                clinicPanel.switchLateralPanel(appointmentPanel, SlidePanel.Slide.Left);
            }
        }

		private void newPacient(bool edit)
		{

		}

		private void newHealthPlan(bool edit)
		{

		}

		private void newPrescription(bool edit)
		{

		}

		private void loadList(string model)
		{
			clinic_listview.Clear();
			using (var dE = new Model.DataModel.databaseEntities())
			{
				if (model == "appointment")
				{
					var results = from a in dE.Appointments
								  select new
								  {
									  Numero = a.id,
									  Pessoa = a.person_id,
									  Convênio = a.healthplan_id,
									  Data = a.schedule
								  };
					string[] items = { "", "Número", "Pessoa", "Convênio", "Data" };
					foreach (string s in items)
						clinic_listview.Columns.Add(s);

					foreach (var i in results)
					{
						ListViewItem lvitem = new ListViewItem();
						lvitem.SubItems.Add(i.Numero.ToString());
						lvitem.SubItems.Add(i.Pessoa.ToString());
						lvitem.SubItems.Add(i.Convênio.ToString());
						if (i.Data != null)
							lvitem.SubItems.Add(i.Data.ToString());
						else
							lvitem.SubItems.Add("Sem data registrada");
						clinic_listview.Items.Add(lvitem);
					}

				}
				else if (model == "doctor")
				{
					var results = from d in dE.People
								  where d.specialization_id >= 0
								  join spec in dE.Specializations on d.specialization_id equals spec.id
								  select new
								  {
									  Id = d.id,
									  Nome = d.name,
									  Idade = d.age,
									  Especialização = spec.name
								  };
					string[] items = { "", "Identificador", "Nome", "Idade", "Especialização" };
					foreach (string s in items)
						clinic_listview.Columns.Add(s);

					foreach (var i in results)
					{
						ListViewItem lvitem = new ListViewItem();
						lvitem.SubItems.Add(i.Id.ToString());
						if (i.Nome != null)
							lvitem.SubItems.Add(i.Nome.ToString());
						else
							lvitem.SubItems.Add("Sem nome registrada");
						if (i.Idade != null)
							lvitem.SubItems.Add(i.Idade.ToString());
						else
							lvitem.SubItems.Add("Sem idade registrada");
						if (i.Especialização != null)
							lvitem.SubItems.Add(i.Especialização.ToString());
						else
							lvitem.SubItems.Add("Sem data registrada");
						clinic_listview.Items.Add(lvitem);
					}

				}
				else if (model == "pacient")
				{
					var results = from p in dE.People
                                  where p.specialization_id == 0
                                  select new
								  {
									  Id = p.id,
									  Nome = p.name,
									  Idade = p.age,
									  Telefone = p.phone,
                                      Endereço = p.address,
                                      Spec = p.specialization_id
								  };
					string[] items = { "", "Identificador", "Nome", "Idade", "Telefone", "Endereço" };
					foreach (string s in items)
						clinic_listview.Columns.Add(s);

					foreach (var i in results)
					{
						ListViewItem lvitem = new ListViewItem();
						lvitem.SubItems.Add(i.Id.ToString());
						if (i.Nome != null)
							lvitem.SubItems.Add(i.Nome.ToString());
						else
							lvitem.SubItems.Add("Sem nome registrada");
						if (i.Idade != null)
							lvitem.SubItems.Add(i.Idade.ToString());
						//else
							//lvitem.SubItems.Add("Sem idade registrada");
						if (i.Endereço != null)
							lvitem.SubItems.Add(i.Endereço.ToString());
						//else
							//lvitem.SubItems.Add("");
						clinic_listview.Items.Add(lvitem);
					}
				}
				else if (model == "healthplan")
				{

                    var results = from hp in dE.Healthplans                                  
                                  select new
                                  {
                                      Id = hp.id,
                                      Nome = hp.name,                                      
                                  };
                    string[] items = { "", "Identificador", "Nome"};
                    foreach (string s in items)
                        clinic_listview.Columns.Add(s);

                    foreach (var i in results)
                    {
                        ListViewItem lvitem = new ListViewItem();
                        lvitem.SubItems.Add(i.Id.ToString());
                        if (i.Nome != null)
                            lvitem.SubItems.Add(i.Nome.ToString());
                        else
                            lvitem.SubItems.Add("Sem nome registrada");
                        clinic_listview.Items.Add(lvitem);
                    }
                }
				else if (model == "prescription")
				{
                    var results = from p in dE.Prescriptions
                                  select new
                                  {
                                      Id = p.id,
                                      Nome = p.name
                                  };
                    string[] items = { "", "Identificador", "Nome"};
                    foreach (string s in items)
                        clinic_listview.Columns.Add(s);

                    foreach (var i in results)
                    {
                        ListViewItem lvitem = new ListViewItem();
                        lvitem.SubItems.Add(i.Id.ToString());
                        if (i.Nome != null)
                            lvitem.SubItems.Add(i.Nome.ToString());
                        else
                            lvitem.SubItems.Add("Sem nome registrada");
                        clinic_listview.Items.Add(lvitem);
                    }

                }
			}
			clinic_listview.Columns[0].Width = 0;
			int widht = clinic_listview.Width / (clinic_listview.Columns.Count - 1);
			for (int i = 1; i < clinic_listview.Columns.Count; i++)
				clinic_listview.Columns[i].Width = widht;
			clinic_listview.MultiSelect = false;
			clinic_listview.FullRowSelect = true;
			clinic_listview.View = View.Details;
		}

		private void loadDoctor()
		{

		}

		private void loadPacient()
		{

		}

		private void loadHealthPlan()
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
