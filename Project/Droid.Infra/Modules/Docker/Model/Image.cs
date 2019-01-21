using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid.Infra.Modules.Docker.Model
{
    public delegate void ImageEventHandler();

    [Serializable]
    public class Image : Command
    {
        #region Attributes
        public event ImageEventHandler ImageUpdated;

        private string _repository;
        private string _tag;
        private string _id;
        private string _created;
        private string _size;
        #endregion

        #region Properties
        public string Size
        {
            get { return _size; }
            set { _size = value; }
        }
        public string Created
        {
            get { return _created; }
            set { _created = value; }
        }
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }
        public string Repository
        {
            get { return _repository; }
            set { _repository = value; }
        }
        #endregion

        #region Constructor
        public Image()
        {
                
        }
        public Image(string[] tab)
        {
            try
            {
                if (tab.Length > 4)
                {
                    this.Repository = tab[0].Trim();
                    this.Tag = tab[1].Trim();
                    this.Id = tab[2].Trim();
                    this.Created = tab[3].Trim();
                    this.Size = tab[4].Trim();
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message);
            }
        }
        #endregion

        #region Methods public
        public override string ToString()
        {
            return string.Format("{0} - {1}", _repository, _tag);
        }
        public Image InspectImage(string id)
        {
            ImageUpdated?.Invoke();
            return null;
        }
        public void Delete()
        {
            ExecuteCommand(string.Format("docker rmi {0} -f", _id));
        }
        #endregion
    }
}
