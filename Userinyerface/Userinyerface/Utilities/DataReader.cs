using Aquality.Selenium.Core.Utilities;
using Userinyerface.Models;

namespace Userinyerface.Utilities
{
    public static class DataReader
    {
        private static JsonSettingsFile configDataJson = new JsonSettingsFile(Paths.ConfigDataPath);
        private static JsonSettingsFile testDataJson = new JsonSettingsFile(Paths.TestDataPath);

        public static ConfigDataModel configData => configDataJson.GetValue<ConfigDataModel>("config");
        public static TestDataModel testData => testDataJson.GetValue<TestDataModel>("testData");
    }
}