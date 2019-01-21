using System.Windows.Forms;
using Tools.Utilities;

namespace Droid.Infra.UI
{
    /// <summary>
    /// provides a formular which asks for a password
    /// </summary>
    public partial class ViewVPNPasswd : UserControlCustom
    {
        #region constructor
        /// <summary>
        /// generates the form
        /// </summary>
        public ViewVPNPasswd()
        {
            InitializeComponent();
        }
        #endregion

        /// <summary>
        /// Asks for a password.
        /// </summary>
        /// <param name="pwTitle">name of the password, e.g. 'private key'</param>
        /// <param name="config">name of the config</param>
        /// <returns>the password or null if aborted</returns>
        public string AskPass(string pwTitle, string config)
        {
            // set labels
            lblAsk.Text = pwTitle;
            lblName.Text = config;

            // show form, return
            //if (this.ShowDialog() != DialogResult.OK)
            //    return null;
            //else
                return txtPasswd.Text;
        }
    }
}
