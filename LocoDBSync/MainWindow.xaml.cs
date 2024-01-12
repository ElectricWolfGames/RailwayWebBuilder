using LocoDBSync.Models;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Serialization;

namespace LocoDBSync
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly ObservableCollection<LocoDetails> _locos = new ObservableCollection<LocoDetails>();

        public MainWindow()
        {
            InitializeComponent();

            LoadFileDB();

            LocoItemsList.ItemsSource = _locos;
        }

        private void LoadFileDB()
        {
            var fileDB = ModelLocoDetailsHolder.Load();

            int count = 10;
            foreach (var item in fileDB.ModelLocoDetails)
            {
                LocoDetails locoDetails = new LocoDetails();
                var model = locoDetails.GetModel;
                model.CatalogueId = item.CatalogueId;
                model.Name = item.Name;
                model.Manufacturers = item.Manufacturers;
                model.RunningNumber = item.RunningNumber;

                _locos.Add(locoDetails);

                if (count-- == 0)
                    return;
            }
        }
    }
}