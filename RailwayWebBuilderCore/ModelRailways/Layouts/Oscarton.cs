﻿using RailwayWebBuilderCore.Data;

namespace RailwayWebBuilderCore.ModelRailways.Layouts
{
    internal class Oscarton : LayoutBase
    {
        public Oscarton()
        {
            Name = LayoutNamesEnums.Oscarton;
            Gauge = Gauges.N_Gauge;
            Owner = "Robin Sharman";
            Description = "Oscarton station is a four platform terminus served exclusively by DMUs, and has working colour\r\nlight signals positioned at the platform ends. The track plan comprises two interwoven shuttle\r\nlines - one automatic and the other manually controlled.";
        }
    }
}