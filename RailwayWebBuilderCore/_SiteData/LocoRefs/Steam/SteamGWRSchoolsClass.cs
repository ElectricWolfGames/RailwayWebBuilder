using RailwayWebBuilderCore._SiteData.LocoRefs.Diesel;
using RailwayWebBuilderCore.Enums;

namespace RailwayWebBuilderCore._SiteData.LocoRefs.Steam;

public class SteamGWRSchoolsClass : SteamClassBase
{
    public SteamGWRSchoolsClass()
    {
        ClassName = "GWR Schools Class, SR V Class";
        StockType = StockTypes.SteamLoco;

        Paragraph1 = "The SR V class, more commonly known as the Schools class, is a class of steam locomotive designed by Richard Maunsell for the Southern Railway. The class was a cut down version of his Lord Nelson class but also incorporated components from Urie and Maunsell's LSWR/SR King Arthur class. It was the last locomotive in Britain to be designed with a 4-4-0 wheel arrangement, and was the most powerful class of 4-4-0 ever produced in Europe. All 40 of the class were named after English public schools, and were designed to provide a powerful class of intermediate express passenger locomotive on semi-fast services for lines which could cope with high axle loads but some of which had short turntables. Because of the use of a ‘’King Arthur’’ firebox, rather than the square-topped Belpaire firebox used on the Lord Nelsons, the class could be used on lines with a restricted loading gauge and some of the best performance by the class was on the heavily restricted Tonbridge to Hastings line. The locomotives performed well from the beginning but were subject to various minor modifications to improve their performance over the years. The class operated until 1961 when mass withdrawals took place and all had gone by December 1962. Three examples are now preserved on heritage railways in Britain.";
        Paragraph2 = "926, Repton, is owned by the North Yorkshire Moors Railway. It was completed in May 1934 and entered service on the Bournemouth route, with some time operating between Waterloo and Portsmouth before that line was electrified. It was one of the last of the class to be overhauled by British Railways in 1960, so was considered a good choice for preservation. In December 1962 the engine was withdrawn from service, and in 1966 it was purchased and overhauled at Eastleigh, before moving to the United States. It was donated by the purchaser to Steamtown, U.S.A. in Bellows Falls, Vermont, US. Steamtown loaned the engine to the Cape Breton Steam Railway in Canada, where it operated a regular passenger service. In 1989 it was sold again, and returned to the UK to the NYMR, where it was again overhauled and found to be in good condition. Recently returned to service following an overhaul. 30926 has also operated on the mainline between Whitby and Grosmont with occasional visits to Battersby.";

        Keywords.Add("SR V Class 926");
        Keywords.Add("Schools class");
        Keywords.Add("Richard Maunsell");
        Keywords.Add("Repton");

        LocoNumbers.AddRange(new[]
        {
            new LocoDetails("926", "Repton", "_F5A0926.JPG"),
            });
    }
}