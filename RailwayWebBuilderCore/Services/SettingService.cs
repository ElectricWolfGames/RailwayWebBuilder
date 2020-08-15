using System;
using System.Configuration;

namespace RailwayWebBuilderCore.Services
{
    public class SettingService
    {
        public string GoogleMapKey { get; private set; }

        public SettingService()
        {
            ReadAllSettings();
            GoogleMapKey = ReadSetting("GoogleMapKey");
        }

        public static SettingService GetSetting
        {
            get
            {
                return ServiceLocator.Instance.GetService<SettingService>();
            }
        }

        private string ReadSetting(string key)
        {
            try
            {
                var appSettings = ConfigurationManager.AppSettings;
                string result = appSettings[key] ?? "Not Found";
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading app settings");
            }
            return null;
        }

        private void ReadAllSettings()
        {
            try
            {
                // Get the configuration file.
                var config =
                    ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                // Get the appSettings section.
                AppSettingsSection appSettings =
                    (AppSettingsSection)config.GetSection("appSettings");

                // Get the auxiliary file name.
                Console.WriteLine("Auxiliary file: {0}", config.AppSettings.File);

                // Get the settings collection (key/value pairs).
                if (appSettings.Settings.Count != 0)
                {
                    foreach (string key in appSettings.Settings.AllKeys)
                    {
                        string value = appSettings.Settings[key].Value;
                        Console.WriteLine("Key: {0} Value: {1}", key, value);
                    }
                }
                else
                {
                    Console.WriteLine("The appSettings section is empty. Write first.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception raised: {0}",
                    e.Message);
            }
        }
    }
}
