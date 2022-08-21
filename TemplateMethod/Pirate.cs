using System;

namespace TemplateMethod
{
    public class Pirate : Character
    {
        public override void DefenseAction()
        {
            Console.WriteLine("Defend with sword");
        }

        public override void MoveToSafety()
        {
            Console.WriteLine("Return to the ship");
        }

        public override void PickUpWeapon()
        {
            Console.WriteLine("Pick up sword");
        }
    }
}