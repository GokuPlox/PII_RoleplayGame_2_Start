namespace RoleplayGame
{
    public class Dwarf : Character
    {


        public Dwarf(string name): base(name)
        {
            this.DefenseValue = defenseValue;
        }

        public Axe Axe { get; set; }

        public Shield Shield { get; set; }

        public Helmet Helmet { get; set; }

        public int attackValue
        {
            get
            {
                return Axe.AttackValue;
            }
        }

        public int defenseValue
        {
            get
            {
                return Shield.DefenseValue + Helmet.DefenseValue;
            }
        }


    }
}