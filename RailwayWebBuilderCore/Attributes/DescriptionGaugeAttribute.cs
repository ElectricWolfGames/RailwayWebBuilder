using RailwayWebBuilderCore.Enums;
using System;

namespace RailwayWebBuilderCore.Attributes;

public class DescriptionGaugeAttribute : Attribute
{
    public static readonly DescriptionGaugeAttribute Default;
    public string Description;
    public Gauges Gauge;

    public DescriptionGaugeAttribute(string description, Gauges gauge)
    {
        Description = description;
        Gauge = gauge;
    }
}