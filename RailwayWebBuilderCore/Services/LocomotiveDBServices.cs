using RailwayWebBuilderCore.LocoDB;
using System.Collections.Generic;
using System.IO;

namespace RailwayWebBuilderCore.Services
{
    public class LocomotiveDBServices
    {
        private List<LocomotiveDetails> _locomotiveDetails = new List<LocomotiveDetails>();
        private string _outputFolder = @"F:\Trains\LocoDB\Locomotives\";

        public static LocomotiveDBServices GetDBServices()
        {
            return ServiceLocator.Instance.GetService<LocomotiveDBServices>();
        }

        public List<LocomotiveDetails> FullList
        {
            get
            {
                return _locomotiveDetails;
            }
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