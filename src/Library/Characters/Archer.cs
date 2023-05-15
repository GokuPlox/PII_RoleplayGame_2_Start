namespace RoleplayGame
{
    public class Archer : ICharacter
    {


        public Archer(string name)
        {
        }
        
        public Bow Bow { get; set; }

        public Helmet Helmet { get; set; }

        public int  Health {get;set;}
        

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
        public void ReceiveAttack(int power)
        {
            if (Defense < power)
            {
                Health -= power - this.Defense;
            }
        }




    }
}