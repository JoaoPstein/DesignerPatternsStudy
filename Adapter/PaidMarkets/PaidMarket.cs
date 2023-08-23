namespace Adapter.PaidMarkets
{
    public class PaidMarket : IPaidMarket
    {
        private Token token;

        public Token AuthToken()
        {
            return new Token();
        }

        public void ReceivePaymentWithPaidMarket()
        {
            token = AuthToken();
            Console.WriteLine("Recebendo pagamento com mercado pago");
        }

        public void SendPaymentWithPaidMarket()
        {
            token = AuthToken();
            Console.WriteLine("Enviando pagamento com mercado pago");
        }
    }
}
