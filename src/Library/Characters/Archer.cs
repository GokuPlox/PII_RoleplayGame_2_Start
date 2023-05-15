namespace RoleplayGame
{
    public class Archer : ICharacter
    {


        public Archer(string name)
        {
            this.Name= name;
        } 
        public string Name { get; set; }
        
        public int health = 100;
        
        public Bow Bow { get; set; }

        public Helmet Helmet { get; set; }

        //public int  Health {get;set;}
        

        public int Defense {get; set;}
        

        public int attackValue
        {
            get
            {
                return Bow.AttackValue;
            }
        }

        public int defenseValue
        {
            get
            {
                this.Defense = Helmet.DefenseValue;
                return Defense;
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
            if (Defense < power)
            {
                this.Health -= power - this.Defense;
            }
        }
        public void Cure()
        {
            this.Health = 100;
        }



    }
}