using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools.Utilities;

namespace Droid.Infra.UI
{
    public partial class DemoSyncany : Form
    {
        #region Attribute
        private SyncanyAdapter _intSyn;
        private string _workingDirectory;
        #endregion

        #region Properties
        public string WorkingDirectory
        {
            get { return _workingDirectory; }
            set { _workingDirectory = value; }
        }
        #endregion

        #region Constuctor
        public DemoSyncany()
        {
            InitializeComponent();

            _workingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Servodroid\Droid-Infra\";
            _intSyn = new SyncanyAdapter();
            cloudView1.SyncanyAdapter = _intSyn;
        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        #endregion

        #region Event
        #endregion
    }
}
