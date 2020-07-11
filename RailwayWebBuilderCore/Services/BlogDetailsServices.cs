using RailwayWebBuilder.Factories;
using RailwayWebBuilder.Interfaces;
using System.Collections.Generic;

namespace RailwayWebBuilder.Services
{
    public class BlogDetailsServices
    {
        private List<IBlog> _blogs = new List<IBlog>();

        public BlogDetailsServices()
        {
            AddBlogs();
        }

        private void AddBlogs()
        {
            _blogs.Add(BlogFactory.CreateIdea());
            _blogs.Add(BlogFactory.CreateSiteUploaded());
            _blogs.Add(BlogFactory.CreateTakeALookAround());
            _blogs.Add(BlogFactory.Create20200216SystonEvent());
            _blogs.Add(BlogFactory.Create202024IlkestonEvent());
            _blogs.Add(BlogFactory.Create202029NewarkEvent());
            _blogs.Add(BlogFactory.Create2020313MyLayoutTrackPlans());
            _blogs.Add(BlogFactory.Create2020319NoTrips());
            _blogs.Add(BlogFactory.Create2020416TheHills());
            _blogs.Add(BlogFactory.Create2020419HomeRunning());
            _blogs.Add(BlogFactory.Create2020511WithGrass());
            _blogs.Add(BlogFactory.Create2020626RushcliffeHaltVisit());
        }

        internal List<IBlog> Blogs
        {
            get
            {
                return _blogs;
            }
        }
    }
}