using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate.BusinessLogic
{
    public class ResearchPublicationDetailsService
    {
        /// <summary>
        /// Method that reads Candidate  Research Publication details from  Console screen
        /// </summary>
        public ResearchPublicationDetails ReadResearchPublicationDetails()
        {
            ResearchPublicationDetails researchPublication = new ResearchPublicationDetails();
            StringBuilder validations = new StringBuilder();
            try
            {
                Console.WriteLine();
                Console.WriteLine("Provide Candidate  Reasearch Publication Details:\n");
                Console.Write("Enter the Research Title :");
                string researchTitle = Console.ReadLine();

                if (!string.IsNullOrEmpty(researchTitle))
                    researchPublication.ResearchTitle = researchTitle;
                else
                    validations.Append("Candidate Research Title is missing.\n");

                Console.Write("Enter the Research URL :");
                string researchURL = Console.ReadLine();

                if(!string.IsNullOrEmpty(researchURL))
                    researchPublication.ResearchURL = researchURL;
                else              
                    validations.Append("Candidate Research URL is missing.\n");

                Console.Write("Enter Research Publication Year :");
                string publicationYear = Console.ReadLine();

                if (!string.IsNullOrEmpty(publicationYear))
                    researchPublication.ResearchPublicationYear = publicationYear;
                else
                    validations.Append("Candidate Research Publication Year is missing.\n");

                Console.Write("Enter Research Publication Month :");
                string publicationMonth = Console.ReadLine();

                if (!string.IsNullOrEmpty(publicationMonth))
                    researchPublication.ResearchPublicationMonth = publicationMonth;
                else
                    validations.Append("Research Publication Month is missing.\n");

                Console.Write("Enter Research Description :");
                string researchDescription = Console.ReadLine();

                if (!string.IsNullOrEmpty(researchDescription))
                    researchPublication.ResearchDescription = researchDescription;
                else
                    validations.Append("Candidate Research Description is missing.\n");


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
            return researchPublication;
        }

        /// <summary>
        /// Method that  writes/prints Candidate Research Publication details to the Console Screen
        /// </summary>
        /// <param name="details"></param>
        public void PrintResearchPublicationDetails(ResearchPublicationDetails details)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Research Publication Details :");
                Console.WriteLine($"Research Title : {details.ResearchTitle}");
                Console.WriteLine($"Research URL : {details.ResearchURL}");
                Console.WriteLine($"Research Publication Year : {details.ResearchPublicationYear}");
                Console.WriteLine($"Research Publication Month : {details.ResearchPublicationMonth}");
                Console.WriteLine($"Research Description : {details.ResearchDescription}");

            }
            catch( Exception ex )
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
                Console.WriteLine();
                Console.WriteLine("Exception Trace: {0}", ex.StackTrace);
            }
        }
    }
}
