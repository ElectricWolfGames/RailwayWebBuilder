﻿using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.KeepForNow;
using System.Collections.Generic;

namespace RailwayWebBuilderCore.Data
{
    public class LayoutDetails
    {
        public LayoutDetails(string name, Gauges gauge)
        {
            Name = name;
            Gauge = gauge;
        }

        public LayoutDetails(LayoutNamesEnums name)
        {
            NameEnum = name;
            var (a, b) = ItemHelper.GetEnumDescription(name);
            Name = a;
            Gauge = b;
            GaugeName = ItemHelper.GetEnumGaugeDescription(Gauge);

            Path = Name;
        }

        public LayoutDetails(string name, Gauges gauge, bool setPath)
        {
            Name = name;
            Gauge = gauge;
            GaugeName = ItemHelper.GetEnumGaugeDescription(Gauge);

            if (setPath)
                Path = Name;
        }

        public LayoutDetails(string name, Gauges gauge, string path)
        {
            Name = name;
            Gauge = gauge;
            GaugeName = ItemHelper.GetEnumGaugeDescription(Gauge);
            Path = path;
        }

        public Gauges Gauge { get; private set; }
        public string GaugeName { get; private set; }

        public string IDName
        {
            get
            {
                return Name.Replace(" ", "-");
            }
        }

        public List<string> ImagePaths { get; set; } = new List<string>();
        public string Name { get; set; }
        public LayoutNamesEnums NameEnum { get; private set; }
        public string Path { get; private set; }
    }
}