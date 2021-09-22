namespace RoleplayGame
{
    public interface ICharacter
    {
        void ReceiveAttack(int power);
        void Cure();
        int Health{get;}
        int DefenseValue{get;}
        int AttackValue{get;}



    }
}