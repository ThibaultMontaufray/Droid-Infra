using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools4Libraries;

namespace Droid_Infra
{
    public partial class ViewInfraAdd : UserControlCustom
    {
        #region Attributes
        private Interface_infra _intInfra;
        #endregion

        #region Properties
        public Interface_infra IntInfra
        {
            get { return _intInfra; }
            set { _intInfra = value; }
        }
        #endregion

        #region Constructor
        public ViewInfraAdd(Interface_infra intInfra)
        {
            _intInfra = intInfra;
            InitializeComponent();
        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        private void Init()
        {

        }
        #endregion

        #region Event
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            InfraAdapteur ia = null;
            switch (comboBoxInfra.Text.ToLower())
            {
                case "server":
                    ia = new ComputerAdapter();
                    break;
                case "sonarqube":
                    ia = new SonarAdapter();
                    break;
                case "sql":
                    ia = new SqlAdapter();
                    break;
                case "vpn":
                    ia = new VPNAdapter();
                    break;
                case "team city":
                    ia = new TeamCityAdapter();
                    break;
                case "bitbucket":
                    ia = new BitbucketAdapter();
                    break;
                default:
                    break;
            }

            if (ia != null)
            {
                ia.Name = textBoxName.Text;
                ia.Url = textBoxAddress.Text;

                _intInfra.InfraFarm.Add(ia);
                _intInfra.GoAction("Infra_Save");
            }
        }
        #endregion
    }
}
