using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern
{
    public class ConcreteHandlerA : EventHandler
    {
        public override void HandleRequest(EventRequest request)
        {
            if (request.EventType == "TypeA")
            {
                Console.WriteLine($"Handler A обрабатывает запрос: {request.Content}");
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }
}
