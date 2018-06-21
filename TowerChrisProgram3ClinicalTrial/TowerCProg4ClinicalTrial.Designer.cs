namespace TowerChrisProgram3ClinicalTrial
{
    partial class TowerCProg4ClinicalTrial
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.patientNameTextBox = new System.Windows.Forms.TextBox();
            this.patientNamePromptLabel = new System.Windows.Forms.Label();
            this.patientNumberTextBox = new System.Windows.Forms.TextBox();
            this.maximumMonthsTextBox = new System.Windows.Forms.TextBox();
            this.patientNumberPromptLabel = new System.Windows.Forms.Label();
            this.maximumNumberofMonthsPromptLabel = new System.Windows.Forms.Label();
            this.clinicalLabTitleLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.addPatientButton = new System.Windows.Forms.Button();
            this.removePatientButton = new System.Windows.Forms.Button();
            this.readDataFileButton = new System.Windows.Forms.Button();
            this.patientRecordsListBox = new System.Windows.Forms.ListBox();
            this.patientsNamesListBox = new System.Windows.Forms.ListBox();
            this.clearNamesButton = new System.Windows.Forms.Button();
            this.writeToDataFileButton = new System.Windows.Forms.Button();
            this.reportListBox = new System.Windows.Forms.ListBox();
            this.getRandonNumberLabel = new System.Windows.Forms.Label();
            this.randomPatientNumberButton = new System.Windows.Forms.Button();
            this.openDialogBoxFileButton = new System.Windows.Forms.Button();
            this.cancelCurrentInputButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.appendToFileButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.specialPatientCheckBox = new System.Windows.Forms.CheckBox();
            this.getTotalsButton = new System.Windows.Forms.Button();
            this.clearTotalsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patientNameTextBox
            // 
            this.patientNameTextBox.Location = new System.Drawing.Point(246, 61);
            this.patientNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.patientNameTextBox.Name = "patientNameTextBox";
            this.patientNameTextBox.Size = new System.Drawing.Size(223, 26);
            this.patientNameTextBox.TabIndex = 2;
            this.toolTip1.SetToolTip(this.patientNameTextBox, "Enter patient name: first and last.");
            // 
            // patientNamePromptLabel
            // 
            this.patientNamePromptLabel.AutoSize = true;
            this.patientNamePromptLabel.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientNamePromptLabel.Location = new System.Drawing.Point(31, 61);
            this.patientNamePromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patientNamePromptLabel.Name = "patientNamePromptLabel";
            this.patientNamePromptLabel.Size = new System.Drawing.Size(201, 20);
            this.patientNamePromptLabel.TabIndex = 1;
            this.patientNamePromptLabel.Text = "Please enter the patient\'s name:";
            // 
            // patientNumberTextBox
            // 
            this.patientNumberTextBox.Location = new System.Drawing.Point(246, 174);
            this.patientNumberTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.patientNumberTextBox.Name = "patientNumberTextBox";
            this.patientNumberTextBox.Size = new System.Drawing.Size(71, 26);
            this.patientNumberTextBox.TabIndex = 7;
            this.toolTip1.SetToolTip(this.patientNumberTextBox, "Button above generates number.");
            // 
            // maximumMonthsTextBox
            // 
            this.maximumMonthsTextBox.Location = new System.Drawing.Point(319, 95);
            this.maximumMonthsTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.maximumMonthsTextBox.Name = "maximumMonthsTextBox";
            this.maximumMonthsTextBox.Size = new System.Drawing.Size(50, 26);
            this.maximumMonthsTextBox.TabIndex = 4;
            this.toolTip1.SetToolTip(this.maximumMonthsTextBox, "Enter number 1-99.");
            // 
            // patientNumberPromptLabel
            // 
            this.patientNumberPromptLabel.AutoSize = true;
            this.patientNumberPromptLabel.Location = new System.Drawing.Point(12, 174);
            this.patientNumberPromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.patientNumberPromptLabel.Name = "patientNumberPromptLabel";
            this.patientNumberPromptLabel.Size = new System.Drawing.Size(220, 20);
            this.patientNumberPromptLabel.TabIndex = 6;
            this.patientNumberPromptLabel.Text = "Random patient\'s number (4 digits):";
            // 
            // maximumNumberofMonthsPromptLabel
            // 
            this.maximumNumberofMonthsPromptLabel.AutoSize = true;
            this.maximumNumberofMonthsPromptLabel.Location = new System.Drawing.Point(13, 95);
            this.maximumNumberofMonthsPromptLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maximumNumberofMonthsPromptLabel.Name = "maximumNumberofMonthsPromptLabel";
            this.maximumNumberofMonthsPromptLabel.Size = new System.Drawing.Size(298, 20);
            this.maximumNumberofMonthsPromptLabel.TabIndex = 3;
            this.maximumNumberofMonthsPromptLabel.Text = "Please enter the max. # of months for trial (1-99):";
            // 
            // clinicalLabTitleLabel
            // 
            this.clinicalLabTitleLabel.AutoSize = true;
            this.clinicalLabTitleLabel.BackColor = System.Drawing.Color.Blue;
            this.clinicalLabTitleLabel.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clinicalLabTitleLabel.ForeColor = System.Drawing.Color.White;
            this.clinicalLabTitleLabel.Location = new System.Drawing.Point(37, 13);
            this.clinicalLabTitleLabel.Name = "clinicalLabTitleLabel";
            this.clinicalLabTitleLabel.Size = new System.Drawing.Size(515, 37);
            this.clinicalLabTitleLabel.TabIndex = 0;
            this.clinicalLabTitleLabel.Text = "Nanotech Prostate Cancer Clinic";
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(274, 458);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(95, 82);
            this.exitButton.TabIndex = 15;
            this.exitButton.Text = "E&XIT PROGRAM";
            this.toolTip1.SetToolTip(this.exitButton, "Exit");
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // addPatientButton
            // 
            this.addPatientButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.addPatientButton.ForeColor = System.Drawing.Color.White;
            this.addPatientButton.Location = new System.Drawing.Point(502, 79);
            this.addPatientButton.Name = "addPatientButton";
            this.addPatientButton.Size = new System.Drawing.Size(137, 78);
            this.addPatientButton.TabIndex = 9;
            this.addPatientButton.Text = "&ADD NEW PATIENT";
            this.toolTip1.SetToolTip(this.addPatientButton, "Click to process data from input");
            this.addPatientButton.UseVisualStyleBackColor = false;
            this.addPatientButton.Click += new System.EventHandler(this.addPatientButton_Click);
            // 
            // removePatientButton
            // 
            this.removePatientButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.removePatientButton.ForeColor = System.Drawing.Color.White;
            this.removePatientButton.Location = new System.Drawing.Point(274, 345);
            this.removePatientButton.Name = "removePatientButton";
            this.removePatientButton.Size = new System.Drawing.Size(95, 82);
            this.removePatientButton.TabIndex = 13;
            this.removePatientButton.Text = "R&EMOVE PATIENT\'S NAME";
            this.toolTip1.SetToolTip(this.removePatientButton, "Removes a name from list.");
            this.removePatientButton.UseVisualStyleBackColor = false;
            this.removePatientButton.Click += new System.EventHandler(this.removePatientButton_Click);
            // 
            // readDataFileButton
            // 
            this.readDataFileButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.readDataFileButton.ForeColor = System.Drawing.Color.White;
            this.readDataFileButton.Location = new System.Drawing.Point(645, 18);
            this.readDataFileButton.Name = "readDataFileButton";
            this.readDataFileButton.Size = new System.Drawing.Size(95, 54);
            this.readDataFileButton.TabIndex = 10;
            this.readDataFileButton.Text = "&READ FROM DATA FILE";
            this.toolTip1.SetToolTip(this.readDataFileButton, "Click to read data from file");
            this.readDataFileButton.UseVisualStyleBackColor = false;
            this.readDataFileButton.Click += new System.EventHandler(this.readDataFileButton_Click);
            // 
            // patientRecordsListBox
            // 
            this.patientRecordsListBox.FormattingEnabled = true;
            this.patientRecordsListBox.ItemHeight = 20;
            this.patientRecordsListBox.Location = new System.Drawing.Point(645, 78);
            this.patientRecordsListBox.Name = "patientRecordsListBox";
            this.patientRecordsListBox.Size = new System.Drawing.Size(452, 184);
            this.patientRecordsListBox.TabIndex = 11;
            // 
            // patientsNamesListBox
            // 
            this.patientsNamesListBox.FormattingEnabled = true;
            this.patientsNamesListBox.ItemHeight = 20;
            this.patientsNamesListBox.Location = new System.Drawing.Point(44, 297);
            this.patientsNamesListBox.Name = "patientsNamesListBox";
            this.patientsNamesListBox.Size = new System.Drawing.Size(202, 144);
            this.patientsNamesListBox.TabIndex = 12;
            // 
            // clearNamesButton
            // 
            this.clearNamesButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.clearNamesButton.ForeColor = System.Drawing.Color.White;
            this.clearNamesButton.Location = new System.Drawing.Point(173, 202);
            this.clearNamesButton.Name = "clearNamesButton";
            this.clearNamesButton.Size = new System.Drawing.Size(95, 82);
            this.clearNamesButton.TabIndex = 14;
            this.clearNamesButton.Text = "C&LEAR ALL NAMES";
            this.toolTip1.SetToolTip(this.clearNamesButton, "Clear names.");
            this.clearNamesButton.UseVisualStyleBackColor = false;
            this.clearNamesButton.Click += new System.EventHandler(this.clearNamesButton_Click);
            // 
            // writeToDataFileButton
            // 
            this.writeToDataFileButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.writeToDataFileButton.ForeColor = System.Drawing.Color.White;
            this.writeToDataFileButton.Location = new System.Drawing.Point(1001, 18);
            this.writeToDataFileButton.Name = "writeToDataFileButton";
            this.writeToDataFileButton.Size = new System.Drawing.Size(95, 54);
            this.writeToDataFileButton.TabIndex = 11;
            this.writeToDataFileButton.Text = "&WRITE TO DATA FILE";
            this.toolTip1.SetToolTip(this.writeToDataFileButton, "Write data to file. Data clears after write completes.");
            this.writeToDataFileButton.UseVisualStyleBackColor = false;
            this.writeToDataFileButton.Click += new System.EventHandler(this.writeToDataFileButton_Click);
            // 
            // reportListBox
            // 
            this.reportListBox.FormattingEnabled = true;
            this.reportListBox.ItemHeight = 20;
            this.reportListBox.Location = new System.Drawing.Point(406, 297);
            this.reportListBox.Name = "reportListBox";
            this.reportListBox.Size = new System.Drawing.Size(663, 244);
            this.reportListBox.TabIndex = 18;
            // 
            // getRandonNumberLabel
            // 
            this.getRandonNumberLabel.AutoSize = true;
            this.getRandonNumberLabel.Location = new System.Drawing.Point(22, 137);
            this.getRandonNumberLabel.Name = "getRandonNumberLabel";
            this.getRandonNumberLabel.Size = new System.Drawing.Size(304, 20);
            this.getRandonNumberLabel.TabIndex = 5;
            this.getRandonNumberLabel.Text = "Click Button to generate random patient  number: ";
            // 
            // randomPatientNumberButton
            // 
            this.randomPatientNumberButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.randomPatientNumberButton.ForeColor = System.Drawing.Color.White;
            this.randomPatientNumberButton.Location = new System.Drawing.Point(17, 204);
            this.randomPatientNumberButton.Name = "randomPatientNumberButton";
            this.randomPatientNumberButton.Size = new System.Drawing.Size(137, 78);
            this.randomPatientNumberButton.TabIndex = 8;
            this.randomPatientNumberButton.Text = "Generate Random Patient &Number";
            this.toolTip1.SetToolTip(this.randomPatientNumberButton, "Generates random four-digit number.");
            this.randomPatientNumberButton.UseVisualStyleBackColor = false;
            this.randomPatientNumberButton.Click += new System.EventHandler(this.randomPatientNumberButton_Click);
            // 
            // openDialogBoxFileButton
            // 
            this.openDialogBoxFileButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.openDialogBoxFileButton.ForeColor = System.Drawing.Color.White;
            this.openDialogBoxFileButton.Location = new System.Drawing.Point(406, 217);
            this.openDialogBoxFileButton.Name = "openDialogBoxFileButton";
            this.openDialogBoxFileButton.Size = new System.Drawing.Size(175, 65);
            this.openDialogBoxFileButton.TabIndex = 17;
            this.openDialogBoxFileButton.Text = "&OPEN FILE FOR REPORT";
            this.toolTip1.SetToolTip(this.openDialogBoxFileButton, "Opens data file and creates report.");
            this.openDialogBoxFileButton.UseVisualStyleBackColor = false;
            this.openDialogBoxFileButton.Click += new System.EventHandler(this.openDialogBoxFileButton_Click);
            // 
            // cancelCurrentInputButton
            // 
            this.cancelCurrentInputButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.cancelCurrentInputButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelCurrentInputButton.ForeColor = System.Drawing.Color.White;
            this.cancelCurrentInputButton.Location = new System.Drawing.Point(274, 232);
            this.cancelCurrentInputButton.Name = "cancelCurrentInputButton";
            this.cancelCurrentInputButton.Size = new System.Drawing.Size(95, 82);
            this.cancelCurrentInputButton.TabIndex = 16;
            this.cancelCurrentInputButton.Text = "CAN&CEL LAST INPUT";
            this.toolTip1.SetToolTip(this.cancelCurrentInputButton, "Cancels last input.");
            this.cancelCurrentInputButton.UseVisualStyleBackColor = false;
            this.cancelCurrentInputButton.Click += new System.EventHandler(this.cancelCurrentInputButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // appendToFileButton
            // 
            this.appendToFileButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.appendToFileButton.ForeColor = System.Drawing.Color.White;
            this.appendToFileButton.Location = new System.Drawing.Point(823, 18);
            this.appendToFileButton.Name = "appendToFileButton";
            this.appendToFileButton.Size = new System.Drawing.Size(95, 54);
            this.appendToFileButton.TabIndex = 19;
            this.appendToFileButton.Text = "A&PPEND TO DATA FILE";
            this.toolTip1.SetToolTip(this.appendToFileButton, "Click to append file.");
            this.appendToFileButton.UseVisualStyleBackColor = false;
            this.appendToFileButton.Click += new System.EventHandler(this.appendToFileButton_Click);
            // 
            // specialPatientCheckBox
            // 
            this.specialPatientCheckBox.AutoSize = true;
            this.specialPatientCheckBox.Location = new System.Drawing.Point(384, 174);
            this.specialPatientCheckBox.Name = "specialPatientCheckBox";
            this.specialPatientCheckBox.Size = new System.Drawing.Size(203, 24);
            this.specialPatientCheckBox.TabIndex = 20;
            this.specialPatientCheckBox.Text = "Check for special processing";
            this.specialPatientCheckBox.UseVisualStyleBackColor = true;
            // 
            // getTotalsButton
            // 
            this.getTotalsButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.getTotalsButton.ForeColor = System.Drawing.Color.White;
            this.getTotalsButton.Location = new System.Drawing.Point(26, 459);
            this.getTotalsButton.Name = "getTotalsButton";
            this.getTotalsButton.Size = new System.Drawing.Size(95, 82);
            this.getTotalsButton.TabIndex = 21;
            this.getTotalsButton.Text = "TO&TALS OF WALK-IN PATIENTS";
            this.getTotalsButton.UseVisualStyleBackColor = false;
            this.getTotalsButton.Click += new System.EventHandler(this.getTotalsButton_Click);
            // 
            // clearTotalsButton
            // 
            this.clearTotalsButton.BackColor = System.Drawing.Color.SaddleBrown;
            this.clearTotalsButton.ForeColor = System.Drawing.Color.White;
            this.clearTotalsButton.Location = new System.Drawing.Point(150, 459);
            this.clearTotalsButton.Name = "clearTotalsButton";
            this.clearTotalsButton.Size = new System.Drawing.Size(95, 82);
            this.clearTotalsButton.TabIndex = 22;
            this.clearTotalsButton.Text = "CLEAR TOTALS";
            this.clearTotalsButton.UseVisualStyleBackColor = false;
            this.clearTotalsButton.Click += new System.EventHandler(this.clearTotalsButton_Click);
            // 
            // TowerCProg4ClinicalTrial
            // 
            this.AcceptButton = this.addPatientButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.exitButton;
            this.ClientSize = new System.Drawing.Size(1109, 570);
            this.Controls.Add(this.clearTotalsButton);
            this.Controls.Add(this.getTotalsButton);
            this.Controls.Add(this.specialPatientCheckBox);
            this.Controls.Add(this.appendToFileButton);
            this.Controls.Add(this.cancelCurrentInputButton);
            this.Controls.Add(this.openDialogBoxFileButton);
            this.Controls.Add(this.randomPatientNumberButton);
            this.Controls.Add(this.getRandonNumberLabel);
            this.Controls.Add(this.reportListBox);
            this.Controls.Add(this.writeToDataFileButton);
            this.Controls.Add(this.clearNamesButton);
            this.Controls.Add(this.patientsNamesListBox);
            this.Controls.Add(this.patientRecordsListBox);
            this.Controls.Add(this.readDataFileButton);
            this.Controls.Add(this.removePatientButton);
            this.Controls.Add(this.addPatientButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clinicalLabTitleLabel);
            this.Controls.Add(this.maximumNumberofMonthsPromptLabel);
            this.Controls.Add(this.patientNumberPromptLabel);
            this.Controls.Add(this.maximumMonthsTextBox);
            this.Controls.Add(this.patientNumberTextBox);
            this.Controls.Add(this.patientNamePromptLabel);
            this.Controls.Add(this.patientNameTextBox);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TowerCProg4ClinicalTrial";
            this.Text = "Nanotech Prostate Cancer Clinic                                                  " +
    "                                        TowerChrisProg4";
            this.toolTip1.SetToolTip(this, "Click for totals of walk in patients");
            this.Load += new System.EventHandler(this.TowerCProg3ClinicalTrial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox patientNameTextBox;
        private System.Windows.Forms.Label patientNamePromptLabel;
        private System.Windows.Forms.TextBox patientNumberTextBox;
        private System.Windows.Forms.TextBox maximumMonthsTextBox;
        private System.Windows.Forms.Label patientNumberPromptLabel;
        private System.Windows.Forms.Label maximumNumberofMonthsPromptLabel;
        private System.Windows.Forms.Label clinicalLabTitleLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button addPatientButton;
        private System.Windows.Forms.Button removePatientButton;
        private System.Windows.Forms.Button readDataFileButton;
        private System.Windows.Forms.ListBox patientRecordsListBox;
        private System.Windows.Forms.ListBox patientsNamesListBox;
        private System.Windows.Forms.Button clearNamesButton;
        private System.Windows.Forms.Button writeToDataFileButton;
        private System.Windows.Forms.ListBox reportListBox;
        private System.Windows.Forms.Label getRandonNumberLabel;
        private System.Windows.Forms.Button randomPatientNumberButton;
        private System.Windows.Forms.Button openDialogBoxFileButton;
        private System.Windows.Forms.Button cancelCurrentInputButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button appendToFileButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox specialPatientCheckBox;
        private System.Windows.Forms.Button getTotalsButton;
        private System.Windows.Forms.Button clearTotalsButton;
    }
}

