using System;
using System.IO;

namespace RailwayWebBuilderCore.Configuration;

public static class Constants
{
    /// <summary>
    /// The Events folder of the DaVinci Resolve disk project library.
    /// </summary>
    public static readonly string ResolveProjectsRoot = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
        @"Blackmagic Design\DaVinci Resolve\Support\Resolve Project Library\Resolve Projects\Users\guest\Projects\Events");

    /// <summary>
    /// An empty project, copied to make a new one for each layout.
    /// </summary>
    public static readonly string ResolveEmptyProject = Path.Combine(
        ResolveProjectsRoot, @"2026\Template\Project.db");

    /// <summary>
    /// A Resolve project export holding the TITLE and DESCRIPTION placeholders,
    /// copied and filled in to make a per layout project to import.
    /// </summary>
    public const string ResolveTemplateDrp = _aaDriveLetter + @"Trains\Photos - Main\Template.drp";

    /// <summary>
    /// Descriptions are trimmed to this before going into a Resolve title.
    /// </summary>
    public const int ResolveDescriptionLength = 600;

    public const string _aaDriveLetter = @"E:\";
    public const string _aRootPath = _aaDriveLetter + @"eWolfSiteUploads\Railways\";
    public const string _LocomotiveName = "Locomotives";
    public const string _StationFolder = "Stations" + @"\";
    public const string A60StationFolder = _StationFolder + @"GCR-A60Bridge\";
    public const string DieselBuilders = _LocomotiveName + @"\DieselBuilders";
    public const string DieselDesigners = _LocomotiveName + @"\DieselDesigners";
    public const string DieselMaxSpeeds = _LocomotiveName + @"\DieselMaxSpeeds";
    public const string DieselPowers = _LocomotiveName + @"\DieselPowers";
    public const string HeritageRailways = @"HeritageRailways";
    public const string HeritageRailwaysRoot = _aRootPath + HeritageRailways + @"\";
    public const string DieselWheelArrangements = _LocomotiveName + @"\DieselWheelArrangements";
    public const string FullCatalog = _aRootPath + "Catalog" + @"\";
    public const string FullMVRLayouts = _aRootPath + MVRLayouts + @"\";
    public const string FullMyLayouts = _aRootPath + MyLayouts + @"\";
    public const string GCR = @"GCR";
    public const string GCRFolder = @"GCR\";
    public const string LayoutByLayout = @"LayoutByLayout";
    public const string LeicestershireNorthFolder = _StationFolder + @"GCR-LeicestershireNorth\";
    public const string LocoBuilders = _LocomotiveName + @"\Builders";
    public const string LocoDesigners = _LocomotiveName + @"\Designers";
    public const string Locomotive = _LocomotiveName + @"\";
    public const string LocomotiveRef = _LocomotiveName + @"\" + "Ref" + @"\";
    public const string LocoRef = @"LocoRefs";
    public const string LocoWheelArrangements = _LocomotiveName + @"\WheelArrangements";
    public const string LoughboroughStationFolder = _StationFolder + @"GCR-LoughboroughStation\";
    public const string MainlineLoughboroughStationFolder = _StationFolder + @"Mainline-LoughboroughStation\";
    public const string MistyValleyRailwayLayouts = "MistyValleyRailway";
    public const string ModelEvents = @"ModelEvents";
    public const string MVRLayouts = "MistyValleyRailway";
    public const string MyLayouts = "MyLayouts";
    public const string QuornAndWoodHouseFolder = _StationFolder + @"GCR-QuornAndWoodHouse\";
    public const string RawDataPath = _aaDriveLetter + @"Trains\_WebsiteData\";
    public const string RothleyFolder = _StationFolder + @"GCR-Rothley\";
    public const string RushcliffeHaltFolder = _StationFolder + @"GCR-RushcliffeHalt\";
    public const string Shop = @"Shop";
    public const string ShopFolder = @"Shop\";
    public const string StandardClasses = "StandardClasses";
    public const string StockVideos = @"StockVideos\";
}