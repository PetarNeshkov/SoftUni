
namespace WildFarm.Models.Animal
{
    public abstract class Mammal : Animal
    {
        protected Mammal(string name, double weight,string livingregion) 
            : base(name, weight)
        {
            LivingRegion = livingregion;
        }
        public string LivingRegion { get;}
        public override string ToString()
        {
            return base.ToString()+$"{Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
