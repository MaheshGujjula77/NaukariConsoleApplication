using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate.BusinessLogic
{
    public class CareerProfileService
    {
        /// <summary>
        /// Method that reads Candidate Career Profile details from  Console screen
        /// </summary>
        public CareerProfile ReadCareerProfileDetails()
        {
            CareerProfile careerProfileDetails = new CareerProfile();
            StringBuilder validations = new StringBuilder();
            try
            {
                Console.WriteLine();
                Console.WriteLine("Provide Candidate Career Profile Details:\n");
                Console.WriteLine("Different values for Current Industry :");
                List<String> currentIndustryList = new List<String>();
                currentIndustryList.Add(Constants.CIndustryConstants.HARDWARE_NETWORKING);
                currentIndustryList.Add(Constants.CIndustryConstants.E_COMMERCE);
                currentIndustryList.Add(Constants.CIndustryConstants.BANKING);
                currentIndustryList.Add(Constants.CIndustryConstants.INSURANCE);
                currentIndustryList.Add(Constants.CIndustryConstants.AGRICULTURE);
                currentIndustryList.Add(Constants.CIndustryConstants.CREDIT_BUREAU);
                currentIndustryList.Add(Constants.CIndustryConstants.E_LEARNING);
                currentIndustryList.Add(Constants.CIndustryConstants.INFORMATION_TECHNOLOGY);

                //Print Career Profile List
                Utility.Utility.PrintListValues(currentIndustryList);

                Console.Write("Select value for Current Industry(Ex: 3 for Banking): ");
                int cIndustryOutput = 0;
                bool isCurrentIndustry = int.TryParse(Console.ReadLine(), out cIndustryOutput);
                string currentIndustry = string.Empty;

                if (isCurrentIndustry)
                {
                    switch (cIndustryOutput)
                    {
                        case (int)Enums.CurrentIndustry.Hardware_Networking:
                            currentIndustry = Constants.CIndustryConstants.HARDWARE_NETWORKING;
                            break;
                        case (int)Enums.CurrentIndustry.E_Commerce:
                            currentIndustry = Constants.CIndustryConstants.E_COMMERCE;
                            break;
                        case (int)Enums.CurrentIndustry.Banking:
                            currentIndustry = Constants.CIndustryConstants.BANKING;
                            break;
                        case (int)Enums.CurrentIndustry.Insurance:
                            currentIndustry = Constants.CIndustryConstants.INSURANCE;
                            break;
                        case (int)Enums.CurrentIndustry.Agriculture:
                            currentIndustry = Constants.CIndustryConstants.AGRICULTURE;
                            break;
                        case (int)Enums.CurrentIndustry.Credit_Bureau:
                            currentIndustry = Constants.CIndustryConstants.CREDIT_BUREAU;
                            break;
                        case (int)Enums.CurrentIndustry.E_Learning:
                            currentIndustry = Constants.CIndustryConstants.E_LEARNING;
                            break;
                        case (int)Enums.CurrentIndustry.Information_Technology:
                            currentIndustry = Constants.CIndustryConstants.INFORMATION_TECHNOLOGY;
                            break;
                        default:
                            validations.Append("Unknown value for Current Industry is selected.\n");
                            break;
                    }
                    careerProfileDetails.CurrentIndustry = currentIndustry;
                }
                else
                    validations.Append("Please select integer value for Current Industry(EX: 3 for Banking)\n");
                Console.WriteLine();
                Console.WriteLine("Different values for Department :");
                List<string> departmentList = new List<string>();
                departmentList.Add(Constants.DepartmentConstants.DATASCIENCE_ANALYTICS);
                departmentList.Add(Constants.DepartmentConstants.IT_INFORMATION_SECURITY);
                departmentList.Add(Constants.DepartmentConstants.PRODUCT_MANAGEMENT);
                departmentList.Add(Constants.DepartmentConstants.CONSULTING);
                departmentList.Add(Constants.DepartmentConstants.TEACHING_TRAINING);
                departmentList.Add(Constants.DepartmentConstants.OTHER);

                //Print Department List
                Utility.Utility.PrintListValues(departmentList);

                Console.Write("Select value for Department(EX: 1 for Data Science & Analytics): ");
                int departmentOutput = 0;
                bool isdepartment = int.TryParse(Console.ReadLine(), out departmentOutput);
                string department = string.Empty;

                if (isdepartment)
                {
                    switch (departmentOutput)
                    {
                        case (int)Enums.Department.DataScience_Analytics:
                            department = Constants.DepartmentConstants.DATASCIENCE_ANALYTICS;
                            break;
                        case (int)Enums.Department.IT_Information_Security:
                            department = Constants.DepartmentConstants.IT_INFORMATION_SECURITY;
                            break;
                        case (int)Enums.Department.Product_Management:
                            department = Constants.DepartmentConstants.PRODUCT_MANAGEMENT;
                            break;
                        case (int)Enums.Department.Consulting:
                            department = Constants.DepartmentConstants.CONSULTING;
                            break;
                        case (int)Enums.Department.Teaching_Training:
                            department = Constants.DepartmentConstants.TEACHING_TRAINING;
                            break;
                        case (int)Enums.Department.Other:
                            department = Constants.DepartmentConstants.OTHER;
                            break;
                        default:
                            validations.Append("Unknown value for Department is selected.\n");
                            break;
                    }
                    careerProfileDetails.Department = department;
                }
                else
                    validations.Append("Please select integer value for Department(EX: 1 for Data Science & Analytics)\n");
                Console.WriteLine();
                Console.WriteLine("Different values for Desired Job Type :");
                List<string> desiredJobList = new List<string>();
                desiredJobList.Add(Constants.DesiredJobConstants.PERMANENT);
                desiredJobList.Add(Constants.DesiredJobConstants.CONTRACTUAL);

                //Print Desired Job Type List
                Utility.Utility.PrintListValues(desiredJobList);

                Console.Write("Select value for Desired Job Type(EX: 1 for Permanent): ");
                int desiredJobOutput = 0;
                bool isDesiredJob = int.TryParse(Console.ReadLine(), out desiredJobOutput);
                string desiredJob = string.Empty;

                if (isDesiredJob)
                {
                    switch (desiredJobOutput)
                    {
                        case (int)Enums.DesiredJob.Permanent:
                            desiredJob = Constants.DesiredJobConstants.PERMANENT;
                            break;
                        case (int)Enums.DesiredJob.Contractual:
                            desiredJob = Constants.DesiredJobConstants.CONTRACTUAL;
                            break;
                        default:
                            validations.Append("Unknown value for Desired Job Type is selected.\n");
                            break;
                    }
                    careerProfileDetails.DesiredJobType = desiredJob;
                }
                else
                    validations.Append("Please select integer value for Desired Job Type(EX: 1 for Permanent)\n");
                Console.WriteLine();
                Console.WriteLine("Different values for Desired Employment Type :");
                List<string> desiredEmploymentList = new List<string>();
                desiredEmploymentList.Add(Constants.DesiredEmploymentConstants.FULL_TIME);
                desiredEmploymentList.Add(Constants.DesiredEmploymentConstants.PART_TIME);

                //Print Desired Employment Type List
                Utility.Utility.PrintListValues(desiredEmploymentList);

                Console.Write("Select value for Desired Employment Type(EX: 1 for Full Time): ");
                int desiredEmploymentOutput = 0;
                bool isDesiredEmployment = int.TryParse(Console.ReadLine(), out desiredEmploymentOutput);
                string desiredEmploymentType = string.Empty;

                if(isDesiredEmployment)
                {
                    switch(desiredEmploymentOutput)
                    {
                        case (int)Enums.DesiredEmployment.Full_Time:
                            desiredEmploymentType = Constants.DesiredEmploymentConstants.FULL_TIME;
                            break;
                        case (int)Enums.DesiredEmployment.Part_Time:
                            desiredEmploymentType = Constants.DesiredEmploymentConstants.PART_TIME;
                            break;
                        default:
                            validations.Append("Unknown value for Desired Employment Type is selected.\n ");
                            break;
                    }
                    careerProfileDetails.DesiredEmploymentType = desiredEmploymentType;
                }
                else
                    validations.Append("Please select integer value for Desired Employment Type(EX: 1 for Full Time)\n ");
                Console.WriteLine();
                Console.WriteLine("Different values for Preferred Shift :");
                List<string> preferredShiftList = new List<string>();
                preferredShiftList.Add(Constants.PreShiftConstants.DAY);
                preferredShiftList.Add(Constants.PreShiftConstants.NIGHT);
                preferredShiftList.Add(Constants.PreShiftConstants.FLEXIBLE);

                //Print Preferred Shift List
                Utility.Utility.PrintListValues(preferredShiftList);

                Console.Write("Select value for Preferred Shift(Ex: 1 for Day): ");
                int pShiftOutput = 0;
                bool isPreferredShift = int.TryParse(Console.ReadLine(), out pShiftOutput);
                string preferredShift = string.Empty;

                if (isPreferredShift)
                {
                    switch (pShiftOutput)
                    {
                        case (int)Enums.PreferredShift.Day:
                            preferredShift = Constants.PreShiftConstants.DAY;
                            break;
                        case (int)Enums.PreferredShift.Night:
                            preferredShift = Constants.PreShiftConstants.NIGHT;
                            break;
                        case (int)Enums.PreferredShift.Flexible:
                            preferredShift = Constants.PreShiftConstants.FLEXIBLE;
                            break;
                        default:
                            validations.Append("Unknown value for Preffered Shift is selected.\n");
                            break;
                    }
                    careerProfileDetails.PreferredShift = preferredShift;
                }
                else
                    validations.Append("Please select integer value for Preferred Shift(Ex: 1 for Preferred Shift)\n");
                Console.WriteLine();
                Console.WriteLine("Different values for Preferred Work Location :");
                List<string> workLocationList = new List<string>();
                workLocationList.Add(Constants.WorkLocationConstants.BANGALORE);
                workLocationList.Add(Constants.WorkLocationConstants.HYDERABAD);
                workLocationList.Add(Constants.WorkLocationConstants.CHENNAI);
                workLocationList.Add(Constants.WorkLocationConstants.MUMBAI);
                workLocationList.Add(Constants.WorkLocationConstants.PUNE);
                workLocationList.Add(Constants.WorkLocationConstants.DELHI);

                //Print Work Location List
                Utility.Utility.PrintListValues(workLocationList);

                Console.Write("Select value for Preferred Work Location(EX: 1 for Bangalore): ");
                int workLocationOutput = 0;
                bool isWorkLocation = int.TryParse(Console.ReadLine(), out workLocationOutput);
                string workLocation = string.Empty;

                if (isWorkLocation)
                {
                    switch (workLocationOutput)
                    {
                        case (int)Enums.WorkLocation.Bangalore:
                            workLocation = Constants.WorkLocationConstants.BANGALORE;
                            break;
                        case (int)Enums.WorkLocation.Hyderabad:
                            workLocation = Constants.WorkLocationConstants.HYDERABAD;
                            break;
                        case (int)Enums.WorkLocation.Chennai:
                            workLocation = Constants.WorkLocationConstants.CHENNAI;
                            break;
                        case (int)Enums.WorkLocation.Mumbai:
                            workLocation = Constants.WorkLocationConstants.MUMBAI;
                            break;
                        case (int)Enums.WorkLocation.Pune:
                            workLocation = Constants.WorkLocationConstants.PUNE;
                            break;
                        case (int)Enums.WorkLocation.Delhi:
                            workLocation = Constants.WorkLocationConstants.DELHI;
                            break;
                        default:
                            validations.Append("Unknown Value for Preferred Work Location is selected.\n");
                            break;
                    }
                    careerProfileDetails.PreferredWorkLocation = workLocation;
                }
                else
                    validations.Append("Please select integer value for Preferred Work Location(EX: 1 for Bangalore)\n");
                Console.WriteLine();
                Console.Write("Enter the Expected Salary :");
                string expectedSalary = Console.ReadLine();

                if (!string.IsNullOrEmpty(expectedSalary))
                    careerProfileDetails.ExpectedSalary = expectedSalary;
                else
                    validations.Append("Candidate Expected Salary is missing.\n");
                Console.WriteLine();
                Console.WriteLine("Different values for Job Role :");
                List<string> jobRoleList = new List<string>();
                jobRoleList.Add(Constants.JobRoleConstants.TESTING);
                jobRoleList.Add(Constants.JobRoleConstants.DEVELOPMENT);
                jobRoleList.Add(Constants.JobRoleConstants.PROJECT_MANAGEMENT);
                jobRoleList.Add(Constants.JobRoleConstants.PRODUCTION_SUPPORT);
                jobRoleList.Add(Constants.JobRoleConstants.DEPLOYMENT);

                //Print Job Role List
                Utility.Utility.PrintListValues(jobRoleList);

                Console.Write("Select value for Job Role(EX: 1 for Testing): ");
                int jobRoleOutput = 0;
                bool isJobRole = int.TryParse(Console.ReadLine(), out jobRoleOutput);
                string jobRole = string.Empty;

                if (isJobRole)
                {
                    switch (jobRoleOutput)
                    {
                        case (int)Enums.JobRole.Testing:
                            jobRole = Constants.JobRoleConstants.TESTING;
                            break;
                        case (int)Enums.JobRole.Development:
                            jobRole = Constants.JobRoleConstants.DEVELOPMENT;
                            break;
                        case (int)Enums.JobRole.Project_Management:
                            jobRole = Constants.JobRoleConstants.PROJECT_MANAGEMENT;
                            break;
                        case (int)Enums.JobRole.Production_Support:
                            jobRole = Constants.JobRoleConstants.PRODUCTION_SUPPORT;
                            break;
                        case (int)Enums.JobRole.Deployment:
                            jobRole = Constants.JobRoleConstants.DEPLOYMENT;
                            break;
                        default:
                            validations.Append("Unknown value for Job Role is selected.\n");
                            break;
                    }
                    careerProfileDetails.JobRole = jobRole;
                }
                else
                    validations.Append("Please select integer value for Job Role(EX: 1 for Testing)\n");


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
            return careerProfileDetails;
        }

        /// <summary>
        ///  Method that  writes/prints Candidate Career Profile details to the Console Screen
        /// </summary>
        public void PrintCareerProfileDetails(CareerProfile details)
        {
            try
            {
                Console.WriteLine();
                Console.WriteLine("Career Profile Details :");
                Console.WriteLine($"Current Industry : {details.CurrentIndustry}");
                Console.WriteLine($"Department : {details.Department}");
                Console.WriteLine($"Desired Job Type : {details.DesiredJobType}");
                Console.WriteLine($"Desired Employment Type : {details.DesiredEmploymentType}");
                Console.WriteLine($"Preferred Shift : {details.PreferredShift}");
                Console.WriteLine($"Preferred Work Location : {details.PreferredWorkLocation}");
                Console.WriteLine($"Expected Salary : {details.ExpectedSalary}");
                Console.WriteLine($"Job Role : {details.JobRole}");

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
