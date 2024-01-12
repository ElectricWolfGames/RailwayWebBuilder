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
using LocoDBSync.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace LocoDBSync
{
    /// <summary>
    /// Interaction logic for LocoDetails.xaml
    /// </summary>
    public partial class LocoDetails : UserControl
    {
        public LocoDetails()
        {
            InitializeComponent();
        }

        public string CatalogueId
        {
            get
            {
                return _modelLocoDetails.CatalogueId;
            }
        }

        public ModelLocoDetails GetModel
        {
            get
            {
                return _modelLocoDetails;
            }
        }

        public string LocoName
        {
            get
            {
                return _modelLocoDetails.Name;
            }
        }

        public string Manufacturers
        {
            get
            {
                return _modelLocoDetails.Manufacturers;
            }
        }

        public string RunningNumber
        {
            get
            {
                return _modelLocoDetails.RunningNumber;
            }
        }

        private ModelLocoDetails _modelLocoDetails { get; set; } = new ModelLocoDetails();
    }
}