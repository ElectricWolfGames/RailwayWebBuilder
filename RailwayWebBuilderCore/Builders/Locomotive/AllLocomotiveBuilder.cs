using eWolfBootstrap.Builders;
using eWolfBootstrap.Chats;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.LocoDetails;
using RailwayWebBuilderCore.Services;
using System;
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

            var locos = new List<HtmlTableExtractLoco>();

            IEnumerable<Locos> values = Enum.GetValues(typeof(Locos)).Cast<Locos>();
            foreach (Locos loc in values)
            {
                locos.Add(LocomotivesServices.Get(loc));
            }

            var th = new SortableTableHolder();

            th.Header(new string[] { "Name", "Build date", "Whyte", "Total Produced", "Power Class", "Tractive Effort" });

            var orderedByDate = locos.OrderBy(x => x.BuildDateTime);

            foreach (var loco in orderedByDate)
            {
                List<string> locoFields = new List<string>();
                locoFields.Add(loco.Name);
                locoFields.Add(loco.BuildDateTime.ToString("yyyy"));
                locoFields.Add(loco.Whyte);
                locoFields.Add(loco.TotalProduced.ToString());
                locoFields.Add(loco.PowerClass.ToString());
                locoFields.Add(loco.TractiveEffort.ToString());

                th.AddRow(locoFields.ToArray());
            }

            _pageBuilder.Append(th.Output());

            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");

            _pageBuilder.Output();
        }
    }
}
