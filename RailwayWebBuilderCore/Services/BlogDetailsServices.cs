﻿using RailwayWebBuilderCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RailwayWebBuilderCore.Services
{
    public class BlogDetailsServices
    {
        private List<IBlog> _blogs = new();

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

        private static List<IBlog> GetAll()
        {
            var canBlog = from t in Assembly.GetExecutingAssembly().GetTypes()
                          where t.GetInterfaces().Contains(typeof(IBlogger))
                                && t.GetConstructor(Type.EmptyTypes) != null
                          select Activator.CreateInstance(t) as IBlogger;

            List<IBlog> blogs = new();
            foreach (var blogger in canBlog)
            {
                blogs.Add(blogger.GetBlog());
            }
            return blogs;
        }

        private static IEnumerable<IBlog> GetAllMore()
        {
            IEnumerable<IBlog> blogs = from t in Assembly.GetExecutingAssembly().GetTypes()
                                       where t.GetInterfaces().Contains(typeof(IBlog))
                                             && t.GetConstructor(Type.EmptyTypes) != null
                                       select Activator.CreateInstance(t) as IBlog;

            return blogs;
        }

        private void AddBlogs()
        {
            _blogs.AddRange(GetAll());
            _blogs.AddRange(GetAllMore());
        }
    }
}