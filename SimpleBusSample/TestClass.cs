using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleEventBus;

namespace SimpleBusTest
{
    /// <summary>
    /// Test class that subscribes to two kinds of EventBus events. 
    /// </summary>
    class TestClass : IDisposable
    {
        public TestClass()
        {
            //Subscribe to the Event Bus
            MainBus.Instance.Register(this);
        }

        public void Dispose()
        {
            //Unregister from the event bus; important so we release references and enable GC to collect;
            MainBus.Instance.Unregister(this);
        }

        /// <summary>
        /// Subscribe for events that pass ButtonClickBusEvent
        /// </summary>
        /// <param name="e"></param>
        [Subscribe]
        public void OnButtonClicked(ButtonClickBusEvent e)
        {
            Console.WriteLine("Button click event handeled in TestClass instance: " + this.ToString());
        }

        /// <summary>
        /// Subscribes for events that pass TextChangedBusEvent
        /// </summary>
        /// <param name="e"></param>
        [Subscribe]
        public void OnTextChangedEvent(TextChangedBusEvent e)
        {
            Console.WriteLine("Handling text change in TestClass object instance. New Text: " + e.Text);
        }

        
    }
}
