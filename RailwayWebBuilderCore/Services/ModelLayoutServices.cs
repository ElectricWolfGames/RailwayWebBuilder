using RailwayWebBuilderCore._SiteData.ModelRailways;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RailwayWebBuilderCore.Services
{
    public class ModelLayoutServices
    {
        private readonly List<ILayoutBase> _modelLayout = new();

        public ModelLayoutServices()
        {
            AddModelLayouts();
        }

        internal List<ILayoutBase> Layouts
        {
            get
            {
                return _modelLayout;
            }
        }

        private static List<ILayoutBase> GetAll()
        {
            var updates = from t in Assembly.GetExecutingAssembly().GetTypes()
                          where t.GetInterfaces().Contains(typeof(ILayoutBase))
                                && t.GetConstructor(Type.EmptyTypes) != null
                          select Activator.CreateInstance(t) as ILayoutBase;

            return updates.ToList();
        }

        private void AddModelLayouts()
        {
            _modelLayout.AddRange(GetAll());
        }
    }
}