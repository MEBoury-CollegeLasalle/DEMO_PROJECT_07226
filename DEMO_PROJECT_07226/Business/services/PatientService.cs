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


    public PatientDTO OpenModalForCreation() {
        PatientDTO patientDto = new PatientDTO();
        return this.patientCreationForm.OpenWithIntent(patientDto, ViewIntent.CREATION);
    }

    public PatientDTO OpenModalForDisplay(int id) {
        PatientDTO patient = this.patientDAO.GetById(id);
        return this.OpenModalForDisplay(patient);
    }

    public PatientDTO OpenModalForDisplay(PatientDTO patient) {
        return this.patientCreationForm.OpenWithIntent(patient, ViewIntent.VISUALIZATION);
    }

    public PatientDTO OpenModalForModification(PatientDTO patient) {
        return this.patientCreationForm.OpenWithIntent(patient, ViewIntent.MODIFICATION);
    }

    public PatientDTO OpenModalForDeletion(PatientDTO patient) {
        return this.patientCreationForm.OpenWithIntent(patient, ViewIntent.DELETION);
    }


    public PatientDTO CreateNewPatient(PatientDTO newPatient) {
        this.patientDAO.SaveNewPatient(newPatient);
        return newPatient;
    }

    public PatientDTO UpdatePatient(PatientDTO patient) {
        this.patientDAO.SaveModifications(patient);
        return patient;
    }

    public PatientDTO DeletePatient(PatientDTO patient) {
        this.patientDAO.DeletePatient(patient);
        return patient;
    }
}
