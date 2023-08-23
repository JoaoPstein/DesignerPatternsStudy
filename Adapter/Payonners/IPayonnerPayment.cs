namespace Adapter.Payonners
{
    public interface IPayonnerPayment
    {
        Token AuthToken();
        void SendPayment();
        void ReceivePayment();
    }
}
