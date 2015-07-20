using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Folding;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PickleStudio.Editor.Folding
{
    public abstract class AbstractFoldingStrategy : IFoldingStrategy
    {	
        public void UpdateFoldings(FoldingManager manager, TextDocument document)
        {
            int firstErrorOffset;
            IEnumerable<NewFolding> foldings = CreateNewFoldings(document, out firstErrorOffset);
            manager.UpdateFoldings(foldings, firstErrorOffset);
        }

        protected virtual IEnumerable<NewFolding> CreateNewFoldings(TextDocument document, out int firstErrorOffset)
        {
            try
            {
                firstErrorOffset = -1;
                return CreateNewFoldings(document);
            }
            catch (Exception)
            {
                firstErrorOffset = 0;
                return Enumerable.Empty<NewFolding>();
            }
        }

        protected abstract IEnumerable<NewFolding> CreateNewFoldings(TextDocument document);
    }
}
