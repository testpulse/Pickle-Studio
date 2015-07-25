using System.Collections.Generic;

namespace PickleStudio.Core.Options
{
    public class ProjectOptions
    {
        public string InitialDirectory { get; set; }
        public IEnumerable<string> OpenedFilePaths { get; set; }

        public ProjectOptions()
        {
            InitialDirectory = string.Empty;
            OpenedFilePaths = new List<string>();
        }
    }
}
