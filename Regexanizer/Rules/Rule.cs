namespace Regexanizer.Rules
{
    class Rule : IRule
    {
        public string RuleName { get; set; }
        public string WorkDirectory { get; set; }
        public string SearchPattern { get; set; }
        public bool TopDirectoryOnly { get; set; }
        public string Regex { get; set; }
        public string ActionPath { get; set; }
    }
}
