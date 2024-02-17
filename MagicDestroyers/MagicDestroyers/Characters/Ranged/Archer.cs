using System;
namespace MagicDestroyers.Characters.Ranged
{
    public class Archer : Character
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

        public Archer()
        {
        }

        // Abilities

        public void ScatterShot()
        {
            throw new NotImplementedException();
        }

        public void PiercingShot()
        {
            throw new NotImplementedException();
        }

        public void TripleShot()
        {
            throw new NotImplementedException();
        }
    }
}
