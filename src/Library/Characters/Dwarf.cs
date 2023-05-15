namespace RoleplayGame
{
    public class Dwarf : ICharacter
    {


        public Dwarf(string name)
        {
            this.Name=name;
        }
        public string Name {get;set;}
        public int health = 100;
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

        public int DefenseValue
        {
            get
            {
                return Shield.DefenseValue + Helmet.DefenseValue;
            }
        }
        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
            {
                this.health -= power - this.DefenseValue;
            }
        }

        public void Cure()
        {
            this.health=100;
        }

    }
}