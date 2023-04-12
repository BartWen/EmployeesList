using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace EmployeesList
{
    public class FIleUpload<T> where T : new()
    {
        private string _filePath;

        public FIleUpload(string filePath)
        {
            _filePath = filePath;
        }

        public void SerializeToFile(T employees)
        { 
            var serializer = new XmlSerializer(typeof (T));

            using (var streamWriter = new StreamWriter(_filePath)) 
            {
                serializer.Serialize(streamWriter, employees);
                streamWriter.Close();
            }
        }
        public T DeserializeToFile()
        {
            if (!File.Exists(_filePath))
                return new T();

            var serializer = new XmlSerializer(typeof(T));

            using (var streamReader = new StreamReader(_filePath))
            {
                var employees = (T)serializer.Deserialize(streamReader);
                streamReader.Close();
                return employees;
            }
        }
    }
}
