using PickleStudio.Core;
using PickleStudio.Core.Helpers;
using PickleStudio.Core.Interfaces;
using PickleStudio.Resources;
using System;
using System.Linq;
using System.Windows.Forms;

namespace PickleStudio.Views
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
            state.Project.ProjectClosed += OnProjectOrFeatureClosed;
            state.Project.FeatureOpened += OnFeatureOpened;
            state.Project.FeatureClosed += OnProjectOrFeatureClosed;
            state.Project.FeatureContentChanged += OnFeatureUpdate;
            state.Project.FeatureSaved += OnFeatureUpdate;
        }

        private void OnFeatureOpened(object sender, EventArgs<Project, Feature> e)
        {
            olvProject.SetObjects(e.Item1.Features);
            olvProject.SelectObject(e.Item2);
         }

        public void OnFeatureUpdate(object sender, EventArgs<Feature> e)
        {
            olvProject.RefreshObject(e.Item);
        }

        private void OnProjectOpened(object sender, EventArgs<Project> e)
        {
            RefreshView(e.Item);
        }

        private void OnProjectOrFeatureClosed(object sender, EventArgs e)
        {
            RefreshView(_state.Project);
        }

        private void RefreshView(Project project)
        {
            olvProject.SetObjects(project.Features);
            var feature = project.Features.FirstOrDefault();
            if (feature != null)
            {
                olvProject.SelectObject(feature);
            }
            else
            {
                project.CurrentFeature = null;
            }
        }

        private ImageList GetImageList()
        {
            var imageList = new ImageList();
            imageList.Images.Add(Images.StatusUnknown);
            imageList.Images.Add(Images.StatusUnsaved);
            imageList.Images.Add(Images.StatusSuccess);
            imageList.Images.Add(Images.StatusFailure);
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
