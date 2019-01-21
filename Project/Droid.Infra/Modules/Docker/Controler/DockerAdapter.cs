using Droid.Infra.Modules.Docker.Model;
using System.Collections.Generic;
using System;
using Tools.Utilities;
using Droid.Infra;
using Docker.DotNet;
using Docker.DotNet.Models;
using Droid.Infra.Modules.Docker.Controler;

namespace Droid.Infra
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