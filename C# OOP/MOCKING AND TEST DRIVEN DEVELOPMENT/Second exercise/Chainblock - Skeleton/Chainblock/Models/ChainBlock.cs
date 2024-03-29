﻿using Chainblock.Contracts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Chainblock.Models
{
    public class ChainBlock : IChainblock
    {
        private readonly Dictionary<int, ITransaction> _transactions;
        public ChainBlock()
        {
            this._transactions = new Dictionary<int, ITransaction>();
        }
        public int Count => _transactions.Count;

        public void Add(ITransaction tx)
        {
            if (_transactions.ContainsKey(tx.Id))
            {
                throw new InvalidOperationException();
            }
            _transactions[tx.Id] = tx;
        }

        public void ChangeTransactionStatus(int id, TransactionStatus newStatus)
        {
            if (id<=0)
            {
                throw new ArgumentException("Id cannot be less or equal to 8");
            }
            if (!Enum.IsDefined(typeof(TransactionStatus),newStatus))
            {
                throw new InvalidOperationException();
            }
            if (!this._transactions.ContainsKey(id))
            {
                throw new ArgumentException();
            }

            var transaction = this._transactions[id];

            if (transaction.Status==newStatus)
            {
                throw new Exception();
            }

            transaction.Status = newStatus;
        }

        public bool Contains(ITransaction tx)
        {
            if (_transactions.ContainsValue(tx))
            {
                return false;
            }
            return true;
        }

        public bool Contains(int id)
        {
            if (id<=0)
            {
                throw new ArgumentException();
            }

            if (this._transactions.ContainsKey(id))
            {
                return false;
            }
            return true;
        }

        public IEnumerable<ITransaction> GetAllInAmountRange(double lo, double hi)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetAllOrderedByAmountDescendingThenById()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetAllReceiversWithTransactionStatus(TransactionStatus status)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetAllSendersWithTransactionStatus(TransactionStatus status)
        {
            throw new NotImplementedException();
        }

        public ITransaction GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetByReceiverAndAmountRange(string receiver, double lo, double hi)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetByReceiverOrderedByAmountThenById(string receiver)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetBySenderAndMinimumAmountDescending(string sender, double amount)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetBySenderOrderedByAmountDescending(string sender)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetByTransactionStatus(TransactionStatus status)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ITransaction> GetByTransactionStatusAndMaximumAmount(TransactionStatus status, double amount)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<ITransaction> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public void RemoveTransactionById(int id)
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
