using eWolfCommon.Helpers;
using eWolfCommon.Interfaces;
using RailwayWebBuilderCore.LocoDetails;
using System;
using System.IO;

namespace RailwayWebBuilderCore.LocoDB
{
    [Serializable]
    public class LocomotiveDetails : ISaveable
    {
        private string _outputFolder = @"F:\Trains\LocoDB\Locomotives\";

        public LocomotiveDetails()
        {
        }

        public LocomotiveDetails(HtmlTableExtractLoco htmlTableExtractLoco, string html)
        {
            PopulateFromWeb(htmlTableExtractLoco, html);
        }

        public string Axleload { get; set; }

        public string BuildDate { get; set; }
        public DateTime BuildDateTime { get; set; }
        public string Builder { get; set; } = "NEEDS UPDATING";
        public string Cylinders { get; set; } = "NEEDS UPDATING";
        public string Designer { get; set; }
        public string Disposition { get; set; } = "NEEDS UPDATING";

        public string GetFileName
        {
            get
            {
                return $"{Name}.xml";
            }
        }

        public string Length { get; set; }
        public string Locale { get; set; } = "NEEDS UPDATING";
        public string Name { get; set; }
        public string Operators { get; set; } = "NEEDS UPDATING";
        public string PowerClass { get; set; }
        public string Powertype { get; set; } = "NEEDS UPDATING";
        public int TotalProduced { get; set; }

        public string TractiveEffort { get; set; }

        public string webSite { get; set; }
        public string Whyte { get; set; }

        public static LocomotiveDetails Load(string file)
        {
            return ReadWriteFileHelper.ReadFromXmlFile<LocomotiveDetails>(file);
        }

        public void Save()
        {
            Directory.CreateDirectory(_outputFolder);

            ReadWriteFileHelper.WriteToXmlFile<LocomotiveDetails>(_outputFolder + GetFileName, this);
        }

        private void PopulateFromWeb(HtmlTableExtractLoco htmlTableExtractLoco, string url)
        {
            Name = htmlTableExtractLoco.Name;
            Designer = htmlTableExtractLoco.Designer;
            Axleload = htmlTableExtractLoco.Axleload;
            BuildDate = htmlTableExtractLoco.BuildDate;
            BuildDateTime = htmlTableExtractLoco.BuildDateTime;
            Whyte = htmlTableExtractLoco.Whyte;
            TotalProduced = htmlTableExtractLoco.TotalProduced;
            Length = htmlTableExtractLoco.Length;
            PowerClass = htmlTableExtractLoco.PowerClass;
            TractiveEffort = htmlTableExtractLoco.TractiveEffort;
            webSite = url;
        }
    }
}
