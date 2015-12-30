# SimpleEventBus

This is very basic Event Bus implementation written in c#.


## USAGE

Create a new instance of an event bus.

    Bus bus = new Bus();
    
### PUBLISHING

To publish an event use post method like so:

    bus.Post(new LanistersSlainedEvent(5));
    
You can use whatever object you wish as event parameter;

### SUBSCRIBING

To subscribe to an event annotate a method with [Subscribe] annotation. Subscription method must return void and only use one parameter.
Below you can see an example of an subscription method that listened for events that pass LanistersSlainedEvent parameter.

    [Subscribe]
    public void WhateverNameYouWant(LanistersSlainedEvent e)
    {
        //Do something
    }
    
One more thing you have to do, for object to start listening for bus events is calling `Register` method. 

    bus.Register(this);
    
When `Register` is called, Bus will collect subscription functions and add them to its collection.
To cancel the subscriptions you must call `Unregister`. You should also call `Unregister` when disposing of class.






