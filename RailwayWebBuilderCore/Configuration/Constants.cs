namespace RailwayWebBuilderCore.Configuration
{
    public static class Constants
    {
        public const string DriveLetter = @"D:\";

        public const string RawDataPath = DriveLetter + @"Trains\_WebsiteData\";

        public const string RootPath = DriveLetter + @"eWolfSiteUploads\Railways\";
        public const string ModelEvents = @"ModelEvents";
        public const string Shop = @"Shop";
        public const string StandardClasses = "StandardClasses";

        public const string MyLayouts = "MyLayouts";
        public const string Catalog = "Catalog";
        public const string Stations = "Stations";
        public const string LocomotiveName = "Locomotives";

        public const string FullMyLayouts = RootPath + MyLayouts + @"\";
        public const string FullCatalog = RootPath + Catalog + @"\";
        public const string Locomotive = LocomotiveName + @"\";

        public const string StationFolder = Stations + @"\";
        public const string RushcliffeHaltFolder = StationFolder + @"GCR-RushcliffeHalt\";
        public const string LoughboroughStationFolder = StationFolder + @"GCR-LoughboroughStation\";
        public const string QuornAndWoodHouseFolder = StationFolder + @"GCR-QuornAndWoodHouse\";

        public const string LeicestershireNorthFolder = StationFolder + @"GCR-LeicestershireNorth\";
        public const string RothleyFolder = StationFolder + @"GCR-Rothley\";
    }
}