using RailwayWebBuilderCore._Site.Railways.ModelEvents;
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
        private List<ILayoutBase> _layouts = new();

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

                var path = @"E:\Projects\eWolfModelRailwayWeb\RailwayWebBuilder\RailwayWebBuilderCore\_SiteData\ModelRailways\Layouts\";
                string filedata = "using RailwayWebBuilderCore.Enums;" +
                    "namespace RailwayWebBuilderCore._SiteData.ModelRailways.Layouts" +
                    "{" +
                    $"    internal class {nameEnum} : LayoutBase\r\n" +
                    "    {\r\n" +
                    $"        public {nameEnum}()\r\n" +
                    "        {\r\n" +
                    $"            Name = LayoutNamesEnums.{nameEnum};\r\n" +
                    "            Owner = \"\";\r\n" +
                    $"            Description = \"\";  // TODO {nameEnum} Needs description \r\n" +
                    "        }\r\n" +
                    "    }\r\n" +
                    "}";
                File.WriteAllText(path + nameEnum + ".cs", filedata);
            }

            return layoutBase;
        }

        private void AddModelEvents()
        {
            _layouts.AddRange(GetAll());
        }

        private static List<ILayoutBase> GetAll()
        {
            var updates = from t in Assembly.GetExecutingAssembly().GetTypes()
                          where t.GetInterfaces().Contains(typeof(ILayoutBase))
                                && t.GetConstructor(Type.EmptyTypes) != null
                          select Activator.CreateInstance(t) as ILayoutBase;

            return updates.ToList();
        }
    }
}