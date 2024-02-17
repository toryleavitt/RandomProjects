using System;
using MagicDestroyers.Characters.Equipment.Weapons;
using MagicDestroyers.Characters.Equipment.Armor.Pieces;

namespace MagicDestroyers.Characters
{
    public class Character
    {

        private int abilityPoints;
        private int healthPoints;
        private int level;
        private int defensePoints;

        private string faction;
        private string name;

        private Boots boots;
        private Gloves gloves;
        private Helmet helmet;
        private ChestPiece chestPiece;
        private Leggings leggings;

        private Weapon weapon;

        public int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }
            set
            {
                if(value > 0)
                {
                    abilityPoints = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"The ability points for {name} must be greater than 0");
                }
            }
         }

        public int HealthPoints
        {
            get
            {
                return healthPoints;
            }
            set
            {
                if (value > 0)
                {
                    healthPoints = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"The health points for {name} must be greater than 0");
                }
            }
        }

        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                if (value > 0)
                {
                    level = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"The level for {name} must be greater than 0");
                }
            }
        }

        public int DefensePoints
        {
            get
            {
                return defensePoints;
            }
            set
            {
                SetDefensePoints();

            }
        }

        public void SetDefensePoints()
        {
            defensePoints = 0;

            if (Boots != null)
            {
                defensePoints += Boots.DefensePoints;
            }

            if (Gloves != null)
            {
                defensePoints += Gloves.DefensePoints;
            }

            if (Helmet != null)
            {
                defensePoints += Helmet.DefensePoints;
            }

            if (ChestPiece != null)
            {
                defensePoints += ChestPiece.DefensePoints;
            }

            if (Leggings != null)
            {
                defensePoints += Leggings.DefensePoints;
            }
        }

        public string Faction
        {
            get
            {
                return faction;
            }
            set
            {
                if (value.ToLower().Equals("melee") || value.ToLower().Equals("ranged"))
                {
                    faction = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"The faction for {name} must be either 'melee' or 'ranged'");
                }
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value.Length > 0)
                {
                    name = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "The name of your character has to have at least one character.");
                }
            }
        }

        public Boots Boots { get; set; }
        public Gloves Gloves { get; set; }
        public Helmet Helmet { get; set; }
        public Leggings Leggings { get; set; }
        public ChestPiece ChestPiece { get; set; }


        public Character()
        {
        }
    }
}
