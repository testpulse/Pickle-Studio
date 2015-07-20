using PickleStudio.Core;
using PickleStudio.Core.Helpers;
using PickleStudio.Core.Interfaces;
using PickleStudio.Properties;
using System.Linq;
using System.Windows.Forms;

namespace PickleStudio.Controls
{
    public partial class ProjectView : UserControl
    {
        private readonly IApplicationState _state;

        public ProjectView(IApplicationState state)
        {
            InitializeComponent();

            _state = state;

            olvProject.SmallImageList = GetImageList();
            colName.ImageGetter = (f) => ((Feature)f).IsChanged ? 1 : 0;

            state.Project.ProjectOpened += OnProjectOpened;
            state.Project.FeatureOpened += OnFeatureOpened;
            state.Project.FeatureContentChanged += OnFeatureUpdate;
            state.Project.FeatureSaved += OnFeatureUpdate;
        }

        private void OnFeatureOpened(object sender, EventArgs<Feature> e)
        {
            OnFeatureUpdate(sender, e); // TODO test if this actually works, might need a full data refresh
         }

        public void OnFeatureUpdate(object sender, EventArgs<Feature> e)
        {
            olvProject.RefreshObject(e.Item);
        }

        private void OnProjectOpened(object sender, EventArgs<Project> e)
        {
            olvProject.SetObjects(e.Item.Features);
            var feature = e.Item.Features.FirstOrDefault();
            if (feature != null)
            {
                olvProject.SelectObject(feature);
            }
            else 
            {
                e.Item.CurrentFeature = null;
            }
        }

        private ImageList GetImageList()
        {
            var imageList = new ImageList();
            imageList.Images.Add(Resources.StatusUnknownImage);
            imageList.Images.Add(Resources.StatusUnsavedImage);
            imageList.Images.Add(Resources.StatusSuccessImage);
            imageList.Images.Add(Resources.StatusFailureImage);
            return imageList;
        }

        private void olvProject_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (!e.IsSelected) return;

            var feature = (olvProject.SelectedItem != null) ?  olvProject.SelectedItem.RowObject as Feature : null;

            _state.Project.CurrentFeature = feature;
        }
    }
}
