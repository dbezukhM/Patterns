namespace Command
{
    public class OrderHandler
    {
        public void invoke(Command command)
        {
            command.Execute();
        }
    }
}
