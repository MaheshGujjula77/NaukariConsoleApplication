using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate.BusinessLogic
{
    public class ProjectDetailsService
    {
        /// <summary>
        /// Method that reads Candidate  Project details from  Console screen
        /// </summary>
        public ProjectDetails ReadProjectDetails()
        {
            ProjectDetails projectDetails = new ProjectDetails();
            StringBuilder validations = new StringBuilder();
            try
            {
                Console.WriteLine();
                Console.WriteLine("Provide Candidate  Project Details:\n");
                Console.Write("Enter the Project Title :");
                string projectTitle = Console.ReadLine();

                if (!string.IsNullOrEmpty(projectTitle))
                    projectDetails.ProjectTitle = projectTitle;
                else
                    validations.Append("Candidate Project Title is missing.");
                Console.WriteLine("Tag this project with your Employment/Education :");
                List<string> projectTagList = new List<string>();
                projectTagList.Add(Constants.Constants.GRADUATION);
                projectTagList.Add(Constants.Constants.PG);
                projectTagList.Add(Constants.Constants.MPHIL);
                projectTagList.Add(Constants.Constants.PHD);
                projectTagList.Add(Constants.Constants.PREVIOUS_COMPANY);

                //Print Project Tag List
                Utility.Utility.PrintListValues(projectTagList);
                Console.Write("Select value for Project Tag(Ex: 1 for Graduation): ");
                int projectTagOutput = 0;
                bool isProjectTag = int.TryParse(Console.ReadLine(), out projectTagOutput);
                string projectTag = string.Empty;

                if (isProjectTag)
                {
                    switch (projectTagOutput)
                    {
                        case (int)Enums.ProjectTag.Graduation:
                            projectTag = Constants.Constants.GRADUATION;
                            break;
                        case (int)Enums.ProjectTag.PG:
                            projectTag = Constants.Constants.PG;
                            break;
                        case (int)Enums.ProjectTag.Mphil:
                            projectTag = Constants.Constants.MPHIL;
                            break;
                        case (int)Enums.ProjectTag.Phd:
                            projectTag = Constants.Constants.PHD;
                            break;
                        case (int)Enums.ProjectTag.Previous_Company:
                            projectTag = Constants.Constants.PREVIOUS_COMPANY;
                            break;
                        default:
                            validations.Append("Unknown value for Project Tag is selected.\n");
                            break;
                    }
                    projectDetails.EmploymentTag = projectTag;
                }
                else
                    validations.Append("Please select integer value for Project Tag(EX: 1 for Graduation)\n");
                Console.WriteLine();
                Console.Write("Enter Client :");
                string client = Console.ReadLine();

                if (!string.IsNullOrEmpty(client))
                    projectDetails.Client = client;
                else
                    validations.Append("Client Value is missing.\n");
                Console.WriteLine("Different values for Project status :");
                List<string> projectStatusList = new List<string>();
                projectStatusList.Add(Constants.Constants.INPROGRESS);
                projectStatusList.Add(Constants.Constants.FINISHED);

                //Print Project Status List
                Utility.Utility.PrintListValues(projectStatusList);

                Console.Write("Select value for Project Status(EX: 1 for In Progress): ");
                int projectStatusOutput = 0;
                bool isProjectStatus = int.TryParse(Console.ReadLine(), out projectStatusOutput);
                string projectStatus = string.Empty;

                if (isProjectStatus)
                {
                    switch (projectStatusOutput)
                    {
                        case (int)Enums.ProjectStatus.In_Progress:
                            projectStatus = Constants.Constants.INPROGRESS;
                            break;
                        case (int)Enums.ProjectStatus.Finished:
                            projectStatus = Constants.Constants.FINISHED;
                            break;
                        default:
                            validations.Append("Unknown value for Project Status is selected.\n");
                            break;
                    }
                    projectDetails.ProjectStatus = projectStatus;
                }
                else
                    validations.Append("Please select integer value for Project Status(EX: 1 for In Progress)\n");
                Console.WriteLine();
                Console.Write("Enter Project Work From Year :");
                string workFromYear = Console.ReadLine();

                if (!string.IsNullOrEmpty(workFromYear))
                    projectDetails.WorkFromYear = workFromYear;
                else
                    validations.Append("Work From Year Value is missing.\n");

                Console.Write("Enter Project Work From Month :");
                string workFromMonth = Console.ReadLine();

                if (!string.IsNullOrEmpty(workFromMonth))
                    projectDetails.WorkFromMonth = workFromMonth;
                else
                    validations.Append("Work From Month value is missing.\n");

                Console.Write("Enter Project Description :");
                string projectDescription = Console.ReadLine();

                if (!string.IsNullOrEmpty(projectDescription))
                    projectDetails.ProjectDescription = projectDescription;
                else
                    validations.Append("Project Description Value is missing.\n");

                Console.Write("Enter Project Location :");
                string projectLocation = Console.ReadLine();

                if (!string.IsNullOrEmpty(projectLocation))
                    projectDetails.ProjectLocation = projectLocation;
                else
                    validations.Append("Project Location value is missing.\n");
                Console.WriteLine();
                Console.WriteLine("Different values for Project Site :");
                List<string> projetSiteList = new List<string>();
                projetSiteList.Add(Constants.Constants.ONSITE);
                projetSiteList.Add(Constants.Constants.OFFSITE);

                //Print Project site List
                Utility.Utility.PrintListValues(projetSiteList);

                Console.Write("Select value for Project Site(EX: 1 for Onsite): ");
                int projectOnsiteOutput = 0;
                bool isProjectOnsite = int.TryParse(Console.ReadLine(), out projectOnsiteOutput);
                string projectOnsite = string.Empty;

                if (isProjectOnsite)
                {
                    switch (projectOnsiteOutput)
                    {
                        case (int)Enums.ProjectOnsite.Onsite:
                            projectOnsite = Constants.Constants.ONSITE;
                            break;
                        case (int)Enums.ProjectOnsite.Offsite:
                            projectOnsite = Constants.Constants.OFFSITE;
                            break;
                        default:
                            validations.Append("Unknown value for Project Site is selected.\n");
                            break;
                    }
                    projectDetails.ProjectSite = projectOnsite;
                }
                else
                    validations.Append("Please select integer value for Project Site(EX: 1 for Onsite)\n");
                Console.WriteLine();
                Console.WriteLine("Different Values for Employment Nature :");
                List<string> employmentNatureList = new List<string>();
                employmentNatureList.Add(Constants.Constants.FULLTIME);
                employmentNatureList.Add(Constants.Constants.PARTTIME);
                employmentNatureList.Add(Constants.Constants.CONTRACTUAL);

                //Print Employment Nature List
                Utility.Utility.PrintListValues(employmentNatureList);

                Console.Write("Select value for Employment Nature(EX: 1 for Full time): ");
                int employmentOutput = 0;
                bool isEmploymentNature = int.TryParse(Console.ReadLine(), out employmentOutput);
                string employmentNature = string.Empty;

                if (isEmploymentNature)
                {
                    switch (employmentOutput)
                    {
                        case (int)Enums.EmploymentNature.FullTime:
                            employmentNature = Constants.Constants.FULLTIME;
                            break;
                        case (int)Enums.EmploymentNature.PartTime:
                            employmentNature = Constants.Constants.PARTTIME;
                            break;
                        case (int)Enums.EmploymentNature.Contractual:
                            employmentNature = Constants.Constants.CONTRACTUAL;
                            break;
                        default:
                            validations.Append("Unknown value for Employment Nature is selected.\n");
                            break;
                    }
                    projectDetails.EmploymentNature = employmentNature;
                }
                else
                    validations.Append("Please select integer value for Employment Nature(EX: 1 for Full Time)\n");
                Console.WriteLine();
                //Console.Write("Enter Team Size :");
                //int teamSize =Convert.ToInt32(Console.ReadLine());

                //if (teamSize == int.MinValue)
                //    projectDetails.TeamSize = teamSize;
                //else if(teamSize == 0 )
                //    projectDetails.TeamSize =teamSize;
                //else
                //    validations.Append("Team Size value is missing.\n");
                Console.WriteLine();
                Console.WriteLine("Different values for Role :");
                List<string> roleList = new List<string>();
                roleList.Add(Constants.Constants.DEVELOPER);
                roleList.Add(Constants.Constants.TESTER);
                roleList.Add(Constants.Constants.PROJECT_MANAGER);
                roleList.Add(Constants.Constants.TECHNICAL_LEAD);
            
                //Print Project Role List
                Utility.Utility.PrintListValues(roleList);

                Console.Write("Select value for Role(EX: 1 for Developer): ");
                int roleOutput = 0;
                bool isRoleOutput = int.TryParse(Console.ReadLine(), out roleOutput);
                string role = string.Empty;

                if (isRoleOutput)
                {
                    switch (roleOutput)
                    {
                        case (int)Enums.Role.Developer:
                            role = Constants.Constants.DEVELOPER;
                            break;
                        case (int)Enums.Role.Tester:
                            role = Constants.Constants.TESTER;
                            break;
                        case (int)Enums.Role.Project_Manager:
                            role = Constants.Constants.PROJECT_MANAGER;
                            break;
                        case (int)Enums.Role.Technical_Lead:
                            role = Constants.Constants.TECHNICAL_LEAD;
                            break;
                        default:
                            validations.Append("Unknown value for Role is selected.\n");
                            break;
                    }
                    projectDetails.Role = role;
                }
                else
                    validations.Append("Please select integer value for Role(EX: 1 for Developer)\n");
                Console.WriteLine();
                Console.Write("Enter Role Description :");
                string roleDescription = Console.ReadLine();

                if (!string.IsNullOrEmpty(roleDescription))
                    projectDetails.RoleDescription = roleDescription;
                else
                    validations.Append("Role Description Value is missing.\n");

                Console.Write("Enter SKills Used :");
                string skillsUsed = Console.ReadLine();

                if (!string.IsNullOrEmpty(skillsUsed))
                    projectDetails.SkillsUsed = skillsUsed;
                else
                    validations.Append("Skills used value is missing.\n");

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
            return projectDetails;
        }

        /// <summary>
        /// Method that  writes/prints Candidate  Project details to the Console Screen
        /// </summary>
        /// <param name="projectDetails"></param>
        public void PrintProjectDetails(ProjectDetails projectDetails)
        {
            try
            {

                Console.WriteLine();
                Console.WriteLine("Project Details :");
                Console.WriteLine($"Project Title: {projectDetails.ProjectTitle}");
                Console.WriteLine($"Employment Tag: {projectDetails.EmploymentTag}");
                Console.WriteLine($"Client: {projectDetails.Client}");
                Console.WriteLine($"ProjectStatus: {projectDetails.ProjectStatus}");
                Console.WriteLine($"WorkFromYear: {projectDetails.WorkFromYear}");
                Console.WriteLine($"WorkFromMonth: {projectDetails.WorkFromMonth}");
                Console.WriteLine($"ProjectDescription: {projectDetails.ProjectDescription}");
                Console.WriteLine($"ProjectLocation: {projectDetails.ProjectLocation}");
                Console.WriteLine($"ProjectSite: {projectDetails.ProjectSite}");
                Console.WriteLine($"EmploymentNature: {projectDetails.EmploymentNature}");
                Console.WriteLine($"TeamSize: {projectDetails.TeamSize}");  
                Console.WriteLine($"Role: {projectDetails.Role}");
                Console.WriteLine($"RoleDescription: {projectDetails.RoleDescription}");
                Console.WriteLine($"SkillsUsed: {projectDetails.SkillsUsed}");

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
