using RailwayWebBuilderCore.Interfaces;
using RailwayWebBuilderCore.ModelRailways.Layouts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace RailwayWebBuilderCore.Services
{
    public class ModelLayoutServices
    {
        private List<ILayoutBase> _modelLayout = new List<ILayoutBase>();

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

        private void AddModelLayouts()
        {
            _modelLayout.AddRange(GetAll());
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