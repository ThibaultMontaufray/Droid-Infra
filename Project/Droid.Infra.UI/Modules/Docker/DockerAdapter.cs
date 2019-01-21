using Droid.Infra.Modules.Docker.Model;
using Droid.Infra.Modules.Docker.View;
using System.Collections.Generic;
using System.Windows.Forms;
using System;
using Tools4Libraries;
using Droid.Infra;
using Docker.DotNet;
using Docker.DotNet.Models;
using Droid.Infra.Modules.Docker.Controler;

namespace Droid.Infra.UI
{
    // execute command : docker-machine ssh default -t "touch me"
    // transfert file  : docker-machine ssh default "cat > destination.file" < original.file
    public class DockerAdapter : InfraAdapter
    {
        #region Attribute
        private Engine _engine;
        private Modules.Docker.Model.Image _currentImage;
        private Modules.Docker.Model.Container _currentContainer;
        private Modules.Docker.Model.Network _currentNetwork;

        private ViewDockerManage _viewManage;
        private ViewImages _viewImages;
        private ViewContainer _viewContainers;
        private ViewNetworks _viewNetworks;
        private ViewDockerMonitor _viewMonitor;
        private ViewDockerCompose _viewCompose;
        private ViewImageDetail _viewImageDetail;
        private ViewContainerDetail _viewContainerDetail;
        private ViewNetworkDetail _viewNetworkDetail;
        #endregion

