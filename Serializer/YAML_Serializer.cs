using DataFormatsDemo.Models;
using YamlDotNet.Serialization; //braucht YamlDotNet (zB nuget) oder console: Install-Package YamlDotNet

namespace DataFormatsDemo.Serializer
{
    // YAML = YAML Ain't Markup Language
    internal class YAML_Serializer
    {
        // Serialisiere eine Liste von Personen in das YAML-Format
        public void SerializeToYAML(List<Person> people, string filePath)
        {
            var serializer = new SerializerBuilder().Build();
            var yaml = serializer.Serialize(people);
            File.WriteAllText(filePath, yaml);
        }

        // Deserialisiere YAML-Daten zu einer Liste von Personen
        public List<Person> DeserializeFromYAML(string filePath)
        {
            var deserializer = new DeserializerBuilder().Build();
            var yaml = File.ReadAllText(filePath);
            return deserializer.Deserialize<List<Person>>(yaml);
        }
    }
}
