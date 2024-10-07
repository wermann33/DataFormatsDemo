using DataFormatsDemo.Models;
using System.Xml.Serialization;

namespace DataFormatsDemo.Serializer
{
    // XML =  eXtensible Markup Language
    internal class XML_Serializer
    {
        // Serialisiere eine Liste von Personen in das XML-Format
        public void SerializeToXML(List<Person> people, string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
            using TextWriter writer = new StreamWriter(filePath);
            serializer.Serialize(writer, people);
        }

        // Deserialisiere XML-Daten zu einer Liste von Personen
        public List<Person> DeserializeFromXML(string filePath)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
            using FileStream fileStream = new FileStream(filePath, FileMode.Open);
            return (List<Person>)serializer.Deserialize(fileStream);
        }
    }
}
