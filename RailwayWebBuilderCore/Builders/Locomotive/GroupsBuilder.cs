using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using eWolfBootstrap.Builders;
using eWolfBootstrap.Chats;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;
using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.Services;

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

            var ldb = LocomotiveDBServices.GetDBServices();
            ObservableCollection<LocoDB.LocomotiveDetails> locos = ldb.FullList;
            var odredlocos = locos.OrderBy(x => x.Operators);

            var groups = odredlocos.Select(x => x.Operators).Distinct();

            foreach (var group in groups)
            {
                IEnumerable<LocoDB.LocomotiveDetails> groupLocos = odredlocos.Where(x => x.Operators == group);
                CreatTable(group, groupLocos);
            }

            _pageBuilder.Output();
        }

        private void CreatTable(string title, IEnumerable<LocoDB.LocomotiveDetails> locos)
        {
            _pageBuilder.Append("<div class='container mt-4'>");
            _pageBuilder.Append("<div class='row mb-2'>");
            _pageBuilder.Append($"<h2>{title}</h2>");

            var th = new SortableTableHolder(title);

            th.Header(new string[] { "Name", "Designer", "Build date", "Total Produced", "Whyte", "Length", "Power Class", "Tractive Effort" });

            foreach (var loco in locos)
            {
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

            /* DoughnutBar dbTotalProduced = new DoughnutBar();

             locos = locos.OrderByDescending(x => x.TotalProduced).ToList();

             foreach (var loco in locos)
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