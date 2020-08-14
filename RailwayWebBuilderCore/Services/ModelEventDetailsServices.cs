using RailwayWebBuilder.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RailwayWebBuilder.Services
{
    public class ModelEventDetailsServices
    {
        private List<IModelEvent> _modelPages = new List<IModelEvent>();

        public ModelEventDetailsServices()
        {
            AddModelEvents();
        }

        private void AddModelEvents()
        {
            _modelPages.AddRange(GetAll());

            foreach (var pages in _modelPages)
            {
                pages.Fix();
            }
        }

        private List<IModelEvent> GetAll()
        {
            var updates = from t in Assembly.GetExecutingAssembly().GetTypes()
                          where t.GetInterfaces().Contains(typeof(IModelEvent))
                                && t.GetConstructor(Type.EmptyTypes) != null
                          select Activator.CreateInstance(t) as IModelEvent;

            return updates.ToList();
        }

        internal List<IModelEvent> Events
        {
            get
            {
                return _modelPages;
            }
        }
    }
}