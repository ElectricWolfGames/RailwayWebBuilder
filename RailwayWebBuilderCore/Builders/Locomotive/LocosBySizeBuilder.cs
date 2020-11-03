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
    public class LocosBySizeBuilder : LocomotiveDetailsBase, ILocomotiveDetailsPages
    {
        public string HtmlFileName { get; } = "BySize.html";
        public string PageTitle { get; } = "Loco by size";

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

            th.Header(new string[] { "Name", "Whyte", "Length", "Axle Load" });

            IOrderedEnumerable<HtmlTableExtractLoco> orderedByDate = locos.OrderBy(x => x.BuildDateTime);

            foreach (var loco in orderedByDate)
            {
                if (string.IsNullOrWhiteSpace(loco.Length))
                {
                    continue;
                }
                List<string> locoFields = new List<string>();
                locoFields.Add(loco.Name);
                locoFields.Add(loco.Whyte);
                locoFields.Add(loco.Length);
                locoFields.Add(loco.Axleload);
                th.AddRow(locoFields.ToArray());
            }

            _pageBuilder.Append(th.Output());

            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");

            _pageBuilder.Output();
        }
    }
}
