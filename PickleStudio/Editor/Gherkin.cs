using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace PickleStudio.Editor
{
    public static class Gherkin
    {
        private static readonly IEnumerable<string> _functionKeywords = new List<string> 
        {
            "language:",
            "Background:",
            "Examples:",
            "Feature:",
            "Scenario:",
            "Scenario Outline:"
        };

        private static readonly IEnumerable<string> _reservedKeywords = new List<string>
        {
            Given,
            When,
            Then,
            And,
            But
        };

        public const char Comment = '#';
        public const char Tag = '@';
        public const string Given = "Given";
        public const string When = "When";
        public const string Then = "Then";
        public const string And = "And";
        public const string But = "But";

        private static Lazy<string> _functionExpression = new Lazy<string>(() => ToExpression(_functionKeywords));
        private static Lazy<string> _reservedExpression = new Lazy<string>(() => ToExpression(_reservedKeywords));
        private static Lazy<string> _commentExpression = new Lazy<string>(() => ToExpression(Comment));
        private static Lazy<string> _tagExpression = new Lazy<string>(() => ToExpression(Tag));

        public static IEnumerable<string> FunctionKeywords { get { return _functionKeywords; } }
        public static IEnumerable<string> ReservedKeywords { get { return _reservedKeywords; } }

        public static string FunctionExpression { get { return _functionExpression.Value; } }
        public static string ReservedExpression { get { return _reservedExpression.Value; } }
        public static string CommentExpression { get { return _commentExpression.Value; } }
        public static string TagExpression { get { return _tagExpression.Value; } }

        private static string ToExpression(char value)
        {
            return @"^\s*" + value;
        }
        
        private static string ToExpression(IEnumerable<string> keywords)
        {
            StringBuilder keyWordRegex = new StringBuilder();
            // We can use "\b" only where the keyword starts/ends with a letter or digit, otherwise we don't
            // highlight correctly. (example: ILAsm-Mode.xshd with ".maxstack" keyword)
            if (keywords.All(k => char.IsLetterOrDigit(k[0]) && char.IsLetterOrDigit(k, k.Length - 1)))
            {
                keyWordRegex.Append(@"^\s*(?>");
                // (?> = atomic group
                // atomic groups increase matching performance, but we
                // must ensure that the keywords are sorted correctly.
                // "\b(?>in|int)\b" does not match "int" because the atomic group captures "in".
                // To solve this, we are sorting the keywords by descending length.
                int i = 0;
                foreach (string keyword in keywords.OrderByDescending(w => w.Length))
                {
                    if (i++ > 0)
                        keyWordRegex.Append('|');
                    keyWordRegex.Append(Regex.Escape(keyword));
                }
                keyWordRegex.Append(@")\b");
            }
            else
            {
                keyWordRegex.Append(@"^\s*(");
                int i = 0;
                foreach (string keyword in keywords)
                {
                    if (i++ > 0)
                        keyWordRegex.Append('|');
                    if (char.IsLetterOrDigit(keyword[0]))
                        keyWordRegex.Append(@"\b");
                    keyWordRegex.Append(Regex.Escape(keyword));
                    if (char.IsLetterOrDigit(keyword[keyword.Length - 1]))
                        keyWordRegex.Append(@"\b");
                }
                keyWordRegex.Append(')');
            }

            return keyWordRegex.ToString();
        }
    }
}
