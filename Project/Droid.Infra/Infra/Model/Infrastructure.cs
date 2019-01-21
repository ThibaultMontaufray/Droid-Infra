using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Droid.Infra
{
    public class Infrastructure
    {
        #region Attributes
        private List<BitbucketAdapter> _bitBucketAccounts;
        private List<ComputerAdapter> _computers;
        private List<TeamCityAdapter> _teamCityAccounts;
        private List<SonarAdapter> _sonarAccount;
        #endregion

        #region Properties
        public List<SonarAdapter> SonarAccount
        {
            get { return _sonarAccount; }
            set { _sonarAccount = value; }
        }
        public List<ComputerAdapter> Computers
        {
            get { return _computers; }
            set { _computers = value; }
        }
        public List<BitbucketAdapter> BitBucketAccounts
        {
            get { return _bitBucketAccounts; }
            set { _bitBucketAccounts = value; }
        }
        public List<TeamCityAdapter> TeamCityAccounts
        {
            get { return _teamCityAccounts; }
            set { _teamCityAccounts = value; }
        }
        #endregion

        #region Constructor
        public Infrastructure()
        {
            _bitBucketAccounts = new List<BitbucketAdapter>();
            _computers = new List<ComputerAdapter>();
            _teamCityAccounts = new List<TeamCityAdapter>();
            _sonarAccount = new List<SonarAdapter>();
        }
        #endregion

        #region Methods public
        public void Load(string filePath)
        {
            using (var stream = System.IO.File.OpenRead(filePath))
            {
                var serializer = new XmlSerializer(typeof(Infrastructure));
                Infrastructure infraTmp = serializer.Deserialize(stream) as Infrastructure;
            }
        }
        public void Save(string filePath)
        {
            using (var writer = new System.IO.StreamWriter(filePath))
            {
                var serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(writer, this);
                writer.Flush();
            }
        }
        #endregion

        #region Methods private
        #endregion

        #region Event
        #endregion
    }
}
