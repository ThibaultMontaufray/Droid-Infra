using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid.Infra
{
    public class SonarAdapter : InfraAdapter
    {
        #region Attributes
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public SonarAdapter()
        {
            _techno = TECHNO.SONARQUBE;
            _type = AdapterType.SonarAdapter;
        }
        public SonarAdapter(InterfaceInfra intInfra)
        {
            _techno = TECHNO.SONARQUBE;
            _parent = intInfra;
            _type = AdapterType.SonarAdapter;
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
