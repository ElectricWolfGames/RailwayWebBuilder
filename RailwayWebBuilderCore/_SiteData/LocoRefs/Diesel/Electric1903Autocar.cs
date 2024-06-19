using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Diesel
{
    public class Electric1903Autocar : DieselClassBase
    {
        public Electric1903Autocar()
        {
            ClassName = "1903 Autocar";
            StockType = StockTypes.Electric;

            Paragraph1 = "The Trust has restored the original body to its rebuilt 1923 form, this involved re-uniting the body halves (it was cut in two to facilitate movement to its holiday home site at Keldholme), repairing damage to some window pillars and thoroughly overhauling the rest of the body structure.";
            Paragraph2 = "The 1903 Petrol Electric Autocars were built by the North Eastern Railway in 1903 at their carriage works in York. These were powered by petrol engines which generated electricity for two traction motors which were mounted on the bogie underneath. This means of powering a railway vehicle was pioneering and would eventually be developed into the diesel-electric technology that powered and powers many locomotives worldwide. The railcars were numbered 3170 and 3171 and were 53.5 feet (16.3 m) long and weighed around 35 long tons (36 t) . The engine was mounted in an engine compartment 13.25 feet (4.04 m) long. The rest of the vehicles' length was taken up by a vestibule, driving compartment and a 52-seat passenger compartment. Two were built and ran until 1930; one has been restored and preserved in working order.";

            Keywords.Add("");

            LocoNumbers.AddRange(new[]
            {
                new LocoDetails("3170"),
                });
        }
    }
}