using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate.BusinessLogic
{
    public  class KeySkillsService
    {
        /// <summary>
        /// 
        /// </summary>
        public List<Skill> ReadKeySkills()
        {

            List<Skill> skills = new List<Skill>();
            StringBuilder validations = new StringBuilder();
            try
            {
                bool candidateChoice = false;
                do
                {
                    Skill skill = new Skill();
                    if (skills.Count == 0)
                        Console.WriteLine("\nProvide Skills Details :");
                    else
                        Console.WriteLine("\nProvide one more Language Details :");

                    Console.Write("Enter Skill Name :");
                    string skillName = Console.ReadLine();

                    if (!string.IsNullOrEmpty(skillName))
                        skill.SkillName = skillName;
                    else
                        validations.Append("Skill value is missing.\n");
                    Console.WriteLine();
                    Console.Write("Would you like to add one more Skill?(Yes/No):");
                    string candidateWish = Console.ReadLine();

                    if (candidateWish == "Yes")
                        candidateChoice = true;
                    else
                        candidateChoice = false;

                    skills.Add(skill);
                    Console.WriteLine();

                    if (skills.Count == 5)
                    {
                        candidateChoice = false;
                        Console.WriteLine("\nYou can only add maximum of 5 Skills.\n");
                    }

                } while (candidateChoice == true);


                //Validations Errors  Displayed here
                //if (!string.IsNullOrEmpty(validations.ToString()))
                //{
                //    Console.WriteLine($"\n\nValidation Errors:\n{validations}");
                //}



            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception Message: {0}", ex.Message);
                Console.WriteLine();
                Console.WriteLine("Exception Trace: {0}", ex.StackTrace);
            }
            return skills;
        }

        public void PrintKeySkills(List<Skill> skills)
        {
            try
            {
                Console.WriteLine("Candidate Skills:");
                Console.WriteLine();
                int increment = 0;

                foreach(Skill skill in skills)
                {
                    increment++;
                    Console.WriteLine();
                    Console.WriteLine($"Skill {increment}: {skill.SkillName}");
                }

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
