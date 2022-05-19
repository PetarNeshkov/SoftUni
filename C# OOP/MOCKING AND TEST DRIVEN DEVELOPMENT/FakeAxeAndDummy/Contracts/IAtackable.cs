namespace FakeAxeAndDummy.Contracts
{
    public interface IAtackable
    {
        public int GiveExperience();
        public void TakeAttack(int attackPoints);
        public bool IsDead();
    }
}
