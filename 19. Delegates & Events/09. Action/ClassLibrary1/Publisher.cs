using System;

namespace ClassLibrary1
{
    //publisher
    public class Publisher
    {
        //step 1: create event
        public event Action<int, int> myEvent;

        public void RaiseEvent(int a, int b)
        {
            //step 2: raise event
            if (this.myEvent != null)
            {
                this.myEvent(a, b);
            }
        }
    }
}
