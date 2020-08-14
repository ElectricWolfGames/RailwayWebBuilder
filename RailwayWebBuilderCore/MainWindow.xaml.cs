using RailwayWebBuilder.Builders;
using RailwayWebBuilder.Services;
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

            EventLocationsPage.Build();
        }
    }
}
