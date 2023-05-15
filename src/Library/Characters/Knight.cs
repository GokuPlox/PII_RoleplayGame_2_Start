namespace RoleplayGame
{
    public class Knight : ICharacter
    {

        public int health = 100;
        public string Name { get; set; }
        
        public Knight(string name, int attackValue, int defenseValue)
        {
            this.Name = name;
        }

        

        public Sword Sword { get; set; }

        public Shield Shield { get; set; }

        public Armor Armor { get; set; }

        public int attackValue
        {
            get
            {
                return Sword.AttackValue;
            }
        }

        public int DefenseValue
        {
            get
            {
                return Armor.DefenseValue + Shield.DefenseValue;
            }

        }

        public int Health
        {
            get
            {
                return this.health;
            }
            private set
            {
                this.health = value < 0 ? 0 : value;
            }
        }
        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.Health -= power - this.DefenseValue;
            }
        }

        public void Cure()
        {
            this.Health = 100;
        }



    }
}