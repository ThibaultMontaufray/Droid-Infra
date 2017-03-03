using System.Collections.Generic;
using Tools4Libraries;

namespace Droid_infra
{
    public class Interface_infra : GPInterface
    {
        #region Attribute
        #endregion

        #region Properties
        #endregion

        #region Constructor
        public Interface_infra()
        {

        }
        #endregion

        #region Methods public
        #region ACTIONS
        //public static void ACTION_lancer_syncdocker_130()
        //{
        //    Syncany.SyncanyView syncancyView = new Syncany.SyncanyView();
        //    syncancyView.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
        //    syncancyView.ShowDialog();
        //}
        #endregion

        public void GlobalAction(string action)
        {
            switch (action)
            {
                case "it":
                    LaunchIt();
                    break;
            }
        }
        #endregion

        #region Methods private
        private void LaunchIt()
        {

        }
        #endregion
    }
}