using eWolfBootstrap.Builders;
using eWolfBootstrap.Chats;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.Services;
using System.Collections.Generic;
using System.Linq;

namespace RailwayWebBuilderCore.Builders.Locomotive
{
    public class AllLocomotiveBuilder : LocomotiveDetailsBase, ILocomotiveDetailsPages
    {
        public string HtmlFileName { get; } = "AllLocomotives.html";
        public string PageTitle { get; } = "All Locomotives";

        public void Build()
        {
            _pageBuilder = new PageBuilder(HtmlFileName, LocalPath, new AllLocosDetailsHeader(), "../");

            _pageBuilder.Append(NavBarHelper.NavBar("../"));
            AddBreadCrumb(this);

            _pageBuilder.Append("<div class='container mt-4'>");

            _pageBuilder.Append("<div class='row mb-2'>");

            var ldb = LocomotiveDBServices.GetDBServices();
            var locos = ldb.FullList;

            var th = new SortableTableHolder();

            th.Header(new string[] { "Name", "Build date", "Operators", "Whyte", "Total Produced", "Power Class", "Tractive Effort" });

            var orderedByDate = locos.OrderBy(x => x.BuildDateTime);

            foreach (var loco in orderedByDate)
            {
                List<string> locoFields = new List<string>
                {
                    loco.Name,
                    loco.BuildDateTime.ToString("yyyy"),
                    loco.Operators,
                    loco.Whyte,
                    loco.TotalProduced.ToString(),
                    loco.PowerClass.ToString(),
                    loco.TractiveEffort.ToString()
                };

                th.AddRow(locoFields.ToArray());
            }

            _pageBuilder.Append(th.Output());

            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");

            _pageBuilder.Output();
        }
    }
}
