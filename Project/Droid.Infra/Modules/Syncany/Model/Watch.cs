namespace Droid.Infra
{
    public class Watch
    {
        #region Attribute
        private string _id;
        private bool _enabled;
        private string _path;
        #endregion

        #region Properties
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }
        #endregion

        #region Constructor
        public Watch()
        {

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
