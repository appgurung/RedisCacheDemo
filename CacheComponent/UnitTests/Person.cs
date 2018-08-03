using System.Collections.Generic;

namespace UnitTests
{
    public class Contact
    {
        public string Type { get; set; }

        public string Value { get; set; }

        public Contact(string type, string value)
        {
            this.Type = type;
            this.Value = value;
        }
    }

    public class Person
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public List<Contact> Contacts { get; set; }

        public Person(long id, string name, List<Contact> contacts)
        {
            this.Id = id;
            this.Name = name;
            this.Contacts = contacts;
        }
    }
}