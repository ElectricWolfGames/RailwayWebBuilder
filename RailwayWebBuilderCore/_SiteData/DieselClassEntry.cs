using RailwayWebBuilderCore._SiteData.LocoRefs;
using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RailwayWebBuilderCore._SiteData;

public class DieselClassEntry
{
    public string ClassName { get; init; } = string.Empty;
    public string Designer { get; init; } = string.Empty;
    public string Builder { get; init; } = string.Empty;
    public string WheelArrangement { get; init; } = string.Empty;
    public string Engine { get; init; } = string.Empty;
    public string Power { get; init; } = string.Empty;
    public string MaxSpeed { get; init; } = string.Empty;
    public string TractiveEffort { get; init; } = string.Empty;
    public string LocoWeight { get; init; } = string.Empty;
    public string Length { get; init; } = string.Empty;
    public string BuildDate { get; init; } = string.Empty;
    public int TotalProduced { get; init; }
    public string PowerType { get; init; } = string.Empty;
    public string FirstLocoNumber { get; init; } = string.Empty;

    public static List<DieselClassEntry> BuildAll()
    {
        var entries = new List<DieselClassEntry>();
        foreach (var type in Assembly.GetExecutingAssembly().GetTypes()
            .Where(t => t.IsSubclassOf(typeof(DieselClassBase))
                     && !t.IsSubclassOf(typeof(SteamClassBase))
                     && !t.IsAbstract))
        {
            try
            {
                var dc = (DieselClassBase)Activator.CreateInstance(type);
                entries.Add(new DieselClassEntry
                {
                    ClassName = dc.ClassName,
                    Designer = dc.Designer,
                    Builder = dc.Builder,
                    WheelArrangement = dc.WheelArrangement,
                    Engine = dc.Engine,
                    Power = dc.Power,
                    MaxSpeed = dc.MaxSpeed,
                    TractiveEffort = dc.TractiveEffort,
                    LocoWeight = dc.LocoWeight,
                    Length = dc.Length,
                    BuildDate = dc.BuildDate,
                    TotalProduced = dc.TotalProduced,
                    PowerType = dc.PowerType,
                    FirstLocoNumber = dc.LocoNumbers.Count > 0 ? dc.LocoNumbers[0].Number : string.Empty,
                });
            }
            catch { }
        }
        return entries.OrderBy(e => e.ClassName).ToList();
    }
}
