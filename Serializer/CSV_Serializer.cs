using DataFormatsDemo.Models;

namespace DataFormatsDemo.Serializer
{
    // CSV = Comma-Separated Values 
    internal class CSV_Serializer
    {
        // Serialisiere eine Liste von Personen in das CSV-Format
        public void SerializeToCSV(List<Person> people, string filePath)
        {
            using StreamWriter writer = new StreamWriter(filePath);
            writer.WriteLine("Name,Age,Email"); // Header
            foreach (var person in people)
            {
                writer.WriteLine($"{person.Name},{person.Age},{person.Email}");
            }
        }

        // Deserialisiere CSV-Daten zu einer Liste von Personen
        public List<Person> DeserializeFromCSV(string filePath)
        {
            var people = new List<Person>();
            using StreamReader reader = new StreamReader(filePath);
            reader.ReadLine(); // Überspringe den Header
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                var values = line.Split(',');
                var person = new Person
                {
                    Name = values[0],
                    Age = int.Parse(values[1]),
                    Email = values[2]
                };
                people.Add(person);
            }

            return people;
        }
    }
}
