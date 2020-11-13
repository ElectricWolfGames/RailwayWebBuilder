﻿using RailwayWebBuilderCore.Builders;
using RailwayWebBuilderCore.Builders.Locations;
using RailwayWebBuilderCore.Builders.Locomotive;
using RailwayWebBuilderCore.Builders.ModelEvents;
using RailwayWebBuilderCore.Builders.MyLayouts;
using RailwayWebBuilderCore.Builders.Stations;
using RailwayWebBuilderCore.LocoDetails;
using RailwayWebBuilderCore.Services;
using System.Diagnostics;
using System.Windows;

// https://stackoverflow.com/questions/14588336/wpf-listview-editing-listviewitem
namespace RailwayWebBuilderCore
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _cacheFolder = @"F:\Trains\DeletableCache\";

        public MainWindow()
        {
            InitializeComponent();

            DownloadServices ds = ServiceLocator.Instance.GetService<DownloadServices>();
            ds.CacheFolder = _cacheFolder;

            var ldb = LocomotiveDBServices.GetDBServices();
            ldb.Init();

            List.ItemsSource = ldb.FullList;

            LocomotivesServices ls = ServiceLocator.Instance.GetService<LocomotivesServices>();
            ls.Init();

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
            BuildStationsRushcliffeHaltPage b2 = new BuildStationsRushcliffeHaltPage();
            b2.Build();
            BuildStationsLoughboroughStationPage b = new BuildStationsLoughboroughStationPage();
            b.Build();

            BlogDetailsServices blogs = ServiceLocator.Instance.GetService<BlogDetailsServices>();
            HomePageBuilder.Build(blogs.Blogs);

            LocationsPageBuilder.Build();

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
                FileName = @"F:/eWolfSiteUploads/Railways/Locomotives/Index.html",
                UseShellExecute = true
            };
            Process.Start(psi);
        }
    }
}
