using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEventBus
{
    class SubscriptionsCollection
    {
        private Dictionary<Tuple<Type, object>, Action<Object>> objRef = new Dictionary<Tuple<Type, object>, Action<Object>>();

        public List<Action<Object>> GetAll(Type type)
        {
            return objRef
                .Where((t, _) => t.Key.Item1 == type)
                .Select(t => t.Value)
                .ToList();
        }


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


        public void Add(Object o, Type t, Action<Object> a)
        {
            objRef.Add(new Tuple<Type, object>(t, o), a);
        }

    }

 

}
