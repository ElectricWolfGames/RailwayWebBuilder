using RailwayWebBuilderCore.Data;
using System;

namespace RailwayWebBuilderCore.Blogs.Year2020
{
    public class CreateSiteUploaded : BlogBase
    {
        public CreateSiteUploaded()
        {
            Name = "Site Uploaded";
            Date = new DateTime(2020, 02, 15);
            Paragraph = "Hello, This site is now live. It's a collection of all the photos I've taken on Model railways and heritage railways. " +
            "I live near Nottingham so all the events are with-in travel distance from their. " +
                "To start with I have just upload the eventsfrom 2019, " +
                "but I will be uploading new events for 2020. Please keep checking back for more updates.";
        }
    }
}
