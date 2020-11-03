using eWolfBootstrap.Builders;
using eWolfBootstrap.Chats;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.LocoDetails;
using RailwayWebBuilderCore.Services;
using System.Collections.Generic;

namespace RailwayWebBuilderCore.Builders.Locomotive
{
    public class GroupsBuilder : LocomotiveDetailsBase, ILocomotiveDetailsPages
    {
        public string HtmlFileName { get; } = "Groups.html";
        public string PageTitle { get; } = "Groups";

        public void Build()
        {
            _pageBuilder = new PageBuilder(HtmlFileName, LocalPath, new AllLocosDetailsHeader(), "../");

            _pageBuilder.Append(NavBarHelper.NavBar("../"));

            AddBreadCrumb(this);

            List<HtmlTableExtractLoco> locos = new List<HtmlTableExtractLoco>
            {
                LocomotivesServices.Get(Locos.Class7Britannia),
                LocomotivesServices.Get(Locos.Class8DukeOfGloucester),
                LocomotivesServices.Get(Locos._9F),

                LocomotivesServices.Get(Locos.Class6Clan),
                LocomotivesServices.Get(Locos._5MT4_6_0),
                LocomotivesServices.Get(Locos._4MT4_6_0),
                LocomotivesServices.Get(Locos._4MT2_6_0),
                LocomotivesServices.Get(Locos._3MT2_6_0),
                LocomotivesServices.Get(Locos._2MT2_6_0),
                LocomotivesServices.Get(Locos._4MT2_6_4T),
                LocomotivesServices.Get(Locos._3MT2_6_2T),
                LocomotivesServices.Get(Locos._2MT2_6_2T)
            };

            CreatTable("BR standard classes", locos);

            locos = new List<HtmlTableExtractLoco>
            {
                LocomotivesServices.Get(Locos.LMS_Ivatt_Class_2T),
                LocomotivesServices.Get(Locos.LMS_Fairburn),
                LocomotivesServices.Get(Locos.LMS_Ivatt_Class_4),
                LocomotivesServices.Get(Locos.LMS_Stanier_Class5),
                LocomotivesServices.Get(Locos.LMS_Coronation_Class),
                LocomotivesServices.Get(Locos.LMS_Ivatt_Class_2),
                LocomotivesServices.Get(Locos.LMS_Kitson)
            };

            CreatTable("LMS designs", locos);

            locos = new List<HtmlTableExtractLoco>
            {
                LocomotivesServices.Get(Locos.SR_Merchant_Navy_Class),
                LocomotivesServices.Get(Locos.SR_West_Country_and_Battle_of_Britain_classes),
            };

            CreatTable("SR designs", locos);

            locos = new List<HtmlTableExtractLoco>
            {
                LocomotivesServices.Get(Locos.LNER_Peppercorn_A1),
                LocomotivesServices.Get(Locos.LNER_Peppercorn_A2),
                LocomotivesServices.Get(Locos.LNER_Thompson_B1),
                LocomotivesServices.Get(Locos.LNER_J72),
                LocomotivesServices.Get(Locos.LNER_Thompson_Peppercorn_K1),
                LocomotivesServices.Get(Locos.LNER_Thompson_L1),
            };
            CreatTable("LNER designs", locos);

            _pageBuilder.Output();
        }

        private void CreatTable(string title, List<HtmlTableExtractLoco> locos)
        {
            _pageBuilder.Append("<div class='container mt-4'>");
            _pageBuilder.Append("<div class='row mb-2'>");
            _pageBuilder.Append($"<h2>{title}</h2>");

            var th = new SortableTableHolder(title);

            th.Header(new string[] { "Name", "Designer", "Build date", "Total Produced", "Whyte", "Length", "Power Class", "Tractive Effort" });

            foreach (var loco in locos)
            {
                if (loco.Name.Contains("LMS Fairburn 2-6-4T"))
                {
                    int i = 0;
                    i++;
                }

                List<string> locoFields = new List<string>
                {
                    loco.Name,
                    loco.Designer,
                    loco.BuildDate,
                    loco.TotalProduced.ToString(),
                    loco.Whyte,
                    loco.Length,
                    loco.PowerClass,
                    loco.TractiveEffort
                };

                th.AddRow(locoFields.ToArray());
            }

            /*            DoughnutBar dbTotalProduced = new DoughnutBar();

                        locos = locos.OrderByDescending(x => x.TotalProduced).ToList();

                        foreach (HtmlTableExtractLoco loco in locos)
                        {
                            dbTotalProduced.Add(loco.TotalProduced, loco.Name);
                        }*/
            _pageBuilder.Append(th.Output());
            //_pageBuilder.Append(dbTotalProduced.Output());
            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");
        }
    }
}
