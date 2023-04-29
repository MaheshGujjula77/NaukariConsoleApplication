using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate.BusinessLogic
{
    public class ProfileDetailsService
    {
        /// <summary>
        /// Method that reads Candidate  Profile details from  Console screen
        /// </summary>
        public ProfileDetails ReadProfileDetails()
        {
            ProfileDetails profileDetails = new ProfileDetails();
            StringBuilder validations = new StringBuilder();
            try
            {
                Console.WriteLine();
                Console.WriteLine("Provide Candidate  Profile Details:\n");
                Console.Write("Enter the Profile Summary :");
                string profileSummary = Console.ReadLine();

                if (!string.IsNullOrEmpty(profileSummary))
                    profileDetails.ProfileSummary = profileSummary;
                else
                    validations.Append("Candidate Profile Summary is missing.\n");

                Console.Write("Enter the Resume HeadLine :");
                string resumeHeadLine = Console.ReadLine();

                if (!string.IsNullOrEmpty(resumeHeadLine))
                    profileDetails.ResumeHeadLine = resumeHeadLine;
                else
                    validations.Append("Candidate Resume HeadLine is missing.\n");


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
            return profileDetails;
        }

        /// <summary>
        /// Method that  writes/prints Candidate  Profile details to the Console Screen
        /// </summary>
        public void PrintProfileDetails(ProfileDetails details)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Profile Details :");
                Console.WriteLine($"Profile Summary : {details.ProfileSummary}");
                Console.WriteLine($"Resume HeadLine : {details.ResumeHeadLine}");
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
