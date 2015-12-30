using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleEventBus;

namespace SimpleBusTest
{
    class TestClass : IDisposable
    {
        public TestClass()
        {
            MainBus.Instance.Register(this);
        }

        public void Dispose()
        {
            MainBus.Instance.Unregister(this);
        }


        [Subscribe]
        public void OnButtonClicked(ButtonClickBusEvent e)
        {
            Console.WriteLine("Button click event handeled in TestClass instance: " + this.ToString());
        }

        [Subscribe]
        public void OnTextChangedEvent(TextChangedBusEvent e)
        {
            Console.WriteLine("Handling text change in TestClass object instance. New Text: " + e.Text);
        }

        
    }
}
