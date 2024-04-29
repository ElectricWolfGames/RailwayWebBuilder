using System;

namespace RailwayWebBuilderCore.Attributes
{
    public class DescriptionAttribute : Attribute
    {
        public static readonly DescriptionAttribute Default;
        public string Description;

        public DescriptionAttribute(string description)
        {
            Description = description;
        }
    }
}