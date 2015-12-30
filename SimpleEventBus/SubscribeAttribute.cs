using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEventBus
{
    /// <summary>
    /// Subscribe attribute annotates all methods that are listening for event bus events. 
    /// </summary>
    [System.AttributeUsage(System.AttributeTargets.Method)]
    public class SubscribeAttribute : Attribute
    {
        

    }
}
