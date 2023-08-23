using Adapter.Paypals;

namespace Adapter.PaidMarkets
{
    public class PaidMarketAdapter : IPaypalPayment
    {
        private PaidMarket _paidMarket;

        public PaidMarketAdapter(PaidMarket paidMarket)
        {
            _paidMarket = paidMarket;
        }

        public Token AuthToken()
        {
            return _paidMarket.AuthToken();
        }

        public void PaypalPayment()
        {
            _paidMarket.SendPaymentWithPaidMarket();
        }

        public void PaypalReceive()
        {
            _paidMarket.ReceivePaymentWithPaidMarket();
        }
    }
}
