using System;
using MagicDestroyers.Characters.Equipment.Armor;
using MagicDestroyers.Characters.Equipment.Weapons;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Mage : Character
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
                if (value <= 70)
                {
                    healthPoints = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"The health for {Name} cannot exceed 70 points");

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
                if (value <= 70)
                {
                    healthPoints = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"The abiltiy points for {Name} cannot exceed 70 points");
                }

            }
        }

        public Mage()
        {

        }

        //Abilities

        public void ArcaneWrath()
        {
            throw new NotImplementedException();
        }

        public void Firewall()
        {
            throw new NotImplementedException();
        }

        public void Meditation()
        {
            throw new NotImplementedException();
        }
    }
}
