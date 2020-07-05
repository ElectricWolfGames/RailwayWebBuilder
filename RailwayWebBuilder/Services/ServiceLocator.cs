using eWolfCommon.Services;
using System;
using System.Collections.Generic;

namespace RailwayWebBuilder.Services
{
    public class ServiceLocator : ServiceLocatorBase
    {
        private ServiceLocator()
        {
            _services = new Dictionary<Type, object>
            {
                { typeof(ModelEventDetailsServices), new ModelEventDetailsServices() },
                { typeof(BlogDetailsServices), new BlogDetailsServices() }
            };
        }

        public static ServiceLocatorBase Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ServiceLocator();
                }
                return _instance;
            }
        }
    }
}
