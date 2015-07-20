using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Folding;

namespace PickleStudio.Editor.Folding
{
    public interface IFoldingStrategy
    {
        void UpdateFoldings(FoldingManager manager, TextDocument document);
    }
}
