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



        public int DefenseValue {get ; set;}
        public Character(string name)
        {
            this.Name = name;
            this.Health = 100;

        }

        public void Cure()
        {
            this.Health = 100;
        }

    }
}