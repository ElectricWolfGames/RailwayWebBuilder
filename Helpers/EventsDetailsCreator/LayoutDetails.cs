
namespace LayoutHelper
{
    internal class LayoutDetails
    {
        public string Name { get; set; }
        public string Gauge { get; set; } = "Unset";
        public string EnumName { get; set; }

        internal void SetGauge(string raw)
        {
            if (raw.Contains("TT:120"))
            {
                Gauge = "Gauges.TT120_Gauge";
                return;
            }
            if (raw.Contains("OO9 Gauge"))
            {
                Gauge = "Gauges.OO9_Gauge";
                return;
            }
            if (raw.Contains("N Gauge"))
            {
                Gauge = "Gauges.N_Gauge";
                return;
            }
            if (raw.Contains("OO Gauge"))
            {
                Gauge = "Gauges.OO_Gauge";
                return;
            }
            if (raw.Contains("Demo"))
            {
                Gauge = "Gauges.NONE";
                return;
            }
            if (raw.Contains("32mm Gauge"))
            {
                Gauge = "Gauges._32mm_Gauge";
                return;
            }
            if (raw.Contains("HOe Gauge"))
            {
                Gauge = "Gauges.HOe_Gauge";
                return;
            }
            if (raw.Contains("45mm Gauge"))
            {
                Gauge = "Gauges._45mm";
                return;
            }
            if (raw.Contains("O Gauge"))
            {
                Gauge = "Gauges.O_Gauge";
                return;
            }

            if (raw.Contains("33mm Gauge"))
            {
                Gauge = "Gauges._33mm_Gauge";
                return;
            }
            if (raw.Contains("OO/009 Gauge"))
            {
                Gauge = "Gauges.OO_Gauge";
                return;
            }

            if (raw.Contains("9mm Gauge"))
            {
                Gauge = "Gauges._9mm";
                return;
            }

            int i = 0;
            i++;
        }
    }
}