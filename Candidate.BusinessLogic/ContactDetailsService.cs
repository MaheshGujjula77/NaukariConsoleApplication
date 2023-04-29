using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate.BusinessLogic
{
    public class ContactDetailsService
    {
        /// <summary>
        /// Method that reads Candidate contact details from  Console screen
        /// </summary>
        /// <returns></returns>
        public ContactDetails ReadContactDetails()
        {
            ContactDetails contactDetails = new ContactDetails();
            StringBuilder validations = new StringBuilder();
            try
            {
                Console.WriteLine("Provide Candidate Contact Details:\n");
                Console.Write("Enter Primary Phone Number :");
                string phoneNumber = Console.ReadLine();

                if (!string.IsNullOrEmpty(phoneNumber))
                    contactDetails.PrimaryPhoneNumber = phoneNumber;
                else
                    validations.Append("Candidate Primary Phone Number is missing.\n");

                Console.Write("Enter Secondary Phone Number :");
                string secondaryPhoneNumber = Console.ReadLine();

                if (!string.IsNullOrEmpty(secondaryPhoneNumber))
                    contactDetails.SecondaryPhoneNumber = secondaryPhoneNumber;
                else
                    validations.Append("Candidate Secondary Phone Number is Missing.\n");

                Console.Write("Enter Primary Email Address :");
                string primaryEmailAddress = Console.ReadLine();

                if (!string.IsNullOrEmpty(primaryEmailAddress))
                    contactDetails.PrimaryEmailAddress = primaryEmailAddress;
                else
                    validations.Append("Candidate Primary Email Address is missing.\n");

                Console.Write("Enter Secondary Email Address :");
                string secondaryEmailAddress = Console.ReadLine();

                if (!string.IsNullOrEmpty(secondaryEmailAddress))
                    contactDetails.SecondaryEmailAddress = secondaryEmailAddress;
                else
                    validations.Append("Candidate Secondary Email Address is missing.\n");


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
            return contactDetails;
        }

        /// <summary>
        /// Method that writes/prints Candidate Contact details to the Console Screen
        /// </summary>
        public void PrintContactDetails(ContactDetails details)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Contact Details :");

                Console.WriteLine($"Primary Phone Number : {details.PrimaryPhoneNumber}");
                Console.WriteLine($"Secondary Phone Number : {details.SecondaryPhoneNumber}");
                Console.WriteLine($"Primary Email Address : {details.PrimaryEmailAddress}");
                Console.WriteLine($"Secondary Email Address : {details.SecondaryPhoneNumber}");

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
