using RailwayWebBuilderCore.Builders;
using RailwayWebBuilderCore.Builders.Locations;
using RailwayWebBuilderCore.Builders.Locomotive;
using RailwayWebBuilderCore.Builders.ModelEvents;
using RailwayWebBuilderCore.Builders.MyLayouts;
using RailwayWebBuilderCore.Builders.Shop;
using RailwayWebBuilderCore.Builders.Stations;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.LocoDB;
using RailwayWebBuilderCore.LocoDetails;
using RailwayWebBuilderCore.Services;
using System.Diagnostics;
using System.Windows;

// https://stackoverflow.com/questions/14588336/wpf-listview-editing-listviewitem

// https://docs.microsoft.com/en-us/dotnet/api/system.windows.controls.itemcollection?view=net-5.0

// https://www.wpf-tutorial.com/list-controls/listbox-control/

namespace RailwayWebBuilderCore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _cacheFolder = Constants.DriveLetter + @"Trains\DeletableCache\";

        public MainWindow()
        {
            InitializeComponent();

            DownloadServices ds = ServiceLocator.Instance.GetService<DownloadServices>();
            ds.CacheFolder = _cacheFolder;

            //var ldb = LocomotiveDBServices.GetDBServices();
            //ldb.Init();

            //myList.ItemsSource = ldb.FullList;

            //List.ItemsSource = ldb.FullList;
            // List.Items =

            //LocomotivesServices ls = ServiceLocator.Instance.GetService<LocomotivesServices>();
            //ls.Init();

            BuildSite();
        }

        private void BuildSite()
        {
            ModelEventDetailsServices meds = ServiceLocator.Instance.GetService<ModelEventDetailsServices>();

            ModelEventsPageBuilder.Build(meds.Events);

            foreach (var pageDetails in meds.Events)
            {
                ModelEventPageBuilder.Build(pageDetails);
            }
            BuildMyLayoutsPage.Build(null);
            BuildCatalogPage.Build(null);

            BuildStationsHome.Build();

            var b2 = new BuildStationsRushcliffeHaltPage();
            b2.Build();
            var b = new BuildStationsLoughboroughStationPage();
            b.Build();
            var b3 = new BuildStationsQuornAndWoodHouse();
            b3.Build();
            var b4 = new BuildStationsLeicestershireNorthPage();
            b4.Build();
            var b5 = new BuildStationsRothleyPage();
            b5.Build();

            BlogDetailsServices blogs = ServiceLocator.Instance.GetService<BlogDetailsServices>();
            HomePageBuilder.Build(blogs.Blogs);

            LocationsPageBuilder.Build();

            ShopPageBuilder.Build();

            LocomotiveDetailsBuilder ld = new LocomotiveDetailsBuilder();
            ld.Build();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BuildSite();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            GetLocoDetails gld = new GetLocoDetails();
            gld.Now();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = Constants.DriveLetter + @"eWolfSiteUploads/Railways/MyLayouts/index.html",
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void lbTodoList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (myList.SelectedItem != null)
                this.Title = (myList.SelectedItem as LocomotiveDetails).Name;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (myList.SelectedItem == null)
                return;

            var psi = new ProcessStartInfo
            {
                FileName = (myList.SelectedItem as LocomotiveDetails).WebSite,
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void Button_Click_Save(object sender, RoutedEventArgs e)
        {
            var ldb = LocomotiveDBServices.GetDBServices();

            foreach (var item in ldb.FullList)
            {
                item.Save();
            }
            myList.Items.Refresh();
        }

        private void Button_Click_CleanUpText(object sender, RoutedEventArgs e)
        {
            var ldb = LocomotiveDBServices.GetDBServices();

            foreach (var item in ldb.FullList)
            {
                item.TractiveEffort = RemoveCharacterCodes(item.TractiveEffort);
                item.ConsildateText();
                item.SetDirty();
            }
            myList.Items.Refresh();
        }

        private string RemoveCharacterCodes(string tractiveEffort)
        {
            tractiveEffort = tractiveEffort.Replace(@"&#160;", " ");

            return tractiveEffort;
        }

        private void AddLoco_Click(object sender, RoutedEventArgs e)
        {
            string url = NewUrl.Text;

            LocomotivesServices ls = ServiceLocator.Instance.GetService<LocomotivesServices>();
            var loco = ls.CreateDB(url);
        }

        private void Button_Click_UpdateAllFromWeb(object sender, RoutedEventArgs e)
        {
            var ldb = LocomotiveDBServices.GetDBServices();

            foreach (var item in ldb.FullList)
            {
                item.UpdateFromSite();
            }
            myList.Items.Refresh();
        }
    }
}