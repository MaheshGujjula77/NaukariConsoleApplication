using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate.BusinessLogic
{
    public class DocumentDetailsService
    {
        /// <summary>
        /// Method that reads Candidate Document details from  Console screen
        /// </summary>
        /// <returns></returns>
        public DocumentDetails ReadDocumentDetails()
        {
            DocumentDetails documentDetails = new DocumentDetails();
            StringBuilder validations = new StringBuilder();
            try
            {
                Console.WriteLine("Provide Candidate Document Details:\n");
                Console.Write("Enter Aadhar Number :");
                string aadharNumber = Console.ReadLine();

                if (!string.IsNullOrEmpty(aadharNumber))
                    documentDetails.AadharNumber = aadharNumber;
                else
                    validations.Append("Candidate Aadhar Number is missing.\n");

                Console.Write("Enter PAN Number :");
                string panNumber = Console.ReadLine();

                if (!string.IsNullOrEmpty(panNumber))
                    documentDetails.PANNumber = panNumber;
                else
                    validations.Append("Candidate PAN Number is missing.\n");

                Console.Write("Enter Driving License :");
                string drivingLicense = Console.ReadLine();

                if (!string.IsNullOrEmpty(drivingLicense))
                    documentDetails.DrivingLicense = drivingLicense;
                else
                    validations.Append("Candidate Driving License is missing.\n");

                Console.Write("Enter Voter Card :");
                string voterCard = Console.ReadLine();

                if (!string.IsNullOrEmpty(voterCard))
                    documentDetails.VoterCard = voterCard;
                else
                    validations.Append("Candidate Voter Card is missing.\n");

                Console.Write("Enter Passport Number :");
                string passportNumber = Console.ReadLine();

                if (!string.IsNullOrEmpty(passportNumber))
                    documentDetails.PassportNumber = passportNumber;
                else
                    validations.Append("Candidate Passport Number is missing.\n");


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
            return documentDetails;
        }

        /// <summary>
        /// Method that  writes/prints Candidate Document details to the Console Screen
        /// </summary>
        public void PrintDocumentDetails(DocumentDetails details)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Document Details :");
                Console.WriteLine($"Aadhar Number : {details.AadharNumber}");
                Console.WriteLine($"PAN Number : {details.PANNumber}");
                Console.WriteLine($"Driving License : {details.DrivingLicense}");
                Console.WriteLine($"Voter Card : {details.VoterCard}");
                Console.WriteLine($"Passport NUmber : {details.PassportNumber}");
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
