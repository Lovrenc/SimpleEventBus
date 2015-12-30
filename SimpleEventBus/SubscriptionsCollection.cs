using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEventBus
{
    /// <summary>
    /// Simple Subscriptions collection implementation.
    /// </summary>
    class SubscriptionsCollection
    {
        //All subscriptions are held in this dictionary
        private Dictionary<Tuple<Type, object>, Action<Object>> objRef = new Dictionary<Tuple<Type, object>, Action<Object>>();

        /// <summary>
        /// Returns list of actions that are subscribed for event that passes Type type as parameter.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public List<Action<Object>> GetAll(Type type)
        {
            return objRef
                .Where((t, _) => t.Key.Item1 == type)
                .Select(t => t.Value)
                .ToList();
        }

        /// <summary>
        /// Remove all subscriptions of Object o.
        /// </summary>
        /// <param name="o"></param>
        public void Remove(Object o)
        {
            var toRemove = objRef
                .Where(t => object.ReferenceEquals(t.Key.Item2, o))
                .Select(t => t.Key)
                .ToList();

            for (int i = 0; i < toRemove.Count(); i++)
            {
                objRef.Remove(toRemove[i]);
            }
        }

        /// <summary>
        /// Add subscription to the collection.
        /// </summary>
        /// <param name="o"></param>
        /// <param name="t"></param>
        /// <param name="a"></param>
        public void Add(Object o, Type t, Action<Object> a)
        {
            objRef.Add(new Tuple<Type, object>(t, o), a);
        }

    }

 

}
