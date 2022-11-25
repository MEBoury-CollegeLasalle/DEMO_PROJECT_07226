namespace DEMO_PROJECT_07226.GUI;

partial class MainForm {
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
            this.buttonCreateNewPatient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCreateNewPatient
            // 
            this.buttonCreateNewPatient.Location = new System.Drawing.Point(270, 90);
            this.buttonCreateNewPatient.Name = "buttonCreateNewPatient";
            this.buttonCreateNewPatient.Size = new System.Drawing.Size(240, 29);
            this.buttonCreateNewPatient.TabIndex = 0;
            this.buttonCreateNewPatient.Text = "Create New Patient";
            this.buttonCreateNewPatient.UseVisualStyleBackColor = true;
            this.buttonCreateNewPatient.Click += new System.EventHandler(this.buttonCreateNewPatient_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCreateNewPatient);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

    }

    #endregion

    private Button buttonCreateNewPatient;
}