using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;

namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts
{
    internal class NewDalbyResearchDivision : LayoutBase, ILayoutByLayoutSetA
    {
        public NewDalbyResearchDivision()
        {
            Name = LayoutNamesEnums.NewDalbyResearchDivision;
            Owner = "Andrew Porter";
            Description = "New Dalby is a fictitious replacement for the current, existing Railway Technical Centre at Derby. Due to the RTC occupying prime land near the centre of Derby. the outfit has been uprooted and relocated to the former Asfordby Super-pit, and Holwell Steel Works sites. at the foot of the Old Dalby Test Track, near Melton Mowbray in Leicestershire, with the former site being sold off for student accommodation. The layout represents a slice of a much larger complex which, all together, forms Network Rail's new Rail Research and Testing Facility. The centre operates and maintains Network Rail's fleet of measurement vehicles and also provides a certain degree of workforce development from this central location which also boasts its very own dedicated, 13.5 mile-long test track, allowing measurement vehicle calibration and testing to be carried out off-network and out of the way of revenue-earning flows.";
            LayoutByLayoutVideo = "https://youtu.be/Kcrtbzv7rd4";
        }
    }
}