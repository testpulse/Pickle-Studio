using PickleStudio.Core.Commands;
using PickleStudio.Interfaces;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PickleStudio.Extensions
{
    public static class ControlExtensions
    {
        public static bool BindControl(this Command type, ToolStripButton control)
        {
            var command = type.Get<IUiCommand>();
            if (command == null) return false;

            command.PropertyChanged += (o, e) =>
            {
                if (e.PropertyName == "Text") control.Text = command.Text;
                if (e.PropertyName == "ToolTipText") control.ToolTipText = command.ToolTipText;
                if (e.PropertyName == "Enabled") control.Enabled = command.Enabled;
                if (e.PropertyName == "Image")
                {
                    control.Image = command.Image;
                    control.DisplayStyle = (control.Image != null) ? ToolStripItemDisplayStyle.Image : ToolStripItemDisplayStyle.Text;
                }
                if (e.PropertyName == "ValueChanged") control.Checked = command.IsToggled;
            };
            
            control.Name = "tbb" + type.ToString();
            control.CheckOnClick = command.CanToggle;
            control.Checked = command.IsToggled;
            control.Text = command.Text;
            control.ToolTipText = command.ToolTipText;
            control.Enabled = command.Enabled;
            control.Image = command.Image;
            control.DisplayStyle = (control.Image != null) ? ToolStripItemDisplayStyle.Image : ToolStripItemDisplayStyle.Text;
            control.Click += (o, e) => command.Execute();

            return true;
        }

        public static ToolStripContainer AddToolStrip(this ToolStripContainer container, CommandGroup group, params Command[] commands)
        {
            var ts = commands.Aggregate(new ToolStrip { Name = "tsp" + group.ToString() }, (b, c) => b.AddToolStripItem(c));

            container.TopToolStripPanel.Controls.Add(ts);

            return container;
        }

        public static ToolStrip AddToolStripItem(this ToolStrip ts, Command type)
        {
            var command = type.Get<IUiCommand>();
            ToolStripItem item;
            switch (type)
            {
                case Command.None:
                    item = new ToolStripSeparator();
                    break;
                default:
                    var button = new ToolStripButton();
                    type.BindControl(button);
                    item = button;
                    break;
            }
            ts.Items.Add(item);

            return ts;
        }

        public static DialogResult ShowDialog<T>(this T control)
            where T : UserControl, IDialogControl
        {
            var form = new Form();
            form.Controls.Add(control);
            control.Location = new Point(0, 0);
            form.ClientSize = control.Size;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Text = control.Title;
            form.AcceptButton = control.AcceptButton;
            form.CancelButton = control.CancelButton;
            return form.ShowDialog();
        }

        public static void Close(this UserControl control, DialogResult dialogResult = DialogResult.OK)
        {
            if (control.ParentForm == null) return;
            control.ParentForm.DialogResult = dialogResult;
            control.ParentForm.Close();
        }
    }
}
