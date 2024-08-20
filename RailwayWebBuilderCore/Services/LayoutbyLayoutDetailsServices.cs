using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RailwayWebBuilderCore.Services
{
    public class LayoutbyLayoutDetailsServices
    {
        private List<ILayoutByLayoutSetA> _layouts = new List<ILayoutByLayoutSetA>();

        public LayoutbyLayoutDetailsServices()
        {
            AddModelEvents();
        }

        public List<ILayoutByLayoutSetA> Layouts
        {
            get
            {
                return _layouts;
            }
        }

        internal ILayoutByLayoutSetA FindLayout(LayoutNamesEnums nameEnum)
        {
            return _layouts.FirstOrDefault(x => x.Name == nameEnum);
        }

        private void AddModelEvents()
        {
            _layouts.AddRange(GetAll());
        }

        private List<ILayoutByLayoutSetA> GetAll()
        {
            var updates = from t in Assembly.GetExecutingAssembly().GetTypes()
                          where t.GetInterfaces().Contains(typeof(ILayoutByLayoutSetA))
                                && t.GetConstructor(Type.EmptyTypes) != null
                          select Activator.CreateInstance(t) as ILayoutByLayoutSetA;

            return updates.ToList();
        }
    }
}