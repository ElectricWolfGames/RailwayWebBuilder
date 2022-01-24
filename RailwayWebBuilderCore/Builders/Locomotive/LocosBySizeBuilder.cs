namespace RailwayWebBuilderCore.Builders.Locomotive
{
    /*public class LocosBySizeBuilder : LocomotiveDetailsBase, ILocomotiveDetailsPages
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

            var ldb = LocomotiveDBServices.GetDBServices();
            ObservableCollection<LocoDB.LocomotiveDetails> locos = ldb.FullList;

            var odredlocos = locos.Where(x => !x.Whyte.Contains("T"));

            odredlocos = odredlocos.OrderBy(x => x.BuildDateTime);

            var th = new SortableTableHolder();

            th.Header(new string[] { "Name", "Whyte", "Length", "Axle Load" });

            foreach (var loco in odredlocos)
            {
                if (string.IsNullOrWhiteSpace(loco.Length))
                {
                    continue;
                }
                List<string> locoFields = new List<string>
                {
                    loco.Name,
                    loco.Whyte,
                    loco.Length,
                    loco.Axleload
                };
                th.AddRow(locoFields.ToArray());
            }

            // https://mdbootstrap.com/docs/jquery/javascript/charts/#radar-chart
            // Add a line graph that show all the sizes

            _pageBuilder.Append(th.Output());

            _pageBuilder.Append("</div>");
            _pageBuilder.Append("</div>");

            _pageBuilder.Output();
        }
    }*/
}