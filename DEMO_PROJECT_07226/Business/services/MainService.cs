using DEMO_PROJECT_07226.DataAccess.contexts;
using DEMO_PROJECT_07226.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO_PROJECT_07226.Business.services;
public class MainService {
    private ClinicContext clinicContext;
    private PatientService patientService;

    private static MainService INSTANCE = null!;

    protected MainService() { 
        this.clinicContext = new ClinicContext();
        this.patientService = new PatientService(this.clinicContext);
    }

    public static MainService getInstance() {
        if (INSTANCE is null) {
            INSTANCE = new MainService();
        }
        return INSTANCE;
    }

    public void OpenMainWindow() {
        Application.Run(new MainForm());
    }

    public void ExitApplication() {
        Application.Exit();
    }

    public PatientService GetPatientService() {
        return this.patientService;
    }
}
