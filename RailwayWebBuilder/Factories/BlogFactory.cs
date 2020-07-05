using RailwayWebBuilder.Configuration;
using RailwayWebBuilder.Data;
using RailwayWebBuilder.Interfaces;
using System;

namespace RailwayWebBuilder.Factories
{
    public static class BlogFactory
    {
        public static IBlog CreateSiteUploaded()
        {
            return new Blog
            {
                Name = "Site Uploaded",
                Date = new DateTime(2020, 02, 15),
                Paragraph = "Hello, This site is now live. It's a collection of all the photos I've taken on Model railways and heritage railways. " +
                "I live near Nottingham so all the events are with-in travel distance from their. " +
                "To start with I have just upload the eventsfrom 2019, " +
                "but I will be uploading new events for 2020. Please keep checking back for more updates."
            };
        }

        public static IBlog CreateIdea()
        {
            return new Blog
            {
                Name = "I have an idea!",
                Date = new DateTime(2020, 01, 06),
                Paragraph = "Hello, this all started with a simple idea, why don't I create a web site to show all my photos and group them together by loco or events." +
                " All I need to do is learn how to create a nice web site and host it!"
            };
        }

        public static IBlog CreateTakeALookAround()
        {
            return new Blog
            {
                Featured = true,
                Name = "Take a look around",
                Date = new DateTime(2020, 02, 10),
                Paragraph = "While you are here make sure to take a look at the Model Events list, they are all the events from last year." +
                " Showing off some amazing layouts. And I hope to be uploading more soon.",
                Link = $"{Constants.ModelEvents}/index.html"
            };
        }

        public static IBlog Create20200216SystonEvent()
        {
            return new Blog
            {
                Name = "Syston Model Railway Event",
                Date = new DateTime(2020, 02, 16),
                Paragraph = "Visted the Syston Model Railway event on the 15 feburay, lots of amazing models displays.",
                Link = $"{Constants.ModelEvents}/20200215-Syston/index.html",
                ModelEvent = ModelEventFactory.CreateSyston2020(),
                Carousel = "P2157640 NewtonEast SystonModelRailway.JPG",
                CarouselText = "Syston Model Railway Event"
            };
        }

        public static IBlog Create202024IlkestonEvent()
        {
            return new Blog
            {
                Name = "Ilkeston (Woodside) Model Railway Club",
                Date = new DateTime(2020, 02, 24),
                Paragraph = "Visted the Ilkeston Model Railway Club event on the 23 feburay, very cool",
                Link = $"{Constants.ModelEvents}/20200223-Ilkeston/index.html",
                ModelEvent = ModelEventFactory.CreateIlkeston2020(),
                Carousel = "P2237873 Avyn-A-Llyin Ilkeston.JPG",
                CarouselText = "Ilkeston (Woodside) Model Railway Club"
            };
        }

        public static IBlog Create202029NewarkEvent()
        {
            return new Blog
            {
                Name = "Lincoln Model Rail Club General Exhibition",
                Date = new DateTime(2020, 02, 29),
                Paragraph = "Big show at the Newark Showground, this time it's the Lincoln Model Rail Club General Exhibition.",
                Link = $"{Constants.ModelEvents}/20200229-Newark/index.html",
                ModelEvent = ModelEventFactory.CreateLinclon2020March(),
                Carousel = "P2298149 DorehillST LincolnModelRailClub.Stephens LincolnModelRailClub.JPG",
                CarouselText = "Lincoln Model Rail Club General Exhibition"
            };
        }

        public static IBlog Create2020313MyLayoutTrackPlans()
        {
            return new Blog
            {
                Name = "My layouts",
                Date = new DateTime(2020, 03, 13),
                Paragraph = "I've just uploaded my track plans for my very own layout. This is some work I did back in January.",
                Link = "MyLayouts/index.html",
                KeyImage = @"MyLayouts\images\P1187439-Track-Ideas.JPG",
                Carousel = "P2097593 Final Layout plan.JPG",
                CarouselText = "Home layouts"
            };
        }

        public static IBlog Create2020319NoTrips()
        {
            return new Blog
            {
                Name = "Lockdown",
                Date = new DateTime(2020, 03, 19),
                Paragraph = "Just like everyone one else, I'm not going to any events. So it's going to be a long time before I have any more new photos, but in the meantime I'll continue to work on my own layouts. Keep safe.",
                Link = "MyLayouts/index.html",
                KeyImage = @"MyLayouts\images\P2097593-Final-Layout-plan.JPG",
            };
        }

        public static IBlog Create2020416TheHills()
        {
            return new Blog
            {
                Name = "I've made a start (kind of)",
                Date = new DateTime(2020, 04, 16),
                Paragraph = "I've been doing small bits on my shelf display",
                Link = "MyLayouts/index.html",
                KeyImage = @"MyLayouts\images\P4168539.JPG",
            };
        }

        public static IBlog Create2020419HomeRunning()
        {
            return new Blog
            {
                Name = "Time for some home running",
                Date = new DateTime(2020, 04, 19),
                Paragraph = "Tests layout on the floor, giving us some more ideas",
                Link = "MyLayouts/index.html",
                KeyImage = @"MyLayouts\images\P4188612.JPG",
            };
        }

        public static IBlog Create2020511WithGrass()
        {
            return new Blog
            {
                Name = "Shelf display update",
                Date = new DateTime(2020, 05, 11),
                Paragraph = "Added grass, bridges and fences",
                Link = "MyLayouts/index.html",
                KeyImage = @"MyLayouts\images\P5110124.JPG",
            };
        }

        public static IBlog Create2020626RushcliffeHaltVisit()
        {
            return new Blog
            {
                Name = "Visit to Rushcliffe Halt",
                Date = new DateTime(2020, 06, 26),
                Paragraph = "Quick visit to Rushcliffe Halt ",
                Link = "Stations/RushcliffeHalt/index.html",
                KeyImage = @"Stations\RushcliffeHalt/images\P6260086.JPG",
            };
        }
    }
}
