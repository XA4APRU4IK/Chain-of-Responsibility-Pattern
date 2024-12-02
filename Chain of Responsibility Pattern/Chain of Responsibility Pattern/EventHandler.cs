using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chain_of_Responsibility_Pattern
{
    public abstract class EventHandler
    {
        protected EventHandler _nextHandler;

        public void SetNext(EventHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public virtual void HandleRequest(EventRequest request)
        {
            if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
        }
    }

}
