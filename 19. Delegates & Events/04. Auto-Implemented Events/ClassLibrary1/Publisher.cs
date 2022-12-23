using System;

namespace ClassLibrary1
{
    //delegate type
    public delegate void MyDelegateType(int a, int b);

    //publisher
    public class Publisher
    {
        //step 1: create event
        public event MyDelegateType myEvent;

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
