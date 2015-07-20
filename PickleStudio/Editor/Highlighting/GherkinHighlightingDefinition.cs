using System.Windows;
using System.Windows.Media;

namespace PickleStudio.Editor.Highlighting
{
    public class GherkinHighlightingDefinition : HighlightingDefinition
    {


        public GherkinHighlightingDefinition()
            : base("Gherkin")
        {
            AddSpan(Gherkin.CommentExpression, @"$", Colors.Green);
            AddSpan(Gherkin.TagExpression, @"$", Colors.Teal);
            AddSpan(@"<", @">", Colors.Gray);
            AddSpan(@"""", @"""", Colors.Gray);
            AddSpan(@"'", @"'", Colors.Gray);
            AddRule(Gherkin.FunctionExpression, Colors.DarkBlue, FontWeights.Bold);
            AddRule(Gherkin.ReservedExpression, Colors.Blue, FontWeights.Bold);
            AddRule(@"(?<=\|)([^\|]*?)(?=\|)", Colors.Maroon);
        }
    }
}
