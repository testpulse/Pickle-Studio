using PickleStudio.Core;
using PickleStudio.Extensions;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PickleStudio.Editor.CodeCompletion
{
    public class CodeCompletionFeatureSteps
    {
        private static readonly Regex _regex = new Regex(string.Format(@"^\s*(?<type>{0})\s+(?<text>.*?)\s*$", string.Join("|", Gherkin.ReservedKeywords)), RegexOptions.CultureInvariant | RegexOptions.ExplicitCapture | RegexOptions.Compiled);

        public List<string> Givens { get; set; }
        public List<string> Thens { get; set; }
        public List<string> Whens { get; set; }

        public CodeCompletionFeatureSteps()
        {
            Givens = new List<string>();
            Thens = new List<string>();
            Whens = new List<string>();
        }

        public CodeCompletionFeatureSteps(Feature feature)
        {
            var givens = new List<string>();
            var thens = new List<string>();
            var whens = new List<string>();
            var previousStepType = string.Empty;
            foreach (var line in feature.Content.ReadLines())
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                var match = _regex.Match(line);
                if (!match.Success) continue;
                var stepType = match.Groups["type"].Value;
                if (stepType == Gherkin.And || stepType == Gherkin.But) stepType = previousStepType;
                if (string.IsNullOrEmpty(stepType)) continue;
                var text = match.Groups["text"].Value;
                switch (stepType)
                {
                    case Gherkin.Given:
                        givens.Add(text);
                        break;
                    case Gherkin.When:
                        whens.Add(text);
                        break;
                    case Gherkin.Then:
                        thens.Add(text);
                        break;
                }
                previousStepType = stepType;
            }
            Givens = givens.Distinct().ToList();
            Whens = whens.Distinct().ToList();
            Thens = thens.Distinct().ToList();
        }

        public CodeCompletionFeatureSteps Given(string text)
        {
            Givens.Add(text);
            return this;
        }

        public CodeCompletionFeatureSteps When(string text)
        {
            Whens.Add(text);
            return this;
        }

        public CodeCompletionFeatureSteps Then(string text)
        {
            Thens.Add(text);
            return this;
        }
    }
}
