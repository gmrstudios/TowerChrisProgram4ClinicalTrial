// Chris Tower for April 16, 2014 // SUBMITTED April 21st, 2014 - first and only free pass late submission
// Started date - April 7th, 2014
// Program #4 - MEDICAL CLINICAL TRIAL PROGRAM - VERSION TWO
// Chapters five and six: list boxes, loops, and file handling.
// Also, Chapter NINE: CLASSES AND MULTIFORM PROJECTS
// BUSINESS POINT OF VIEW: This program runs a clinical trial system. 
// PROGRAM'S MAIN FUNCTION and PURPOSE: The program processes data about the patients who will participate in the clinical trial
// for a new treatment for prostate cancer using nanotechnology. 
// PROGRAM INPUT: The program uses data obtained either from walk-in patients, entered by the clinic receptionist,
// or from a data file of previously entered data. The form contains the means for the user to enter the patient's name, the maximum number of months that the
// patient can participate in the trial, a random four-digit code (for which the user may use a button that generates a random number). The walk-in patients are
// added to a main list box after processing AND to a names list box that shows the patient's name and corresponding four-digit code. The user may also read the 
// data already saved in the file, which contains four digit codes for patients and the maximum number of months for the trial (no names). 
// DATA PROCESSING: When the file data is read into the program and/or when a new patient is added via input from walk-ins that data is processed, 
// determining which of the four trials the patient will participate in the actual months for the trial (a random number between one month and 
// maximum number of months inputted), and the number of treatments (generated randomly from the actual number of months). 
// ADDITIONAL FILE HANDLING AND REPORT: The user may write all the data in the main list to the file at any time with a write to file button.
// Also, the form contains an append to file button in case additional input is obtained from walk-ins after the data is written to the file.
// Other buttons clear data, cancel last input, and allow the user to open the processed data file and generate a report (which outputs to a list box).

// NEW FOR PROGRAM FOUR: ADDITIONAL DATA PROCESSING: Generation of the random numbers and output for each patient (number indicating which clinical trial, 
// number of actual months on trial derived from maximum, and number of treatments) is completed in a business tier for better protection of data.
// Only the maximum number of months, obtained from user input or from reading the data file, is passed through a constructor to the business tier
// to be used in calculating the actual number of months the patient will be on the trial and in turn the number of treatments. Needed data for output
// is returned to form through "get" and "return" commands.
// SPECIAL PROCESSING: If a checkbox is checked, during user input of patient data, special rules for which clinical trials (only two of the four) and
// the number of months (only five through ten) must be used and so the data is passed to a derived tier, which inherits from the business tier
// and overrides the business tier for those values (trial and treatments).
// ACCUMULATIONS: In the program four version, the number of walk-in patients (both with the check box and without) must be counted. These
// accumulations are completed in the business and derived tiers.

// CLASS POINT OF VIEW: Continued use of basic controls, such as buttons, output to message box, exception handling
// via both try-catch and if-then, data validation via boolean operators, use of varipous data types including random numbers, 
// processing user data. Use of SELECT CASE and IF-Then decision structures.
// Use of variables of various kinds: integer, decimal, string, boolean, random.
// Use of Streamwriter and Streamreader to handle file output and input.
// USE OF CLASSES: both a business tier class and a derived or "inherited" tier that overrides the business tier in special cases.
// FOR TIERS AND CLASSES: Use of CONSTRUCTOR, passing arguments via calling the class, assigning parameters to properties, which in turn
// assign values to backing fields for use in calculations.
// Properties Used: Text, Name, Tag, Tab Stop, Tab Index, Tooltip, Accept Button, Cancel Button, Font, back/forecolor among others.
// Controls Used: Buttons, textbox, label, message box, and list boxes.
// Methods Used: Close, Clear, Focus, Switch, ResetText, SelectAll, Trim, Parse, ToString, Concert.ToInt, new and next for Random numbers, MessageBox.Show.
// Methods of list boxes used: Add and remove.

//****************************************************************************************************************************************************************
// PROGRAM STRUCTURE: Following I have supplied a list of the modules as in a table of contents for the following program.
// 1. VARIABLE DECLARATION and/or INTIALIZATION
// 2. FORM LOAD
// 3. DATA VALIDATION & SEARCH FOR DUPLICATE
// 4. DATA PROCESSING & OUTPUT
// 5. INPUT CONTROLS - Includes list box management and the "add new patient" IE. Process Data event handler.
// 6. FILE HANDLING - Read, write, and append.
// 7. OPEN DATA FILE AND GENERATE REPORT
// 8. EXIT
//****************************************************************************************************************************************************************

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// ADDED THIS LINE TO BE ABLE TO CAN USE FILES COMMANDS, ETC.
using System.IO;


