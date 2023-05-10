namespace RoleplayGame
{
    public abstract class Character

    {
        public string Name {get;set;}
        public int Health
        {
            get
            {
                return this.Health;
            }
            private set
            {
                this.Health = value < 0 ? 0 : value;
            }
        }

        public int AttackValue {get ; set;}

        public int DefenseValue {get ; set;}
        public Character(string name ,int attackValue, int defenseValue)
        {
            this.Name = name;
            this.Health = 100;
            this.AttackValue = attackValue;
            this.DefenseValue = defenseValue;
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