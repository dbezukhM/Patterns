using System;

namespace TemplateMethod
{
    public abstract class Character
    {
        public void DefendAgainstAttack()
        {
            PickUpWeapon();
            DefenseAction();
            MoveToSafety();
            Console.WriteLine();
        }

        public abstract void DefenseAction();
        public abstract void MoveToSafety();
        public abstract void PickUpWeapon();
    }
}