using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern
{
    public class ConcreteHandlerB : EventHandler
    {
        public override void HandleRequest(EventRequest request)
        {
            if (request.EventType == "TypeB")
            {
                Console.WriteLine($"Handler B обрабатывает запрос: {request.Content}");
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }

}
