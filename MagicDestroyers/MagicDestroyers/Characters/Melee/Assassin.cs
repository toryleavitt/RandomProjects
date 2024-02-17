using System;
using MagicDestroyers.Characters.Equipment.Armor;
using MagicDestroyers.Characters.Equipment.Weapons;

namespace MagicDestroyers.Characters.Melee
{
    public class Assassin : Character
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
                if (value <= 80)
                {
                    healthPoints = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"The health for {Name} cannot exceed 80 points");

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
                if (value <= 60)
                {
                    healthPoints = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"The abiltiy points for {Name} cannot exceed 60 points");
                }

            }
        }



        public Assassin()
        {
            
        }

        // Abilities

        public void Raze()
        {
            throw new NotImplementedException();
        }

        public void BleedToDeath()
        {
            throw new NotImplementedException();
        }

        public void Survival()
        {
            throw new NotImplementedException();
        }
    }
}
