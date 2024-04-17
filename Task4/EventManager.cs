using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public delegate void EventHandler();
    class EventManager
    {
        public event EventHandler CustomEvent;

        public void TriggerEvent()
        {
           
                CustomEvent?.Invoke();
            
        }
        public void AddEventHandler(EventHandler handler)
        {
            CustomEvent += handler;
        }

        public void RemoveEventHandler(EventHandler handler)
        {
            CustomEvent -= handler;
        }
    }
}
