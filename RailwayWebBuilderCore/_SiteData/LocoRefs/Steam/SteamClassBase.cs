using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Configuration;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam
{
    public class SteamClassBase : DieselClassBase
    {
        public override string GetRawImagePath(string locoNo)
        {
            return Constants.RawDataPath + @$"\Locos\{locoNo}\";
        }
    }
    public class WagonsClassBase : DieselClassBase
    {
        public override string GetRawImagePath(string locoNo)
        {
            return Constants.RawDataPath + @$"\Locos\_Wagons\{locoNo}\";
        }
    }
}