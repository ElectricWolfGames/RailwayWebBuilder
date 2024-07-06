using RailwayWebBuilderCore._SiteData.ModelRailways;
using RailwayWebBuilderCore.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;

namespace RailwayWebBuilderCore.Services
{
    internal class LayoutBaseServices
    {
        private List<ILayoutBase> _layouts = new List<ILayoutBase>();

        internal LayoutBaseServices()
        {
            AddModelEvents();
        }

        internal List<ILayoutBase> Layouts
        {
            get
            {
                return _layouts;
            }
        }

        internal ILayoutBase FindLayout(LayoutNamesEnums nameEnum)
        {
            ILayoutBase layoutBase = _layouts.FirstOrDefault(x => x.Name == nameEnum);
            if (layoutBase == null)
            {
                File.AppendAllText("e:\\temp\\list.txt", nameEnum.ToString() + "\n\r");
                int i = 0;
                i++;
            }

            return layoutBase;
        }

        private void AddModelEvents()
        {
            _layouts.AddRange(GetAll());
        }

        private List<ILayoutBase> GetAll()
        {
            var updates = from t in Assembly.GetExecutingAssembly().GetTypes()
                          where t.GetInterfaces().Contains(typeof(ILayoutBase))
                                && t.GetConstructor(Type.EmptyTypes) != null
                          select Activator.CreateInstance(t) as ILayoutBase;

            return updates.ToList();
        }
    }
}