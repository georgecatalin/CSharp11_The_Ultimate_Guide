using System.Runtime.CompilerServices;

namespace ModuleInitializers
{
    internal class Initializer1 // the initializer method can be either public or internal (which is default). Not compulsory, but recommended to be static
    {
        //[ModuleInitializer]
        public static void Module_initializer_method_1() // the method access level can be either on of public, internal or protected internal.It must be static and returns void
        {
            Console.WriteLine("Hello from module_initializer_method_1() ");
        }
    }
}
