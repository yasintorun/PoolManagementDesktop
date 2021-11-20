using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PoolManagementDesktop
{
    public partial class MainForm : Form
    {
        private Button currentButton;
        private Form activeForm;

        private Form userForm;
        private Form poolForm;
        private Form laneForm;
        private Form packageForm;
        private Form appointmentForm;



        public MainForm()
        {
            InitializeComponent();
            userForm = new Forms.FormUsers();
            poolForm = new Forms.FormPools();
            laneForm = new Forms.FormLanes();
            packageForm = new Forms.FormPackages();
            appointmentForm = new Forms.FormAppointments();

        }

        private void ActivateButton(object btnSender, string colorString)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = ColorTranslator.FromHtml(colorString);
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Microsoft Sans Serif", 12.5F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    lblTitle.Text = currentButton.Text;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender, string colorString)
        {
            if (activeForm != null)
            {
                activeForm.Hide();
            }
            ActivateButton(btnSender, colorString);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            OpenChildForm(userForm, sender, "#EF937E");
        }

        private void btnPools_Click(object sender, EventArgs e)
        {
            OpenChildForm(poolForm, sender, "#E41A4A");
        }

        private void btnLanes_Click(object sender, EventArgs e)
        {
            OpenChildForm(laneForm, sender, "#018790");
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            OpenChildForm(appointmentForm, sender, "#8BC240");
        }

        private void btnPackages_Click(object sender, EventArgs e)
        {
            OpenChildForm(packageForm, sender, "#43B76E");
        }
    }
}
