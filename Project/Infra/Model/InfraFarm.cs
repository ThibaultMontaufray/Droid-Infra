using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Droid_Infra
{
    [Serializable]
    [XmlRoot("InfraFarm")]
    public class InfraFarm
    {
        //[XmlArray("InfraComponents"), XmlArrayItem(typeof(InfraAdapteur), ElementName = "InfraComponent")]
        [XmlElement(typeof(BitbucketAdapter))]
        [XmlElement(typeof(ComputerAdapter))]
        [XmlElement(typeof(DockerAdapter))]
        [XmlElement(typeof(GitHubAdapter))]
        [XmlElement(typeof(JenkinsAdapter))]
        [XmlElement(typeof(JiraAdapter))]
        [XmlElement(typeof(SonarAdapter))]
        [XmlElement(typeof(SyncanyAdapter))]
        [XmlElement(typeof(TeamCityAdapter))]
        [XmlElement(typeof(SqlAdapter))]
        [XmlElement(typeof(VPNAdapter))]
        public List<InfraAdapteur> InfraComponents { get; set; }

        public InfraFarm()
        {
            InfraComponents = new List<InfraAdapteur>();
        }

        public void Clear()
        {
            InfraComponents.Clear();
        }
        public void Add(InfraAdapteur ia)
        {
            InfraComponents.Add(ia);
        }
    }
}
