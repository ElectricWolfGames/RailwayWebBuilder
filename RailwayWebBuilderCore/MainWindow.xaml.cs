using RailwayWebBuilder.Builders;
using RailwayWebBuilder.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RailwayWebBuilderCore
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
    }
}
