using System;
namespace MagicDestroyers.Characters.Equipment.Weapons
{
    public class Weapon
    {
        private int damage;
        private string name;
        private string type;

        public int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                if (value >= 1)
                {
                    damage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"The damage value for {name} must be at least 1.");
                }
            }
        }
        public string Name { get; set; }
        public string Type { get; set; }

        public Weapon()
        {
        }
    }
}
