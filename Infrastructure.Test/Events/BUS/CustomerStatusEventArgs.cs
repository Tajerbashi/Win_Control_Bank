namespace Infrastructure.Test.Events.BUS
{
    public class CustomerStatusEventArgs : EventArgs
    {
        public Guid Key { get; private set; }
        public CustomerStatusEventArgs(Guid key)
        {
            Key = key;
        }
    }
}
