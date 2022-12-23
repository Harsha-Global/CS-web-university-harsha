using System;

namespace ClassLibrary1
{
    public class Sample
    {
        //constructor
        public Sample()
        {
            //file & db connection logic here
            Console.WriteLine("File is opened");
        }

        //destructor
        ~Sample()
        {
            //file & db closing logic here
            Console.WriteLine("File is closed");
        }
    }
}
