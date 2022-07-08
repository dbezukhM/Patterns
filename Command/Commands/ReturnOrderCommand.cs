using Command.Service;

namespace Command.Commands
{
    internal class ReturnOrderCommand : Command
    {
        public ReturnOrderCommand(Jacket jacket) : base(jacket)
        {
        }

        public override void Execute()
        {
            _jacket.returnOrder();
        }
    }
}