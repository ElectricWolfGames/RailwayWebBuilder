using eWolfBootstrap.Interfaces;
using System.Collections.Generic;

namespace RailwayWebBuilderCore.Headers
{
    public class MyLayoutHeader : HeaderBase, IPageHeader
    {
        public MyLayoutHeader()
        {
            Title = "My Layouts";
            Keywords = new List<string>
            {
                "Model Trains",
                "Model railway",
                "Home layout"
            };
            Description = "Home model railway";

            ExtraIncludes.Add(eWolfBootstrap.Enums.BootstrapOptions.GALLERY);
        }
    }
}