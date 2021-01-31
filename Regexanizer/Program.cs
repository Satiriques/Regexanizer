using PowerArgs;
using System;

namespace Regexanizer
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var parsed = Args.Parse<UserArgs>(args);
            }
            catch (ArgException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ArgUsage.GenerateUsageFromTemplate<UserArgs>());
                return;
            }


        }
    }
}
