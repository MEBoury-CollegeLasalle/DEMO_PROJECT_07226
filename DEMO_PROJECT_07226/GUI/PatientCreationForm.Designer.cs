namespace DEMO_PROJECT_07226.GUI;

partial class PatientCreationForm {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
        if (disposing && (components != null)) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.healthCArdNumberLabel = new System.Windows.Forms.Label();
            this.firstNameField = new System.Windows.Forms.TextBox();
            this.lastNameField = new System.Windows.Forms.TextBox();
            this.healthCardNumberField = new System.Windows.Forms.TextBox();
            this.createPatientButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Location = new System.Drawing.Point(58, 71);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(150, 25);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First name:";
            this.firstNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Location = new System.Drawing.Point(58, 96);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(150, 25);
            this.lastNameLabel.TabIndex = 1;
            this.lastNameLabel.Text = "Last name:";
            this.lastNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // healthCArdNumberLabel
            // 
            this.healthCArdNumberLabel.Location = new System.Drawing.Point(58, 121);
            this.healthCArdNumberLabel.Name = "healthCArdNumberLabel";
            this.healthCArdNumberLabel.Size = new System.Drawing.Size(150, 25);
            this.healthCArdNumberLabel.TabIndex = 2;
            this.healthCArdNumberLabel.Text = "Health card number:";
            this.healthCArdNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // firstNameField
            // 
            this.firstNameField.Location = new System.Drawing.Point(214, 71);
            this.firstNameField.Name = "firstNameField";
            this.firstNameField.PlaceholderText = "first name";
            this.firstNameField.Size = new System.Drawing.Size(250, 27);
            this.firstNameField.TabIndex = 3;
            // 
            // lastNameField
            // 
            this.lastNameField.Location = new System.Drawing.Point(214, 96);
            this.lastNameField.Name = "lastNameField";
            this.lastNameField.PlaceholderText = "last name";
            this.lastNameField.Size = new System.Drawing.Size(250, 27);
            this.lastNameField.TabIndex = 4;
            // 
            // healthCardNumberField
            // 
            this.healthCardNumberField.Location = new System.Drawing.Point(214, 121);
            this.healthCardNumberField.Name = "healthCardNumberField";
            this.healthCardNumberField.PlaceholderText = "RAMQ card number";
            this.healthCardNumberField.Size = new System.Drawing.Size(250, 27);
            this.healthCardNumberField.TabIndex = 5;
            // 
            // createPatientButton
            // 
            this.createPatientButton.Location = new System.Drawing.Point(214, 166);
            this.createPatientButton.Name = "createPatientButton";
            this.createPatientButton.Size = new System.Drawing.Size(250, 29);
            this.createPatientButton.TabIndex = 6;
            this.createPatientButton.Text = "Create new patient";
            this.createPatientButton.UseVisualStyleBackColor = true;
            this.createPatientButton.Click += new System.EventHandler(this.createPatientButton_Click);
            // 
            // PatientCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 253);
            this.Controls.Add(this.createPatientButton);
            this.Controls.Add(this.healthCardNumberField);
            this.Controls.Add(this.lastNameField);
            this.Controls.Add(this.firstNameField);
            this.Controls.Add(this.healthCArdNumberLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Name = "PatientCreationForm";
            this.Text = "PatientCreationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private Label firstNameLabel;
    private Label lastNameLabel;
    private Label healthCArdNumberLabel;
    private TextBox firstNameField;
    private TextBox lastNameField;
    private TextBox healthCardNumberField;
    private Button createPatientButton;
}