using System.Collections.Generic;

namespace RailwayWebBuilderCore.Services
{
    public class LocationsService
    {
        public List<Interfaces.IModelEvent> Items = new List<Interfaces.IModelEvent>();

        public void AddLocation(Interfaces.IModelEvent pageDetails)
        {
            Items.Add(pageDetails);
        }
    }
}