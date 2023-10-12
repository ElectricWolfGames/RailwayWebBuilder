namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class DieselClass10 : DieselClassBase
    {
        public DieselClass10()
        {
            ClassName = "Class 10";
            Paragraph1 = "The British Rail Class 10 diesel locomotive was a variation on the Class 08 diesel-electric shunter in which a Blackstone diesel engine was fitted instead of one made by the English Electric company. Traction motors were by the General Electric Company plc (GEC); the class D3/5 were similar, but had British Thomson-Houston (BTH) traction motors";
            Paragraph2 = "The locomotives were built at the BR Works in Darlington and Doncaster over the period 1955–1962. At first they were classified D3/4, then 3/1C before becoming Class 10 under TOPS";

            LocoNumbers.AddRange(new[] {
                new LocoDetails("10119"),
                new LocoDetails("D4067")
            }
            );
        }
    }
}