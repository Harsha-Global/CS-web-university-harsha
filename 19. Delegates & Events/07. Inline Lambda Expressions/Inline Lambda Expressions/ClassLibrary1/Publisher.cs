using System;

namespace ClassLibrary1
{
    //delegate type
    public delegate int MyDelegateType(int a, int b);

    //publisher
    public class Publisher
    {
        //step 1: create event
        public event MyDelegateType myEvent;

        public int RaiseEvent(int a, int b)
        {
            //step 2: raise event
            if (this.myEvent != null)
            {
                int x = this.myEvent(a, b);
                return x;
            }
            else
            {
                return 0;
            }
        }
    }
}
