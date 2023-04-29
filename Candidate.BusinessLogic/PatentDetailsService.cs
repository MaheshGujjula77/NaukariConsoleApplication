using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate.BusinessLogic
{
    public class PatentDetailsService
    {
        /// <summary>
        /// Method that reads Candidate  Patent details from  Console screen
        /// </summary>
        public PatentDetails ReadPatentDetails()
        {
            PatentDetails patentDetails = new PatentDetails();
            StringBuilder validations = new StringBuilder();
            try
            {
                Console.WriteLine();
                Console.WriteLine("Provide Candidate Patent Details:\n");
                Console.Write("Enter Patent Title :");
                string patentTitle = Console.ReadLine();

                if (!string.IsNullOrEmpty(patentTitle))
                    patentDetails.PatentTitle = patentTitle;
                else
                    validations.Append("Candidate Patent Title is missing.\n");

                Console.Write("Enter Patent URL :");
                string patentURL = Console.ReadLine();

                if (!string.IsNullOrEmpty(patentURL))
                    patentDetails.PatentURL = patentURL;
                else
                    validations.Append("Candidate Patent URL is missing.\n");

                Console.Write("Enter Patent Office :");
                string patentOffice = Console.ReadLine();

                if (!string.IsNullOrEmpty(patentOffice))
                    patentDetails.PatentOffice = patentOffice;
                else
                    validations.Append("Candidate Patent Office is missing.\n");
                Console.WriteLine();
                Console.WriteLine("Different Values for Patent Status :");
                List<string> patentStatusList = new List<string>();
                patentStatusList.Add(Constants.Constants.PATENT_ISSUED);
                patentStatusList.Add(Constants.Constants.PATENT_PENDING);

                //Print Patent Status List
                Utility.Utility.PrintListValues(patentStatusList);

                Console.Write("Select value for Patent Status(EX: 1 for Patent Issued): ");
                int patentStatusOutput = 0;
                bool isPatentStatus = int.TryParse(Console.ReadLine(), out patentStatusOutput);
                string patentStatus = string.Empty;

                if (isPatentStatus)
                {
                    switch (patentStatusOutput)
                    {
                        case (int)Enums.PatentStatus.Patent_Issued:
                            patentStatus = Constants.Constants.PATENT_ISSUED;
                            break;
                        case (int)Enums.PatentStatus.Patent_Pending:
                            patentStatus = Constants.Constants.PATENT_PENDING;
                            break;
                        default:
                            validations.Append("Unknown value for Patent Status is selected.\n");
                            break;
                    }
                    patentDetails.PatentStatus = patentStatus;
                }
                else
                    validations.Append("Please enter integer value for Patent Status(Ex: 1 for Patent Status)\n");
                Console.WriteLine();
                Console.Write("Enter Patent Application Number :");
                string pApplicationNumber = Console.ReadLine();

                if (!string.IsNullOrEmpty(pApplicationNumber))
                    patentDetails.PatentApplicationNumber = pApplicationNumber;
                else
                    validations.Append("Candidate Patent Application Number is missing.\n");

                Console.Write("Enter Patent Issued Year :");
                string patentIssuedYear = Console.ReadLine();

                if (!string.IsNullOrEmpty(patentIssuedYear))
                    patentDetails.PatentIssueDateYear = patentIssuedYear;
                else
                    validations.Append("Candidate Patent Issued Year is missing.\n");

                Console.Write("Enter Patent Issued Month :");
                string patentIssuedMonth = Console.ReadLine();

                if (!string.IsNullOrEmpty(patentIssuedMonth))
                    patentDetails.PatentIssueDateMonth = patentIssuedMonth;
                else
                    validations.Append("Candidate Patent Issued Month is missing.\n");

                Console.Write("Enter Patent Description :");
                string patentDescription = Console.ReadLine();

                if (!string.IsNullOrEmpty(patentDescription))
                    patentDetails.PatentDescription = patentDescription;
                else
                    validations.Append("Candidate Patent Description is missing.\n");

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
            return patentDetails;
        }

        /// <summary>
        /// Method that  writes/prints Candidate Patent details to the Console Screen
        /// </summary>
        public void PrintPatentDetails(PatentDetails patentDetails)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Patent Details :");
                Console.WriteLine($"Patent Title : {patentDetails.PatentTitle}");
                Console.WriteLine($"Patent URL : {patentDetails.PatentURL}");
                Console.WriteLine($"Patent Office : {patentDetails.PatentOffice}");
                Console.WriteLine($"Patent Status : {patentDetails.PatentStatus}");
                Console.WriteLine($"Patent Application Number : {patentDetails.PatentApplicationNumber}");
                Console.WriteLine($"Patent Issued Year : {patentDetails.PatentIssueDateYear}");
                Console.WriteLine($"Patent Issued Month : {patentDetails.PatentIssueDateMonth}");
                Console.WriteLine($"Patent Description : {patentDetails.PatentDescription}");

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
