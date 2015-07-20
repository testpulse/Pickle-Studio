using System.Collections.Generic;

namespace PickleStudio.Core
{
    public class ProjectSettings
    {
        public string InitialDirectory { get; set; }
        public IEnumerable<string> OpenedFilePaths { get; set; }

        public ProjectSettings()
        {
            InitialDirectory = string.Empty;
            OpenedFilePaths = new List<string>();
        }
    }
}
