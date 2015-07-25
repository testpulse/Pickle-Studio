using PickleStudio.Core.Options;

namespace PickleStudio.Editor.Highlighting
{
    public class GherkinHighlightingDefinition : HighlightingDefinition
    {
        public GherkinHighlightingDefinition(EditorOptions options)
            : base("Gherkin")
        {
            AddSpan(Gherkin.CommentExpression, @"$", options.CommentFontOptions);
            AddSpan(Gherkin.TagExpression, @"$", options.TagFontOptions);
            AddSpan(@"<", @">", options.ParametersFontOptions);
            var stringsColor = options.StringsFontOptions.ToHighlightingColor();
            AddSpan(@"""", @"""", stringsColor);
            AddSpan(@"'", @"'", stringsColor);
            AddRule(Gherkin.FunctionExpression, options.FeatureKeywordFontOptions);
            AddRule(Gherkin.ReservedExpression, options.StepKeywordFontOptions);
            AddRule(@"(?<=\|)([^\|]*?)(?=\|)", options.TableFontOptions);
        }
    }
}
