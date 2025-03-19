/* This is an example to execute multiple module initializers in the desired order */
using System.Runtime.CompilerServices;

namespace ModuleInitializers
{
    internal class FinalModuleInitializer
    {
        [ModuleInitializer]
        public static void final_module_initializer()
        {
            Initializer1.Module_initializer_method_1();
            Initializer2.Module_initializer_method_2();
        }
    }
}
