using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate.BusinessLogic
{
    public class AccomplishmentsService
    {
       public Accomplishments ReadAccomplishments()
        {
            Accomplishments accomplishments = new Accomplishments();

            Console.WriteLine("Accomplishments :");
            OnlineProfileDetailsService onlineProfileDetailsService = new OnlineProfileDetailsService();
            accomplishments.OnlineProfileDetails = onlineProfileDetailsService.ReadOnlineProfileDetails();

            WorkSampleDetailsService workSampleDetailsService = new WorkSampleDetailsService();
            accomplishments.WorkSampleDetails = workSampleDetailsService.ReadWorkSampleDetails();

            ResearchPublicationDetailsService researchPublicationDetailsService = new ResearchPublicationDetailsService();
            accomplishments.ResearchPublicationDetails = researchPublicationDetailsService.ReadResearchPublicationDetails();

            PresentationDetailsService presentationDetailsService = new PresentationDetailsService();
            accomplishments.PresentationDetails = presentationDetailsService.ReadPresentationDetails();

            PatentDetailsService patentDetailsService = new PatentDetailsService();
            accomplishments.PatentDetails = patentDetailsService.ReadPatentDetails();

            CertificationDetailsService certificationDetailsService = new CertificationDetailsService();
            accomplishments.CertificationDetails = certificationDetailsService.ReadCertificationDetails();


            return accomplishments;

        }


        public void PrintAccomplishments(Accomplishments accomplishments)
        {
            Console.WriteLine("Accomplishments :");
            Console.WriteLine("--------------------------");
            OnlineProfileDetailsService onlineProfileDetailsService = new OnlineProfileDetailsService();
            onlineProfileDetailsService.PrintOnlineProfileDetails(accomplishments.OnlineProfileDetails);

            ResearchPublicationDetailsService researchPublicationDetailsService = new ResearchPublicationDetailsService();
            researchPublicationDetailsService.PrintResearchPublicationDetails(accomplishments.ResearchPublicationDetails);

            WorkSampleDetailsService workSampleDetailsService = new WorkSampleDetailsService();
            workSampleDetailsService.PrintWorkSampleDetails(accomplishments.WorkSampleDetails);

            PresentationDetailsService presentationDetailsService = new PresentationDetailsService();
            presentationDetailsService.PrintPresentationDetails(accomplishments.PresentationDetails);

            PatentDetailsService patentDetailsService = new PatentDetailsService();
            patentDetailsService.PrintPatentDetails(accomplishments.PatentDetails);

            CertificationDetailsService certificationDetailsService = new CertificationDetailsService();
            certificationDetailsService.PrintCertificationDetails(accomplishments.CertificationDetails);

        }
    }
}


