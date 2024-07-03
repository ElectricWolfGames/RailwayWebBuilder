using RailwayWebBuilderCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RailwayWebBuilderCore.Services
{
    public class ModelEventDetailsServices
    {
        private List<IModelEvent> _modelEventDetails = new List<IModelEvent>();

        public ModelEventDetailsServices()
        {
            AddModelEvents();
        }

        internal List<IModelEvent> Events
        {
            get
            {
                return _modelEventDetails;
            }
        }

        private void AddModelEvents()
        {
            _modelEventDetails.AddRange(GetAll());

            foreach (var pages in _modelEventDetails)
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
    }
}