using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid.Infra
{
    public class JenkinsAdapter : InfraAdapter
    {
        #region Attributes
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public JenkinsAdapter()
        {
            _techno = TECHNO.JENKINS;
            _type = AdapterType.JenkinsAdapter;
        }
        public JenkinsAdapter(InterfaceInfra intInfra)
        {
            _techno = TECHNO.JENKINS;
            _parent = intInfra;
            _type = AdapterType.JenkinsAdapter;
        }
        #endregion

        #region Methods public
        public override void GoAction(string action)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Methods private
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
