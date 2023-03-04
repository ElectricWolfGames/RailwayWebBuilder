﻿using RailwayWebBuilderCore.Builders;
using RailwayWebBuilderCore.Builders.Locations;
using RailwayWebBuilderCore.Builders.ModelEvents;
using RailwayWebBuilderCore.Builders.MyLayouts;
using RailwayWebBuilderCore.Builders.Shop;
using RailwayWebBuilderCore.Builders.Stations;
using RailwayWebBuilderCore.Builders.StockVideos;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.LocoDB;
using RailwayWebBuilderCore.LocoDetails;
using RailwayWebBuilderCore.Services;
using System.Diagnostics;
using System.Windows;
using RailwayWebBuilderCore.Builders.GCR;
using RailwayWebBuilderCore.Builders.Locomotive;

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

            BuildSite();

            Button_Click_2(null, null);
            Close();
        }

        private void AddLoco_Click(object sender, RoutedEventArgs e)
        {
            string url = NewUrl.Text;

            LocomotivesServices ls = ServiceLocator.Instance.GetService<LocomotivesServices>();
            var loco = ls.CreateDB(url);
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

            var b2 = new GCR_RushcliffeHaltPage();
            b2.Build();
            var b = new GCR_LoughboroughStationPage();
            b.Build();
            var b3 = new GCR_QuornAndWoodHouse();
            b3.Build();
            var b4 = new GCR_LeicestershireNorthPage();
            b4.Build();
            var b5 = new GCR_RothleyPage();
            b5.Build();
            var b6 = new GCR_A60BridgePage();
            b6.Build();
            var b7 = new Mainline_LoughboroughStation();
            b7.Build();

            var lr = new LocoRefPageBuilder();
            lr.Build();

            BlogDetailsServices blogs = ServiceLocator.Instance.GetService<BlogDetailsServices>();
            HomePageBuilder.Build(blogs.Blogs);

            LocationsPageBuilder.Build();

            ShopMainPageBuilder.Build();
            ShopPageBuilder.Build();
            AuctionsBuilder.Build();

            var bsv = new BuildStockVideos();
            bsv.Build();

            //var table = new Table();
            //table.Build();

            //var gcrshop = new GCRShop();
            //gcrshop.Build();

            var gcrttd = new GCRTextToDonate();
            gcrttd.Build();

            //LocomotiveDetailsBuilder ld = new LocomotiveDetailsBuilder();
            //ld.Build();
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
                FileName = Constants._aaDriveLetter + @"eWolfSiteUploads/Railways/MyLayouts/index.html",
                UseShellExecute = true
            };
            Process.Start(psi);
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

        private void Button_Click_Save(object sender, RoutedEventArgs e)
        {
            var ldb = LocomotiveDBServices.GetDBServices();

            foreach (var item in ldb.FullList)
            {
                item.Save();
            }
            myList.Items.Refresh();
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

        private void lbTodoList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (myList.SelectedItem != null)
                this.Title = (myList.SelectedItem as LocomotiveDetails).Name;
        }

        private string RemoveCharacterCodes(string tractiveEffort)
        {
            tractiveEffort = tractiveEffort.Replace(@"&#160;", " ");

            return tractiveEffort;
        }
    }
}