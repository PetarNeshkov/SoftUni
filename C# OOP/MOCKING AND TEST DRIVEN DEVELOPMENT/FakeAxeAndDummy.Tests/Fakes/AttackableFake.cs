using FakeAxeAndDummy.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace FakeAxeAndDummy.Tests.Fakes
{
    public class AttackableFake : IAtackable
    {
        public int GiveExperience()
        {
            return 20;
        }

        public bool IsDead()
        {
            return true;
        }

        public void TakeAttack(int attackPoints)
        {
           
        }
    }
}
