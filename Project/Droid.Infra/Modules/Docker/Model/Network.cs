using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid.Infra.Modules.Docker.Model
{
    public delegate void NetworkEventHandler();

    [Serializable]
    public class Network : Command
    {
        #region Attributes
        public event NetworkEventHandler NetworkUpdated;

        private string _id;
        private string _name;
        private string _driver;
        private string _scope;
        #endregion

        #region Properties
        public string Scope
        {
            get { return _scope; }
            set { _scope = value; }
        }
        public string Driver
        {
            get { return _driver; }
            set { _driver = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        #endregion

        #region Constructor
        public Network()
        {

        }
        public Network(string[] tab)
        {
            try
            {
                if (tab.Length > 3)
                {
                    this.Id = tab[0];
                    this.Name = tab[1];
                    this.Driver = tab[2];
                    this.Scope = tab[3];
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
            return string.Format("{0} ({1})", _name, _driver);
        }
        public Network InspectNetwork(string id)
        {
            NetworkUpdated?.Invoke();
            return null;
        }
        public void Delete()
        {
            ExecuteCommand(string.Format("docker network rm {0} -f", _id));
        }
        #endregion
    }
}
