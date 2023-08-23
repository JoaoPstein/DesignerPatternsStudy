namespace Adapter.Paypals
{
    public interface IPaypalPayment
    {
        Token AuthToken();
        void PaypalPayment();
        void PaypalReceive();
    }
}