        #region Properties
        public Engine Engine
        {
            get { return _engine; }
            set { _engine = value; }
        }
        public override bool Online
        {
            get
            {
                try
                {
                    return !string.IsNullOrEmpty(_engine.Version);
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public Modules.Docker.Model.Network CurrentNetwork
        {
            get { return _currentNetwork; }
            set { _currentNetwork = value; }
        }
        public Modules.Docker.Model.Container CurrentContainer
        {
            get { return _currentContainer; }
            set { _currentContainer = value; }
        }
        public Modules.Docker.Model.Image CurrentImage
        {
            get { return _currentImage; }
            set { _currentImage = value; }
        }
        #endregion

        #region Constructor
        public DockerAdapter()
        {
            _techno = TECHNO.DOCKER;
            _type = AdapterType.DockerAdapter;
            Init();
        }
        public DockerAdapter(InterfaceInfra parent)
        {
            _techno = TECHNO.DOCKER;
            _type = AdapterType.DockerAdapter;
            _parent = parent;
            Init();
            //_docker = new Boot2Docker();
        }
        #endregion

        #region Methods public
        #region ACTIONS
        public static void ACTION_lancer_docker_130()
        {
            ViewDocker ddp = new ViewDocker();
            //ddp.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            //ddp.ShowDialog();
        }
        #endregion
        
        public override void GoAction(string action)
        {
            switch (action)
            {
                //case "initialisation":
                //    LaunchInitDocker();
                //    break;
                //case "status":
                //    LaunchStatus();
                //    break;
                //case "start":
                //    LaunchStart();
                //    break;
                //case "stop":
                //    LaunchStop();
                //    break;
                case "monitor":
                    LaunchMonitor();
                    break;
                case "manage":
                    LaunchManage();
                    break;
                case "images":
                    LaunchListImages();
                    break;
                case "containers":
                    LaunchListContainers();
                    break;
                case "networks":
                    LaunchListNetworks();
                    break;
                case "compose":
                    LaunchCompose();
                    break;
                case "composeInspect":
                    LaunchComposeInspect();
                    break;
                case "composePlay":
                    LaunchComposePlay();
                    break;
                case "composeStop":
                    LaunchComposeStop();
                    break;
                case "composeLogs":
                    LaunchComposeLogs();
                    break;
                case "inspectImage":
                    LaunchInspectImage();
                    break;
                case "inspectNetwork":
                    LaunchInspectNetwork();
                    break;
                case "inspectContainer":
                    LaunchInspectContainer();
                    break;
            }
        }
        #endregion

        #region Methods private
        const string EventStoreImage = "eventstore/eventstore";
        private void Init()
        {
            _engine = new Engine();
            
            //try
            //{
            //    var config = new DockerClientConfiguration(new Uri("npipe://./pipe/docker_engine"));
            //    var Client = config.CreateClient();
            //    var images = await Client.Images.ListImagesAsync(new ImagesListParameters { MatchName = EventStoreImage });
            //    if (images.Count == 0)
            //    {
            //        // No image found. Pulling latest ..
            //        await Client.Images.CreateImageAsync(new ImagesCreateParameters { FromImage = EventStoreImage, Tag = "latest" }, null, IgnoreProgress.Forever);
            //    }
            //}
            //catch (Exception exp)
            //{
            //    Console.WriteLine(exp.Message + " | " + exp.InnerException);
            //}
        }
        private void LaunchManage()
        {
            if (_viewManage == null) { _viewManage = new ViewDockerManage(); }
            _viewManage.Adapter = this;
            LaunchSheet(_viewManage);
        }
        private void LaunchListImages()
        {
            if (_viewImages == null) { _viewImages = new ViewImages(); }
            _viewImages.Adapter = this;
            LaunchSheet(_viewImages);
        }
        private void LaunchListContainers()
        {
            if (_viewContainers == null) { _viewContainers = new ViewContainer(); }
            _viewContainers.Adapter = this;
            LaunchSheet(_viewContainers);
        }
        private void LaunchListNetworks()
        {
            if (_viewNetworks == null) { _viewNetworks = new ViewNetworks(); }
            _viewNetworks.Adapter = this;
            LaunchSheet(_viewNetworks);
        }
        private void LaunchMonitor()
        {
            if (_viewMonitor == null) { _viewMonitor = new ViewDockerMonitor(); }
            _viewMonitor.Adapter = this;
            LaunchSheet(_viewMonitor);
        }
        private void LaunchCompose()
        {
            if (_viewCompose == null) { _viewCompose = new ViewDockerCompose(); }
            _viewCompose.Adapter = this;
            LaunchSheet(_viewCompose);
        }
        private void LaunchComposeInspect()
        {
            if (_engine?.CurrentCompose != null)
            {
                _engine?.CurrentCompose.Inspect();
            }
        }
        private void LaunchComposePlay()
        {
            if (_engine?.CurrentCompose != null)
            {
                _engine?.CurrentCompose.Start();
            }
        }
        private void LaunchComposeClear()
        {
            if (_engine?.CurrentCompose != null)
            {
                _engine?.CurrentCompose.Clear();
            }
        }
        private void LaunchComposeStop()
        {
            if (_engine?.CurrentCompose != null)
            {
                _engine?.CurrentCompose.Stop();
            }
        }
        private void LaunchComposeLogs()
        {
            if (_engine?.CurrentCompose != null)
            {
                _engine?.CurrentCompose.Logs();
            }
        }
        private void LaunchInspectImage()
        {
            if (_viewImageDetail == null) { _viewImageDetail = new ViewImageDetail(); }
            _viewImageDetail.Adapter = this;
            _viewImageDetail.CurrentImage = _currentImage;
            LaunchSheet(_viewImageDetail);
        }
        private void LaunchInspectContainer()
        {
            if (_viewContainerDetail == null) { _viewContainerDetail = new ViewContainerDetail(); }
            _viewContainerDetail.Adapter = this;
            _viewContainerDetail.CurrentContainer = _currentContainer;
            LaunchSheet(_viewContainerDetail);
        }
        private void LaunchInspectNetwork()
        {
            if (_viewNetworkDetail == null) { _viewNetworkDetail = new ViewNetworkDetail(); }
            _viewNetworkDetail.Adapter = this;
            _viewNetworkDetail.CurrentNetwork = _currentNetwork;
            LaunchSheet(_viewNetworkDetail);
        }

        protected override string BuildPanelCustom()
        {
            string html = string.Format(MONITORINGHTML, Online ? "componentOnline" : "componentOffline", "id123", "styleposition", (string.IsNullOrEmpty(_name) ? _techno.ToString() : _name));
            string detail = "<li>&nbsp;</li>";
            detail += "<li>Machines : " + _engine.Machines.Count + "</li>";
            detail += "<li>Compose : " + _engine.DockerComposes.Count + "</li>";
            foreach (var item in _engine.Machines)
            {
                if (item != null)
                {
                    detail += string.Format("<li> - {0} : {1}</li>", item.Name, item.State);
                }
            }
            return html.Replace("<li>&nbsp;</li>", detail);
        }
        #endregion
    }
    public class IgnoreProgress : IProgress<JSONMessage>
    {
        public static readonly IProgress<JSONMessage> Forever = new IgnoreProgress();

        public void Report(JSONMessage value) { }
    }
}