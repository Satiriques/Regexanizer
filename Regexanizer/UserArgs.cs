using PowerArgs;
using System.IO;

namespace Regexanizer
{
    class UserArgs
    {
        [HelpHook, ArgShortcut("-?"), ArgDescription("Shows this help")]
        public bool Help { get; set; }

        [ArgExistingFile]
        public string RulesPath { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "config.json");
    }
}
