using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid.Infra
{
    public class Mask
    {
        #region Attributes
        private string _path;
        private string _filter;
        private int _delay;
        #endregion

        #region Properties
        public int Delay
        {
            get { return _delay; }
            set { _delay = value; }
        }
        public string Filter
        {
            get { return _filter; }
            set { _filter = value; }
        }
        public string Path
        {
            get { return _path; }
            set { _path = value; }
        }
        #endregion

        #region Constructor
        public Mask()
        {

        }
        #endregion
    }
}
