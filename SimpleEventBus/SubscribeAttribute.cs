﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleEventBus
{
    [System.AttributeUsage(System.AttributeTargets.Method)]
    public class SubscribeAttribute : Attribute
    {
        

    }
}
