
namespace PickleStudio.Core.Interfaces
{
    public interface IEditor
    {
        void Copy();
        void Cut();
        void Paste();
        void Undo();
        void Redo();
        void ApplySettings(string propertyName);
    }
}
