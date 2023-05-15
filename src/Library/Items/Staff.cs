namespace RoleplayGame
{
    public class Staff : IAttackItem , IDefenseItem, IItem
    {
        public int AttackValue 
        {
            get
            {
                return 20;
            } 
        }

        public int DefenseValue
        {
            get
            {
                return 100;
            }
        }
    }
}