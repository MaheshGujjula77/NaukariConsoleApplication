using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate.BusinessLogic
{
    public class WorkSampleDetailsService
    {
        /// <summary>
        /// Method that reads Candidate Work Sample details from  Console screen
        /// </summary>
        public WorkSampleDetails ReadWorkSampleDetails()
        {
            WorkSampleDetails workSampleDetails = new WorkSampleDetails();
            StringBuilder validations = new StringBuilder();
            try
            {
                Console.WriteLine();
                Console.WriteLine("Provide Candidate Work Sample Details:\n");
                Console.Write("Enter Work Title :");
                string workTitle = Console.ReadLine();

                if (!string.IsNullOrEmpty(workTitle))
                    workSampleDetails.WorkTitle = workTitle;
                else
                    validations.Append("Candidate Work Title is missing.\n");

                Console.Write("Enter Work Title URL :");
                string wTitleURL = Console.ReadLine();

                if (!string.IsNullOrEmpty(wTitleURL))
                    workSampleDetails.WorkTitleURL = wTitleURL;
                else
                    validations.Append("Candidate Work Title URL is missing.\n");

                Console.Write("Enter Work Title From Year :");
                string wTitleFromYear = Console.ReadLine();

                if (!string.IsNullOrEmpty(wTitleFromYear))
                    workSampleDetails.WorkTitleFromYear = wTitleFromYear;
                else
                    validations.Append("Candidate Work Title From Year is missing.\n");

                Console.Write("Enter Work Title From Month :");
                string wTitleFromMonth = Console.ReadLine();

                if (!string.IsNullOrEmpty(wTitleFromMonth))
                    workSampleDetails.WorkTitleFromMonth = wTitleFromMonth;
                else
                    validations.Append("Candidate Work Title From Month is missing.\n");

                Console.Write("Enter Work Title To Year :");
                string wTitleToYear = Console.ReadLine();

                if (!string.IsNullOrEmpty(wTitleToYear))
                    workSampleDetails.WorkTitleToYear = wTitleToYear;
                else
                    validations.Append("Candidate Work Title To Month is missing.\n");

                Console.Write("Enter Work Title To Month :");
                string wTitleToMonth = Console.ReadLine();

                if (!string.IsNullOrEmpty(wTitleToMonth))
                    workSampleDetails.WorkTitleToMonth = wTitleToMonth;
                else
                    validations.Append("Candidate Work Title To Month is missing.\n");
                Console.WriteLine();
                Console.WriteLine("Different values for Currently Working :");
                List<string> cWorkingList = new List<string>();
                cWorkingList.Add(Constants.Constants.YES);
                cWorkingList.Add(Constants.Constants.NO);

                //Print Currently working List
                Utility.Utility.PrintListValues(cWorkingList);

                Console.Write("Select value for Work Title Currently Working(EX: 1 for Yes): ");
                int cWorkingOutput = 0;
                bool isCurrentlyWorking = int.TryParse(Console.ReadLine(), out cWorkingOutput);
                string wTCurrentlyWorking = string.Empty;

                if (isCurrentlyWorking)
                {
                    switch (cWorkingOutput)
                    {
                        case (int)Enums.WorkSample.Yes:
                            wTCurrentlyWorking = Constants.Constants.YES;
                            break;
                        case (int)Enums.WorkSample.No:
                            wTCurrentlyWorking = Constants.Constants.NO;
                            break;
                        default:
                            validations.Append("Unknown value for Currently Working is selected.\n");
                            break;
                    }

                    workSampleDetails.WorkTitleCurrentlyWorking = wTCurrentlyWorking;
                }
                else
                    validations.Append("Please select integer value for Work Title Currently Working(EX: 1 for Yes)\n");
                Console.WriteLine();

                Console.Write("Enter Work Title Description :");
                string wTitleDescription = Console.ReadLine();

                if (!string.IsNullOrEmpty(wTitleDescription))
                    workSampleDetails.WorkTitleDescription = wTitleDescription;
                else
                    validations.Append("Candidate Work Title Description is missing.\n");

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
            return workSampleDetails;
        }

        /// <summary>
        /// Method that  writes/prints Candidate Work Sample details to the Console Screen
        /// </summary>
        /// <param name="workSampleDetails"></param>
        public void PrintWorkSampleDetails(WorkSampleDetails workSampleDetails)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Work Sample Details :");
                Console.WriteLine($"Work Title : {workSampleDetails.WorkTitle}");
                Console.WriteLine($"Work Title URL : {workSampleDetails.WorkTitleURL}");
                Console.WriteLine($"Work  Title From Year :{workSampleDetails.WorkTitleFromYear}");
                Console.WriteLine($"Work  Title From Month :{workSampleDetails.WorkTitleFromMonth}");
                Console.WriteLine($"Work  Title To Year :{workSampleDetails.WorkTitleToYear}");
                Console.WriteLine($"Work  Title to Month :{workSampleDetails.WorkTitleToMonth}");
                Console.WriteLine($"Work Title Currently Working: {workSampleDetails.WorkTitleCurrentlyWorking}");
                Console.WriteLine($"Work Title Description : {workSampleDetails.WorkTitleDescription}");

            }
            catch ( Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
                Console.WriteLine();
                Console.WriteLine("Exception Trace: {0}", ex.StackTrace);
            }
        }
    }
}
