using System;

namespace ClassLibrary1
{
    //publisher
    public class Publisher
    {
        //step 1: create event
        public event Predicate<int> myEvent;

        public bool RaiseEvent(int a)
        {
            //step 2: raise event
            if (this.myEvent != null)
            {
                bool result = this.myEvent(a);
                return result;
            }
            else
            {
                return false;
            }
        }
    }
}
