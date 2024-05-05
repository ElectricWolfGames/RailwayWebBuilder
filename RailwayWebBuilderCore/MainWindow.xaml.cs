using eWolfBootstrap.SiteBuilder;
using eWolfBootstrap.SiteBuilder.Interfaces;
using RailwayWebBuilderCore._SiteData;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Services;
using System.Diagnostics;
using System.Reflection;
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
        private readonly BuildSite _buildSite = new BuildSite();
        private string _cacheFolder = Constants._aaDriveLetter + @"Trains\DeletableCache\";

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

            //BuildSite();

            //Button_Click_2(null, null);

            _buildSite.WebSiteRootAddress = @"E:\eWolfSiteUploads";

            SiteBuilderServiceLocator.Instance.InjectService<IPageHeaderDetails>(new RailwaySiteHeader());
            SiteBuilderServiceLocator.Instance.InjectService<IBuildSite>(_buildSite);
            SiteBuilderServiceLocator.Instance.InjectService<INavigationBuilder>(new NavigationBuilder());

            _buildSite.PreProcess(Assembly.GetExecutingAssembly());
            _buildSite.Create();
            _buildSite.OpenHomePage();

            Close();
        }

        private void AddLoco_Click(object sender, RoutedEventArgs e)
        {
            /*string url = NewUrl.Text;

            LocomotivesServices ls = ServiceLocator.Instance.GetService<LocomotivesServices>();
            var loco = ls.CreateDB(url);*/
        }

        /*private void BuildSite()
        {
            ModelEventDetailsServices meds = ServiceLocator.Instance.GetService<ModelEventDetailsServices>();

            ModelEventsPageBuilder.Build(meds.Events);

            foreach (var pageDetails in meds.Events)
            {
                ModelEventPageBuilder.Build(pageDetails);
            }
            BuildMyLayoutsPage.Build(null);
            BuildCatalogPage.Build(null);
        }*/

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var psi = new ProcessStartInfo
            {
                FileName = Constants._aaDriveLetter + @"eWolfSiteUploads/Railways/MyLayouts/index.html",
                UseShellExecute = true
            };
            Process.Start(psi);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            /*if (myList.SelectedItem == null)
                return;

            var psi = new ProcessStartInfo
            {
                FileName = (myList.SelectedItem as LocomotiveDetails).WebSite,
                UseShellExecute = true
            };
            Process.Start(psi);*/
        }

        private void Button_Click_CleanUpText(object sender, RoutedEventArgs e)
        {
            /*var ldb = LocomotiveDBServices.GetDBServices();

            foreach (var item in ldb.FullList)
            {
                item.TractiveEffort = RemoveCharacterCodes(item.TractiveEffort);
                item.ConsildateText();
                item.SetDirty();
            }
            myList.Items.Refresh();*/
        }

        private void Button_Click_Save(object sender, RoutedEventArgs e)
        {
            /*var ldb = LocomotiveDBServices.GetDBServices();

            foreach (var item in ldb.FullList)
            {
                item.Save();
            }
            myList.Items.Refresh();*/
        }

        private void Button_Click_UpdateAllFromWeb(object sender, RoutedEventArgs e)
        {
            /*var ldb = LocomotiveDBServices.GetDBServices();

            foreach (var item in ldb.FullList)
            {
                item.UpdateFromSite();
            }
            myList.Items.Refresh();*/
        }

        private void lbTodoList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            /*if (myList.SelectedItem != null)
                this.Title = (myList.SelectedItem as LocomotiveDetails).Name;*/
        }

        private string RemoveCharacterCodes(string tractiveEffort)
        {
            tractiveEffort = tractiveEffort.Replace(@"&#160;", " ");

            return tractiveEffort;
        }
    }
}