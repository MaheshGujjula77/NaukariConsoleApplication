using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate.BusinessLogic
{
    public class LanguagesService
    {
        public List<Language> ReadLanguages()
        {
            List<Language> languages = new List<Language>();
            StringBuilder validations = new StringBuilder();
            try
            {
                bool candidateChoice = false;
                do
                {
                    Language language = new Language();
                    if (languages.Count == 0)
                        Console.WriteLine("\nProvide Language Details :");
                    else
                        Console.WriteLine("\nProvide one more Language Details :");

                    Console.Write("Enter Language Name :");
                    string languageName = Console.ReadLine();

                    if (!string.IsNullOrEmpty(languageName))
                        language.LanguageName = languageName;
                    else
                        validations.Append("Candidate Language Name is missing.\n");
                    Console.WriteLine();
                    Console.WriteLine("Different Values for Proficiency :");
                    List<string> proficiencyList = new List<string>();
                    proficiencyList.Add(Constants.Constants.BEGINNER);
                    proficiencyList.Add(Constants.Constants.PROFICIENT);
                    proficiencyList.Add(Constants.Constants.EXPERT);

                    //Print Language Proficiency List 
                    Utility.Utility.PrintListValues(proficiencyList);

                    Console.Write("Select value for Proficiency(Ex: 1 for Beginner): ");
                    int proficiencyOutput = 0;
                    bool isProficiency = int.TryParse(Console.ReadLine(), out proficiencyOutput);
                    string proficiency = string.Empty;

                    if (isProficiency)
                    {
                        switch (proficiencyOutput)
                        {
                            case (int)Enums.Proficiency.Beginner:
                                proficiency = Constants.Constants.BEGINNER;
                                break;
                            case (int)Enums.Proficiency.Proficient:
                                proficiency = Constants.Constants.PROFICIENT;
                                break;
                            case (int)Enums.Proficiency.Expert:
                                proficiency = Constants.Constants.EXPERT;
                                break;
                            default:
                                validations.Append("Unknown value for Proficiency is selected.\n");
                                break;
                        }
                        language.Proficiency = proficiency;
                    }
                    else
                        validations.Append("Please select integer value for Proficiency(EX: 1 for Beginner)\n");
                    Console.WriteLine();
                    Console.WriteLine("Different Values for Can You Read?:");
                    List<string> readList = new List<string>();
                    readList.Add(Constants.Constants.YES);
                    readList.Add(Constants.Constants.NO);

                    //Print Language Read List
                    Utility.Utility.PrintListValues(readList);

                    Console.Write("Select values for Can You Read?(EX: 1 for Yes): ");
                    int readOutput = 0;
                    bool isReadLanguage = int.TryParse(Console.ReadLine(), out readOutput);
                    string readLanguage = string.Empty;

                    if (isReadLanguage)
                    {
                        switch (readOutput)
                        {
                            case (int)Enums.ReadLanguage.Yes:
                                readLanguage = Constants.Constants.YES;
                                break;
                            case (int)Enums.ReadLanguage.No:
                                readLanguage = Constants.Constants.NO;
                                break;
                            default:
                                validations.Append("Unknown value for Read Language is selected.\n ");
                                break;
                        }
                        language.Read = readLanguage;
                    }
                    else
                        validations.Append("Please select integer value for Read Language(Ex: 1 for Yes)\n");
                    Console.WriteLine();
                    Console.WriteLine("Different Values for Can You Speak?:");
                    List<string> speakList = new List<string>();
                    speakList.Add(Constants.Constants.YES);
                    speakList.Add(Constants.Constants.NO);

                    //Print Language Read List
                    Utility.Utility.PrintListValues(speakList);

                    Console.Write("Select values for Can You Speak?(EX: 1 for Yes): ");
                    int speakOutput = 0;
                    bool isSpeakLanguage = int.TryParse(Console.ReadLine(), out speakOutput);
                    string speakLanguage = string.Empty;

                    if (isSpeakLanguage)
                    {
                        switch (speakOutput)
                        {
                            case (int)Enums.SpeakLanguage.Yes:
                                speakLanguage = Constants.Constants.YES;
                                break;
                            case (int)Enums.SpeakLanguage.No:
                                speakLanguage = Constants.Constants.NO;
                                break;
                            default:
                                validations.Append("Unknown value for Speak Language is selected.\n ");
                                break;
                        }
                        language.Speak = speakLanguage;
                    }
                    else
                        validations.Append("Please select integer value for Speak Language(Ex: 1 for Yes)\n");
                    Console.WriteLine();
                    Console.WriteLine("Different Values for Can You Write?:");
                    List<string> writeList = new List<string>();
                    writeList.Add(Constants.Constants.YES);
                    writeList.Add(Constants.Constants.NO);

                    //Print Language Read List
                    Utility.Utility.PrintListValues(speakList);

                    Console.Write("Select values for Can You Write?(EX: 1 for Yes): ");
                    int writeOutput = 0;
                    bool isWriteLanguage = int.TryParse(Console.ReadLine(), out writeOutput);
                    string writeLanguage = string.Empty;

                    if (isWriteLanguage)
                    {
                        switch (writeOutput)
                        {
                            case (int)Enums.WriteLanguage.Yes:
                                writeLanguage = Constants.Constants.YES;
                                break;
                            case (int)Enums.WriteLanguage.No:
                                writeLanguage = Constants.Constants.NO;
                                break;
                            default:
                                validations.Append("Unknown value for Write Language is selected.\n ");
                                break;
                        }
                        language.Write = writeLanguage;
                    }
                    else
                        validations.Append("Please select integer value for Write Language(Ex: 1 for Yes)\n");
                    Console.WriteLine();
                    Console.Write("Would you like to add one more Language?(Yes/No):");
                    string candidateWish = Console.ReadLine();

                    if (candidateWish == "Yes")
                        candidateChoice = true;
                    else
                        candidateChoice = false;

                    languages.Add(language);
                    Console.WriteLine();

                    if (languages.Count == 5)
                    {
                        candidateChoice = false;
                        Console.WriteLine("\nYou can only add maximum of 5 Languages.\n");
                    }
                }while(candidateChoice == true);

                //Validations Errors  Displayed here
                //if (!string.IsNullOrEmpty(validations.ToString()))
                //{
                //    Console.WriteLine($"\n\nValidation Errors:\n{validations}");
                //}



            }

            catch (Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
                Console.WriteLine();
                Console.WriteLine("Exception Trace: {0}", ex.StackTrace);
            }
            return languages;
        }

        public void PrintLanguages(List<Language> languages)
        {
            try
            {
                Console.WriteLine("Candidate Languages:");
                Console.WriteLine();
                int increment = 0;
                foreach(Language language in languages)
                {
                    increment++;
                    Console.WriteLine();
                    Console.WriteLine($"Language {increment}: {language.LanguageName}");
                    Console.WriteLine($"Proficiency : {language.Proficiency}");
                    Console.WriteLine($"Read : {language.Read}");
                    Console.WriteLine($"Write : {language.Write}");
                    Console.WriteLine($"Speak : {language.Speak}");

                }

            }
            catch( Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
                Console.WriteLine();
                Console.WriteLine("Exception Trace: {0}", ex.StackTrace);
            }
        }
    }
}
