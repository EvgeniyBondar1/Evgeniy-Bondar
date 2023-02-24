using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    public class Patient
    {
        public Patient(int numberPlanTreatment)
        {
            if (numberPlanTreatment == 1)
            {
                Surgeon surgeon = new Surgeon();
                surgeon.Treat();
            }
            else if (numberPlanTreatment == 2)
            {
                Dentist dentist = new Dentist();
                dentist.Treat();
            }
            else 
            {
                Therapist therapist = new Therapist();
                therapist.Treat();
            }
        }
    }
}
