using System.IO;
using System.Text.Json;

namespace Workplace.Infrastructure.Persistence.Configuration
{
    public static class PersistanceConfiguration
    {
        public static string Configure()
        {
            using (StreamReader r = new StreamReader("appsettings.json"))
            {
                string json = r.ReadToEnd();
                var curDir = Directory.GetCurrentDirectory();
                return Directory.GetParent(curDir) + JsonSerializer.Deserialize<Settings>(json).ConnectionString;
            }
        }
    }

    public class Settings
    {
        public string ConnectionString { get; set; }
    }
}
