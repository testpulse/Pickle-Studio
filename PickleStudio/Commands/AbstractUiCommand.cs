using PickleStudio.Core.Commands;
using PickleStudio.Extensions;
using PickleStudio.Interfaces;
using System;
using System.Drawing;

namespace PickleStudio.Commands
{
    public abstract class AbstractUiCommand : AbstractCommand, IUiCommand
    {
        public string Text { 
            get { return Get<string>(); }
            set { Set(value); }
        }

        public Bitmap Image
        {
            get { return Get<Bitmap>(); }
            set { Set(value); }
        }

        public string ToolTipText
        {
            get { return Get<string>(); }
            set { Set(value); }
        }

        public virtual bool CanToggle
        {
            get { return false; }
        }

        public virtual bool IsToggled
        {
            get { return false; }
        }

        public override void Execute(params string[] args)
        {
            try
            {
                DoExecute(args);
            }
            catch (Exception e)
            {
                e.Show();
            }
        }

        protected abstract void DoExecute(params string[] args);
    }
}
