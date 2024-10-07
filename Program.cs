using DataFormatsDemo.Models;
using DataFormatsDemo.Serializer;

namespace DataFormatsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>
            {
                new Person { Name = "John", Age = 30, Email = "john@example.com" },
                new Person { Name = "Jane", Age = 25, Email = "jane@example.com" }
            };

            // Definiere eine allgemeine Action für die Ausgabe. (Delegate)
            Action<Person> printPerson = person => Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, Email: {person.Email}");

            // CSV
            CSV_Serializer csvSerializer = new CSV_Serializer();
            csvSerializer.SerializeToCSV(people, "people.csv");
            var csvPeople = csvSerializer.DeserializeFromCSV("people.csv");
            csvPeople.ForEach(person => Console.WriteLine($"Name: {person.Name}, Age: {person.Age}, Email: {person.Email}"));

            // XML
            XML_Serializer xmlSerializer = new XML_Serializer();
            xmlSerializer.SerializeToXML(people, "people.xml");
            var xmlPeople = xmlSerializer.DeserializeFromXML("people.xml");
            xmlPeople.ForEach(printPerson);



            // JSON
            JSON_Serializer jsonSerializer = new JSON_Serializer();
            jsonSerializer.SerializeToJSON(people, "people.json");
            var jsonPeople = jsonSerializer.DeserializeFromJSON("people.json");
            jsonPeople.ForEach(printPerson);



            // YAML
            YAML_Serializer yamlSerializer = new YAML_Serializer();
            yamlSerializer.SerializeToYAML(people, "people.yaml");
            var yamlPeople = yamlSerializer.DeserializeFromYAML("people.yaml");
            yamlPeople.ForEach(printPerson);


        }
    }
}
