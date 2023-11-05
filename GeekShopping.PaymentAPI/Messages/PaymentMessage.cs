using GeekShopping.MessageBus;

namespace GeekShopping.PaymentAPI.Messages
{
    public class PaymentMessage : BaseMessage
    {
        public long OrderId {  get; set; }
        public string Name { set; get; }
        public string CardNumber { set; get; }
        public string CVV { set; get; }
        public string ExpiyryMonthYear { set; get; }
        public decimal PurchaseAmount { set; get; }
        public string Email { set; get; }
    }
}
