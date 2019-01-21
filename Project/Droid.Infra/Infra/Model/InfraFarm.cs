using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Droid.Infra
{
    [Serializable]
    [XmlRoot("InfraFarm")]
    public class InfraFarm
    {
        #region Attributes
        private InfraAdapter _localMachine;
        #endregion

        #region Properties
        //[XmlArray("InfraComponents"), XmlArrayItem(typeof(InfraAdapteur), ElementName = "InfraComponent")]
        public List<InfraAdapter> Adapters { get; set; }
        public InfraAdapter CurrentAdapter { get; set; }

        public InfraAdapter LocalMachine
        {
            get
            {
                if (_localMachine == null)
                {
                    _localMachine = new ComputerAdapter();
                    _localMachine.Name = "local";
                    _localMachine.Url = "127.0.0.1";
                    _localMachine.Techno = InfraAdapter.TECHNO.SERVER;
                    _localMachine.Env = InfraAdapter.ENV.NONE;
                }
                return _localMachine;
            }
        }
        #endregion

        #region Constructor
        public InfraFarm()
        {
            Adapters = new List<InfraAdapter>();
            Clear();
        }
        #endregion

        #region Methods public
        public InfraAdapter GetAdapter(AdapterType type)
        {
            foreach (var adapter in Adapters)
            {
                if (adapter.Type == type)
                {
                    return adapter;
                }
            }
            return null;
        }
        public void CastToMyType<T>(object givenObject) where T : class
        {
            var newObject = givenObject as T;
        }
        public T Casting<T>(object input)
        {
            return (T)Convert.ChangeType(input, typeof(T));
        }
        public void Clear()
        {
            Adapters.Clear();
            Add(LocalMachine);
        }
        public void Add(InfraAdapter ia)
        {
            Adapters.Add(ia);
        }
        #endregion
    }
}
