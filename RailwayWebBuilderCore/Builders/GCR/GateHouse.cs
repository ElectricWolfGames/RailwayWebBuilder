using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eWolfBootstrap.Builders;
using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Headers;
using RailwayWebBuilderCore.Helpers;


namespace RailwayWebBuilderCore.Builders.GCR
{
    internal class GateHouse
    {
        public static void Build()
        {
            Directory.CreateDirectory(Constants._aRootPath + "\\" + Constants.GCR);
            string htmlpath = Constants._aRootPath + "\\" + Constants.GCR + "\\";

            var sb = new PageBuilder("GateHouse.html", htmlpath, new ShopGCRAuctionsHeader(), "../");
            sb.Append(NavBarHelper.NavBar("../"));
            sb.Append("<div class='container mt-4'>");
            sb.Jumbotron("<h2>Friends of The Great Central Mainline: GateHouse</h2>", "", 8);

        }
    }
}
