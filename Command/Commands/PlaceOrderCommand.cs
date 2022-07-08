using Command.Service;

namespace Command.Commands
{
    public class PlaceOrderCommand : Command
    {
        public PlaceOrderCommand(Jacket jacket) : base(jacket)
        {
        }

        public override void Execute()
        {
            _jacket.placeOrder();
        }
    }
}