namespace TowerChrisProgram3ClinicalTrial
{
    public partial class TowerCProg4ClinicalTrial : Form
    {
        public TowerCProg4ClinicalTrial()
        {
            InitializeComponent();
        }

        // ***************** BUSINESS TIER CLASS DECLARATION ********************

        private ProcessPatient aPatient;        // Establishes business tier class for calculating patient's ckinical trials.

        //NEW DOCUMENTATION NOTE PROGRAM 4: I did not remove all the variables declared here that are now used in the business tier.
        // Some of these declarations are now redundant as of PROGRAM 4 .


        // VARIABLE DECLARATION and/or INTIALIZATION

        // ************** WORKING FILES ****************************************
        
        StreamReader CurrentPatientFile;         // class level declaration of input data file Name
        StreamWriter PatientOutputFile;          // class level declaration of Output data file Name

        // ******************** INPUT VARIABLES *******************************

        int currentPatientRandomFourDigitCodeInteger;      // Integer value for use in program for four digit code
                                                        // from either radnom generation via button or user input.

        int currentPatientMaximumMonthsForTrialInteger;           // Integer value of maximum months for trial from user input.
                                                        // This number must be between 1-99.
        

        // **************** PROCESSED RECORD DATA (CALCULATION) VARIABLES *************************************

        //Random currentPatientTreatmentPlanRandomNumber = new Random(1000);  // Random number used to determine a treatment plan (1-4) for patient's trial.

        int currentPatientTreatmentPlanInteger;         // Result of randomization that determines a treatment plan (1-4) for patient's trial.

        string currentPatientTreatmentPlanNameString;   // This variable is not used in main processing and output but is used the creation of the final report.

        //Random currentPatientMonthsTotalRandomNumber = new Random(1000);    // Random number used to determine number of months for patient's trial.

        int currentPatientMonthsTotalInteger;               // Result of randomization that determines number of months for patient's trial.

        // From program version 3 - calculation variable now used in business tier.
        // int currentPatientNumberMonthsDividedInteger;       // This number is used in the case select after integer division to determine number of treatments.
                                                                // See documentation in the CalculateNumberofTreatments method.

        //Random currentPatientTreatmentsRandomNumber = new Random(1000); // Random number used to determine number of treatments for patient's trial.

        int currentPatientNumberofTreatmentsInteger; // This number is used in the case select after integer division and randomization to determine number of treatments.
                                                                    // See documentation in the CalculateNumberofTreatments method.

        bool AccumulateWalkInPatientsBoolean; // This is a boolean to pass to business and derived tier to swicth on counting walk in patients.
                                                // Since the processing for all data (including data from file) is accomplished in business tier
                                                // a switch must be used to trigger the accumulation.

        bool AccumulateSpecialWalkInPatientsBoolean; // Separate boolean to accumulate checked walk-in patients for processing as described in documentation above.

        
        // ************** WORKING VARIABLES ****************************************

        int loopControlVariableInteger;         // Variable to count through loop for processing

        string currentPatientInputRecordString;        // String for variable for assembling new patient record from walk in patients as inputted by receptionist.

        //string currentPatientNameAndNumberString;     // String used to assemble four digit code for patient with name for Patient Names List Box.

        string currentPatient4DigitCodeString;      // String used for four digit code as sometimes with the special processing it will have an asterisk
                                                        // and sometimes it will not. Since the asterisk is only for patients added via input from walk ins
                                                    // this string will be set in the "add patient" method.

        Random currentRandomPatientNumber = new Random(1000); // Working variable to generate random four-digit patient number for the clinical trial.

        bool validDataBoolean = false;          // Boolean to control data validation.

        bool headerBoolean = false;             // Boolean for header for report output. Controls that header is only outputted once.

        bool duplicateNameBoolean = false;      // Boolean for controlling the existence of a duplicate name in the list.

        int currentNameBoxIndexInteger;             // Variable saves the index position of last added record in names list box for the "cancel last" button.

