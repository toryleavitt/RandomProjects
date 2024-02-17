using System;
using MagicDestroyers.Characters.Equipment.Armor;
using MagicDestroyers.Characters.Equipment.Weapons;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Druid : Character
    {
        private int healthPoints;
        private int abilityPoints;

        public new int HealthPoints
        {
            get
            {
                return healthPoints;
            }

            set
            {
                if (value <= 90)
                {
                    healthPoints = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"The health for {Name} cannot exceed 90 points");

                }

            }
        }

        public new int AbilityPoints
        {
            get
            {
                return abilityPoints;
            }

            set
            {
                if (value <= 50)
                {
                    healthPoints = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"The abiltiy points for {Name} cannot exceed 50 points");
                }

            }
        }

        public Druid()
        {
           
        }

        // Abilities

        public void Moonfire()
        {
            throw new NotImplementedException();
        }

        public void Starburst()
        {
            throw new NotImplementedException();
        }

        public void OneWithNature()
        {
            throw new NotImplementedException();
        }
    }
}
