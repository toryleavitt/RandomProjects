using System;

using MagicDestroyers.Characters.Melee;

namespace MagicDestroyers
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior Conan = new Warrior();
            Conan.Boots = new Characters.Equipment.Armor.Pieces.Boots("Studded Leather");
            Conan.SetDefensePoints();
            System.Console.WriteLine(Conan.DefensePoints);
        }
    }
}