        int currentPatientRecordListBoxIndexInteger;    // Variable saves the index position of last added record in main patient records list box for the "cancel last" button.


        private void TowerCProg3ClinicalTrial_Load(object sender, EventArgs e)
        {

            // Set back color for form.

            this.BackColor = System.Drawing.Color.Bisque;

            cancelCurrentInputButton.Enabled = false;       // disables cancel last input button so user cannot click it before input and break the program.

            clearNamesButton.Enabled = false; // disables clear all names button so user cannot click it before input and break the program.

            appendToFileButton.Enabled = false; // disables append to file button. This button is enabled after first write, which empties list box.
                                                    // Thus saving the need to verify the file's existence before appending to it and to 
                                                    // prevent data from being written to the file twice.

            readDataFileButton.Enabled = true;  // Read data file button is enabled just to be sure it's active. It is disabled after the data is read one time from
                                                    // the file to prevent users from reading the data twice.

            writeToDataFileButton.Enabled = false; // Write to data file button is disabled until after at least one record is inputted and placed in list box.
                                                    // The program does not break if this is enabled and clicked when there is no data to write. But nothing
                                                        // happens as there is no data to write.
                        
        }

        // ********************************** DATA VALIDATION ***************************************

        private void ValidateData()
        {
            if (patientNameTextBox.Text.Trim() != String.Empty)         // Tests that a name has been inputted, IE. some text in name text box.
               
            {
                               
                if (maximumMonthsTextBox.Text.Trim() != String.Empty && (int.TryParse(maximumMonthsTextBox.Text, out currentPatientMaximumMonthsForTrialInteger))
                   && (currentPatientMaximumMonthsForTrialInteger > 0) && (currentPatientMaximumMonthsForTrialInteger < 100))
                

                    // The mutliple part if-then above tests that a number has been inputted for the four digit code, that it is an integer, and that it is between 1000-9999.
                    // If the user used the random number generator, the last two tests will automaically be true, but it is tested again here to catch any user error.

                {
                    if (patientNumberTextBox.Text.Trim() != String.Empty && (int.TryParse(patientNumberTextBox.Text, out currentPatientRandomFourDigitCodeInteger))
                    && (currentPatientRandomFourDigitCodeInteger > 999) && (currentPatientRandomFourDigitCodeInteger < 10000))

                    // The mutliple part if-then above tests that a number has been inputted for the maximum number of months, that it is an integer, and
                        // that the number is between 1-99.
                    {

                                validDataBoolean = true;        // If this statement is reached successfully, then all data is valid.
                                randomPatientNumberButton.BackColor = Color.SaddleBrown;
                     }
                  else
                    {
                        MessageBox.Show("Enter a four digit number or use random number generator button",
                        "PATIENT FOUR DIGIT CODE ERROR");   	//Error handling for input into patient four digit code textbox
                        randomPatientNumberButton.BackColor = Color.Red;
                        patientNumberTextBox.Focus();
                        patientNumberTextBox.SelectAll();
                     }
              }
                else
                {
                    MessageBox.Show("Enter a number between 1-99, please",
                        "PATIENT MONTHS NUMBER INPUT ERROR");   	//Error handling for input into patient months textbox
                    maximumMonthsTextBox.Focus();
                    maximumMonthsTextBox.SelectAll();
                }
              }
            else
            {
                MessageBox.Show("Enter a Name Please!", "PATIENT INPUT ERROR");   	//Error handling when no value input into name textbox
                patientNameTextBox.Focus();
                patientNameTextBox.SelectAll();
            }
        }

        // **************************************** METHOD FOR AVOIDING DUPLICATE NAMES **************************************
        
        private void SearchForDuplicate()
        {
            duplicateNameBoolean = false;       // I always like to re-initialize the boolean at the method level even though it is set at the class level
                                                        // just to avoid any problems. So, yes, duplicate code, but sometimes redundany is a good thing.

            int indx = 0;               // initializing counter for loop.
            
            while (duplicateNameBoolean == false && indx < patientsNamesListBox.Items.Count) // Loop used to search for duplicate
            {
                if (patientNameTextBox.Text.ToUpper().Trim() == patientsNamesListBox.Items[indx].ToString().ToUpper())
                {
             duplicateNameBoolean = true;       // if comparison in if-then is equal after names are converted to all upper case, then
                }                               // boolean is switched to true to throw duplicate error message and stop user until new name is inputted.
           indx++;
            }
        }
       // ************************************ PROCESSING DATA METHODS ******************************************

