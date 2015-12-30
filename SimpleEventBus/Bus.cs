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
        

        public void Register(Object item)
        {
            var type = item.GetType();
            var methods = type.GetMethods();

            

            var attrs = methods
                .Where(prop => Attribute.IsDefined(prop, typeof(SubscribeAttribute)));
                

            foreach (var attr in attrs)
            {
                var pDelegate = attr.GetParameters().First().ParameterType;
                var name = attr.Name;

                var action = new Action<Object>(el =>
                {
                    attr.GetBaseDefinition().Invoke(item, new Object[] {el});
                });
                
                subs.Add(item, pDelegate, action);

                //attr.GetBaseDefinition().Invoke(item, new object[] {null});
                //Console.WriteLine("-------------" + attr.Name);
            }
        }


        public void Unregister(Object obj)
        {
            subs.Remove(obj);
        }



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
