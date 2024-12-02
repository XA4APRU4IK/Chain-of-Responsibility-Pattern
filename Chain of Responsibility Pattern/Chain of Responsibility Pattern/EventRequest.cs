using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern
{
    public class EventRequest
    {
        public string EventType { get; }
        public string Content { get; }

        public EventRequest(string eventType, string content)
        {
            EventType = eventType;
            Content = content;
        }
    }

}
