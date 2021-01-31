using nucs.JsonSettings;
using System.Collections.Generic;

namespace Regexanizer.Rules
{
    class RulesConfig : JsonSettings, IRulesConfig
    {
        public List<IRule> Rules { get; set; } = new List<IRule>();
        public override string FileName { get; set; } = "config.json";
    }
}
