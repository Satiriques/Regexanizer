using nucs.JsonSettings;
using PowerArgs;
using Regexanizer.Rules;
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

            var settings = JsonSettings.Load<RulesConfig>();
        }
    }
}
