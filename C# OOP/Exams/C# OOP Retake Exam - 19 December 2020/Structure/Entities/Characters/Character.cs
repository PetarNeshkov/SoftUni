using System;

using WarCroft.Constants;
using WarCroft.Entities.Inventory;
using WarCroft.Entities.Items;

namespace WarCroft.Entities.Characters.Contracts
{
    public abstract class Character
    {
        // TODO: Implement the rest of the class.
        private string name;
        private double health;
        private double armor;

        public Character(string name, double health, double armor, double abilityPoints, Bag bag)
        {
            this.BaseHealth = health;
            this.BaseArmor = armor;

            this.Name = name;
            this.Health = health;
            this.Armor = armor;
            this.AbilityPoints = abilityPoints;
            this.Bag = bag;
        }
        public string Name {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.CharacterNameInvalid);
                }
                this.name = value;
            }
        }
        public double BaseHealth { get; private set; }
        public double Health
        {
            get => this.health;
            set
            {
                if (value <= this.BaseHealth && value >= 0)
                {
                    this.health = value;
                }
            }
        }


        public double BaseArmor { get; private set; }
        public double Armor
        {
            get => this.armor;
            set
            {
                if (value >= 0)
                {
                    this.armor = value;
                }
            }
        }

        public double AbilityPoints  { get; private set; }
        public Bag Bag { get; set; }
        public bool IsAlive { get; set; } = true;

		public void TakeDamage(double hitPoints)
        {
			EnsureAlive();
            if (this.Armor >= hitPoints)
            {
				this.Armor -= hitPoints;
            }
            else if (this.Armor < hitPoints)
            {
                hitPoints -= this.Armor;
                this.Armor = 0;
                this.Health -= hitPoints;

                if (this.Health <= 0)
                {
                    this.Health = 0;
                    this.IsAlive = false;
                }
            }
        }
        public void UseItem(Item item)
        {
            EnsureAlive();
            item.AffectCharacter(this);
        }

        protected void EnsureAlive()
		{
			if (!this.IsAlive)
			{
				throw new InvalidOperationException(ExceptionMessages.AffectedCharacterDead);
			}
		}
    }
}