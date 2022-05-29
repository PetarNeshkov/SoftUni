using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WarCroft.Constants;
using WarCroft.Entities.Characters;
using WarCroft.Entities.Characters.Contracts;
using WarCroft.Entities.Items;

namespace WarCroft.Core
{
    public class WarController
	{
		private Stack<Item> itemPool;
		private List<Character> characterParty;
		public WarController()
		{
			itemPool = new Stack<Item>();
			characterParty = new List<Character>();
		}

		public string JoinParty(string[] args)
		{
			var characterType = args[0];
			var name = args[1];
			Character character = null;

            if (characterType != "Warrior" && characterType != "Priest")
            {
				throw new ArgumentException(string.Format(ExceptionMessages.InvalidCharacterType, characterType));
            }
            if (characterType == "Warrior")
            {
				character = new Warrior(name);
            }
            else if (characterType == "Priest")
            {
				character = new Priest(name);
            }
			characterParty.Add(character);
			return string.Format(SuccessMessages.JoinParty, name);
		}

		public string AddItemToPool(string[] args)
		{
			var itemName = args[0];
			Item item = null;
            if (itemName != "FirePotion" && itemName != "HealthPotion")
            {
				throw new ArgumentException(string.Format(ExceptionMessages.InvalidItem, itemName));
            }
            if (itemName == "FirePotion")
            {
				item = new FirePotion();
            }
            else if (itemName == "HealthPotion")
            {
				item = new HealthPotion();
            }
			itemPool.Push(item);
			return string.Format(SuccessMessages.AddItemToPool, itemName);
		}

		public string PickUpItem(string[] args)
		{
			var name = args[0];
			var character = characterParty.FirstOrDefault(c => c.Name == name);

            if (character == null)
            {
				throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, name));
            }
            if (itemPool.Count == 0)
            {
				throw new InvalidOperationException(ExceptionMessages.ItemPoolEmpty);
			}
			var item = itemPool.Pop();
			character.Bag.AddItem(item);
			
			return string.Format(SuccessMessages.PickUpItem, name, item.GetType().Name);
		}

		public string UseItem(string[] args)
		{
			var characterName = args[0];
			var itemName = args[1];
			var character = characterParty.FirstOrDefault(c => c.Name == characterName);

            if (character == null)
            {
				throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, characterName));
            }
			var item = character.Bag.GetItem(itemName);
			character.UseItem(item);
			return string.Format(SuccessMessages.UsedItem, characterName, item.GetType().Name);
		}

		public string GetStats()
		{
			var sb = new StringBuilder();
			var sortedCharacters = characterParty
				.OrderByDescending(c => c.IsAlive)
				.ThenByDescending(c => c.Health);

            foreach (var character in sortedCharacters)
            {
				string characterStatus = character.IsAlive ? "Alive" : "Dead";
				sb.AppendLine($"{character.Name} - HP: {character.Health}/{character.BaseHealth}, AP: {character.Armor}/{character.BaseArmor}, Status: {characterStatus}");
            }
			return sb.ToString().TrimEnd();
		}

		public string Attack(string[] args)
		{
			var sb = new StringBuilder();
			var attackerName = args[0];
			var receiverName = args[1];

			var attacker = characterParty.FirstOrDefault(c => c.Name == attackerName);
			var reciever = characterParty.FirstOrDefault(c => c.Name == receiverName);

            if (attacker == null)
            {
				throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty,attackerName));
            }
            if (reciever == null)
            {
				throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, receiverName));
			}
            if (attacker.GetType().Name != "Warrior")
            {
				throw new ArgumentException(string.Format(ExceptionMessages.AttackFail, attackerName));
            }
			var warrior = (Warrior)attacker;
			warrior.Attack(reciever);
			sb.AppendLine(string.Format(SuccessMessages.AttackCharacter, attackerName, receiverName, warrior.AbilityPoints, receiverName, reciever.Health, reciever.BaseHealth, reciever.Armor, reciever.BaseArmor));
            if (!reciever.IsAlive)
            {
				sb.AppendLine(string.Format(SuccessMessages.AttackKillsCharacter, receiverName));
            }
			return sb.ToString().TrimEnd();
		}

		public string Heal(string[] args)
		{
			var healerName = args[0];
			var healingReceiverName = args[1];

			var healer = characterParty.FirstOrDefault(c => c.Name == healerName);
			var reciever = characterParty.FirstOrDefault(c => c.Name == healingReceiverName);
			if (healer == null)
			{
				throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, healer));
			}
			if (reciever == null)
			{
				throw new ArgumentException(string.Format(ExceptionMessages.CharacterNotInParty, reciever));
			}
			if (healer.GetType().Name != "Priest")
			{
				throw new ArgumentException(string.Format(ExceptionMessages.HealerCannotHeal, healerName));
			}
			var priest = (Priest)healer;
			priest.Heal(reciever);
			return string.Format(SuccessMessages.HealCharacter, healerName, healingReceiverName, healer.AbilityPoints, healingReceiverName, reciever.Health);
		}
	}
}
