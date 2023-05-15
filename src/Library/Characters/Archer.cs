namespace RoleplayGame
{
    public class Archer : Character
    {


        public Archer(string name, int defenseValue): base(name)
        {

        }
        
        public Bow Bow { get; set; }

        public Helmet Helmet { get; set; }
        

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
                return Helmet.DefenseValue;
            }
        }
        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                Character.Health -= power - this.DefenseValue;
            }
        }




    }
}