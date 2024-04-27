using RailwayWebBuilderCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RailwayWebBuilderCore.Services
{
    public class LayoutbyLayoutDetailsServices
    {
        private List<ILayoutByLayout> _modelPages = new List<ILayoutByLayout>();

        public LayoutbyLayoutDetailsServices()
        {
            AddModelEvents();
        }

        internal List<ILayoutByLayout> Events
        {
            get
            {
                return _modelPages;
            }
        }

        private void AddModelEvents()
        {
            _modelPages.AddRange(GetAll());

            
        }

        private List<ILayoutByLayout> GetAll()
        {
            var updates = from t in Assembly.GetExecutingAssembly().GetTypes()
                          where t.GetInterfaces().Contains(typeof(ILayoutByLayout))
                                && t.GetConstructor(Type.EmptyTypes) != null
                          select Activator.CreateInstance(t) as ILayoutByLayout;

            return updates.ToList();
        }
    }
}