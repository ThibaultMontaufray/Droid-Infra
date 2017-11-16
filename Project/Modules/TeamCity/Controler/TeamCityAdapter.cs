using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCitySharp;

namespace Droid_Infra
{
    public class TeamCityAdapter : InfraAdapteur
    {
        #region Attributes
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public TeamCityAdapter()
        {
            Connect();
        }
        #endregion

        #region Methods public
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
        #endregion

        #region Event
        #endregion
    }
}