        // *********** Basic method that processes the data records with random number generation follows next ************
        
        private void ProcessPatientRecords()                // if then controls which tier is used for calculations based on check box.
        {
            if (!specialPatientCheckBox.Checked)
                aPatient = new ProcessPatient(currentPatientMaximumMonthsForTrialInteger, AccumulateWalkInPatientsBoolean);
            else
                aPatient = new SpecialProcessPatient(currentPatientMaximumMonthsForTrialInteger, AccumulateSpecialWalkInPatientsBoolean);
        }

        private void OutputPatientRecord()
        {
        // MAIN PREPARATION of processed data string for OUTPUT to main list box.
         currentPatientInputRecordString = currentPatient4DigitCodeString +
                    ", " + aPatient.TreatmentPlan.ToString("d2") + ", " + aPatient.MonthsTotal.ToString("d2") +
                    ", " + aPatient.TreatmentsTotal.ToString("d3");

                patientRecordsListBox.Items.Add(currentPatientInputRecordString);       // ADDS data as string to list box.
           
        }
                        
        // ****************** TREATMENT NAME DETERMINATION METHOD **************************

        // NOTE: Original record processing only requires treatment type as a code 1-4.
            // This next method is used during the report generation method to
                    // get the name of the treatment for use in the output of the report.

        private void getTreatmentPlanName()
        {
            switch (currentPatientTreatmentPlanInteger)     // There's a cheat here that I have included JUST FOR FUN because programs should be fun.
                                                        // This CASE needs to determine the treatment name for numbers passed here from the report method.
                                                        // Since the numbers are all between 1-4 there is no need for a CASE ZERO.
                                                        // However, just for fun, I have included a case for zero that should never be used if
                                                            // the program is running correctly, which it is.
            {
                case 0:
                    currentPatientTreatmentPlanNameString = "Why zero?";
                    break;

                case 1:
                    currentPatientTreatmentPlanNameString = "retired drug";
                    break;

                case 2:
                    currentPatientTreatmentPlanNameString = "active drug";
                    break;

                case 3:
                    currentPatientTreatmentPlanNameString = "new drug";
                    break;

                case 4:
                    currentPatientTreatmentPlanNameString = "placebo";
                   break;
            }

        }
        // ********************************************** INPUT CONTROLS *********************************************************

        // ********* CREATES RANDOM NUMBER FOR PATIENT'S CODE FOR CLINICAL TRIAL *******

        private void randomPatientNumberButton_Click(object sender, EventArgs e)
        {
            currentPatientRandomFourDigitCodeInteger = currentRandomPatientNumber.Next(1000, 10001); // Generates a four digit number for patient code.

            patientNumberTextBox.Text = currentPatientRandomFourDigitCodeInteger.ToString(); // Outputs for digit code into text box pre-processing of record.

            // These four digit numbers do not need to be validated because I have set a button for randomly generate numbers all of which are valid.
            // The user knows that she/he can input a chosen four digit code directly, and before processing this input will be validated that it is
            // both a number and four digits.
        }

        // ******************* LIST BOX MANAGEMENT BUTTONS ***********************************
       
