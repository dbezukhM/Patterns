namespace TemplateMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Character character = new Pirate();
            character.DefendAgainstAttack();

            character = new Troll();
            character.DefendAgainstAttack();
        }
    }
}