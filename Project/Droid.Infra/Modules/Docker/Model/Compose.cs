using System.Collections.Generic;

namespace Droid.Infra.Modules.Docker.Model
{
    public class Compose
    {
        #region Attributes
        private string _path;
        private List<Image> _images;
        private List<Container> _containers;
        private string _conf;
        private string _version;
        #endregion

        #region Properties
        public List<Container> Containers
        {
            get { return _containers; }
            set { _containers = value; }
        }
        public string Conf
        {
            get { return _conf; }
            set { _conf = value; }
        }
        public List<Image> Images
        {
            get { return _images; }
            set { _images = value; }
        }
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }
        public string Version
        {
            get { return _version; }
            set { _version = value; }
        }
        #endregion

        #region Constructor
        public Compose()
        {

        }
        #endregion

        #region Methods public
        #endregion

        #region Methods private
        #endregion
    }
}
