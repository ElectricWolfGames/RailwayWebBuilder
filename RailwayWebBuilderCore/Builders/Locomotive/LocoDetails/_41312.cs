using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore.Builders.Locomotive.LocoDetails
{
    public class _41312 : LocomotiveDetailsBase
    {
        public _41312()
        {
            Title = "41312, LMS Ivatt Class 2, 2-6-2T";
            PageTitle = "41312";
            HtmlFileName = $"{PageTitle}.html";
            RawImagePath = Constants.RawDataPath + @"\Locos\41312\";
            ExportImagePath = Constants.LocoRef + "images\\41312\\";
            Paragraph1 = "Number 41241 was built by British Railways at Crewe Works in September 1949. " +
                "From new it was allocated to Bath Green Park on the Somerset and Dorset Joint Railway " +
                "and saw use on local passenger services over the S&D including the occasional banking job. " +
                "Alongside spending the first 9 years allocated to the S&D it was reallocated to Bristol Barrow Road in July 1958, " +
                "this however was not to last for long and it returned to its former home at Bath Green Park in October 1958 " +
                "(by then under the control of the Western Region of British Railways).";
            Paragraph2 = "Other shed allocations it was based at included: " +
                "Wellington, Leamington Spa, Bangor, Croes Newydd, Llandudno Junction and Skipton. " +
                "Following its allocation to Wellington, it was transferred back to the London Midland Region " +
                "and was allocated to Leamington from February 1964. " +
                "The final shed allocation was to Skipton, and it was to remain there for the rest of its working days on BR until 10 December 1966 " +
                "when it was withdrawn from service.";
            Order = 1;
            StockType = StockTypes.SteamLoco;
            FindTags = "41312,LMSIvattClass2,2-6-2T";

            Keywords.Add("Bath Green Park");
            Keywords.Add("Leamington Spa");
            Keywords.Add("Croes Newydd");
            Keywords.Add("H. G. Ivatt");
        }
    }
}