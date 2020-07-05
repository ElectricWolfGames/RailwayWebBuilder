using RailwayWebBuilder.Builders;
using RailwayWebBuilder.Services;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;

namespace RailwayWebBuilder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BuildSite();
        }

        private void Build_Click(object sender, RoutedEventArgs e)
        {
            BuildSite();
        }

        private void BuildTest_Click(object sender, RoutedEventArgs e)
        {
            BuildSiteExperimental();
        }

        private void BuildSiteExperimental()
        {
            ModelEventDetailsServices meds = ServiceLocator.Instance.GetService<ModelEventDetailsServices>();

            BuildModelEventHomePage.Build(meds.Events);

            foreach (Interfaces.IModelEvent pageDetails in meds.Events)
            {
                BuildModelEventPage.Build(pageDetails);
            }

            BuildMyLayoutsPage.Build(null);
            BuildCatalogPage.Build(null);

            BuildStationsRushcliffeHaltPage.Build(null);

            BlogDetailsServices blogs = ServiceLocator.Instance.GetService<BlogDetailsServices>();
            BuildModelBlogs.Build(blogs.Blogs);
        }

        private void BuildSite()
        {
            ModelEventDetailsServices meds = ServiceLocator.Instance.GetService<ModelEventDetailsServices>();

            BuildModelEventHomePage.Build(meds.Events);

            foreach (var pageDetails in meds.Events)
            {
                BuildModelEventPage.Build(pageDetails);
            }
            BuildMyLayoutsPage.Build(null);
            BuildCatalogPage.Build(null);
            BuildStationsRushcliffeHaltPage.Build(null);

            BlogDetailsServices blogs = ServiceLocator.Instance.GetService<BlogDetailsServices>();
            BuildModelBlogs.Build(blogs.Blogs);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void LiveSite_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"http://electricwolf.co.uk/Railways/index.html");
        }

        private void Site_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start(@"F:/eWolfSiteUploads/Railways/index.html");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string path = @"C:\Users\ThinkCentre\Pictures\_ToName\2020-02-29 NewarkLincolnModelRailClub\";

            List<string> files = new List<string>();

            var filesOnDrive = Directory.GetFiles(path, "*.*", SearchOption.AllDirectories);
            foreach (string file in filesOnDrive)
            {
                // files.Add(file);
                string filePath = Path.GetDirectoryName(file);
                string[] parts = filePath.Split('\\');
                string last = parts.Last();
                string fixName = last.Replace(" ", "");

                fixName = "LincolnModelRailClub";
                // get fileanme
                string name = Path.GetFileName(file);
                if (!name.Contains(fixName))
                {
                    name = name.Replace(".", $" {fixName}.");
                    // rename file
                    File.Move(file, $"{filePath}\\{name}");
                }
            }

            /*IModelEvent me = ModelEventFactory.CreateLinclon2020March();

            foreach (var layout in me.Layouts)
            {
                string path = $@"F:\Trains\eWolfModelRailwayWeb\Data\ModelEvents\2020-02-29 NewarkLincolnModelRailClub\{layout.Name}";
                Directory.CreateDirectory(path);
            }*/
        }
    }
}
