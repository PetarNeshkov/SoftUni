using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace BankSafe.Tests
{
    public class BankVaultTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AddItemShouldThrowExeptionWhenCellDoesntExists()
        {
            var BankVault = new BankVault();
            Item item = new Item("Pencho", "12");

            Assert.Throws<ArgumentException>(() => BankVault.AddItem("1", item));
        }

        [Test]
        public void AddItemShouldThrowExceptionAtTakenCell()
        {
            Item item = new Item("Pencho", "12");
            Item item1 = new Item("Gosho", "13");
            var BankVault = new BankVault();

            BankVault.AddItem("A1", item);

            Assert.Throws<ArgumentException>(() => BankVault.AddItem("A1", item1));
        }

        [Test]
        public void ItemAlreadyInCellExp()
        {
            Item item = new Item("Pencho", "12");
            Item item1 = new Item("Gosho", "12");
            var BankVault = new BankVault();

            BankVault.AddItem("A1", item);

            Assert.Throws<InvalidOperationException>(()=>BankVault.AddItem("B2",item1));
        }

        [Test]
        public void ItemAddedSuccessfully()
        {
            var BankVault = new BankVault();
            Item item = new Item("Pencho", "12");

            BankVault.AddItem("A1", item);

            string expectedId = "12";
            var actualCount = BankVault.VaultCells["A1"].ItemId;

            Assert.AreEqual(expectedId, actualCount);

            string expectedName = "Pencho";
            var actualName = BankVault.VaultCells["A1"].Owner;

            Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        public void RemoveItemAtCertainCellExp()
        {
            var BankVault = new BankVault();
            Item item = new Item("Pencho", "12");

            Assert.Throws<ArgumentException>(() =>BankVault.RemoveItem("1",item));
        }

        [Test]
        public void RemoveInvalidItemAtCertainCellExp()
        {
            var BankVault = new BankVault();
            Item item = new Item("Pencho", "12");
            Item item1 = new Item("Gosho", "13");
            BankVault.AddItem("A1", item);

            Assert.Throws<ArgumentException>(() => BankVault.RemoveItem("A1", item1));
        }

        [Test]
        public void SuccessfullyRemovedItem()
        {
            var BankVault = new BankVault();
            Item item = new Item("Pencho", "12");

            BankVault.AddItem("A1", item);
            BankVault.RemoveItem("A1", item);


            var actualResult = BankVault.VaultCells["A1"];

            Assert.AreEqual(null, actualResult);
        }
    }
}