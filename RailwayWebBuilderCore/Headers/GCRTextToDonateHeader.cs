using eWolfBootstrap.Interfaces;
using System.Collections.Generic;

namespace RailwayWebBuilderCore.Headers
{
    public class GCRTextToDonateHeader : HeaderBase, IPageHeader
    {
        public GCRTextToDonateHeader()
        {
            Title = "GCR Text To Donate";
            Keywords = new List<string>
            {
                "Reunification",
            };
            Description = "Text To Donate";

            ExtraIncludes.Add(eWolfBootstrap.Enums.BootstrapOptions.CHART);
        }
    }
}