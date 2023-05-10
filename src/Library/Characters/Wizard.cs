namespace RoleplayGame
{
    public class Wizard : Character
    {

        public Wizard(string name, int attackValue, int defenseValue): base(name,attackValue,defenseValue)
        {

        }



        public SpellsBook SpellsBook { get; set; }

        public Staff Staff { get; set; }

        public int attackValue
        {
            get
            {
                return SpellsBook.AttackValue + Staff.AttackValue;
            }
        }

        public int defenseValue
        {
            get
            {
                return SpellsBook.DefenseValue + Staff.DefenseValue;
            }
        }


    }
}