        private void addPatientButton_Click(object sender, EventArgs e)
        {

                validDataBoolean = false;       // This variable is set to false in the initial launch of the program, but is reset here in case
                                                    // of user error or user cancels input, and just as a double check safety valve.

                ValidateData();                 // Calls method to validate all data.

                if (validDataBoolean == true)
                {
                    if (specialPatientCheckBox.Checked)
                        AccumulateSpecialWalkInPatientsBoolean = true;      // Boolean used a switch to turn on special checked accumulation.

                    else
                        AccumulateWalkInPatientsBoolean = true; // Boolean used a switch to turn on accumulation if check box is not checked.

                    ProcessPatientRecords();        // Processes patient records by determining treatment plan, number of months on trial, and 
                    // number of treatments.

                    // Following if-then decision adds an asterisk to the patient record or does not based on whether checkbox is checked.
                    // The Random four digit code is stored in a string to keep the output method re-usable and to add the aterisk here.

                    if (specialPatientCheckBox.Checked)
                    { currentPatient4DigitCodeString = currentPatientRandomFourDigitCodeInteger.ToString("d4") + "*"; }
                    else { currentPatient4DigitCodeString = currentPatientRandomFourDigitCodeInteger.ToString("d4"); }

                    SearchForDuplicate();               // Decided to search for duplicate name here rather than in Validate data as the timing seems better.
                    // Search for Duplicate method can be found following validate data method.

                    if (!duplicateNameBoolean)              // If duplicate is not found, the name and patient number are added to the names list box.
                    {
                        //currentPatientNameAndNumberString = patientNameTextBox.Text.Trim() + ", " + currentPatient4DigitCodeString;
                        // NEW NOTE FOR PROGRAM 4: IN THE original version of the program, I added the four digit code next to the name
                        // as a way for the user to see which name is associated with which code. In the PROGRAM 4 version, I had to eliminate this
                        // feature so the search for duplicate method would work on the name only. With the name and the four digit code in the list box
                        // the search for duplicate never works when searching for JUST the name.

                        patientsNamesListBox.Items.Add(patientNameTextBox.Text.Trim());      // Adds patient name and code to name list box.

                        currentNameBoxIndexInteger = patientsNamesListBox.Items.Count - 1;      // Saves the input in case user wishes to cancel based on count.
                        // Count is one more than index, so this code saves the current index number
                        // in case user wishes to cancel last input.

                        OutputPatientRecord();              // Calls method for output.

                        currentPatientRecordListBoxIndexInteger = patientRecordsListBox.Items.Count - 1; // As above, saves current index for cancellation.

                        cancelCurrentInputButton.Enabled = true;    // Enables cancel last input button for use.
                        clearNamesButton.Enabled = true; // enables clear all names button for use.

                        ClearCurrentInputs();       // Clears current input for next input.

                        AccumulateWalkInPatientsBoolean = false; // Switches off boolean for accumulation, which will only be activated again when next
                        // walk in patient is entered.

                    }
                    else                                            // If duplicate name is found, the error messages appear and prompt user for new input.
                    {
                        MessageBox.Show("The name you inputted already exists. Please change the name.", "DUPLICATE NAME ERROR");

                        patientNameTextBox.Focus();
                        patientNameTextBox.SelectAll();

                    }

                    // NEW DOCUMENT PROG 4 : To fix the problerm of overwriting data in the file, the following code tests for the written file.
                    // If the output file exists, then the code disables the write to file button, which will, thus, only allow
                    // the write to file option ONCE. Though redundant (as this code appears elsewhere), the append to file button
                    // is enabled, which is the only option for users after the file is originally written.
                    // HOWEVER, this code works on the premise that the output file is created uniquely every day and so this would test
                    // to see if a new file FOR THIS DAY has been created yet or not. For our testing purposes, the file MAY already exist.
                    // Thus, for a proper test of this code, the output file must be deleted from the bin/debug folder before running the program.
                    // If the PatientRecordsToday.txt file has not been deleted, then the write button will remain disabled and the user
                    // will only be abel to append (which is okay as it will still work).

                    if (File.Exists(Environment.CurrentDirectory + @"\PatientRecordsToday.txt") == false)
                    {
                        writeToDataFileButton.Enabled = true;       // Enables write to data file button for use.
                    }
                    else
                    {
                        writeToDataFileButton.Enabled = false;
                        appendToFileButton.Enabled = true;
                    }
                  }
        }

        // ********************** CANCELS MOST RECENT INPUTTED PATIENT DATA *******************************************

        private void cancelCurrentInputButton_Click(object sender, EventArgs e)
        {
            if (patientsNamesListBox.Items.Count > 0)        // NEW PROG 4 DOCUMENT: Tests that names list box is not empty. Program breaks if the user tries to cancel
                                                                // last input and yet has already removed name from name list box. If-then fixes this,
                                                                    // but code will still remove the patient from the main records list box.
            {
                patientsNamesListBox.SelectedIndex = currentNameBoxIndexInteger;  // Using saved value of count-1, this code associates that value with 
                // the selected index to be able to remove it.

                patientsNamesListBox.Items.RemoveAt(patientsNamesListBox.SelectedIndex);    // Removes saved value, IE. cancels last inputted record.
                
                cancelCurrentInputButton.Enabled = false;       // disables cancel last input button after use so user cannot click it again and break the program.

                ClearCurrentInputs();           // Calls method to clear all input, which can be re-used for each clear.
            }
            else
            {
                MessageBox.Show("There are no items in the Names list box to cancel", "CANCEL BUTTON ERROR");
                cancelCurrentInputButton.Enabled = false;       // disables cancel last input button after use so user cannot click it again and break the program.
            }

            patientRecordsListBox.SelectedIndex = currentPatientRecordListBoxIndexInteger;  // Next two lines remove from main list box as
            // previous two removed from name list box.
            patientRecordsListBox.Items.RemoveAt(patientRecordsListBox.SelectedIndex);
        }
        
