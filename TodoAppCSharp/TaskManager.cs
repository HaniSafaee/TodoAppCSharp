using System.Text.Json;

namespace TodoAppCSharp
{
    public static class TaskManager
    {
        private static readonly string filePath = "tasks.json";

        public static void SaveTasks(List<Task> tasks)
        {
            string json = JsonSerializer.Serialize(tasks, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static List<Task> LoadTasks()
        {
            if (!File.Exists(filePath))
                return new List<Task>();

            string json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Task>>(json) ?? new List<Task>();
        }
    }
}
