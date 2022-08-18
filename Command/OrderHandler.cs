namespace Command
{
    public class OrderHandler
    {
        public void Invoke(Command command)
        {
            command.Execute();
        }
    }
}