        // ********* REMOVES NAMES FROM PATIENT NAMES LIST BOX *******

        private void removePatientButton_Click(object sender, EventArgs e)
        {
            if (patientsNamesListBox.SelectedIndex > -1)        // Tests that name is selected.
            {
                patientsNamesListBox.Items.RemoveAt(patientsNamesListBox.SelectedIndex); // Removes selected name.
            }
            else
            {
                MessageBox.Show("Pick a name");         // Error message if no name is selected.
            }
        }

        // ************************ METHOD FOR CLEAR CURRENT INPUT *******************************

        private void ClearCurrentInputs()
        {
            // Next set of commands clear all inputs and reset focus to name text box for next input.
            maximumMonthsTextBox.ResetText();
            patientNumberTextBox.ResetText();
            patientNameTextBox.ResetText();
            patientNameTextBox.Focus();
        }

        // ***************** CLEARS ALL NAMES IN NAMES LIST BOX **************************

       private void clearNamesButton_Click(object sender, EventArgs e)
        {
            patientsNamesListBox.Items.Clear();
        }
      // ************************** FILE HANDLING ***********************************

      // ************************** READ FROM DATA FILE ***********************************

        private void readDataFileButton_Click(object sender, EventArgs e)       // Event handler that opens the data file and reads to list box.
        {
            try
            {
                // COMMENTED OUT - original simple read command but leaving it here in case I ever want to return to it.
                //CurrentPatientFile = File.OpenText("ClinicalTrialsA.txt");    
                openFileDialog1.InitialDirectory = Environment.CurrentDirectory;    // Open file dialog box for user to select specific file.

                openFileDialog1.FileName = "ClinicalTrialsA.txt";           // Prompts user with correct file name.

                if (openFileDialog1.ShowDialog() == DialogResult.OK)        // error handling for file opening in an if statement inside the larger
                                                                               // error handling of the try-catch
                {
                    CurrentPatientFile = File.OpenText(openFileDialog1.FileName);  // Command for opening file with dialog box.

                    while (!CurrentPatientFile.EndOfStream)             // Loop for reading data into program and add to list box.
                    {
                        // patientRecordsListBox.Items.Add(CurrentPatientFile.ReadLine());      // original code - simple readline from file

                        string inputRecordString = CurrentPatientFile.ReadLine();           // Input string and read one line at a time.

                        var flds = inputRecordString.Split(',');            // split comma delimited input with split method.

                        currentPatientRandomFourDigitCodeInteger = Convert.ToInt32(flds[0]); // Converts string data to Integer data type.

                        currentPatient4DigitCodeString = currentPatientRandomFourDigitCodeInteger.ToString("d4");

                        currentPatientMaximumMonthsForTrialInteger = Convert.ToInt32(flds[1]);

                        ProcessPatientRecords();            // Calls process method to process data, the same as in "add patient" event handler.

                        OutputPatientRecord();              // Calls method for output.
                     }
               CurrentPatientFile.Close();
                }
                else
                {
                    MessageBox.Show("Open file was cancelled", "CANCEL CONFIRMATION");      // Error handling for file open.
                }
            }
            catch (Exception errName)                                                   // CATCH ANY ERROR (TYPICALLY A FILE ONE) AND DISPLAY
            {
                MessageBox.Show(errName.Message);
            }

            cancelCurrentInputButton.Enabled = false;       // disables cancel last input button after file is read so use cannot delete last file record
                                                                   // and to prevent a program break as there may be no values for the last input yet either.

            readDataFileButton.Enabled = false;         // To prevent user from clicking read from data file button twice. The Button is disabled here after
                                                            // the data has been read into the current listbox once.
                                                        // To read from data again, the user would have to exit the program and start it over again,
                                                        // which seems to be in the logic of this clinic's set up.
            
            writeToDataFileButton.Enabled = true;       // Enables write to data file button for use.
        }

