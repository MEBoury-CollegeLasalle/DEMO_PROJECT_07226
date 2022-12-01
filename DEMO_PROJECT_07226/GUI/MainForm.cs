using DEMO_PROJECT_07226.Business.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DEMO_PROJECT_07226.GUI;
public partial class MainForm : Form {
    public MainForm() {
        InitializeComponent();
    }

    private void buttonCreateNewPatient_Click(object sender, EventArgs e) {
        //MainService.getInstance().GetPatientService().OpenPatientCreationForm();
    }
}
