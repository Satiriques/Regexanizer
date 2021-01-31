namespace Regexanizer.Rules
{
    class Rule : IRule
    {
        public string RuleName { get; set; }

        public string Regex { get; set; }

        public string Action { get; set; }
    }
}
