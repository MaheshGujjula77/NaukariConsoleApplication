using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate.BusinessLogic.Constants
{
    public class Constants
    {
        //Gender Configurations
        public const string MALE = "Male";
        public const string FEMALE = "Female";
        public const string TRANSGENDER = "Transgender";


        //Candidate Type Configurations
        public const string SINGLE_PARENT = "Single Parent";
        public const string WORKING_MOTHER = "Working Mother";
        public const string SERVED_IN_MILITARY = "Served in Military";
        public const string RETIRED = "Retired(60+)";
        public const string LGBTQ = "LGBTQ+";


        //Marital Status Configurations
        public const string MARRIED = "Married";
        public const string UNMARRIED = "Unmarried";
        public const string WIDOWED = "Widowed";
        public const string DIVORCED = "Divorced";
        public const string OTHER = "other";


        // Category Configurations
        public const string GENERAL = "General";
        public const string SCHEDULED_CASTE = "Scheduled Caste (SC)";
        public const string SCHEDULED_TRIBE = "Scheduled Tribe (ST)";
        public const string OBC_CREAMY = "OBC - Creamy";
        public const string OBC_NON_CREAMY = "OBC - Non creamy";

        //Differently Abled Configurations
        public const string YES = "Yes";
        public const string NO = "No";

        // Work Permit USA Configurations
        public const string Have_US_H1_Visa = "Have US H1 Visa";
        public const string Need_US_H1_Visa = "Need US H1 Visa";
        public const string US_TN_Permit_Holder = "US TN Permit ";
        public const string US_Green_Card_Holder = "US Green Card Holder";
        public const string US_Citizen = "US Citizen";
        public const string Authorized_to_work_in_US = "Authorized to work in US";

        // Work Permit for Other Countries
        public const string INDIA = "India";
        public const string AUSTRALIA = "Australia";
        public const string NEW_ZEALAND = "New Zealand";
        public const string ENGLAND = "England";
        public const string GERMANY = "Germany";
        public const string USA = "USA";

        // Work Status Configurations
        public const string FRESHER = "Fresher";
        public const string EXPERIENCED = "Experienced";

        //Notice Period Configurations
        public const string FIFTEEN_DAYS_OR_LESS = "15 Days or Less";
        public const string ONE_MONTH = " 1 Month";
        public const string TWO_MONTHS = "2 Months";
        public const string THREE_MONTHS = "3 Months";
        public const string MORE_THAN_THREE_MONTHS = "More than 3 Months";

        // Patent Details Configurations
        public const string PATENT_ISSUED = "Patent Issued";
        public const string PATENT_PENDING = "Patent Pending";

        //Language Proficiency Configurations
        public const string BEGINNER = "Beginner";
        public const string PROFICIENT = "Proficient";
        public const string EXPERT = "Expert";

        // Project Tag with your Employment/Education Configurations
        public const string GRADUATION = "Graduation";
        public const string PG = "PG";
        public const string MPHIL = "Mphil";
        public const string PHD = "Phd";
        public const string PREVIOUS_COMPANY = "Previous Company";

        //Project Status Configurations
        public const string INPROGRESS = "IN Progress";
        public const string FINISHED = "Finished";

        //Project Site Configurations
        public const string ONSITE = "Onsite";
        public const string OFFSITE = "Offsite";

        //Employment Nature Configurations
        public const string FULLTIME = "Full Time";
        public const string PARTTIME = "Part Time";
        public const string CONTRACTUAL = "Contractual";

        //Project Role Configurations
        public const string DEVELOPER = "Developer";
        public const string TESTER = "Tester";
        public const string PROJECT_MANAGER = "Project Manager";
        public const string TECHNICAL_LEAD = "Technical Lead";
    }
}
