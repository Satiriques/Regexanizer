using PowerArgs;
using System.IO;

namespace Regexanizer
{
    class UserArgs
    {
        [HelpHook, ArgShortcut("-?"), ArgDescription("Shows this help")]
        public bool Help { get; set; }

        [ArgExistingDirectory]
        public string WorkingDirectory { get; set; } = Directory.GetCurrentDirectory();
        [ArgExistingFile]
        public string RulesPath { get; set; } = Path.Combine(Directory.GetCurrentDirectory(), "regexanizer.config");
    }
}