        // ************************** WRITE TO DATA FILE ***********************************
                // NOTE: I decided not to open a save dialog in the write button. This is the quick and simple command that writes the data and clears the
                        // boxes. The APPEND button will open the save dialog, thus fulfilling this requirement of the program.

            private void writeToDataFileButton_Click(object sender, EventArgs e)        // Event handler for writing all current patient records to file.
                                                                            // To protect data, a separate file name is used to not overwrite orignal data file.
                                                                           // This data protection is a simple version for this program only. A more complex system
                                                                            // would surely be used by the clinic to back up and keep multiple copies of the file.
            {
                try
                {
                    PatientOutputFile = File.CreateText("PatientRecordsToday.txt");
                    
                    for (loopControlVariableInteger = 0; loopControlVariableInteger < patientRecordsListBox.Items.Count; loopControlVariableInteger++)
                    {
                        PatientOutputFile.WriteLine(patientRecordsListBox.Items[loopControlVariableInteger]);
                     
                    }
                    
                    patientRecordsListBox.Items.Clear();                                   // CLEAR LIST BOX ONCE WRITTEN
                    patientsNamesListBox.Items.Clear();                                     // CLEARS NAMES BOX ONCE WRITTEN
                    PatientOutputFile.Close();
                    
                }
                catch (Exception errName)                                                   // CATCH ANY ERROR (TYPICALLY A FILE ONE) AND DISPLAY
                {
                    MessageBox.Show(errName.Message);
                }

                writeToDataFileButton.Enabled = false;      // NEW DOCUMENT PROG 4: Fixed the overwrite or duplicate problem. Simply disabling this button until
                                                                // the user adds more data, solved the problem of happy clickers clicking write to file button twice
                                                                   // and overwriting file.
                
                appendToFileButton.Enabled = true;          // Append button is enabled here once the data is written the first time to the
                                                                // data output file. This allows user to now add to data output file but
                                                                // not to write data twice to the output file.

            }

            // ************************** APPEND TO DATA FILE ***********************************


            private void appendToFileButton_Click(object sender, EventArgs e)           // Append works much the same as Write method except
            {                                                                          // appending rather than overwriting. See previous documentation.     
                try
                {
                    saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;

                    saveFileDialog1.FileName = "PatientRecordsToday.txt";

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        PatientOutputFile = File.AppendText(saveFileDialog1.FileName);

                        for (loopControlVariableInteger = 0; loopControlVariableInteger < patientRecordsListBox.Items.Count; loopControlVariableInteger++)
                        {
                            PatientOutputFile.WriteLine(patientRecordsListBox.Items[loopControlVariableInteger]);

                        }

                        // NEW DOCUMENT FOR PROGRAM 4 - I did not have these next two clear statements in program #3. This fixes the problem
                        // of the list boxes not being clear and/or duplicated.

                        patientRecordsListBox.Items.Clear();                                   // CLEAR LIST BOX ONCE APPENDED

                        patientsNamesListBox.Items.Clear();                                     // CLEARS NAMES BOX ONCE APPENDED

                        PatientOutputFile.Close();

                    }
                    else
                    {
                        MessageBox.Show("append and save file was cancelled", "CANCEL CONFIRMATION");
                    }
                }
                catch (Exception errName)                                                   // CATCH ANY ERROR (TYPICALLY A FILE ONE) AND DISPLAY
                {
                    MessageBox.Show(errName.Message);
                }
            }

        // *********************** OPENS OUTPUT DATA FILE AND GENERATES REPORT ******************************

