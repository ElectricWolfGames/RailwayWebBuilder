using eWolfBootstrap.Helpers;
using eWolfBootstrap.HtmlExtracts;
using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.LocoDB;
using RailwayWebBuilderCore.LocoDetails;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace RailwayWebBuilderCore.Services
{
    public class LocomotivesServices
    {
        public Dictionary<Locos, HtmlTableExtract> _locos = new Dictionary<Locos, HtmlTableExtract>();

        public static HtmlTableExtractLoco Get(Locos loco)
        {
            LocomotivesServices ls = ServiceLocator.Instance.GetService<LocomotivesServices>();
            var hte = ls.GetLoco(loco);

            hte.Name = GetEnumDescription((Locos)loco);
            //hte.Name = loco.ToString();
            return new HtmlTableExtractLoco(hte);
        }

        public static string GetEnumDescription(System.Enum value)
        {
            FieldInfo fi = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = fi.GetCustomAttributes(typeof(DescriptionAttribute), false) as DescriptionAttribute[];

            if (attributes != null && attributes.Any())
            {
                return attributes.First().Description;
            }

            return value.ToString();
        }

        public LocomotiveDetails CreateDB(string url)
        {
            HtmlTableExtract table = GetTable(url, string.Empty);
            HtmlTableExtractLoco tableLoco = new HtmlTableExtractLoco(table);
            var loco = BuildDB(tableLoco, url);

            var ldb = LocomotiveDBServices.GetDBServices();
            ldb.Add(loco);

            return loco;
        }

        public HtmlTableExtract GetTable(string uri, Locos locos)
        {
            return GetTable(uri, locos.ToString());
        }

        public HtmlTableExtract GetTable(string uri, string locos)
        {
            string file = DownloadServices.Download(uri, locos);

            var table = HtmlExtractHelpers.GetTable(file, "Type and origin");

            return table;
        }

        public void Init()
        {
            AddLoco("https://en.wikipedia.org/wiki/BR_Standard_Class_9F", Locos._9F);

            AddLoco("https://en.wikipedia.org/wiki/BR_Standard_Class_7", Locos.Class7Britannia);
            AddLoco("https://en.wikipedia.org/wiki/BR_Standard_Class_8", Locos.Class8DukeOfGloucester);
            AddLoco("https://en.wikipedia.org/wiki/BR_Standard_Class_6", Locos.Class6Clan);
            AddLoco("https://en.wikipedia.org/wiki/BR_Standard_Class_5", Locos._5MT4_6_0);
            AddLoco("https://en.wikipedia.org/wiki/BR_Standard_Class_4_4-6-0", Locos._4MT4_6_0);

            AddLoco("https://en.wikipedia.org/wiki/BR_Standard_Class_4_2-6-0", Locos._4MT2_6_0);
            AddLoco("https://en.wikipedia.org/wiki/BR_Standard_Class_3_2-6-0", Locos._3MT2_6_0);
            AddLoco("https://en.wikipedia.org/wiki/BR_Standard_Class_2_2-6-0", Locos._2MT2_6_0);
            AddLoco("https://en.wikipedia.org/wiki/BR_Standard_Class_4_2-6-4T", Locos._4MT2_6_4T);
            AddLoco("https://en.wikipedia.org/wiki/BR_Standard_Class_3_2-6-2T", Locos._3MT2_6_2T);
            AddLoco("https://en.wikipedia.org/wiki/BR_Standard_Class_2_2-6-2T", Locos._2MT2_6_2T);

            AddLoco("https://en.wikipedia.org/wiki/LMS_Princess_Royal_Class", Locos.LMS_Princess_Royal_Class);
            AddLoco("https://en.wikipedia.org/wiki/LNER_Gresley_Classes_A1_and_A3", Locos.LNER_Class_A1A3);
            AddLoco("https://en.wikipedia.org/wiki/LNER_Class_A4", Locos.LNER_Class_A4);

            AddLoco("https://en.wikipedia.org/wiki/GWR_1500_Class", Locos.GWR_1500_Class);
            AddLoco("https://en.wikipedia.org/wiki/GWR_1600_Class", Locos.GWR_1600_Class);

            AddLoco("https://en.wikipedia.org/wiki/GWR_9400_Class", Locos.GWR_9400_Class);
            AddLoco("https://en.wikipedia.org/wiki/GWR_2251_Class", Locos.GWR_2251_Class);
            AddLoco("https://en.wikipedia.org/wiki/GWR_5101_Class", Locos.GWR_5101_Class);

            AddLoco("https://en.wikipedia.org/wiki/GWR_5700_Class", Locos.GWR_5700_Class);
            AddLoco("https://en.wikipedia.org/wiki/GWR_6959_Class", Locos.GWR_6959_Class);

            AddLoco("https://en.wikipedia.org/wiki/GWR_4073_Class", Locos.GWR_4073_Castle_Class);
            AddLoco("https://en.wikipedia.org/wiki/GWR_6400_Class", Locos.GWR_6400_Class);
            AddLoco("https://en.wikipedia.org/wiki/GWR_7800_Class", Locos.GWR_7800_Manor_Class);

            // https://en.wikipedia.org/wiki/Steam_locomotives_of_British_Railways

            AddLoco("https://en.wikipedia.org/wiki/SR_West_Country_and_Battle_of_Britain_classes", Locos.SR_West_Country_and_Battle_of_Britain_classes);
            AddLoco("https://en.wikipedia.org/wiki/SR_Merchant_Navy_class", Locos.SR_Merchant_Navy_Class);

            // Barry trains
            AddLoco("https://en.wikipedia.org/wiki/Barry_Railway_Class_A", Locos.BarryRailwayClassA);
            AddLoco("https://en.wikipedia.org/wiki/Barry_Railway_Class_B", Locos.BarryRailwayClassB);
            AddLoco("https://en.wikipedia.org/wiki/Barry_Railway_Class_B1", Locos.BarryRailwayClassB1);
            AddLoco("https://en.wikipedia.org/wiki/Barry_Railway_Class_C", Locos.BarryRailwayClassC);
            AddLoco("https://en.wikipedia.org/wiki/Barry_Railway_Class_D", Locos.BarryRailwayClassD);
            AddLoco("https://en.wikipedia.org/wiki/Barry_Railway_Class_E", Locos.BarryRailwayClassE);
            AddLoco("https://en.wikipedia.org/wiki/Barry_Railway_Class_F", Locos.BarryRailwayClassF);
            AddLoco("https://en.wikipedia.org/wiki/Barry_Railway_Class_G", Locos.BarryRailwayClassG);
            AddLoco("https://en.wikipedia.org/wiki/Barry_Railway_Class_H", Locos.BarryRailwayClassH);
            AddLoco("https://en.wikipedia.org/wiki/Barry_Railway_Class_J", Locos.BarryRailwayClassJ);
            AddLoco("https://en.wikipedia.org/wiki/Barry_Railway_Class_K", Locos.BarryRailwayClassK);
            AddLoco("https://en.wikipedia.org/wiki/Barry_Railway_Class_L", Locos.BarryRailwayClassL);
            //

            // LMS
            AddLoco("https://en.wikipedia.org/wiki/LMS_Ivatt_Class_2_2-6-2T", Locos.LMS_Ivatt_Class_2T);
            AddLoco("https://en.wikipedia.org/wiki/LMS_Fairburn_2-6-4T", Locos.LMS_Fairburn);
            AddLoco("https://en.wikipedia.org/wiki/LMS_Ivatt_Class_4", Locos.LMS_Ivatt_Class_4);
            AddLoco("https://en.wikipedia.org/wiki/LMS_Stanier_Class_5_4-6-0", Locos.LMS_Stanier_Class5);
            AddLoco("https://en.wikipedia.org/wiki/LMS_Coronation_Class", Locos.LMS_Coronation_Class);
            AddLoco("https://en.wikipedia.org/wiki/LMS_Ivatt_Class_2_2-6-0", Locos.LMS_Ivatt_Class_2);
            AddLoco("https://en.wikipedia.org/wiki/LMS_Kitson_0-4-0ST", Locos.LMS_Kitson);

            // LNER
            AddLoco("https://en.wikipedia.org/wiki/LNER_Peppercorn_Class_A1", Locos.LNER_Peppercorn_A1);
            AddLoco("https://en.wikipedia.org/wiki/LNER_Peppercorn_Class_A2", Locos.LNER_Peppercorn_A2);
            AddLoco("https://en.wikipedia.org/wiki/LNER_Thompson_Class_B1", Locos.LNER_Thompson_B1);
            AddLoco("https://en.wikipedia.org/wiki/LNER_Class_J72", Locos.LNER_J72);
            AddLoco("https://en.wikipedia.org/wiki/LNER_Thompson/Peppercorn_Class_K1", Locos.LNER_Thompson_Peppercorn_K1);
            AddLoco("https://en.wikipedia.org/wiki/LNER_Thompson_Class_L1", Locos.LNER_Thompson_L1);

            // https://en.wikipedia.org/wiki/Locomotives_of_the_London_and_North_Eastern_Railway
            // https://en.wikipedia.org/wiki/Locomotives_of_the_London_and_North_Eastern_Railway#Great_Central_Railway

            AddLoco("https://en.wikipedia.org/wiki/GCR_Class_8C", Locos.GCR_Class_8C);
            AddLoco("https://en.wikipedia.org/wiki/GCR_Class_1", Locos.GCR_Class_1);
            AddLoco("https://en.wikipedia.org/wiki/GCR_Class_9P", Locos.GCR_Class_9P);
            AddLoco("https://en.wikipedia.org/wiki/GCR_Class_8F", Locos.GCR_Class_8F);
            AddLoco("https://en.wikipedia.org/wiki/GCR_Class_8", Locos.GCR_Class_8);
            AddLoco("https://en.wikipedia.org/wiki/GCR_Class_8N", Locos.GCR_Class_8N);
            AddLoco("https://en.wikipedia.org/wiki/GCR_Class_9Q", Locos.GCR_Class_9Q);
            AddLoco("https://en.wikipedia.org/wiki/GCR_Class_1A", Locos.GCR_Class_1A);
            AddLoco("https://en.wikipedia.org/wiki/GCR_Class_8G", Locos.GCR_Class_8G);
            AddLoco("https://en.wikipedia.org/wiki/GCR_Class_8B", Locos.GCR_Class_8B);
            AddLoco("https://en.wikipedia.org/wiki/GCR_Classes_8D_and_8E", Locos.GCR_Classes_8D_and_8E);
            AddLoco("https://en.wikipedia.org/wiki/GCR_Class_11B", Locos.GCR_Class_11B);
            AddLoco("https://en.wikipedia.org/wiki/GCR_Class_11E", Locos.GCR_Class_11E);
            AddLoco("https://en.wikipedia.org/wiki/GCR_Class_11F", Locos.GCR_Class_11F);
            AddLoco("https://en.wikipedia.org/wiki/GCR_Class_9J", Locos.GCR_Class_9J);
            AddLoco("https://en.wikipedia.org/wiki/GCR_Class_8K", Locos.GCR_Class_8K);
            AddLoco("https://en.wikipedia.org/wiki/GCR_Class_8A", Locos.GCR_Class_8A);
            AddLoco("https://en.wikipedia.org/wiki/GCR_Class_9N", Locos.GCR_Class_9N);
            AddLoco("https://en.wikipedia.org/wiki/GCR_Class_9K", Locos.GCR_Class_9K);
            AddLoco("https://en.wikipedia.org/wiki/GCR_Class_4", Locos.GCR_Class_4);
            AddLoco("https://en.wikipedia.org/wiki/GCR_Class_5A", Locos.GCR_Class_5A);
            AddLoco("https://en.wikipedia.org/wiki/GCR_Class_1B", Locos.GCR_Class_1B);
            AddLoco("https://en.wikipedia.org/wiki/GCR_Class_8H", Locos.GCR_Class_8H);
        }

        private void AddLoco(string uri, Locos locos)
        {
            /*HtmlTableExtract table = GetTable(uri, locos);

            _locos.Add(locos, table);
            HtmlTableExtractLoco tableLoco = Get(locos);

            var loco = BuildDB(tableLoco, uri);*/
        }

        private LocomotiveDetails BuildDB(HtmlTableExtractLoco table, string uri)
        {
            var db = new LocomotiveDetails(table, uri);
            db.Save();
            return db;
        }

        private HtmlTableExtract GetLoco(Locos loco)
        {
            return _locos[loco];
        }
    }
}