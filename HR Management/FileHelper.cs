using Newtonsoft.Json;
using System.IO;
using System.Xml.Serialization;

namespace HR_Management
{
    public class FileHelper <T> where T : new()
    {
        public string _filePath;

        public FileHelper(string filePath)
        {
            _filePath = filePath;
        }
        public void SerializeToFile(T data)
        {
            var json = JsonConvert.SerializeObject(data);
            File.WriteAllText($"{_filePath}.txt", json);
        }

        public T DeserializeFromFile()
        {
            if (!File.Exists($"{_filePath}.txt"))
                return new T();

            var dataReaded = File.ReadAllText($"{_filePath}.txt");
            return JsonConvert.DeserializeObject<T>(dataReaded);
        }
        public void SerializeToFileXML(T data)
        {
            var serializer = new XmlSerializer(typeof(T));

            using (var streamWriter = new StreamWriter($"{_filePath}.xml"))
            {
                serializer.Serialize(streamWriter, data);
                streamWriter.Close();
            }
        }
        public T DeserializeFromFileXML()
        {
            if (!File.Exists($"{_filePath}.xml"))
                return new T();

            var serializer = new XmlSerializer(typeof(T));

            using (var streamReader = new StreamReader($"{_filePath}.xml"))
            {
                var list = ((T)serializer.Deserialize(streamReader));
                streamReader.Close();
                return list;
            }
        }
        //private static void AssignIdToNewUser(T users)
        //{
        //    var userWithHighestId = users.FirstOrDefault(x => x.Id == _userId);
        //    if (userWithHighestId == null)
        //        _userId = 1;
        //    else
        //        _userId = userWithHighestId.Id + 1;
        //}
    }
}
