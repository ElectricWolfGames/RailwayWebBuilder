﻿using RailwayWebBuilder.Data;
using RailwayWebBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace RailwayWebBuilderCore.Blogs._2020
{
    public class SiteUpdateLocations : BlogBase
    {
        public SiteUpdateLocations()
        {
            Name = "Site update";
            Date = new DateTime(2020, 08, 14);
            Paragraph = "Still in lockdown, and we are in the progress of moving house so not a lot of news, But I have just added a Model Event Location page show all the Location of the events we have been to.";
            Link = "ModelEvents/locations.html";
        }
    }
}
