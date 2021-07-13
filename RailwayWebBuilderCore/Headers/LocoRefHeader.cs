using eWolfBootstrap.Interfaces;
using System.Collections.Generic;

namespace RailwayWebBuilderCore.Headers
{
    public class LocoRefHeader : HeaderBase, IPageHeader
    {
        public LocoRefHeader()
        {
            Title = "Locomotive photo ref";
            Keywords = new List<string>
            {
                "Loco",
                "Train",
                "Locomotive",
            };
            Description = "Locomotive photo Reference Collection";

            ExtraIncludes.Add(eWolfBootstrap.Enums.BootstrapOptions.GALLERY);
        }
    }
}