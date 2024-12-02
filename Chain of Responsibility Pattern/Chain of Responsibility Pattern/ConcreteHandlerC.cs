using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern
{
    public class ConcreteHandlerC : EventHandler
    {
        public override void HandleRequest(EventRequest request)
        {
            if (request.EventType == "TypeC")
            {
                Console.WriteLine($"Handler C обрабатывает запрос: {request.Content}");
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }

}
