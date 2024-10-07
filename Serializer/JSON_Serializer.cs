using DataFormatsDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DataFormatsDemo.Serializer
{
    // JSON = JavaScript Object Notation
    internal class JSON_Serializer
    {
        // Serialisiere eine Liste von Personen in das JSON-Format
        public void SerializeToJSON(List<Person> people, string filePath)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var jsonString = JsonSerializer.Serialize(people, options);
            File.WriteAllText(filePath, jsonString);
        }

        // Deserialisiere JSON-Daten zu einer Liste von Personen
        public List<Person> DeserializeFromJSON(string filePath)
        {
            var jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<List<Person>>(jsonString);
        }
    }
}
