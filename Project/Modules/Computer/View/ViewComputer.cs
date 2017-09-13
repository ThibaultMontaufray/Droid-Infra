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
    public partial class ViewComputer : UserControlCustom
    {
        #region Attributes
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public ViewComputer()
        {
            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        public override void RefreshData()
        {

        }
        public override void ChangeLanguage()
        {

        }
        #endregion

        #region Methods private
        private void Init()
        {
            //_labelGraphicCardValue.Text = Computer.Graphic_card;
            //_labelOsValue.Text = Computer.OS_Plateform;
            //_labelOsVersionValue.Text = Computer.OS_Version;
            //_labelIISInstalledValue.Text = Computer.IIS_installed.ToString();
        }
        #endregion

        #region Event
        #endregion
    }
}
