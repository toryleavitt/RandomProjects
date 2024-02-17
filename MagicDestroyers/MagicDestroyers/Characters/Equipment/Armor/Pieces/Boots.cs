using System;
using MagicDestroyers.Characters;
namespace MagicDestroyers.Characters.Equipment.Armor.Pieces
{
    public class Boots : Armor
    {
        private int defensePoints;

        public new int DefensePoints { get; set; }

        public Boots(string armorType)
        {
            this.ArmorType = armorType;

            if (ArmorClass.Equals("Heavy"))
            {
                DefensePoints = 6;
                this.defensePoints += 6;
            }

            if (ArmorClass.Equals("Medium"))
            {
                DefensePoints = 4;
                this.defensePoints += 4;
            }

            if (ArmorClass.Equals("Light"))
            {
                DefensePoints = 2;
                this.defensePoints += 2;
            }

        }
    }
}
