using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Folding;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace PickleStudio.Editor.Folding
{
    public class GherkinFoldingStrategy : AbstractFoldingStrategy
    {
        private readonly Regex _functionRegex = new Regex(Gherkin.FunctionExpression, RegexOptions.CultureInvariant | RegexOptions.ExplicitCapture | RegexOptions.Compiled);

        protected override IEnumerable<NewFolding> CreateNewFoldings(TextDocument document)
        {
            string name = null;
            int? startOffset = null;
            int? endOffset = null;
            foreach (var line in document.Lines)
            {
                var text = document.GetText(line);
                var isFunction = _functionRegex.IsMatch(text);
                if (isFunction)
                {
                    if (startOffset != null && endOffset != null)
                    {
                        yield return new NewFolding { StartOffset = startOffset.Value, EndOffset = endOffset.Value, Name = name, IsDefinition = true };
                    }
                    name = text;
                    startOffset = line.Offset;
                    endOffset = null;
                    continue;
                }
                if (startOffset == null || string.IsNullOrWhiteSpace(text)) continue;
                var firstChar = text.First(c => !char.IsWhiteSpace(c));
                if (!firstChar.Equals(Gherkin.Comment) && !firstChar.Equals(Gherkin.Tag)) endOffset = line.EndOffset;
            }
            if (startOffset != null && endOffset != null)
            {
                yield return new NewFolding { StartOffset = startOffset.Value, EndOffset = endOffset.Value, Name = name, IsDefinition = true };
            }
        }
    }
}
