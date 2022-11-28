using DEMO_PROJECT_07226.Business.services;
using DEMO_PROJECT_07226.DataAccess.dtos;
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
    private PatientDTO workingInstance;
    private ViewIntent workingIntent;

    public PatientCreationForm() {
        InitializeComponent();
    }

    public PatientDTO OpenWithIntent(PatientDTO dtoInstance, ViewIntent intent) {
        this.workingInstance = dtoInstance;
        this.workingIntent = intent;
        switch (intent) {
            case ViewIntent.CREATION:
                return this.OpenForCreation();
                break;
            case ViewIntent.MODIFICATION:
                return this.OpenForModification();
                break;
            case ViewIntent.DELETION:
                return this.OpenForDeletion();
                break;
            case ViewIntent.VISUALIZATION:
            default:
                return this.OpenForVisualisation();
                break;

        }
    }

    protected PatientDTO OpenForCreation() {
        this.lblValueId.Text = "";
        this.lastNameField.Text = "";
        this.firstNameField.Text = "";
        this.healthCardNumberField.Text = "";
        this.registrationDateControl.Value = DateTime.Now;
        this.lastNameField.Enabled = true;
        this.firstNameField.Enabled = true;
        this.healthCardNumberField.Enabled = true;
        this.registrationDateControl.Enabled = false;
        this.actionButton.Text = "Create!";
        this.ShowDialog();
        return this.workingInstance;
    }

    protected PatientDTO OpenForModification() {
        this.FillFieldsWithDtoData();
        this.lastNameField.Enabled = true;
        this.firstNameField.Enabled = true;
        this.healthCardNumberField.Enabled = true;
        this.registrationDateControl.Enabled = false;
        this.actionButton.Text = "Save Changes";
        this.ShowDialog();
        return this.workingInstance;
    }

    protected PatientDTO OpenForDeletion() {
        this.FillFieldsWithDtoData();
        this.lastNameField.Enabled = false;
        this.firstNameField.Enabled = false;
        this.healthCardNumberField.Enabled = false;
        this.registrationDateControl.Enabled = false;
        this.actionButton.Text = "Delete";
        this.ShowDialog();
        return this.workingInstance;

    }

    protected PatientDTO OpenForVisualisation() {
        this.FillFieldsWithDtoData();
        this.lastNameField.Enabled = false;
        this.firstNameField.Enabled = false;
        this.healthCardNumberField.Enabled = false;
        this.registrationDateControl.Enabled = false;
        this.actionButton.Text = "Close";
        this.ShowDialog();
        return this.workingInstance;

    }

    protected void CloseModal() {
        this.DialogResult = DialogResult.Cancel;
    }

    protected void TriggerCreation() {
        // TODO: validation
        this.workingInstance.FirstName = this.firstNameField.Text;
        this.workingInstance.LastName = this.lastNameField.Text;
        this.workingInstance.HealthCardNumber = this.healthCardNumberField.Text;
        MainService.getInstance().GetPatientService().CreateNewPatient(this.workingInstance);
        this.DialogResult = DialogResult.OK;
    }

    protected void TriggerModification() {
        // TODO: validation
        this.workingInstance.FirstName = this.firstNameField.Text;
        this.workingInstance.LastName = this.lastNameField.Text;
        this.workingInstance.HealthCardNumber = this.healthCardNumberField.Text;
        MainService.getInstance().GetPatientService().UpdatePatient(this.workingInstance);
        this.DialogResult = DialogResult.OK;
    }

    protected void TriggerDeletion() {
        MainService.getInstance().GetPatientService().DeletePatient(this.workingInstance);
        this.DialogResult = DialogResult.OK;
    }

    private void ActionButton_Click(object sender, EventArgs e) {
        switch (this.workingIntent) {
            case ViewIntent.CREATION:
                this.TriggerCreation();
                break;
            case ViewIntent.MODIFICATION:
                this.TriggerModification();
                break;
            case ViewIntent.DELETION:
                this.TriggerDeletion();
                break;
            case ViewIntent.VISUALIZATION:
            default:
                this.CloseModal();
                break;
        }
    }

    private void FillFieldsWithDtoData() {
        this.lblValueId.Text = this.workingInstance.Id.ToString();
        this.lastNameField.Text = this.workingInstance.LastName;
        this.firstNameField.Text = this.workingInstance.FirstName;
        this.healthCardNumberField.Text = this.workingInstance.HealthCardNumber;
        this.registrationDateControl.Value = this.workingInstance.RegistrationDate;
    }
}
