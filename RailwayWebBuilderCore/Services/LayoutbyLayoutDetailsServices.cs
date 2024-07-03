using RailwayWebBuilderCore.Enums;
using RailwayWebBuilderCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Reflection;

namespace RailwayWebBuilderCore.Services
{
    public class LayoutbyLayoutDetailsServices
    {
        private List<ILayoutByLayout> _layouts = new List<ILayoutByLayout>();

        public LayoutbyLayoutDetailsServices()
        {
            AddModelEvents();
        }

        public List<ILayoutByLayout> Layouts
        {
            get
            {
                return _layouts;
            }
        }

        internal ILayoutByLayout FindLayout(LayoutNamesEnums nameEnum)
        {
            return _layouts.FirstOrDefault(x => x.Name == nameEnum);
        }

        private void AddModelEvents()
        {
            _layouts.AddRange(GetAll());
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