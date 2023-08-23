using Adapter.Paypals;

namespace Adapter.Payonners
{
    public class PayonnerAdapter : IPaypalPayment
    {
        private Payonner _payonner;

        public PayonnerAdapter(Payonner payonner)
        {
            _payonner = payonner;
        }

        public Token AuthToken()
        {
            return _payonner.AuthToken();
        }

        public void PaypalPayment()
        {
            _payonner.SendPayment();
        }

        public void PaypalReceive()
        {
            _payonner.ReceivePayment();
        }
    }
}
