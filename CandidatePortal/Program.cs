using Candidate.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Candidate;

namespace CandidatePortal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("\t\t\t\t\t\t\tWelcome to Candidate Portal \n");

                //Read Candidate Details

                //  PersonalDetailsService personalDetails = new PersonalDetailsService();
                ////Read Candidate Personal Details
                // PersonalDetails pDetailsUserInput = personalDetails.ReadPersonalDetails();

                ////Read Candidate Contact Details
                //ContactDetailsService contactDetailsService = new ContactDetailsService();
                //ContactDetails contactDetails = contactDetailsService.ReadContactDetails();


                //LanguagesService languagesService = new LanguagesService();
                //List<Language> languages = languagesService.ReadLanguages();
                //languagesService.PrintLanguages(languages);

                ////Read Candidate Document Details
                //   DocumentDetailsService documentDetailsService = new DocumentDetailsService();
                //   DocumentDetails dDetailsUserInput = documentDetailsService.ReadDocumentDetails();

                ////Read Candidate Address Details
                //   AddressDetailsService addressDetailsService = new AddressDetailsService();
                //   AddressDetails aDetailsUserInput =  addressDetailsService.ReadAddressDetails();

                ////Read Candidate Career Profile Details
                //   CareerProfileService careerProfileService = new CareerProfileService();
                //   CareerProfile careerProfileInput = careerProfileService.ReadCareerProfileDetails();

                ////Read Candidate Profile Details
                //ProfileDetailsService profileDetailsServise = new ProfileDetailsService();
                //ProfileDetails profileDetailsInput = profileDetailsServise.ReadProfileDetails();



                //AccomplishmentsService accomplishmentsService = new AccomplishmentsService();
                //Accomplishments accomplishments = accomplishmentsService.ReadAccomplishments();
                //accomplishmentsService.PrintAccomplishments(accomplishments);


                //ProjectDetailsService projectDetailsService = new ProjectDetailsService();
                //ProjectDetails projectDetails = projectDetailsService.ReadProjectDetails();
                //projectDetailsService.PrintProjectDetails(projectDetails);

                KeySkillsService keySkillsService = new KeySkillsService();
                List<Skill> skills = keySkillsService.ReadKeySkills();
                keySkillsService.PrintKeySkills(skills);




                //Print Candidate Details


                ////Print Candidate Personal Details
                //     personalDetails.PrintPersonalDetails(pDetailsUserInput);

                ////Print Candidate Contact Details
                //contactDetailsService.PrintContactDetails(contactDetails);

                ////Print Candidate Document Details
                
              //  documentDetailsService.PrintDocumentDetails(dDetailsUserInput);

                ////Print Candidate Address Details
                // addressDetailsService.PrintAddressDetails(aDetailsUserInput);

                ////Print Candidate Career Profile Details
                //  careerProfileService.PrintCareerProfileDetails(careerProfileInput);

                ////Print Candidate Profile Details
                //profileDetailsServise.PrintProfileDetails(profileDetailsInput);


               








                Console.ReadLine();

            }
            catch (Exception ex)//Handles General Exceptions - Any type of Exception
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
                Console.WriteLine();
                Console.WriteLine("Exception Trace: {0}", ex.StackTrace);




            }
        }
    }
}
