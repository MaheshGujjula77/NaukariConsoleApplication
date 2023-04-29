using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate.BusinessLogic
{
    public class PresentationDetailsService
    {
        /// <summary>
        /// Method that reads Candidate Presentation details from  Console screen
        /// </summary>
        public PresentationDetails ReadPresentationDetails()
        {
            PresentationDetails presentationDetails = new PresentationDetails();
            StringBuilder validations = new StringBuilder();
            try
            {
                Console.WriteLine();
                Console.WriteLine("Provide Candidate Presentation Details:\n");
                Console.Write("Enter Presentation Title : ");
                string presentationTitle = Console.ReadLine();

                if (!string.IsNullOrEmpty(presentationTitle))
                    presentationDetails.PresentationTitle = presentationTitle;
                else
                    validations.Append("Candidate Presentation Title is missing.\n");

                Console.Write("Enter Presentation URL :");
                string presentationURL = Console.ReadLine();

                if (!string.IsNullOrEmpty(presentationURL))
                    presentationDetails.PresentationURL = presentationURL;
                else
                    validations.Append("Candidate Presentation URL is missing.\n");

                Console.Write("Enter Presentation Description :");
                string pDescription = Console.ReadLine();

                if (!string.IsNullOrEmpty(pDescription))
                    presentationDetails.PresentationDescription = pDescription;
                else
                    validations.Append("Candidate Presentation Description is missing.\n");


                //Validations Errors  Displayed here
                if (!string.IsNullOrEmpty(validations.ToString()))
                {
                    Console.WriteLine($"\n\nValidation Errors:\n{validations}");
                }


            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
                Console.WriteLine();
                Console.WriteLine("Exception Trace: {0}", ex.StackTrace);
            }
            return presentationDetails;
        }

        /// <summary>
        /// Method that  writes/prints Candidate Presentation details to the Console Screen
        /// </summary>
        /// <param name="presentationDetails"></param>
        public void PrintPresentationDetails(PresentationDetails presentationDetails)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Presentation Details :");
                Console.WriteLine($"Presentation Title : {presentationDetails.PresentationTitle}");
                Console.WriteLine($"Presentation URL : {presentationDetails.PresentationURL}");
                Console.WriteLine($"Presentation Description : {presentationDetails.PresentationDescription}");

            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
                Console.WriteLine();
                Console.WriteLine("Exception Trace: {0}", ex.StackTrace);
            }
        }
    }
}
