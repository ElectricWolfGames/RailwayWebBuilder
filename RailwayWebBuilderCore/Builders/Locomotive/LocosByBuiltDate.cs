using eWolfBootstrap.Builders;
using eWolfBootstrap.Chats;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.LocoDetails;
using RailwayWebBuilderCore.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RailwayWebBuilderCore.Builders.Locomotive
{
    public class LocosByBuiltDate
    {
        public static void Build()
        {
            string htmlpath = Constants.RootPath + "//" + Constants.Locomotive + "//";

            eWolfBootstrap.Interfaces.IPageBuilder pageBuilder = new PageBuilder("BuildDates.html", htmlpath, new AllLocosDetailsHeader(), "../");

            pageBuilder.Append(NavBarHelper.NavBar("../"));
            pageBuilder.Append("<div class='container mt-4'>");

            pageBuilder.Append("<div class='row mb-2'>");

            var locos = new List<HtmlTableExtractLoco>();

            IEnumerable<Locos> values = Enum.GetValues(typeof(Locos)).Cast<Locos>();
            foreach (Locos loc in values)
            {
                locos.Add(LocomotivesServices.Get(loc));
            }

            var th = new SortableTableHolder();

            th.Header(new string[] { "Name", "Build date", "Whyte", "Total Produced" });

            var orderedByDate = locos.OrderBy(x => x.BuildDateTime);

            foreach (var loco in orderedByDate)
            {
                List<string> locoFields = new List<string>();
                locoFields.Add(loco.Name);
                locoFields.Add(loco.BuildDateTime.ToString("yyyy"));
                locoFields.Add(loco.Whyte);
                locoFields.Add(loco.TotalProduced.ToString());
                th.AddRow(locoFields.ToArray());
            }

            pageBuilder.Append(th.Output());

            pageBuilder.Append("</div>");
            pageBuilder.Append("</div>");

            pageBuilder.Output();
        }
    }
}
