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
    public partial class FormMain : Form
    {
        #region Attribute
        private readonly string WORKING_DIRECTORY = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Servodroid\Droid-Infra";

        private Ribbon _ribbon;
        private InterfaceInfra _intInf;

        private RibbonButton _btn_open;
        private RibbonButton _btn_exit;
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public FormMain()
        {
            Tools4Libraries.Log.ApplicationAppData = WORKING_DIRECTORY;

            InitializeComponent();
            Init();
        }
        #endregion

        #region Methods public
        public void ChangeLanguage()
        {
            _ribbon.OrbText = GetText.Text("File");
            _btn_open.Text = GetText.Text("Open");
            _btn_exit.Text = GetText.Text("Exit");
        }
        #endregion

        #region Methods private
        private void Init()
        {
            _intInf = new InterfaceInfra(WORKING_DIRECTORY);
            
            InitRibbon();
            InitSheet();
        }
        private void InitRibbon()
        {
            _ribbon = new Ribbon();
            _ribbon.Height = 150;
            _ribbon.ThemeColor = RibbonTheme.Black;
            _ribbon.OrbDropDown.Width = 150;
            _ribbon.OrbStyle = RibbonOrbStyle.Office_2013;
            _ribbon.OrbText = GetText.Text("File");
            _ribbon.QuickAccessToolbar.MenuButtonVisible = false;
            _ribbon.QuickAccessToolbar.Visible = false;
            _ribbon.QuickAccessToolbar.MinSizeMode = RibbonElementSizeMode.Compact;
            _ribbon.Dock = DockStyle.None;
            _ribbon.Top = -25;
            _ribbon.Left = 0;
            _ribbon.Width = this.Width;
            _ribbon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            _ribbon.Tabs.Add(_intInf.Tsm);

            _btn_open = new RibbonButton(GetText.Text("Open"));
            _btn_open.Image = Tools.Utilities.UI.Resources.ResourceIconSet32Default.open_folder;
            _btn_open.SmallImage = Tools.Utilities.UI.Resources.ResourceIconSet16Default.open_folder;
            _btn_open.Click += B_open_Click;
            _ribbon.OrbDropDown.MenuItems.Add(_btn_open);

            _btn_exit = new RibbonButton(GetText.Text("Exit"));
            _btn_exit.Image = Tools.Utilities.UI.Resources.ResourceIconSet32Default.door_out;
            _btn_exit.SmallImage = Tools.Utilities.UI.Resources.ResourceIconSet16Default.door_out;
            _btn_exit.Click += B_exit_Click;
            _ribbon.OrbDropDown.MenuItems.Add(_btn_exit);

            _ribbon.OrbDropDown.Width = 700;
            this.Controls.Add(_ribbon);
        }
        private void InitSheet()
        {
            _intInf.Sheet.Dock = DockStyle.None;
            _intInf.Sheet.Top = 0;
            _intInf.Sheet.Left = 0;
            _intInf.Sheet.Width = this.Width;
            _intInf.Sheet.Height = this.Height;
            _intInf.Sheet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right) | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Controls.Add(_intInf.Sheet);
        }
        #endregion

        #region Event
        private void _intBoo_LanguageModified()
        {
            ChangeLanguage();
        }
        private void B_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void B_open_Click(object sender, EventArgs e)
        {
            _intInf.Open(null);
        }
        #endregion
    }
}
