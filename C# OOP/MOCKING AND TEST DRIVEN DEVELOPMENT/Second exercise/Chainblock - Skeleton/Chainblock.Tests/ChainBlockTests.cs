using Chainblock.Contracts;
using Chainblock.Models;
using NUnit.Framework;
using System;


namespace Chainblock.Tests
{
    [TestFixture]
    public class ChainBlockTests
    {
        public ITransaction Transaction { get; set; }
        public IChainblock Chainblock { get; set; }
        [SetUp]
        public void SetUp()
        {
             Transaction = new Transaction()
            {
                Id = 1,
                From = "Filip",
                To = "Viktor",
                Status = TransactionStatus.Successfull,
                Amount = 1
            };
             Chainblock = new ChainBlock();
        }
        [Test]
        [Category("[Add method]")]
        public void Given_Transaction_When_AddTransactionIsCallen_Then_TransactionsCountIncrease()
        {
            int expectedCount = 1;


            Chainblock.Add(Transaction);

            Assert.AreEqual(expectedCount, Chainblock.Count);
        }

        [Test]
        [Category("[Add method]")]
        public void Given_DuplicateTransaction_When_AddTransactionIsCallen_Then_ThrownInvalidOperationException()
        {
            Chainblock.Add(Transaction);

            Assert.Throws<InvalidOperationException>(() => Chainblock.Add(Transaction));
        }
        [Test]
        [Category("[Count property]")]
        public void Given_PropertyCountValue_WhenCountGetterIsCalled_Then_ProperNumberIsReturned()
        {
            int expectedChainBlockCount = 0;
            Assert.AreEqual(expectedChainBlockCount, Chainblock.Count);
        }
        [Test]
        [Category("[Contains] --> id method")]
        public void Given_NegativeId_When_ContainsByIsCalled_Then_ReturnTrue()
        {
            Chainblock.Add(Transaction);
            bool result= Chainblock.Contains(Transaction);

            Assert.IsTrue(result);
        }
        [Test]
        [Category("[Contains] --> id method")]
        public void Given_NegativeId_When_ContainsByIsCalled_Then_ReturnFalse()
        {
            Assert.That(Chainblock.Contains(Transaction), Is.False);
        }
        [Test]
        [Category("[Contains] --> id method")]
        public void Given_NegativeId_When_ContainsByIsCalled_Then_ThroInvalidArgumentException()
        {
            int invalidId = -1;
            Assert.Throws<ArgumentException>(() => this.Chainblock.Contains(invalidId));
        }
        [Test]
        [Category("[Cotains] --> Transaction method")]
        public void Given_ExistingTransaction_When_ContainsByIdTransactionIsCalled_Then_ReturnTrue()
        {
            Chainblock.Add(Transaction);
            Assert.That(Chainblock.Contains(Transaction), Is.True);  
        }
        [Test]
        [Category("[Cotains] --> Transaction method")]
        public void Given_ExistingTransaction_When_ContainsByIdTransactionIsCalled_Then_ReturnFalse()
        {

            Assert.IsFalse(Chainblock.Contains(Transaction));
        }
        [Test]
        [Category("[ChangeTransactionStatus] method")]
        public void Given_ValidAndStatus_When_ChangeTransactionStatusIsCalled_Then_StatusIsChanged()
        {
            Transaction.Status = TransactionStatus.Successfull;
            Chainblock.Add(Transaction);
            var newStatus = TransactionStatus.Aborted;

            this.Chainblock.ChangeTransactionStatus(Transaction.Id,newStatus);
            Assert.AreEqual(newStatus, Transaction.Status);
           
        }
        [Test]
        [Category("[ChangeTransactionStatus] method")]
        public void Given_ValidAndNamesAndStatus_When_ChangeTransactionIsCalled_ThenThrowInvalidOperationEception()
        {
            Transaction.Status = TransactionStatus.Successfull;
            Chainblock.Add(Transaction);
            TransactionStatus newStatus = TransactionStatus.Successfull;

            Assert.Throws<Exception>(() =>
           Chainblock.ChangeTransactionStatus(Transaction.Id, newStatus));
        }
        [Test]
        [Category("[ChangeTransactionStatus] method")]
        public void Given_InvalidAndStatus_When_ChangeTransactionStatusIsCalled_Then_ThrowArgumentException()
        {
            this.Chainblock.Add(Transaction);
            int newExistingId = 2;
            Assert.Throws<ArgumentException>(() 
                =>Chainblock.ChangeTransactionStatus(newExistingId, TransactionStatus.Aborted));
        }
        [Test]
        [Category("[ChangeTransactionStatus] method")]
        public void Given_ValidAndNamesExistingStatusCode_When_ChangeTransactionIsCalled_ThenThrowInvalidOperationEception()
        {
            int invalidActionStatusValue = 15;

            Assert.Throws<InvalidOperationException>(()
               => Chainblock.ChangeTransactionStatus(Transaction.Id, (TransactionStatus)invalidActionStatusValue));
        }
        [Test]
        [TestCase(0)]
        [TestCase(1)]
        [Category("[ChangeTransactionStatus] method")]
        public void Given_InvalidAndNamesExistingStatusCode_When_ChangeTransactionIsCalled_ThenThrowInvalidOperationEception(int invalidId)
        {
            string expectedErrorMessage = "Id cannot be less or equal to 8";
            ArgumentException ex = Assert.Throws<ArgumentException>(
                delegate
                {
                    Chainblock.ChangeTransactionStatus(invalidId, TransactionStatus.Successfull);
                });

            Assert.That(ex.Message, Is.EqualTo(expectedErrorMessage));
        }
    }
}
