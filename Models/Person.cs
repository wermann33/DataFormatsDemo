
namespace DataFormatsDemo.Models
{
    public class Person //muss public sein für Serialisierung in xml
    {
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Email { get; set; }
    }
}
