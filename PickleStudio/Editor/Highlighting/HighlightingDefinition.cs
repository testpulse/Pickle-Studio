using ICSharpCode.AvalonEdit.Highlighting;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace PickleStudio.Editor.Highlighting
{
    public class HighlightingDefinition : IHighlightingDefinition
    {
        private readonly Dictionary<string, HighlightingColor> _namedColors = new Dictionary<string, HighlightingColor>();
        private readonly Dictionary<string, HighlightingRuleSet> _namedRuleSets = new Dictionary<string, HighlightingRuleSet>();
        private readonly Dictionary<string, string> _properties = new Dictionary<string, string>();

        public string Name { get; private set; }
        public HighlightingRuleSet MainRuleSet { get; private set; }

        public HighlightingDefinition(string name)
        {
            Name = name;
            MainRuleSet = new HighlightingRuleSet { Name = "Main" };
            AddRuleSet(MainRuleSet);
        }

        public HighlightingDefinition AddRule(string expression, Color color, FontWeight? fontWeight = null)
        {
            var rule = new HighlightingRule
            {
                Regex = expression.ToRegex(),
                Color = color.ToHighlightingColor(fontWeight)
            };
            return AddRule(rule);
        }

        public HighlightingDefinition AddRule(HighlightingRule rule)
        {
            MainRuleSet.Rules.Add(rule);
            AddColor(rule.Color);
            return this;
        }

        public HighlightingDefinition AddSpan(string startExpression, string endExpression, Color color, FontWeight? fontWeight = null)
        {
            var span = new HighlightingSpan
            {
                StartExpression = startExpression.ToRegex(),
                EndExpression = endExpression.ToRegex(),
                SpanColor = color.ToHighlightingColor(fontWeight),
                SpanColorIncludesStart = true,
                SpanColorIncludesEnd = true
            };
            return AddSpan(span);
        }

        public HighlightingDefinition AddSpan(HighlightingSpan span)
        {
            MainRuleSet.Spans.Add(span);
            foreach (var color in GetColors(span))
            {
                AddColor(color);
            }
            foreach (var ruleSet in GetRuleSets(span))
            {
                AddRuleSet(ruleSet);
            }
            return this;
        }

        public HighlightingDefinition AddProperty(string key, string value)
        {
            _properties.Add(key, value);
            return this;
        }

        private IEnumerable<HighlightingColor> GetColors(HighlightingSpan span)
        {
            yield return span.SpanColor;
            yield return span.StartColor;
            yield return span.EndColor;
            if (span.RuleSet == null) yield break;

            foreach (var rule in span.RuleSet.Rules)
            {
                yield return rule.Color;
            }

            foreach (var color in span.RuleSet.Spans.SelectMany(GetColors))
            {
                yield return color;
            }
        }

        private IEnumerable<HighlightingRuleSet> GetRuleSets(HighlightingSpan span)
        {
            if (span.RuleSet == null) yield break;

            yield return span.RuleSet;
            foreach (var ruleSet in span.RuleSet.Spans.SelectMany(GetRuleSets))
            {
                yield return ruleSet;
            }
        }

        private void AddColor(HighlightingColor color)
        {
            if (color != null && !string.IsNullOrEmpty(color.Name) && !_namedColors.ContainsKey(color.Name)) _namedColors.Add(color.Name, color);
        }

        private void AddRuleSet(HighlightingRuleSet ruleSet)
        {
            if (ruleSet != null && !string.IsNullOrEmpty(ruleSet.Name) && !_namedRuleSets.ContainsKey(ruleSet.Name)) _namedRuleSets.Add(ruleSet.Name, ruleSet);
        }



        public HighlightingColor GetNamedColor(string name)
        {
            HighlightingColor color;
            return _namedColors.TryGetValue(name, out color) ? color : null;
        }

        public HighlightingRuleSet GetNamedRuleSet(string name)
        {
            HighlightingRuleSet ruleSet;
            return _namedRuleSets.TryGetValue(name, out ruleSet) ? ruleSet : null;
        }

        public IEnumerable<HighlightingColor> NamedHighlightingColors
        {
            get { return _namedColors.Values; }
        }

        public IDictionary<string, string> Properties
        {
            get { return _properties; }
        }
    }
}
