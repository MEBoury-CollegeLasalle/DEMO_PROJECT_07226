using DEMO_PROJECT_07226.DataAccess.contexts;
using DEMO_PROJECT_07226.DataAccess.daos;
using DEMO_PROJECT_07226.DataAccess.dtos;
using DEMO_PROJECT_07226.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_PROJECT_07226.Business.services;
public class PatientService : IService {

    private PatientDAO patientDAO;
    private PatientCreationForm patientCreationForm;

    public PatientService(ClinicContext dbContext) { 
        this.patientDAO = new PatientDAO(dbContext);
        this.patientCreationForm = new PatientCreationForm();
    }


    public void OpenPatientCreationForm() {
        this.patientCreationForm.ShowDialog();
    }

    public void ClosePatientCreationForm() {
        this.patientCreationForm.DialogResult = DialogResult.Cancel;
    }

    public PatientDTO CreateNewPatient(string firstName, string lastName, string healthCarnNumber) {
        PatientDTO newPatient = new PatientDTO(firstName, lastName, healthCarnNumber);
        this.patientDAO.SaveNewPatient(newPatient);
        this.ClosePatientCreationForm();
        return newPatient;
    }
}
