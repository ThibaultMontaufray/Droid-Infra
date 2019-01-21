using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Droid.Infra
{
    public delegate void PurgeLogEventHandler(string message);
    public class PurgeLog
    {
        #region Attributes
        public event PurgeLogEventHandler Log;

        private List<Mask> _masks;
        #endregion

        #region Properties
        public List<Mask> Masks
        {
            get { return _masks; }
            set { _masks = value; }
        }
        #endregion

        #region Constructor
        public PurgeLog()
        {

        }
        public PurgeLog(string path)
        {
            PurgeLog pl = Load(path);
            this._masks = pl.Masks;
        }
        #endregion

        #region Methods public
        public void Process()
        {
            FileInfo fi;
            List<FileInfo> toDel = new List<FileInfo>(); ;
            if (_masks != null)
            {
                foreach (Mask mask in _masks)
                {
                    if (Directory.Exists(mask.Path) && mask.Delay != 0)
                    {
                        LogIt("Max delay : " + mask.Delay);
                        try
                        {
                            foreach (var file in Directory.GetFiles(mask.Path))
                            {
                                fi = new FileInfo(file);
                                if (fi.LastWriteTime < DateTime.Now.Add(-new TimeSpan(mask.Delay, 0, 0, 0)))
                                {
                                    if (fi.Name.StartsWith(mask.Filter))
                                    {
                                        toDel.Add(fi);
                                        LogIt("Maching mask  : " + mask.Filter);
                                        LogIt(fi.Name + " prepared for suppression. Last write " + (DateTime.Now - fi.LastWriteTime).ToString() + " ago");
                                    }
                                }
                            }
                        }
                        catch (Exception exp)
                        {
                            LogIt(exp.Message);
                        }
                    }
                }
                Delete(toDel);
            }
            else
            {
                LogIt("No masks. End of program.");
            }
        }
        public static void Save(PurgeLog pl, string file)
        {
            using (FileStream fs = new FileStream(file, FileMode.OpenOrCreate))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(PurgeLog));
                serializer.Serialize(fs, pl);
            }
        }
        public static PurgeLog Load(string file)
        {
            PurgeLog pl = new PurgeLog();
            if (File.Exists(file))
            {
                XmlSerializer ser = new XmlSerializer(typeof(PurgeLog));
                using (FileStream fs = new FileStream(file, FileMode.Open))
                {
                    pl = ser.Deserialize(fs) as PurgeLog;
                }
            }
            else
            {
                Save(pl, file);
            }
            return pl;
        }
        #endregion

        #region Mehtods private
        private void Init()
        {
            _masks = new List<Mask>();
        }
        private void Delete(List<FileInfo> toDel)
        {
            foreach (var file in toDel)
            {
                try
                {
                    LogIt("Deleting " + file.Name + ".");
                    file.Delete();
                }
                catch (Exception exp)
                {
                    LogIt(exp.Message);
                }
            }
        }
        private void LogIt(string message)
        {
            Console.WriteLine(message);
            Log?.Invoke(message);
            using (StreamWriter sw = new StreamWriter("programlog." + DateTime.Now.Year + "." + DateTime.Now.Month + ".log", true))
            {
                sw.WriteLine(DateTime.Now + ":" + message);
            }
        }
        #endregion

        #region Event
        #endregion
    }
}
