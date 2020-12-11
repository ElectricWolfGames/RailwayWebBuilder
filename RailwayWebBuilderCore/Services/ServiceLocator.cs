using eWolfCommon.Services;
using System;
using System.Collections.Generic;

namespace RailwayWebBuilderCore.Services
{
    public class ServiceLocator : ServiceLocatorBase
    {
        private ServiceLocator()
        {
            _services = new Dictionary<Type, object>
            {
                { typeof(ModelEventDetailsServices), new ModelEventDetailsServices() },
                { typeof(BlogDetailsServices), new BlogDetailsServices() },
                { typeof(LocationsService), new LocationsService() },
                { typeof(SettingService), new SettingService() },
                { typeof(DownloadServices), new DownloadServices() },
                { typeof(LocomotivesServices), new LocomotivesServices() },
                { typeof(LocomotiveDBServices), new LocomotiveDBServices() }
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