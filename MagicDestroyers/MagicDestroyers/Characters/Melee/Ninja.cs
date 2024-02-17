using System;
namespace MagicDestroyers.Characters.Melee
{
    public class Ninja : Character
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

        public Ninja()
        {
        }

        // Abilities

        public void Ambush()
        {
            throw new NotImplementedException();
        }

        public void RoundhouseKick()
        {
            throw new NotImplementedException();
        }

        public void NinjaChop()
        {
            throw new NotImplementedException();
        }

    }
}
