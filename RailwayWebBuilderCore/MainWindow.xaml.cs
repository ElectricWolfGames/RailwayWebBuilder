using RailwayWebBuilderCore.Builders;
using RailwayWebBuilderCore.Builders.Locations;
using RailwayWebBuilderCore.Builders.ModelEvents;
using RailwayWebBuilderCore.Builders.MyLayouts;
using RailwayWebBuilderCore.Builders.Stations;
using RailwayWebBuilderCore.Services;
using System.Windows;

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

            ModelEventsPageBuilder.Build(meds.Events);

            foreach (var pageDetails in meds.Events)
            {
                ModelEventPageBuilder.Build(pageDetails);
            }
            BuildMyLayoutsPage.Build(null);
            BuildCatalogPage.Build(null);
            BuildStationsRushcliffeHaltPage.Build(null);

            BlogDetailsServices blogs = ServiceLocator.Instance.GetService<BlogDetailsServices>();
            HomePageBuilder.Build(blogs.Blogs);

            LocationsPagebuilder.Build();
        }
    }
}
