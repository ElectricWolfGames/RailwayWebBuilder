﻿/*
namespace RailwayWebBuilderCore.KeepForNow
{
    public class LocomotiveDBServices
    {
        private ObservableCollection<LocomotiveDetails> _locomotiveDetails = new ObservableCollection<LocomotiveDetails>();
        private string _outputFolder = Configuration.Constants._aaDriveLetter + @"Trains\LocoDB\Locomotives";

        public ObservableCollection<LocomotiveDetails> FullList
        {
            get
            {
                return _locomotiveDetails;
            }
        }

        public static LocomotiveDBServices GetDBServices()
        {
            return ServiceLocator.Instance.GetService<LocomotiveDBServices>();
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
}*/