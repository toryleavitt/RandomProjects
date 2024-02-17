using System;
using MagicDestroyers.Characters.Equipment.Armor;
using MagicDestroyers.Characters.Equipment.Weapons;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior : Character
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
                if (value <= 120)
                {
                    healthPoints = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"The health for {Name} cannot exceed 120 points");

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
                if (value <= 25)
                {
                    healthPoints = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"The abiltiy points for {Name} cannot exceed 25 points");
                }

            }
        }

        public Warrior()
        {

        }

        // Abilities

        public void Strike()
        {
            throw new NotImplementedException();
        }
        public void Execute()
        {
            throw new NotImplementedException();
        }
        public void SkinHarden()
        {
            throw new NotImplementedException();
        }
    }
}
