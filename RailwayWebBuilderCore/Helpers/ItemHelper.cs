using RailwayWebBuilderCore.Attributes;
using RailwayWebBuilderCore.Enums;
using System;
using System.Linq;
using System.Reflection;

namespace RailwayWebBuilderCore.Helpers;

public static class ItemHelper
{
    public static (string, Gauges) GetEnumDescription(Enum value)
    {
        FieldInfo fi = value.GetType().GetField(value.ToString());

        DescriptionGaugeAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionGaugeAttribute), false) as DescriptionGaugeAttribute[];

        if (attributes != null && attributes.Any())
        {
            return (attributes.First().Description, attributes.First().Gauge);
        }

        return (value.ToString(), Gauges.NONE);
    }

    public static string GetEnumGaugeDescription(Gauges value)
    {
        FieldInfo fi = value.GetType().GetField(value.ToString());

        DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

        if (attributes != null && attributes.Any())
        {
            return attributes.First().Description;
        }
        return string.Empty;
    }
}