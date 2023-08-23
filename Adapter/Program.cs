using Adapter.PaidMarkets;
using Adapter.Paypals;

IPaypalPayment paypal = new PaidMarketAdapter(new PaidMarket());

paypal.PaypalPayment();
paypal.PaypalReceive();

//Payonner payonner = new Payonner();
//payonner.SendPayment();
//payonner.ReceivePayment();

Console.ReadLine();