using DEMO_PROJECT_07226.Business;
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
public partial class LoginWindow : Form {

    private ILoginService loginService;

    public LoginWindow(ILoginService service) {
        if (service is null) {
            throw new Exception("[service] parameter must not be null.");
        }
        this.loginService = service;
        InitializeComponent();
    }

    private void loginButton_Click(object sender, EventArgs e) {
        string username = this.usernameField.Text;
        string password = this.passwordField.Text;
        this.validateUsername(username);
        this.validateUsername(password);
        loginService.LogUserIn(username, password);
    }



    /// <summary>
    /// Author: Marc-Eric Boury
    /// </summary>
    /// <param name="usernameToValidate"></param>
    /// <exception cref="Exception"></exception>
    private void validateUsername(string usernameToValidate) {
        if (usernameToValidate.Length > 32) {
            throw new Exception("Username must not be more than 32 characters long.");
        }
    }


    /// <summary>
    /// Author: Marc-Eric Boury
    /// </summary>
    /// <param name="clearPasswordToValidate"></param>
    /// <exception cref="Exception"></exception>
    private void validatePAssword(string clearPasswordToValidate) {
        if (clearPasswordToValidate.Length > 32) {
            throw new Exception("PAssword must not be more than 32 characters long.");
        }
    }
}
