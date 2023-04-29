using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate.BusinessLogic
{
    public class CertificationDetailsService
    {
        /// <summary>
        /// Method that reads Candidate  Certification details from  Console screen
        /// </summary>
        public CertificationDetails ReadCertificationDetails()
        {
            CertificationDetails certificationDetails = new CertificationDetails();
            StringBuilder validations = new StringBuilder();
            try
            {
                Console.WriteLine();
                Console.WriteLine("Provide Candidate Certification Details:\n");
                Console.Write("Enter Certification Name :");
                string certificationName = Console.ReadLine();

                if (!string.IsNullOrEmpty(certificationName))
                    certificationDetails.CertificationName = certificationName;
                else
                    validations.Append("Candidate Certification Name is missing.\n");

                Console.Write("Enter Certification Completion Id :");
                string cCompletionId = Console.ReadLine();

                if (!string.IsNullOrEmpty(cCompletionId))
                    certificationDetails.CertificationCompletionId = cCompletionId;
                else
                    validations.Append("Candidate Certification Completion Id is missing.\n");

                Console.Write("Enter Certification URL :");
                string certificationURL = Console.ReadLine();

                if (!string.IsNullOrEmpty(certificationURL))
                    certificationDetails.CertificationURL = certificationURL;
                else
                    validations.Append("Candidate Certification URL is missing.\n");

                Console.Write("Enter Certification Validity From Year :");
                string cValidityFromYear = Console.ReadLine();

                if (!string.IsNullOrEmpty(cValidityFromYear))
                    certificationDetails.CertificationValidityFromYear = cValidityFromYear;
                else
                    validations.Append("Candidate Certification Validity From Year is missing.\n");


                Console.Write("Enter Certification Validity From Month :");
                string cValidityFromMonth = Console.ReadLine();

                if (!string.IsNullOrEmpty(cValidityFromMonth))
                    certificationDetails.CertificationValidityFromMonth = cValidityFromMonth;
                else
                    validations.Append("Candidate Certification Validity From Month is missing.\n");

                Console.Write("Enter Certification Validity End Year :");
                string cValidityEndYear = Console.ReadLine();

                if (!string.IsNullOrEmpty(cValidityEndYear))
                    certificationDetails.CertificationValidityEndYear = cValidityEndYear;
                else
                    validations.Append("Candidate Certification Validity End Year is missing.\n");


                Console.Write("Enter Certification Validity End Month :");
                string cValidityEndMonth = Console.ReadLine();

                if (!string.IsNullOrEmpty(cValidityEndMonth))
                    certificationDetails.CertificationValidityEndMonth = cValidityEndMonth;
                else
                    validations.Append("Candidate Certification Validity End Month is missing.\n");
                Console.WriteLine();
                Console.WriteLine("Different values for Certification Expires :");
                List<string> certificationExpiresList = new List<string>();
                certificationExpiresList.Add(Constants.Constants.YES);
                certificationExpiresList.Add(Constants.Constants.NO);

                //Print Certification Expires List
                Utility.Utility.PrintListValues(certificationExpiresList);

                Console.Write("Select value for Certification Expires(EX: 1 for Yes): ");
                int cExpiresOutput = 0;
                bool isCertificationExpires = int.TryParse(Console.ReadLine(), out cExpiresOutput);
                string certificationExpires = string.Empty;

                if(isCertificationExpires)
                {
                    switch(cExpiresOutput)
                    {
                        case (int)Enums.CertificationExpires.Yes:
                            certificationExpires = Constants.Constants.YES;
                            break;
                            case (int)Enums.CertificationExpires.No:
                            certificationExpires = Constants.Constants.NO;
                            break;
                            default:
                            validations.Append("Unknown value for Certification Expires is selected.\n");
                            break;
                    }
                   certificationDetails.CertificationExpires = certificationExpires;
                }

                //Validations Errors  Displayed here
                if (!string.IsNullOrEmpty(validations.ToString()))
                {
                    Console.WriteLine($"\n\nValidation Errors:\n{validations}");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
                Console.WriteLine();
                Console.WriteLine("Exception Trace: {0}", ex.StackTrace);
            }
            return certificationDetails;
        }

        /// <summary>
        /// Method that  writes/prints Candidate Certification details to the Console Screen
        /// </summary>
        public void PrintCertificationDetails(CertificationDetails certificationDetails)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Certification Details :");
                Console.WriteLine($"Certification Name : {certificationDetails.CertificationName}");
                Console.WriteLine($"Certification Completion Id : {certificationDetails.CertificationCompletionId}");
                Console.WriteLine($"Certification URL : {certificationDetails.CertificationURL}");
                Console.WriteLine($"Certification Validity From Year : {certificationDetails.CertificationValidityFromYear}");  
                Console.WriteLine($"Certification Validity From Month : {certificationDetails.CertificationValidityFromMonth}");
                Console.WriteLine($"Certification Validity End Year : {certificationDetails.CertificationValidityEndYear}");
                Console.WriteLine($"Certification Validity End Month : {certificationDetails.CertificationValidityEndMonth}");
                Console.WriteLine($"Certification Expires : {certificationDetails.CertificationExpires}");

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
