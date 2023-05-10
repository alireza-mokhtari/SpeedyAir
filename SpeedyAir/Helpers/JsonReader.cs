using System.Text.Json;

namespace SpeedyAir.Helpers
{
    public static class JsonReader
    {
        public static T ReadFromFile<T>(string filename) where T : class, new()
        {
            var path = @$"Data\{filename}.json";
            if (!File.Exists(path))
                return null;

            var jsonFile = File.ReadAllText(path);

            return JsonSerializer.Deserialize<T>(jsonFile, new JsonSerializerOptions() { PropertyNamingPolicy = JsonNamingPolicy.CamelCase });
        }
    }
}
