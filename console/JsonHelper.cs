using System.IO;

namespace console
{
    public class JsonHelper
    {
        public static void InitJson(string fileName, string nameJson)
        {
            File.WriteAllText(fileName, "{\n" + $"\"{nameJson}\": [\n");
        }
        public static void AppendObjectAndBreak(string fileName, string jsonString)
        {
            File.AppendAllText(fileName, jsonString);
            File.AppendAllText(fileName, ", \n");
        }

        public static void AppendObject(string fileName, string jsonString)
        {
            File.AppendAllText(fileName, jsonString);
        }

        public static void CloseJson(string fileName)
        {
            File.AppendAllText(fileName, "]\n}");
        }
    }
}