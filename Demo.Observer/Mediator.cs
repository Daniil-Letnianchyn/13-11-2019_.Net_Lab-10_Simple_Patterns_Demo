using System;
using System.Collections.Generic;
using System.Text;

namespace Demo.Observer
{
    public class Mediator
    {
        private static Mediator _singletoneInstance = new Mediator();

        public static Mediator GetInstance()
        {
            return _singletoneInstance;
        }

        private Mediator()
        {

        }

        public event EventHandler customEvent;

        public virtual void OnEventRised()
        {
            (customEvent as EventHandler)?.Invoke(this, EventArgs.Empty);
        }
    }
}
