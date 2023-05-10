namespace RoleplayGame
{
    public class Archer : Character
    {


        public Archer(string name, int attackValue, int defenseValue): base(name,attackValue,defenseValue)
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



    }
}