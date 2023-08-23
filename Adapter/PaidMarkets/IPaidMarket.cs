namespace Adapter.PaidMarkets
{
    public interface IPaidMarket
    {
        Token AuthToken();
        void ReceivePaymentWithPaidMarket();
        void SendPaymentWithPaidMarket();
    }
}
