namespace RoleplayGame
{
    public class Knight : Character
    {


        public Knight(string name, int attackValue, int defenseValue): base(name,attackValue,defenseValue)
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

        public int defenseValue
        {
            get
            {
                return Armor.DefenseValue + Shield.DefenseValue;
            }
        }



    }
}