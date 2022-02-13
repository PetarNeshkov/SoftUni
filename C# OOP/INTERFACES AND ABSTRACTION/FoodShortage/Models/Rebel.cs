using FoodShortage.Contracts;

namespace FoodShortage.Models
{
    public class Rebel : IBuyer
    {
        public Rebel(string name, string id, string group)
        {
            Name = name;
            Id = id;
            Group = group;
        }
        public string Name { get; private set; }
        public string Id { get; private set; }
        public string Group { get; private set; }

        public int Food { get; private set; }

        public void BuyFood()
        {
            Food += 5;
        }
        
    }
}
