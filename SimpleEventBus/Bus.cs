using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SimpleEventBus
{
    /// <summary>
    /// Simple Event Bus implementation. 
    /// </summary>
    public class Bus
    {
        private SubscriptionsCollection subs = new SubscriptionsCollection();
        
        /// <summary>
        /// Registers object to the bus. Registered objects receive the bus events.
        /// </summary>
        /// <param name="item"></param>
        public void Register(Object item)
        {
            var type = item.GetType();
            var methods = type.GetMethods();
            
            //Find all the Subscribe attributes
            var attrs = methods
                .Where(prop => Attribute.IsDefined(prop, typeof(SubscribeAttribute)));
                

            foreach (var attr in attrs)
            {
                var pDelegate = attr.GetParameters().First().ParameterType;
                var name = attr.Name;

                //Create action for every subscribe attribute and add it to our subscriptions collection
                var action = new Action<Object>(el =>
                {
                    attr.GetBaseDefinition().Invoke(item, new Object[] {el});
                });
                subs.Add(item, pDelegate, action);
            }
        }

        /// <summary>
        /// Unregister from the event bus.
        /// </summary>
        /// <param name="obj"></param>
        public void Unregister(Object obj)
        {
            subs.Remove(obj);
        }


        /// <summary>
        /// Post new event to the bus. Event will be received on every registered object,
        /// that is listening for events with given object type.
        /// </summary>
        /// <param name="e"></param>
        public void Post(Object e)
        {
            List<Action<Object>> actions;
            var s = subs.GetAll(e.GetType());
            foreach (var c in s)
            {
                c.Invoke(e);
            }
        }
        


    }
}
