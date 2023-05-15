namespace RoleplayGame
{
    public class Wizard : ICharacter
    {
        public int health = 100;
        public Wizard(string name)
        {

        }



        public SpellsBook SpellsBook { get; set; }

        public Staff Staff { get; set; }

        public int AttackValue
        {
            get
            {
                return SpellsBook.AttackValue + Staff.AttackValue;
            }
        }

        public int DefenseValue
        {
            get
            {
                return SpellsBook.DefenseValue + Staff.DefenseValue;
            }
        }
        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.health -= power - this.DefenseValue;
            }
        }
        public void Cure()
        {
            this.health = 100;
        }





    }
}