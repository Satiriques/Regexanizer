using System;
using System.Collections.Generic;
using System.Text;

namespace Regexanizer.Rules
{
    interface IRulesConfig
    {
        List<IRule> Rules { get; }
    }
}
