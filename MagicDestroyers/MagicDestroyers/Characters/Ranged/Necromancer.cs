using System;
using MagicDestroyers.Characters.Equipment.Armor;
using MagicDestroyers.Characters.Equipment.Weapons;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Necromancer : Character
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
                if (value <= 100)
                {
                    healthPoints = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"The health for {Name} cannot exceed 100 points");
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
                if (value <= 40)
                {
                    healthPoints = value;
                }

                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $@"The abiltiy points for {Name} cannot exceed 40 points");
                }

            }
        }

        public Necromancer()
        {

        }

        // Abilities

        public void ShadowRage()
        {
            throw new NotImplementedException();
        }

        public void VampireTouch()
        {
            throw new NotImplementedException();
        }

        public void BoneShield()
        {
            throw new NotImplementedException();
        }
    }
}
