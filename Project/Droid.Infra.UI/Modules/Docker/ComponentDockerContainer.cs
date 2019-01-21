using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid.Infra.UI.Modules.Docker.View
{
    public partial class ComponentDockerContainer : Component
    {
        #region Attributes
        private Model.Container _container;
        private delegate void RefreshDataDelegate();
        #endregion

        #region Properties
        public Model.Container DockerContainer
        {
            get { return _container; }
            set
            {
                if (_container != null) { _container.ContainerUpdated -= _container_ContainerUpdated; }
                _container = value;
                _container.ContainerUpdated += _container_ContainerUpdated;
            }
        }
        #endregion

        #region Constructor
        public ComponentDockerContainer()
        {
            InitializeComponent();
        }

        public ComponentDockerContainer(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        #endregion

        #region Methods public
        public override void RefreshData()
        {
            if (_container != null)
            {
                this.BackgroundImage = _container.Alive ? Properties.Resources.docker_container_face : Properties.Resources.docker_container_face_disable;
            }
        }
        #endregion

        #region Methods private
        #endregion

        #region Event
        private void _container_ContainerUpdated()
        {
            this.Invoke(new RefreshDataDelegate(RefreshData));
        }
        #endregion
    }
}
