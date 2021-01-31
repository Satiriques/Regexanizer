using nucs.JsonSettings;
using PowerArgs;
using Regexanizer.Rules;
using System;
using System.Diagnostics;
using System.IO;
using System.Text.RegularExpressions;

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

            foreach(var rule in settings.Rules)
            {
                HandleRule(rule);
            }
        }

        private static void HandleRule(IRule rule)
        {
            Console.WriteLine($"Executing rule : {rule.RuleName}");

            var files = Directory.GetFiles(rule.WorkDirectory, rule.SearchPattern, 
                rule.TopDirectoryOnly ? 
                SearchOption.TopDirectoryOnly : SearchOption.AllDirectories);

            var regex = new Regex(rule.Regex);

            foreach(var file in files)
            {
                var fileName = Path.GetFileNameWithoutExtension(file);

                // assuming the regex has exactly one capture group

                if (regex.IsMatch(fileName))
                {
                    var match = regex.Match(fileName);

                    var matchStringResult = match.Groups[1].Value;

                    if (!string.IsNullOrWhiteSpace(matchStringResult))
                    {
                        Process.Start(rule.ActionPath, $"{file} {matchStringResult}");
                    }
                    else
                    {
                        Console.WriteLine("Regex found a match, but the group value was whitespace?");
                    }
                }
            }
        }
    }
}
