using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekShopping.MessageBus
{
    public interface IMessageBus
    {
        Task PublicMessage(BaseMessage message, string queueName);
    }
}
