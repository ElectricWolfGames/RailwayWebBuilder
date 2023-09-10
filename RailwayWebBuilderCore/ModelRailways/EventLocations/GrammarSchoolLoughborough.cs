using RailwayWebBuilderCore.Data;
using System.Windows.Controls;

namespace RailwayWebBuilderCore.ModelRailways.EventLocations
{
    public class GrammarSchoolLoughborough : EventLocationsBase
    {
        public GrammarSchoolLoughborough()
        {
            Name = "Grammar School, Loughborough";
            LatitudeLongitude = new LatitudeLongitude(52.765786, -1.199820);
            Address = "LOUGHBOROUGH Grammar School, Leicester Road , Loughborough , Leicestershire, LE11 2AQ";
            PostCode = "LE11 2AQ";
        }
    }
}