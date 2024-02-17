using System;
using MagicDestroyers.Characters.Equipment.Armor.Pieces;

namespace MagicDestroyers.Characters.Equipment.Armor
{
    public class Armor
    {
        private int defensePoints;
        private string armorType;
        private string armorClass;

        public int DefensePoints { get; set; }

        public string ArmorType
        {
            get
            {
                return armorType;
            }
            set
            {
                if(value.ToLower().Equals("platemail"))
                {
                    armorType = value;
                    ArmorClass = "Heavy";
                }

                else if (value.ToLower().Equals("dragon scale"))
                {
                    armorType = value;
                    ArmorClass = "Heavy";
                }

                else if (value.ToLower().Equals("studded leather"))
                {
                    armorType = value;
                    ArmorClass = "Medium";
                }

                else if (value.ToLower().Equals("scalemail"))
                {
                    armorType = value;
                    ArmorClass = "Medium";
                }

                else if (value.ToLower().Equals("cloth robe"))
                {
                    armorType = value;
                    ArmorClass = "Light";
                }

                else if (value.ToLower().Equals("hardened leather"))
                {
                    armorType = value;
                    ArmorClass = "Light";
                }

                else
                {
                    throw new ArgumentException();
                }
            }

        }
        public string ArmorClass
        {
            get
            {
                return armorClass;
            }
            private set
            {
                armorClass = value;
            }
        }

        public Armor()
        {

        }
    }
}