            private void openDialogBoxFileButton_Click(object sender, EventArgs e)
            {
                try
                {
                    // COMMENTED OUT - original simple read command but leaving it here in case I ever want to return to it.
                    //CurrentPatientFile = File.OpenText("ClinicalTrialsA.txt");    

                    openFileDialog1.InitialDirectory = Environment.CurrentDirectory;    // Open file dialog box for user to select specific file.

                    openFileDialog1.FileName = "PatientRecordsToday.txt";           // Prompts user with correct file type to allow use to choose from different output files.

                    if (openFileDialog1.ShowDialog() == DialogResult.OK)        // error handling for file opening in an if statement inside the larger
                    // error handling of the try-catch
                    {
                        CurrentPatientFile = File.OpenText(openFileDialog1.FileName);   //Allows user to open file through dialog box.

                        // Header is established with two strings for two additions to the list box.
                        // ORIGINALLY (as noted in program #3, No check is needed to output header once as report is only generated once, so the usual fancy
                        // header boolean is not needed.

                        // NEW DOCUMENT PROGRAM 4: Header boolean and if-then check added by request.
                        // Following code uses a header boolean to control that the header is only outputted one time.

                        if (headerBoolean == false)       
                        {
                            string reportHeaderLine1String = "NANOTECH PROSTATE CANCER CLINIC PATIENT REPORT FOR TODAY ------->" + DateTime.Now;

                            string reportHeaderLine2String = "PATIENT CODE" +
                                "PLAN CODE".PadLeft(20) +
                                "PLAN NAME".PadLeft(20) +
                                "MONTHS".PadLeft(17) +
                                "TREATMENTS".PadLeft(21);

                            reportListBox.Items.Add(reportHeaderLine1String);
                            reportListBox.Items.Add(reportHeaderLine2String);
                            headerBoolean = true;
                        }

                        // The loop and code that follows reads the data from the data file and splits it all apart
                        // for output to the list box.

                        while (!CurrentPatientFile.EndOfStream)
                        {
                            
                            string inputRecordString = CurrentPatientFile.ReadLine();

                            var flds = inputRecordString.Split(',');

                            currentPatientRandomFourDigitCodeInteger = Convert.ToInt32(flds[0]);
                            
                            currentPatientTreatmentPlanInteger = Convert.ToInt32(flds[1]);

                            getTreatmentPlanName();             // Method called to get the name of the treatment plan, which is only needed here
                                                                // but must be determined via a decision structure and it was better to put the code with
                                                                    // the data processing code.

                            currentPatientMonthsTotalInteger = Convert.ToInt32(flds[2]);

                            currentPatientNumberofTreatmentsInteger = Convert.ToInt32(flds[3]);

                            // Code below creates string for output of report.

                            currentPatientInputRecordString = currentPatientRandomFourDigitCodeInteger.ToString("d4") + 
                                currentPatientTreatmentPlanInteger.ToString().PadLeft(33) +
                                currentPatientTreatmentPlanNameString.PadLeft(38) +
                                currentPatientMonthsTotalInteger.ToString("d2").PadLeft(17) + 
                                currentPatientNumberofTreatmentsInteger.ToString("d3").PadLeft(21);

                            reportListBox.Items.Add(currentPatientInputRecordString);
                        }
                CurrentPatientFile.Close();
                    }
                    else
                    {
                        MessageBox.Show("Open file was cancelled", "CANCEL CONFIRMATION");      // Error handling for file open.
                    }
                }
                catch (Exception errName)                                                   // CATCH ANY ERROR (TYPICALLY A FILE ONE) AND DISPLAY
                {
                    MessageBox.Show(errName.Message);
                }
            }

            private void getTotalsButton_Click(object sender, EventArgs e)              // Event handler to access totals from
            {                                                                    // business tier and show them in a message box.
                string totalString;

                totalString = "Walk-in Patient Totals = " + ProcessPatient.TotalWalkInPatients.ToString("d2")
                    + Environment.NewLine + "Special Walk-in Patient Totals = " +
                    SpecialProcessPatient.totalSpecialWalkInPatients.ToString("d2") + Environment.NewLine +
                    "Total of Walk-in patients without check = " + 
                    (ProcessPatient.TotalWalkInPatients - SpecialProcessPatient.totalSpecialWalkInPatients).ToString("d2");

                MessageBox.Show(totalString, "WALK-IN PATIENT TOTALS");
            }


            private void clearTotalsButton_Click(object sender, EventArgs e)            // CLEARS TOTALS ON CONFIRMATION
            {

                if (MessageBox.Show("Click YES to Clear totals", "RESET TOTALS", MessageBoxButtons.YesNo,
                          MessageBoxIcon.Information, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
                {
                    aPatient = new ProcessPatient(true);                // Totals cleared in both business and derived tier.
                    aPatient = new SpecialProcessPatient(true);
                }
            }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult checkSaveDialogResult;             // Code here checks with user to make sure data is written before program is closed.
                                                            // Saving user from accidentally losing the data.

            checkSaveDialogResult = MessageBox.Show("Are you certain you wish to exit? Have you written or appended all data to the data file?", "DATA CHECK", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (checkSaveDialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close();
            }
         
        }
    }
}
