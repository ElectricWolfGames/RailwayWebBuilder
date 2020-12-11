using RailwayWebBuilderCore.Configuration;
using RailwayWebBuilderCore.Data;
using System;

namespace RailwayWebBuilderCore.Blogs.Year2020
{
    public class CreateTakeALookAround : BlogBase

    {
        public CreateTakeALookAround()
        {
            Featured = true;
            Name = "Take a look around";
            Date = new DateTime(2020, 02, 10);
            Paragraph = "While you are here make sure to take a look at the Model Events list, they are all the events from last year." +
            " Showing off some amazing layouts. And I hope to be uploading more soon.";
            Link = $"{Constants.ModelEvents}/index.html";
        }
    }
}