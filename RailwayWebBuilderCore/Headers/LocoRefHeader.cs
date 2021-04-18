using eWolfBootstrap.Interfaces;
using System.Collections.Generic;

namespace RailwayWebBuilderCore.Headers
{
    public class LocoRefHeader : HeaderBase, IPageHeader
    {
        public LocoRefHeader()
        {
            Title = "Loco ref";
            Keywords = new List<string>
            {
                "Loco",
                "Train",
            };
            Description = "Loco Reference Collection";

            ExtraIncludes.Add(eWolfBootstrap.Enums.BootstrapOptions.GALLERY);
        }
    }
}