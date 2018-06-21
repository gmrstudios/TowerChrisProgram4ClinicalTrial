// Chris Tower for April 16, 2014 // SUBMITTED April 21st, 2014 - first and only free pass late submission
// Started date - April 7th, 2014
// Program #4 - MEDICAL CLINICAL TRIAL PROGRAM - VERSION TWO
// SEE MAIN DOCUMENTATION IN MAIN PROGRAM CODE TAB. 
// This is the BUSINESS TIER "Process Patient." Two arguments are passed to this tier: the maximum months from input or file to be used
// in processing and a Boolean to control accumulations. A second constructor accepts the boolean argument passed that controls clearing the totals.
// Private Instance variables are set as well as random numbers and the accumulator.
// CONSTRUCTOR accepts arguments. One Construtor with two values sent over as part of processing and accumulation and a second
// constructor accepting the argument for clearing the accumulated totals upon confirmation from user.
// Constructor assigns paramters to properties and then properties assign values to the private instance variables (backing fields).
// Sets and gets work with data for porcessing and/or returning data to form.
// Processing occurs in two methods: a main processing method and a case structure.
// Main processing features counting loops to stall a computer that is too fast to truly generate random and varied numbers based on clock speed
// without time wasting counters.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerChrisProgram3ClinicalTrial
{
    class ProcessPatient
    {
        // a)  PRIVATE INSTANCE VARIABLES/BACKING FIELDS

        protected int maximumMonthsInt;           // Value passed over from presentation tier.
        
        private int currentPatientNumberMonthsDividedInteger; // Variable used to calculate number of months for trial.
        protected int currentPatientMonthsTotalInteger;       // Variable used to calculate number of months for trial.

        //Next two variables are "protected," which allows the variable to be inherited to a derived tier. 

        protected int currentPatientTreatmentPlanInteger;     // Variable for result of which of the four trials the patient will take part in.

        protected int currentPatientNumberofTreatmentsInteger; // This number is used in the case select after integer division and randomization to determine number of treatments.
        // See documentation in the CalculateNumberofTreatments method.
        // PROGRAM FOUR NOTE: This variable is NOT used in case select if the processing happens in the DERIVED TIER.

        
        // ********************* RANDOM NUMBERS FOR RECORD PROCESSING ***********************************************************

        Random currentPatientTreatmentPlanRandomNumber = new Random();  // Random number used to determine a treatment plan (1-4) for patient's trial.

       
        Random currentPatientMonthsTotalRandomNumber = new Random();    // Random number used to determine number of months for patient's trial.

                                                                // See documentation in the CalculateNumberofTreatments method.

        Random currentPatientTreatmentsRandomNumber = new Random(); // Random number used to determine number of treatments for patient's trial.

        //                                                  ACCUMULATORS:               // These variables count walk in patients.
                                                                                        // One accumulator for ones processed with the special processing
                                                                                        // check box checked and one when the box is not checked.

        private static int totalWalkInPatientsInteger;

        // b) CONSTRUCTOR
        //                  PARAMETERIZED CONSTRUCTOR:
       public ProcessPatient(int months, bool accumulate)               // 1- accept passed args into 
        {
           MaximumMonths = months;             // 2 - assigns parameters to properties

            ProcessPatientRecord();

            if (accumulate == true)
            {
                AccumulateTotals();
            }
        }

        public ProcessPatient(bool ClearBool)
        {
            ClearTotals();
        }

        // c) PROPERTIES

        public int MaximumMonths                // 1 - For values passed into bus. tier class
        {
            set
            {
                maximumMonthsInt = value;
            }
        }

        public int TreatmentPlan      // get accessor allows form (pres tier) access to this field
        {
            get { return currentPatientTreatmentPlanInteger; }
        }

        public int MonthsTotal      // get accessor allows form (pres tier) access to this field
        {
            get { return currentPatientMonthsTotalInteger; }
        }

        public int TreatmentsTotal      // get accessor allows form (pres tier) access to this field
        {
            get { return currentPatientNumberofTreatmentsInteger; }
        }

        public static int TotalWalkInPatients
        {
            get { return totalWalkInPatientsInteger; }

        }
            
        // D) METHOD/FUNCTIONS/PROCESSING!

        protected virtual void ProcessPatientRecord()
        {
            int loopControlVariableInteger;             // Clock speed on the computer is so fast that I have to insert time wasters by using a loop
                                                        // just to make the computer count as a way to waste time between one random number generation and
                                                        // the next. I experimented with a count to 10,000, which works all right for the patient input
                                                        // but not the file read. So I kept adding zeroes to get the file read random.
                                                        // Apparently ONE MILLION is the magic number. :-) Oi vai!
            int MaximumCountInteger = 1000000;

            // ******************************** TIME WASTER LOOP *******************************

            for (loopControlVariableInteger = 0; loopControlVariableInteger < MaximumCountInteger; loopControlVariableInteger++)
            {
                // Loop for stalling so as to produce different random numbers
            }
            // Determines treatment plan by random number generation.
            // Four plans - random number 1-4.

            currentPatientTreatmentPlanInteger = currentPatientTreatmentPlanRandomNumber.Next(1, 5);        

            // ******************************** TIME WASTER LOOP *******************************

            for (loopControlVariableInteger = 0; loopControlVariableInteger < MaximumCountInteger; loopControlVariableInteger++)
            {
                // Loop for stalling so as to produce different random numbers
            }

            // Detemines actual number of months of treatment
            // based on maximum number of months from input.
            // First a random number generator to create a number of actual months between 1 and the maximum.
            // Then, actual months is divided to create a number used in the case structure
            // to determine the number of treatments.

            currentPatientMonthsTotalInteger = currentPatientMonthsTotalRandomNumber.Next(1, (maximumMonthsInt));

            currentPatientNumberMonthsDividedInteger = currentPatientMonthsTotalInteger / 20;

            // ******************************** TIME WASTER LOOP *******************************

            for (loopControlVariableInteger = 0; loopControlVariableInteger < MaximumCountInteger; loopControlVariableInteger++)
            {
                // Loop for stalling so as to produce different random numbers
            }

            CalculateNumberofTreatments();          // Calls method for determining number of treatments based on actual number of months determined
            // in previous statement.
         
        }

        // ********************* Case structure that determines number of treatments based on 
        // number of months follows.

        protected virtual void AccumulateTotals()
        {
            totalWalkInPatientsInteger++;
        }

        protected virtual void CalculateNumberofTreatments()
        {
            switch (currentPatientNumberMonthsDividedInteger)
            {
                case 0:
                    currentPatientNumberofTreatmentsInteger = currentPatientTreatmentsRandomNumber.Next(9, 31);
                    break;

                case 1:
                    currentPatientNumberofTreatmentsInteger = currentPatientTreatmentsRandomNumber.Next(31, 71);
                    break;

                case 2:
                    currentPatientNumberofTreatmentsInteger = currentPatientTreatmentsRandomNumber.Next(71, 106);
                    break;

                case 3:
                    currentPatientNumberofTreatmentsInteger = currentPatientTreatmentsRandomNumber.Next(106, 141);
                    break;

                case 4:
                    currentPatientNumberofTreatmentsInteger = currentPatientTreatmentsRandomNumber.Next(141, 180);
                    break;
            }
        }

        private void ClearTotals()
        {
            totalWalkInPatientsInteger = 0;
        }

    }
}
