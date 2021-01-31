using System;
using System.Collections.Generic;
using System.Text;

namespace Regexanizer.Rules
{
    interface IRule
    {
        string RuleName { get; }
        string Regex { get; }
        string Action { get; }
    }
}
