using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleEventBus;

namespace SimpleBusTest
{
    class MainBus
    {
        private static readonly Bus instance = new Bus();

        public static Bus Instance
        {
            get { return instance; }
        }

        private MainBus()
        {
        }


    }
}
