﻿using RailwayWebBuilderCore.Factories;
using RailwayWebBuilderCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RailwayWebBuilderCore.Services
{
    public class BlogDetailsServices
    {
        private List<IBlog> _blogs = new List<IBlog>();

        public BlogDetailsServices()
        {
            AddBlogs();
        }

        internal List<IBlog> Blogs
        {
            get
            {
                return _blogs;
            }
        }

        private void AddBlogs()
        {
            _blogs.Add(BlogFactory.CreateIdea());
            _blogs.Add(BlogFactory.CreateSiteUploaded());
            _blogs.Add(BlogFactory.CreateTakeALookAround());
            _blogs.Add(BlogFactory.Create2020313MyLayoutTrackPlans());
            _blogs.Add(BlogFactory.Create2020319NoTrips());
            _blogs.Add(BlogFactory.Create2020416TheHills());
            _blogs.Add(BlogFactory.Create2020419HomeRunning());
            _blogs.Add(BlogFactory.Create2020511WithGrass());
            _blogs.Add(BlogFactory.Create2020626RushcliffeHaltVisit());

            _blogs.AddRange(GetAll());
            _blogs.AddRange(GetAllMore());
        }

        private List<IBlog> GetAll()
        {
            var canBlog = from t in Assembly.GetExecutingAssembly().GetTypes()
                          where t.GetInterfaces().Contains(typeof(IBlogger))
                                && t.GetConstructor(Type.EmptyTypes) != null
                          select Activator.CreateInstance(t) as IBlogger;

            List<IBlog> blogs = new List<IBlog>();
            foreach (var blogger in canBlog)
            {
                blogs.Add(blogger.GetBlog());
            }
            return blogs;
        }

        private IEnumerable<IBlog> GetAllMore()
        {
            IEnumerable<IBlog> blogs = from t in Assembly.GetExecutingAssembly().GetTypes()
                                       where t.GetInterfaces().Contains(typeof(IBlog))
                                             && t.GetConstructor(Type.EmptyTypes) != null
                                       select Activator.CreateInstance(t) as IBlog;

            return blogs;
        }
    }
}