using RailwayWebBuilder.Factories;
using RailwayWebBuilder.Interfaces;
using System.Collections.Generic;

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
            // 2019 events
            _modelPages.Add(ModelEventFactory.CreateLinclon2019());
            _modelPages.Add(ModelEventFactory.CreateWoodthorpe2019());
            _modelPages.Add(ModelEventFactory.CreateLoughborough2019());
            _modelPages.Add(ModelEventFactory.CreateLichfield2019());
            _modelPages.Add(ModelEventFactory.CreateKettering2019());
            _modelPages.Add(ModelEventFactory.CreateKirkby2019());
            _modelPages.Add(ModelEventFactory.CreateBurton2019());

            // 2020 Events
            _modelPages.Add(ModelEventFactory.CreateSyston2020());
            _modelPages.Add(ModelEventFactory.CreateIlkeston2020());
            _modelPages.Add(ModelEventFactory.CreateLinclon2020March());

            foreach (var pages in _modelPages)
            {
                pages.Fix();
            }
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