namespace Regexanizer.Rules
{
    interface IRule
    {
        string RuleName { get; }
        string WorkDirectory { get; set; }
        string SearchPattern { get; set; }
        bool TopDirectoryOnly { get; set; }
        string Regex { get; }
        string ActionPath { get; }
    }
}
