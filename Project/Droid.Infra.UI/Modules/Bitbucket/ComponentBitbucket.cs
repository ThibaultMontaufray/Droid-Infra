using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Droid.Infra.UI
{
    public partial class ComponentBitbucket : Component
    {
        #region Attribute
        private BitbucketAdapter _adapter;
        #endregion

        #region Properties
        public BitbucketAdapter Adapter
        {
            get { return _adapter; }
            set { _adapter = value; }
        }
        #endregion

        #region Constructor
        public ComponentBitbucket(BitbucketAdapter adapter)
        {
            _adapter = adapter;

            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        private void Init()
        {
            if (_adapter != null)
            { 
                labelrepo.Text = "Repo : " + _adapter.Repositories?.Count;
            }
            else
            {
                labelrepo.Text = "Repo : N/A";
            }
        }
        #endregion

        #region Event
        #endregion
    }
}
