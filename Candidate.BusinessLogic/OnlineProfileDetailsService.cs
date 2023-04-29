using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate.BusinessLogic
{
    public class OnlineProfileDetailsService
    {
        /// <summary>
        /// Method that reads Candidate  Online Profile details from  Console screen
        /// </summary>
        public OnlineProfileDetails ReadOnlineProfileDetails()
        {
            OnlineProfileDetails onlineProfileDetails = new OnlineProfileDetails();
            StringBuilder validations = new StringBuilder();
            try
            {
                Console.WriteLine();
                Console.WriteLine("Provide Candidate  Online/Social Profile Details:\n");
                Console.WriteLine("Different Values for Social Profile :");
                List<string> socialProfileList = new List<string>();
                socialProfileList.Add(Constants.SocialProfileConstants.FACEBOOK);
                socialProfileList.Add(Constants.SocialProfileConstants.LINKEDIN);

                //Print Social Profile List
                Utility.Utility.PrintListValues(socialProfileList);

                Console.Write("Select value for Social Profile(EX: 1 for Facebook): ");
                int socialProfileOutput = 0;
                bool isSocialProfile = int.TryParse(Console.ReadLine(), out socialProfileOutput);
                string socialProfile = string.Empty;

                if (isSocialProfile)
                {
                    switch (socialProfileOutput)
                    {
                        case (int)Enums.SocialProfile.Facebook:
                            socialProfile = Constants.SocialProfileConstants.FACEBOOK;
                            break;
                        case (int)Enums.SocialProfile.LinkedIn:
                            socialProfile = Constants.SocialProfileConstants.LINKEDIN;
                            break;
                        default:
                            validations.Append("Unknown value for Social Profile is Selected.\n");
                            break;
                    }
                    onlineProfileDetails.SocialProfile = socialProfile;
                }
                else
                    validations.Append("Please enter integer value for Social Profile(EX: 1 for Facebook)\n");
                Console.WriteLine();
                Console.Write("Enter Social Profile URL :");
                string socialProfileURL = Console.ReadLine();

                if (!string.IsNullOrEmpty(socialProfileURL))
                    onlineProfileDetails.SocialProfileURL = socialProfileURL;
                else
                    validations.Append("Candidate Social Profile URL is missing.\n");

                Console.Write("Enter Social Profile Description :");
                string socialProfileDescription = Console.ReadLine();

                if (!string.IsNullOrEmpty(socialProfileDescription))
                    onlineProfileDetails.SocialProfileDescription = socialProfileDescription;
                else
                    validations.Append("Candidate Social Profile Description is missing.\n");


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
            return onlineProfileDetails;
        }


        /// <summary>
        /// Method that  writes/prints Candidate Online/Social Profile details to the Console Screen
        /// </summary>
        public void PrintOnlineProfileDetails(OnlineProfileDetails details)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Online Profile Details :");
                Console.WriteLine($"Social Profile : {details.SocialProfile}");
                Console.WriteLine($"Social Profile URL : {details.SocialProfileURL}");
                Console.WriteLine($"Social Profile Description : {details.SocialProfileDescription}");
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
