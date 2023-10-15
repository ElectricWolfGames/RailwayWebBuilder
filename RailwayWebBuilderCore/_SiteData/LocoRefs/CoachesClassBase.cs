using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore._SiteData.LocoRefs
{
    public class CoachesClassBase : DieselClassBase
    {
        public override string GetRawImagePath(string locoNo)
        {
            return Constants.RawDataPath + @$"\Locos\_Coaches\{locoNo}\";
        }
    }
}