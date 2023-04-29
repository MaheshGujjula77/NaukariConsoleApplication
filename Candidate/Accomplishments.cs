namespace Candidate
{
    /// <summary>
    /// Class that Candidate Accomplishment Details
    /// </summary>
    public class Accomplishments
    {
        public OnlineProfileDetails OnlineProfileDetails { get; set; }
        public WorkSampleDetails WorkSampleDetails { get; set; }
        public ResearchPublicationDetails ResearchPublicationDetails { get; set; }
        public PresentationDetails PresentationDetails { get; set; }
        public PatentDetails PatentDetails { get; set; }
        public CertificationDetails CertificationDetails { get; set; }
    }
}
