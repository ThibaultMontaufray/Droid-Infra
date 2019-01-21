using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCitySharp;

namespace Droid.Infra
{
    public class TeamCityAdapter : InfraAdapter
    {
        #region Attributes
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public TeamCityAdapter()
        {
            _techno = TECHNO.TEAMCITY;
            _type = AdapterType.TeamCityAdapter;
            Connect();
        }
        public TeamCityAdapter(InterfaceInfra intInfra)
        {
            _techno = TECHNO.TEAMCITY;
            _parent = intInfra;
            _type = AdapterType.TeamCityAdapter;
            Connect();
        }
        #endregion

        #region Methods public
        public override void GoAction(string action)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Methods private
        private void Connect()
        {
            try
            {
                //var client = new TeamCityClient("http://localhost:8080");
                //client.Connect("tmontaufray", "Androi7#");
                //var projects = client.Projects.All();
                //var agents = client.Agents.All();
            }
            catch
            {
            }
        }
        protected override string BuildPanelCustom()
        {
            string html = string.Format(MONITORINGHTML, Online ? "componentOnline" : "componentOffline", "id123", "styleposition", (string.IsNullOrEmpty(_name) ? _techno.ToString() : _name));
            return html;
        }
        #endregion

        #region Event
        #endregion
    }
}
