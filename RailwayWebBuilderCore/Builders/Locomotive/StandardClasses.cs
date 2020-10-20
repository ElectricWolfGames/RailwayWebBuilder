using eWolfBootstrap.Builders;
using eWolfBootstrap.Chats;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.LocoDetails;
using RailwayWebBuilderCore.Services;
using System.Collections.Generic;
using System.Linq;

namespace RailwayWebBuilderCore.Builders.Locomotive
{
    public class StandardClasses
    {
        public static void Build()
        {
            string htmlpath = Constants.RootPath + "//" + Constants.Locomotive + "//";

            eWolfBootstrap.Interfaces.IPageBuilder pageBuilder = new PageBuilder("StandardClasses.html", htmlpath, new ModelEventsHeader(), "../");

            pageBuilder.Append(NavBarHelper.NavBar("../../"));
            pageBuilder.Append("<div class='container mt-4'>");

            pageBuilder.Append("<div class='row mb-2'>");

            List<HtmlTableExtractLoco> locos = new List<HtmlTableExtractLoco>();
            locos.Add(LocomotivesServices.Get(Locos.Class7Britannia));
            locos.Add(LocomotivesServices.Get(Locos.Class8DukeOfGloucester));
            locos.Add(LocomotivesServices.Get(Locos._9F));

            locos.Add(LocomotivesServices.Get(Locos.Class6Clan));
            locos.Add(LocomotivesServices.Get(Locos._5MT4_6_0));
            locos.Add(LocomotivesServices.Get(Locos._4MT4_6_0));
            locos.Add(LocomotivesServices.Get(Locos._4MT2_6_0));
            locos.Add(LocomotivesServices.Get(Locos._3MT2_6_0));
            locos.Add(LocomotivesServices.Get(Locos._2MT2_6_0));
            locos.Add(LocomotivesServices.Get(Locos._4MT2_6_4T));
            locos.Add(LocomotivesServices.Get(Locos._3MT2_6_2T));
            locos.Add(LocomotivesServices.Get(Locos._2MT2_6_2T));

            TableHolder th = new TableHolder();

            th.Header(new string[] { "Name", "Designer", "Build date", "Total Produced", "Whyte", "Length" });

            foreach (var loco in locos)
            {
                List<string> locoFields = new List<string>();
                locoFields.Add(loco.Name);
                locoFields.Add(loco.Designer);
                locoFields.Add(loco.BuildDate);
                locoFields.Add(loco.TotalProduced.ToString());
                locoFields.Add(loco.Whyte);
                locoFields.Add(loco.Length);

                th.AddRow(locoFields.ToArray());
            }

            DoughnutBar dbTotalProduced = new DoughnutBar();

            locos = locos.OrderByDescending(x => x.TotalProduced).ToList();

            foreach (HtmlTableExtractLoco loco in locos)
            {
                dbTotalProduced.Add(loco.TotalProduced, loco.Name);
            }
            pageBuilder.Append(th.Output());
            pageBuilder.Append(dbTotalProduced.Output());
            pageBuilder.Append("</div>");
            pageBuilder.Output();
        }
    }
}
