using System;

namespace ClassLibrary1
{
    //child class of EventArgs
    public class CustomEventArgs: EventArgs
    {
        public int a { get; set; }
        public int b { get; set; }
    }

    //publisher
    public class Publisher
    {
        //step 1: create event
        public event EventHandler<CustomEventArgs> myEvent;

        public void RaiseEvent(object sender, int a, int b)
        {
            //step 2: raise event
            if (this.myEvent != null)
            {
                CustomEventArgs customEventArgs = new CustomEventArgs() { a = a, b = b };
                this.myEvent(sender, customEventArgs);
            }
        }
    }
}
