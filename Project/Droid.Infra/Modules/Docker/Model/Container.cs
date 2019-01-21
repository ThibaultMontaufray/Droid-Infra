using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid.Infra.Modules.Docker.Model
{
    public delegate void ContainerEventHandler();

    [Serializable]
    public class Container : Command
    {
        #region Attributes
        public event ContainerEventHandler ContainerUpdated;

        private string _id;
        private string _dockerImage;
        private string _command;
        private string _created;
        private string _status;
        private string _port;
        private string _name;
        private string _size;
        #endregion

        #region Properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Port
        {
            get { return _port; }
            set { _port = value; }
        }
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public string Created
        {
            get { return _created; }
            set { _created = value; }
        }
        public string Command
        {
            get { return _command; }
            set { _command = value; }
        }
        public string DockerImage
        {
            get { return _dockerImage; }
            set { _dockerImage = value; }
        }
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public bool Alive
        {
            get
            {
                return ExecuteCommand("docker ps -f id=" + _id).Split('\n').Count() > 2;
                //set { _state = value; 
            }
        }
        #endregion

        #region Constructor
        public Container()
        {

        }
        public Container(string[] tab)
        {
            try
            {
                if (tab.Length > 4)
                {
                    this.Id = tab[0].Trim();
                    this.DockerImage = tab[1].Trim();
                    this.Command = tab[2].Trim();
                    this.Created = tab[3].Trim();
                    this.Status = tab[4].Trim();
                    if (tab.Length > 7)
                    {
                        this.Port = tab[5].Trim();
                        this.Name = tab[6].Trim();
                        this.Size = tab[7].Trim();
                    }
                    else if (tab.Length > 5)
                    {
                        this.Name = tab[5].Trim();
                    }
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
        #endregion

        #region Methods public
        public override string ToString()
        {
            return string.Format("{0} ({1}/{2})", _name, _dockerImage);
        }
        public Image InspectContainer(string id)
        {
            ContainerUpdated?.Invoke();
            return null;
        }
        public void Create(string command)
        {
            ExecuteCommand(command);
        }
        public void Delete()
        {
            ExecuteCommand(string.Format("docker rm {0} -f", _id));
        }
        #endregion

        #region Methods private
        #endregion

        #region Event
        #endregion
    }
}
