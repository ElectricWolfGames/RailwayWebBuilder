using RailwayWebBuilderCore.LocoDB;
using System.Collections.ObjectModel;
using System.IO;

namespace RailwayWebBuilderCore.Services
{
    public class LocomotiveDBServices
    {
        private ObservableCollection<LocomotiveDetails> _locomotiveDetails = new ObservableCollection<LocomotiveDetails>();
        private string _outputFolder = @"F:\Trains\LocoDB\Locomotives\";

        public static LocomotiveDBServices GetDBServices()
        {
            return ServiceLocator.Instance.GetService<LocomotiveDBServices>();
        }

        public ObservableCollection<LocomotiveDetails> FullList
        {
            get
            {
                return _locomotiveDetails;
            }
        }

        public void Add(LocomotiveDetails locomotiveDetails)
        {
            _locomotiveDetails.Add(locomotiveDetails);
        }

        public void Init()
        {
            var files = Directory.GetFiles(_outputFolder, "*.xml", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                var ldbf = LocomotiveDetails.Load(file);
                _locomotiveDetails.Add(ldbf);
            }
        }
    }
}