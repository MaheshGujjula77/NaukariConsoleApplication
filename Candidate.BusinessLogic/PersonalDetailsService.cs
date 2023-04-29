using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Candidate;


namespace Candidate.BusinessLogic
{
    public class PersonalDetailsService
    {
        /// <summary>
        /// Method that reads Candidate personal details from  Console screen
        /// </summary>
        public PersonalDetails ReadPersonalDetails()
        {
            PersonalDetails personalDetails = new PersonalDetails();
            StringBuilder validations = new StringBuilder();
            try
            {
                Console.WriteLine("Provide Candidate Personal Details:\n");
                Console.Write("Enter First Name:");
                string firstName = Console.ReadLine();

                if (!string.IsNullOrEmpty(firstName))
                    personalDetails.FirstName = firstName;
                else
                    validations.Append("Candidate First Name is Missing.\n");

                Console.Write("Enter Middle Name:");
                string middleName = Console.ReadLine();

                if (!string.IsNullOrEmpty(middleName))
                    personalDetails.MiddleName = middleName;
                else
                    validations.Append("Candidate Middle Name is Missing.\n");

                Console.Write("Enter Last Name:");
                string lastName = Console.ReadLine();

                if (!string.IsNullOrEmpty(lastName))
                    personalDetails.LastName = lastName;
                else
                    validations.Append("Candidate Last Name is Missing.\n");
                Console.WriteLine();
                Console.WriteLine("Different values for Gender :");
                List<string> genderList = new List<string>();
                genderList.Add(Constants.Constants.MALE);
                genderList.Add(Constants.Constants.FEMALE);
                genderList.Add(Constants.Constants.TRANSGENDER);

                //Print Gender List
                Utility.Utility.PrintListValues(genderList);

                Console.Write("Select value for Grender(Ex: 1 for Male): ");

                int genderOutput = 0;
                bool isGenderHasValue = int.TryParse(Console.ReadLine(), out genderOutput);
                string genderValue = string.Empty;
                if (isGenderHasValue)
                {
                    switch (genderOutput)
                    {
                        case (int)Enums.Gender.Male:
                            genderValue = Constants.Constants.MALE;
                            break;
                        case (int)Enums.Gender.Female:
                            genderValue = Constants.Constants.FEMALE;
                            break;
                        case (int)Enums.Gender.Transgender:
                            genderValue = Constants.Constants.TRANSGENDER;
                            break;
                        default:
                            validations.Append("Unknown Value for Gender is selected.\n");
                            break;
                    }
                    personalDetails.Gender = genderValue;
                }
                else
                {
                    validations.Append("Please select integer valor Male)\n");
                }

                Console.WriteLine();
                Console.WriteLine("Different Values for Candidate Type : ");
                List<string> candidateTypeList = new List<string>();
                candidateTypeList.Add(Constants.Constants.SINGLE_PARENT);
                candidateTypeList.Add(Constants.Constants.WORKING_MOTHER);
                candidateTypeList.Add(Constants.Constants.SERVED_IN_MILITARY);
                candidateTypeList.Add(Constants.Constants.RETIRED);
                candidateTypeList.Add(Constants.Constants.LGBTQ);

                //Print Candidate Type List
                Utility.Utility.PrintListValues(candidateTypeList);

                Console.Write("Select value for Candidate Type(EX: 1 for Single Parent): ");
                int candidateTypeOutput = 0;
                bool isCandidateTypeValid = int.TryParse(Console.ReadLine(), out candidateTypeOutput);
                string candidateTypeValue = string.Empty;
                if (isCandidateTypeValid)
                {
                    switch (candidateTypeOutput)
                    {
                        case (int)Enums.CandidateType.Single_Parent:
                            candidateTypeValue = Constants.Constants.SINGLE_PARENT;
                            break;
                        case (int)Enums.CandidateType.Working_Mother:
                            candidateTypeValue = Constants.Constants.WORKING_MOTHER;
                            break;
                        case (int)Enums.CandidateType.Served_In_Military:
                            candidateTypeValue = Constants.Constants.SERVED_IN_MILITARY;
                            break;
                        case (int)Enums.CandidateType.Retired:
                            candidateTypeValue = Constants.Constants.RETIRED;
                            break;
                        case (int)Enums.CandidateType.LGBTQ:
                            candidateTypeValue = Constants.Constants.LGBTQ;
                            break;
                        default:
                            validations.Append("Unknown Value for Candidate Type is Selected.\n");
                            break;

                    }
                    personalDetails.CandidateType = candidateTypeValue;
                }
                else
                {
                    validations.Append("Please Select integer Value for Candidate Type(Ex: 1 for Single Parent)\n");
                }

                Console.WriteLine();
                Console.WriteLine("Different values for Marital Status :");
                List<string> maritalStatusList = new List<string>();
                maritalStatusList.Add(Constants.Constants.MARRIED);
                maritalStatusList.Add(Constants.Constants.UNMARRIED);
                maritalStatusList.Add(Constants.Constants.WIDOWED);
                maritalStatusList.Add(Constants.Constants.DIVORCED);
                maritalStatusList.Add(Constants.Constants.OTHER);

                //Print Marital Status List
                Utility.Utility.PrintListValues(maritalStatusList);

                Console.Write("Select value for Marital Status(EX: 1 for Married): ");

                int maritalStatusOutput = 0;
                bool isMaritalStatusValid = int.TryParse(Console.ReadLine(), out maritalStatusOutput);
                string maritalStatusValue = string.Empty;
                if (isMaritalStatusValid)
                {
                    switch (maritalStatusOutput)
                    {
                        case (int)Enums.MaritalStatus.Married:
                            maritalStatusValue = Constants.Constants.MARRIED;
                            break;
                        case (int)Enums.MaritalStatus.Unmarried:
                            maritalStatusValue = Constants.Constants.UNMARRIED;
                            break;
                        case (int)Enums.MaritalStatus.Widowed:
                            maritalStatusValue = Constants.Constants.WIDOWED;
                            break;
                        case (int)Enums.MaritalStatus.Divorced:
                            maritalStatusValue = Constants.Constants.DIVORCED;
                            break;
                        case (int)Enums.MaritalStatus.Other:
                            maritalStatusValue = Constants.Constants.OTHER;
                            break;
                        default:
                            validations.Append("Unknown value for Marital Status is selected.\n");
                            break;

                    }
                    personalDetails.MaritalStatus = maritalStatusValue;
                }
                else
                {
                    validations.Append("Please select integer value for Marital Status(EX: 1 for Married)\n");
                }
                Console.WriteLine();
                Console.Write("Enter Date of Birth :");
                string dateOfBirth = Console.ReadLine();


                if (!string.IsNullOrEmpty(dateOfBirth))
                    personalDetails.DateOfBirth = dateOfBirth;
                else
                    validations.Append("Candidate Date of Birth is Missing.\n");

                Console.WriteLine("Different values for Category :");
                List<string> categoryList = new List<string>();
                categoryList.Add(Constants.Constants.GENERAL);
                categoryList.Add(Constants.Constants.SCHEDULED_CASTE);
                categoryList.Add(Constants.Constants.SCHEDULED_TRIBE);
                categoryList.Add(Constants.Constants.OBC_CREAMY);
                categoryList.Add(Constants.Constants.OBC_NON_CREAMY);
                categoryList.Add(Constants.Constants.OTHER);

                //Print Category List
                Utility.Utility.PrintListValues(categoryList);

                Console.Write("Select value for Category(EX: 1 for General): ");
                int categoryOutput = 0;
                bool isCategoryValid = int.TryParse(Console.ReadLine(), out categoryOutput);
                string categoryValue = string.Empty;
                if (isCategoryValid)
                {
                    switch (categoryOutput)
                    {
                        case (int)Enums.Category.General:
                            categoryValue = Constants.Constants.GENERAL;
                            break;
                        case (int)Enums.Category.Scheduled_Caste:
                            categoryValue = Constants.Constants.SCHEDULED_CASTE;
                            break;
                        case (int)Enums.Category.Scheduled_Tribe:
                            categoryValue = Constants.Constants.SCHEDULED_TRIBE;
                            break;
                        case (int)Enums.Category.OBC_Creamy:
                            categoryValue = Constants.Constants.OBC_NON_CREAMY;
                            break;
                        case (int)Enums.Category.OBC_Non_Creamy:
                            categoryValue = Constants.Constants.OBC_NON_CREAMY;
                            break;
                        default:
                            validations.Append("Unknown value for Marital Status is selected.\n");
                            break;
                    }
                    personalDetails.Category = categoryValue;
                }
                else
                {
                    validations.Append("Please select integer value for Category(EX: 1 for General)\n");
                }
                Console.WriteLine();
                Console.WriteLine("Different values for Differently Abled :");
                List<string> differentlyAbledList = new List<string>();
                differentlyAbledList.Add(Constants.Constants.YES);
                differentlyAbledList.Add(Constants.Constants.NO);

                //Print Differently Abled List
                Utility.Utility.PrintListValues(differentlyAbledList);

                Console.Write("Select value for Differently Abled(EX: 1 for Yes): ");
                int differentlyAbledOutput = 0;
                bool isDifferentlyAbledValid = int.TryParse(Console.ReadLine(), out differentlyAbledOutput);
                string differentlyAbledValue = string.Empty;
                if (isDifferentlyAbledValid)
                {
                    switch (differentlyAbledOutput)
                    {
                        case (int)Enums.DifferentlyAbled.Yes:
                            differentlyAbledValue = Constants.Constants.YES;
                            break;
                        case (int)Enums.DifferentlyAbled.No:
                            differentlyAbledValue = Constants.Constants.NO;
                            break;
                        default:
                            validations.Append("Unknown value for Differently Abled is selected.\n");
                            break;
                    }
                    personalDetails.DifferentlyAbled = differentlyAbledValue;
                }
                else
                    validations.Append("Please select integer value for Differently Abled(EX: 1 Yes)\n ");

                Console.WriteLine();
                Console.WriteLine("Different Values for Career Break :");
                List<string> careerBreakList = new List<string>();
                careerBreakList.Add(Constants.Constants.YES);
                careerBreakList.Add(Constants.Constants.NO);

                //Print Career Break List
                Utility.Utility.PrintListValues(careerBreakList);

                Console.Write("Select values for Career Break(EX: 1 for Yes): ");
                int careerBreakOutput = 0;
                bool isCareerBreakValue = int.TryParse(Console.ReadLine(), out careerBreakOutput);
                string careerBreakValue = string.Empty;
                if (isCareerBreakValue)
                {
                    switch (careerBreakOutput)
                    {
                        case (int)Enums.CareerBreak.Yes:
                            careerBreakValue = Constants.Constants.YES;
                            break;
                        case (int)Enums.CareerBreak.No:
                            careerBreakValue = Constants.Constants.NO;
                            break;
                        default:
                            validations.Append("Unknown value for Career Break is selected.\n");
                            break;
                    }
                    personalDetails.CareerBreak = careerBreakValue;
                }
                else
                    validations.Append("Please select integer value for Career Break(EX: 1 for Yes)\n");

                Console.WriteLine();
                Console.WriteLine("Different values for Work Permit USA :");
                List<string> workPermitUSA = new List<string>();
                workPermitUSA.Add(Constants.Constants.Have_US_H1_Visa);
                workPermitUSA.Add(Constants.Constants.Need_US_H1_Visa);
                workPermitUSA.Add(Constants.Constants.US_TN_Permit_Holder);
                workPermitUSA.Add(Constants.Constants.US_Green_Card_Holder);
                workPermitUSA.Add(Constants.Constants.US_Citizen);
                workPermitUSA.Add(Constants.Constants.Authorized_to_work_in_US);

                //Print Work Permit USA List
                Utility.Utility.PrintListValues(workPermitUSA);

                Console.Write("Select value for Work Permit USA(EX: 1 for Have US H1 Visa): ");
                int workPermitUSAOutput = 0;
                bool isWorkPermitUSAValid = int.TryParse(Console.ReadLine(), out workPermitUSAOutput);
                string workPermitUSAValue = string.Empty;
                if (isWorkPermitUSAValid)
                {
                    switch (workPermitUSAOutput)
                    {
                        case (int)Enums.WorkPermitUSA.Have_US_H1_Visa:
                            workPermitUSAValue = Constants.Constants.Have_US_H1_Visa;
                            break;
                        case (int)Enums.WorkPermitUSA.Need_US_H1_Visa:
                            workPermitUSAValue = Constants.Constants.Need_US_H1_Visa;
                            break;
                        case (int)Enums.WorkPermitUSA.US_TN_Permit_Holder:
                            workPermitUSAValue = Constants.Constants.US_TN_Permit_Holder;
                            break;
                        case (int)Enums.WorkPermitUSA.US_Green_Card_Holder:
                            workPermitUSAValue = Constants.Constants.US_Green_Card_Holder;
                            break;
                        case (int)Enums.WorkPermitUSA.US_Citizen:
                            workPermitUSAValue = Constants.Constants.US_Citizen;
                            break;
                        case (int)Enums.WorkPermitUSA.Authorized_to_work_in_US:
                            workPermitUSAValue = Constants.Constants.Authorized_to_work_in_US;
                            break;
                        default:
                            validations.Append("Unknown value for Work Permit USA is selected.\n");
                            break;

                    }
                    personalDetails.WorkPermitUSA = workPermitUSAValue;
                }
                else
                    validations.Append("Please select integer value for Work Permit USA(EX: 1 for Have US H1 Visa)\n ");

                Console.WriteLine();
                Console.WriteLine("Different Values for Work Permit for Other Countries :");
                List<string> workPermitOtherCountries = new List<string>();
                workPermitOtherCountries.Add(Constants.Constants.INDIA);
                workPermitOtherCountries.Add(Constants.Constants.AUSTRALIA);
                workPermitOtherCountries.Add(Constants.Constants.NEW_ZEALAND);
                workPermitOtherCountries.Add(Constants.Constants.ENGLAND);
                workPermitOtherCountries.Add(Constants.Constants.GERMANY);
                workPermitOtherCountries.Add(Constants.Constants.USA);

                //Print Work Permit for Other Countries List
                Utility.Utility.PrintListValues(workPermitOtherCountries);

                Console.Write("Select value for Work Permit for Other Countries(EX: 1 for India): ");
                int workPermitOtherCountriesOutput = 0;
                bool isWorkPermitOtherCountriesValid = int.TryParse(Console.ReadLine(), out workPermitOtherCountriesOutput);
                string workPermitOtherCountriesValue = string.Empty;
                if (isWorkPermitOtherCountriesValid)
                {
                    switch (workPermitOtherCountriesOutput)
                    {
                        case (int)Enums.WorkPermitOtherCountries.India:
                            workPermitOtherCountriesValue = Constants.Constants.INDIA;
                            break;
                        case (int)Enums.WorkPermitOtherCountries.Australia:
                            workPermitOtherCountriesValue = Constants.Constants.AUSTRALIA;
                            break;
                        case (int)Enums.WorkPermitOtherCountries.New_Zealand:
                            workPermitOtherCountriesValue = Constants.Constants.NEW_ZEALAND;
                            break;
                        case (int)Enums.WorkPermitOtherCountries.England:
                            workPermitOtherCountriesValue = Constants.Constants.ENGLAND;
                            break;
                        case (int)Enums.WorkPermitOtherCountries.Germany:
                            workPermitOtherCountriesValue = Constants.Constants.GERMANY;
                            break;
                        case (int)Enums.WorkPermitOtherCountries.USA:
                            workPermitOtherCountriesValue = Constants.Constants.USA;
                            break;
                        default:
                            validations.Append("Unknown value for Work Permit for Other Countries is selected.\n");
                            break;
                    }
                    personalDetails.WorkPermitOtherCountries = workPermitOtherCountriesValue;
                }
                else
                    validations.Append("Please select integer value for Work Permit for Other Countries(EX: 1 for India)\n");
                Console.WriteLine();
                Console.WriteLine("Different values for Work Status :");
                List<string> workStatusList = new List<string>();
                workStatusList.Add(Constants.Constants.FRESHER);
                workStatusList.Add(Constants.Constants.EXPERIENCED);

                //Print work Status List
                Utility.Utility.PrintListValues(workStatusList);

                Console.Write("Select value for Work Status(EX: 1 for Fresher): ");
                int workStatusOutput = 0;
                bool isWorkStatusValid = int.TryParse(Console.ReadLine(), out workStatusOutput);
                string workStatusValue = string.Empty;
                if (isWorkStatusValid)
                {
                    switch (workStatusOutput)
                    {
                        case (int)Enums.WorkStatus.Fresher:
                            workStatusValue = Constants.Constants.FRESHER;
                            break;
                        case (int)Enums.WorkStatus.Experienced:
                            workStatusValue = Constants.Constants.EXPERIENCED;
                            break;
                        default:
                            validations.Append("Unknown value for Work Status is selected.\n");
                            break;
                    }
                    personalDetails.WorkStatus = workStatusValue;
                }
                else
                    validations.Append("Please select integer value for Work Status(EX: 1 for Fresher)\n");
                Console.WriteLine();
                Console.WriteLine("Different values for Notice Perod :");
                List<string> noticePeriodList = new List<string>();
                noticePeriodList.Add(Constants.Constants.FIFTEEN_DAYS_OR_LESS);
                noticePeriodList.Add(Constants.Constants.ONE_MONTH);
                noticePeriodList.Add(Constants.Constants.TWO_MONTHS);
                noticePeriodList.Add(Constants.Constants.THREE_MONTHS);
                noticePeriodList.Add(Constants.Constants.MORE_THAN_THREE_MONTHS);

                //Print Notice Period List
                Utility.Utility.PrintListValues(noticePeriodList);

                Console.Write("Select value for Notice Period(EX: 1 for 15 Days or Less): ");
                int noticePeriodOutput = 0;
                bool isNoticePeriodValid = int.TryParse(Console.ReadLine(), out noticePeriodOutput);
                string noticePeriodValue = string.Empty;
                if (isNoticePeriodValid)
                {
                    switch (noticePeriodOutput)
                    {
                        case (int)Enums.NoticePeriod.Fifteen_Days_OR_Less:
                            noticePeriodValue = Constants.Constants.FIFTEEN_DAYS_OR_LESS;
                            break;
                        case (int)Enums.NoticePeriod.One_Month:
                            noticePeriodValue = Constants.Constants.ONE_MONTH;
                            break;
                        case (int)Enums.NoticePeriod.Two_Months:
                            noticePeriodValue = Constants.Constants.TWO_MONTHS;
                            break;
                        case (int)Enums.NoticePeriod.Three_Months:
                            noticePeriodValue = Constants.Constants.THREE_MONTHS;
                            break;
                        case (int)Enums.NoticePeriod.More_Than_Three_Months:
                            noticePeriodValue = Constants.Constants.MORE_THAN_THREE_MONTHS;
                            break;
                        default:
                            validations.Append("Unknown Value for Notice Period is selected.");
                            break;
                    }
                    personalDetails.NoticePeriod = noticePeriodValue;
                }
                else
                    validations.Append("Please select integer value for Notice Period(EX: 1 for 15 Days or Less)\n");



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
            return personalDetails;
        }


            /// <summary>
            /// Method that writes/prints Candidate personal details to the Console Screen
            /// </summary>
            public void PrintPersonalDetails(PersonalDetails details)
            {
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("Personal Details :");

                    Console.WriteLine($"Name : {details.FirstName}{details.MiddleName} {details.LastName}");
                    Console.WriteLine($"Gender : {details.Gender}");
                    Console.WriteLine($"Candidate Type : {details.CandidateType}");
                    Console.WriteLine($"Marital Status : {details.MaritalStatus}");
                    Console.WriteLine($"Date of Birth : {details.DateOfBirth}");
                    Console.WriteLine($"Category : {details.Category}");
                    Console.WriteLine($"Work Permit USA: {details.WorkPermitUSA}");
                    Console.WriteLine($"Work Permit for Other Countries : {details.WorkPermitOtherCountries}");
                    Console.WriteLine($"Work Status : {details.WorkStatus}");
                    Console.WriteLine($"Notice Period : {details.NoticePeriod}");


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
