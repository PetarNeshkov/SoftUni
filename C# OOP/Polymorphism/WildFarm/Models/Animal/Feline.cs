
namespace WildFarm.Models.Animal
{
    public abstract class Feline : Mammal
    {
        protected Feline(string name, double weight, string livingregion, string breed)
            : base(name, weight, livingregion)
        {
            Breed = breed;
        }
        public string Breed { get; }
        public override string ToString()
        {
            return $"{GetType().Name} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
