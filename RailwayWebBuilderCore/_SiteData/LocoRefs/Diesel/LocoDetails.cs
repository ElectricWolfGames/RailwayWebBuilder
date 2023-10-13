namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class LocoDetails : ILocoDetails
    {
        public LocoDetails(string number)
        {
            Number = number;
        }

        public string Number { get; set; }
    }
}