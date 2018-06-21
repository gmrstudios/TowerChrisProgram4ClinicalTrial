// Chris Tower for April 16, 2014 // SUBMITTED April 21st, 2014 - first and only free pass late submission
// Started date - April 7th, 2014
// Program #4 - MEDICAL CLINICAL TRIAL PROGRAM - VERSION TWO
// SEE MAIN DOCUMENTATION IN MAIN PROGRAM CODE TAB.

// This DERIVED TIER "SpecialProcessPatient" inherits from the business tier "ProcessPatient" and is used to complete the 
// special processing for when the check box is checked as explained in the original main documentation.

// Special accumulations are completed and cleared here as well.
// Though this tier overrides the processing business tier, it works much the same.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TowerChrisProgram3ClinicalTrial
{
    class SpecialProcessPatient : ProcessPatient        // Defines this as an inherited class from main "business tier" class.
                                                        // Establishes name of base business class and dderived tier class
    {
        private static int totalSpecialWalkInPatientsInteger;

        Random currentPatientTreatmentPlanRandomNumber = new Random();  // special Random number for her used to determine a treatment plan (3-4) for patient's trial.
        Random currentPatientTreatmentsRandomNumber = new Random(); // Random number used to determine number of treatments for patient's trial.
        Random currentPatientMonthsTotalRandomNumber = new Random();    // Random number used to determine number of months for patient's trial.

        // CONSTRUCTOR:                 // same value is passed through constructor as in business tier ProcessPatient class.

        public SpecialProcessPatient(int months, bool accumulate) : base(months, accumulate)
        {
            if (accumulate == true)
            {
                totalSpecialWalkInPatientsInteger++; 
            }
        }

        public SpecialProcessPatient(bool ClearBool): base(ClearBool)
        {
            ClearTotals();
        }

        protected override void ProcessPatientRecord()
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
            // Special processing if check box is checked. Treatment plan is only #3(New Drug) or #4(Placebo).
            // If check box is checked, special processing makes case structure irrelevant and number of treatments is a random 
            // number between 5 and 10 and thus the fancy case structure is not needed.

            currentPatientTreatmentPlanInteger = currentPatientTreatmentPlanRandomNumber.Next(3, 5);

            currentPatientNumberofTreatmentsInteger = currentPatientTreatmentsRandomNumber.Next(5, 11);
            
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
        }
       
        public static int totalSpecialWalkInPatients
        {
            get { return totalSpecialWalkInPatientsInteger; }
        }

        private void ClearTotals()
        {
            totalSpecialWalkInPatientsInteger = 0;
        }
    }
}
