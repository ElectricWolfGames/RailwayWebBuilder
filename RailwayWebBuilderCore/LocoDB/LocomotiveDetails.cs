using eWolfBootstrap.HtmlExtracts;
using eWolfCommon.Helpers;
using eWolfCommon.Interfaces;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.LocoDetails;
using RailwayWebBuilderCore.Services;
using System;
using System.ComponentModel;
using System.IO;

namespace RailwayWebBuilderCore.LocoDB
{
    [Serializable]
    public class LocomotiveDetails : ISaveable
    {
        private const string MISSING = "NEEDS UPDATING";

        private bool _isEditing;
        private bool _isSelected;
        private string _outputFolder = Constants._aaDriveLetter + @"Trains\LocoDB\Locomotives\";

        public LocomotiveDetails()
        {
            IsEditing = false;
            _isSelected = false;
        }

        public LocomotiveDetails(HtmlTableExtractLoco htmlTableExtractLoco, string html)
        {
            PopulateFromWeb(htmlTableExtractLoco, html);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public string Axleload { get; set; }
        public string BuildDate { get; set; }
        public DateTime BuildDateTime { get; set; }
        public string Builder { get; set; } = MISSING;
        public string Class { get; set; } = MISSING;
        public string Cylinders { get; set; } = MISSING;
        public string Designer { get; set; }
        public string Disposition { get; set; } = MISSING;

        public string GetFileName
        {
            get
            {
                if (string.IsNullOrWhiteSpace(Name))
                    return "_a";

                string tempName = Name.Replace("\"", "");
                tempName = tempName.Replace("/", "-");
                return $"{tempName}.xml";
            }
        }

        public bool IsDirty { get; set; }

        public bool IsEditing
        {
            get { return _isEditing; }
            set
            {
                if (_isEditing == value) return;
                _isEditing = value;
                OnPropertyChanged("IsEditing");
            }
        }

        public bool IsSelected
        {
            get { return _isSelected; }
            set
            {
                _isSelected = value;
                OnPropertyChanged("IsSelected");
            }
        }

        public string Length { get; set; }

        public string Locale { get; set; } = MISSING;

        public string Name { get; set; }

        public string Operators { get; set; } = MISSING;

        public string PowerClass { get; set; }

        public string Powertype { get; set; } = MISSING;

        public int TotalProduced { get; set; }

        public string TractiveEffort { get; set; }

        public string WebSite { get; set; }

        public string Whyte { get; set; }

        public static LocomotiveDetails Load(string file)
        {
            return ReadWriteFileHelper.ReadFromXmlFile<LocomotiveDetails>(file);
        }

        public void ConsildateText()
        {
            if (Operators == "BR")
            {
                Operators = "British Railways";
                SetDirty();
            }
            if (Operators == "GWR")
            {
                Operators = "Great Western Railway";
                SetDirty();
            }

            if (Operators == "LNER")
            {
                Operators = "London and North Eastern Railway";
                SetDirty();
            }

            if (Operators == "GCR")
            {
                Operators = "Great Central Railways";
                SetDirty();
            }
        }

        public void Save()
        {
            Directory.CreateDirectory(_outputFolder);

            ReadWriteFileHelper.WriteToXmlFile<LocomotiveDetails>(_outputFolder + GetFileName, this);
        }

        public void SetDirty()
        {
            IsDirty = true;
        }

        public void UpdateFromSite()
        {
            LocomotivesServices ls = ServiceLocator.Instance.GetService<LocomotivesServices>();
            HtmlTableExtract table = ls.GetTable(WebSite, string.Empty);
            HtmlTableExtractLoco latestVersion = new HtmlTableExtractLoco(table);

            if (Operators == MISSING)
            {
                Operators = latestVersion.Operators;
                SetDirty();
            }

            if (Class == MISSING)
            {
                Class = latestVersion.Class;
                SetDirty();
            }
        }

        // [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }

        private void PopulateFromWeb(HtmlTableExtractLoco htmlTableExtractLoco, string url)
        {
            Name = htmlTableExtractLoco.TableName;
            Operators = htmlTableExtractLoco.Operators;
            Class = htmlTableExtractLoco.Class;
            Designer = htmlTableExtractLoco.Designer;
            Axleload = htmlTableExtractLoco.Axleload;
            BuildDate = htmlTableExtractLoco.BuildDate;
            BuildDateTime = htmlTableExtractLoco.BuildDateTime;
            Whyte = htmlTableExtractLoco.Whyte;
            TotalProduced = htmlTableExtractLoco.TotalProduced;
            Length = htmlTableExtractLoco.Length;
            PowerClass = htmlTableExtractLoco.PowerClass;
            TractiveEffort = htmlTableExtractLoco.TractiveEffort;
            WebSite = url;
        }
    }
}