using System.Runtime.CompilerServices;

namespace Initializer
{
    internal class Initializer1
    {
        //[ModuleInitializer]
        internal static void Initialize1()
        {
            Console.WriteLine("From Initialize1");
        }
    }
}

