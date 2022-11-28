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
            this.actionButton = new System.Windows.Forms.Button();
            this.lblTextId = new System.Windows.Forms.Label();
            this.lblValueId = new System.Windows.Forms.Label();
            this.lblRegistrationDate = new System.Windows.Forms.Label();
            this.registrationDateControl = new System.Windows.Forms.DateTimePicker();
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
            // actionButton
            // 
            this.actionButton.Location = new System.Drawing.Point(214, 200);
            this.actionButton.Name = "actionButton";
            this.actionButton.Size = new System.Drawing.Size(250, 29);
            this.actionButton.TabIndex = 6;
            this.actionButton.Text = "Placeholder";
            this.actionButton.UseVisualStyleBackColor = true;
            this.actionButton.Click += new System.EventHandler(this.ActionButton_Click);
            // 
            // lblTextId
            // 
            this.lblTextId.Location = new System.Drawing.Point(58, 46);
            this.lblTextId.Name = "lblTextId";
            this.lblTextId.Size = new System.Drawing.Size(150, 25);
            this.lblTextId.TabIndex = 7;
            this.lblTextId.Text = "ID:";
            this.lblTextId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblValueId
            // 
            this.lblValueId.Location = new System.Drawing.Point(214, 46);
            this.lblValueId.Name = "lvlValueId";
            this.lblValueId.Size = new System.Drawing.Size(250, 25);
            this.lblValueId.TabIndex = 8;
            this.lblValueId.Text = "placeholder";
            this.lblValueId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblRegistrationDate
            // 
            this.lblRegistrationDate.Location = new System.Drawing.Point(58, 151);
            this.lblRegistrationDate.Name = "lblRegistrationDate";
            this.lblRegistrationDate.Size = new System.Drawing.Size(150, 25);
            this.lblRegistrationDate.TabIndex = 9;
            this.lblRegistrationDate.Text = "Registration date:";
            this.lblRegistrationDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // registrationDateControl
            // 
            this.registrationDateControl.Location = new System.Drawing.Point(214, 148);
            this.registrationDateControl.Name = "registrationDateControl";
            this.registrationDateControl.Size = new System.Drawing.Size(250, 27);
            this.registrationDateControl.TabIndex = 10;
            // 
            // PatientCreationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 253);
            this.Controls.Add(this.registrationDateControl);
            this.Controls.Add(this.lblRegistrationDate);
            this.Controls.Add(this.lblValueId);
            this.Controls.Add(this.lblTextId);
            this.Controls.Add(this.actionButton);
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
    private Button actionButton;
    private Label lblTextId;
    private Label lblValueId;
    private Label lblRegistrationDate;
    private DateTimePicker registrationDateControl;
}