using System;
using System.Runtime.CompilerServices;

namespace Initializer
{
    public static class FinalModuleInitializer
    {
        [ModuleInitializer]
        public static void FinalInitialize()
        {
            Initializer2.Initialize2();
            Initializer1.Initialize1();
        }
    }
}
