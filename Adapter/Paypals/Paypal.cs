namespace Adapter.Paypals
{
    public class Paypal : IPaypalPayment
    {
        private Token token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void PaypalPayment()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento com PayPal");
        }

        public void PaypalReceive()
        {
            Console.WriteLine("Recebendo pagamento com PayPal");
        }
    }
}
