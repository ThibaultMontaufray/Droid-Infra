using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tools.Utilities;

namespace Droid.Infra.UI
{
    public partial class ViewInfraNew : UserControlCustom
    {
        #region Attributes
        public event UserControlCustomEventHandler CreateRequested;
        private InterfaceInfra _intInfra;
        private string _path;

        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }

        #endregion

        #region Properties
        public InterfaceInfra InterfaceInfra
        {
            get { return _intInfra; }
            set { _intInfra = value; }
        }
        #endregion

        #region Constructor
        public ViewInfraNew()
        {
            InitializeComponent();
            Init();
        }
        public ViewInfraNew(InterfaceInfra intInfra)
        {
            _intInfra = intInfra;
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        public override void RefreshData()
        {

        }
        #endregion

        #region Methods private
        private void Init()
        {
        }
        private void Create()
        {
            if (string.IsNullOrEmpty(textBoxPath.Text))
            {
                textBoxPath.BackColor = Color.AntiqueWhite;
            }
            else
            {
                textBoxPath.BackColor = Color.White;
                _path = textBoxPath.Text;
                CreateRequested?.Invoke(textBoxPath.Text);
            }
        }
        #endregion

        #region Event
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                textBoxPath.Text = fbd.SelectedPath;
            }
        }
        private void buttonCreate_Click(object sender, EventArgs e)
        {
            Create();
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
