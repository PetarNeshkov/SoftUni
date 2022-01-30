using BirthdayCelebrations.Contracts;

namespace BirthdayCelebrations.Models
{
    public class Pet : IBirthable
    {
        public Pet(string name, string birtdate)
        {
            Name = name;
            Birtdate = birtdate;
        }

        public string Name { get; private set; }

        public string Birtdate { get; private set; }
    }
}
