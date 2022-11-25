using DEMO_PROJECT_07226.Business.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO_PROJECT_07226.GUI;
public partial class PatientCreationForm : Form {
    public PatientCreationForm() {
        InitializeComponent();
    }

    private void createPatientButton_Click(object sender, EventArgs e) {
        // do some validation later
        string firstName = this.firstNameField.Text;
        string lastName = this.lastNameField.Text;
        string healthCardNum = this.healthCardNumberField.Text;
        MainService.getInstance().GetPatientService().CreateNewPatient(firstName, lastName, healthCardNum);
    }
}
