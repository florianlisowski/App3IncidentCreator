using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App2IncidentCreator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIncident_Click(object sender, EventArgs e)
        {
            Incident incident1 = new Incident();
            incident1.IncidentID = txtIncidentID.Text;
            incident1.IncidentDate = txtIncidentDate.Text;
            incident1.ReportedDate = txtReportedDate.Text;
            incident1.Comments = txtComments.Text;
            Staff staff = new Staff(txtStaffID.Text, txtFirstName.Text, txtSurname.Text, txtDepartment.Text);

            if (txtIncidentID.Text == "")
            {
                Incident incident = new Incident();
            }
            else
            {
                Incident incident = new Incident(txtIncidentID.Text, txtIncidentDate.Text, txtReportedDate.Text, txtComments.Text, staff);
            }
            MessageBox.Show("" + incident1.NewIncidentMessage().ToString());
        }

        private void btnDos_Click(object sender, EventArgs e)
        {
            DenialOfService denialOfService1 = new DenialOfService();
            denialOfService1.ServerID = txtServerID.Text;
            denialOfService1.Service = txtService1.Text;
            denialOfService1.Outcome = txtOutcome.Text;
            Staff staff = new Staff(txtStaffID.Text, txtFirstName.Text, txtSurname.Text, txtDepartment.Text);
            Incident incident = new Incident(txtIncidentID.Text, txtIncidentDate.Text, txtReportedDate.Text, txtComments.Text, staff);
            if (radYes.Checked)
            {
                MessageBox.Show(denialOfService1.dosNewMessage().ToString());

            }
            else
            {

                MessageBox.Show("Your service is not active".ToString());
            }
        }
    }
}
