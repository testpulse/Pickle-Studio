﻿using PickleStudio.Core;
using PickleStudio.Core.Interfaces;
using PickleStudio.Resources;
using System.IO;
using System.Windows.Forms;

namespace PickleStudio.Commands
{
    public class FileOpenCommand : AbstractUiCommand
    {
        private readonly IApplicationState _state;

        public FileOpenCommand(IApplicationState state)
        {
            _state = state;

            Text = Strings.FileOpenText;
            Image = Images.FileOpen;
            Enabled = true;
            ToolTipText = Strings.FileOpenToolTipText;
        }

        protected override void DoExecute(params string[] args)
        {
            string fileName;
            if (args.Length > 0)
            {
                fileName = args[0];
            }
            else
            {
                var dialog = new OpenFileDialog();
                dialog.Filter = Strings.FileOpenFilter;
                dialog.InitialDirectory = _state.Settings.Project.InitialDirectory;
                if (dialog.ShowDialog() != DialogResult.OK) return;
                fileName = dialog.FileName;
                _state.Settings.Project.InitialDirectory = Path.GetDirectoryName(fileName);
            }

            _state.Project.Open(fileName);
        }
    }
}
