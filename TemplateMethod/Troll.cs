using System;

namespace TemplateMethod
{
    public class Troll : Character
    {
        public override void DefenseAction()
        {
            Console.WriteLine("Defend with club");
        }

        public override void MoveToSafety()
        {
            Console.WriteLine("Return to the mountain");
        }

        public override void PickUpWeapon()
        {
            Console.WriteLine("Pick up club");
        }
    }
}