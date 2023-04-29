using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate.BusinessLogic
{
    public class EducationDoctorateService
    {
        /// <summary>
        /// Method that reads Candidate Doctorate Education details from  Console screen
        /// </summary>
        public void ReadEducationDoctorateDetails()
        {
            EducationDoctorate educationDoctorate = new EducationDoctorate();
            StringBuilder validations = new StringBuilder();
            try
            {
                Console.WriteLine();
                Console.WriteLine("Provide Candidate Doctorate Education Details:\n");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
                Console.WriteLine();
                Console.WriteLine("Exception Trace: {0}", ex.StackTrace);
            }
        }

        public void PrintEducationDoctorateDetails()
        {
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
                Console.WriteLine();
                Console.WriteLine("Exception Trace: {0}", ex.StackTrace);
            }
        }
    }
}
