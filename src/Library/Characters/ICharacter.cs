namespace RoleplayGame
{

    /// <summary>
    /// Esta interfaz permite agrupar los diferentes personajes de nuestro programa y las clases que los representan
    /// Permite definir los atributos y metodos que van a compartir cada uno de ellos
    /// </summary>
    public interface ICharacter
    {
        void ReceiveAttack(int power);
        void Cure();
        int Health{get;}
        int DefenseValue{get;}
        int AttackValue{get;}



    }
}