using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Droid.Infra
{
    public class PostGreAdapter : InfraAdapter
    {
        #region Attributes
        [XmlIgnore]
        private const string CONNECTIONSTRING = "Server={0};Port={1};User Id={2};Password={3};Database={4};";
        [XmlIgnore]
        private const string GETUSERS = "" +
            "SELECT u.usename AS \"User name\"," +
            "  CASE WHEN u.usesuper AND u.usecreatedb THEN CAST('superuser, create database' AS pg_catalog.text)" +
            "       WHEN u.usesuper THEN CAST('superuser' AS pg_catalog.text)" +
            "       WHEN u.usecreatedb THEN CAST('create database' AS pg_catalog.text)" +
            "       ELSE CAST('' AS pg_catalog.text)" +
            "  END AS \"Attributes\"" +
            "FROM pg_catalog.pg_user u" +
            "ORDER BY 1;";

        [XmlIgnore]
        public DataSet Dataset;
        [XmlIgnore]
        public DataTable _datatable;
        [XmlIgnore]
        public NpgsqlConnection _conn;
        
        public string Database;
        public string Host;
        #endregion

        #region Properties
        [XmlIgnore]
        public bool IsConnected
        {
            get
            {
                try
                {
                    _conn = new NpgsqlConnection(string.Format(CONNECTIONSTRING, Host, Port, Login, Password, Database));
                    _conn.Open();
                    _conn.Close();
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("No connection on " + Host + "/" + Database + " : " + e.Message);
                    return false;
                }
            }
        }
        [XmlIgnore]
        public string[] GetUsers
        {
            get
            {
                DataTable dt = new DataTable();
                try
                {
                    _conn = new NpgsqlConnection(String.Format(CONNECTIONSTRING, Host, Port, Login, Password, Database));
                    _conn.Open();
                    dt = ExecuteReader(GETUSERS);
                    _conn.Close();
                    //return dt == null ? null : AsEnumerable(dt).Select(r => r.Field<string>("tablename")).ToArray();
                    return dt == null ? null : AsEnumerable(dt).Select(r => r.ItemArray[0].ToString()).ToArray();
                }
                catch (Exception e)
                {
                    Console.WriteLine("No connection on " + Host + "/" + Database + " : " + e.Message);
                    return null;
                }
            }
        }
        [XmlIgnore]
        public string[] ShowTables
        {
            get
            {
                DataTable dt = new DataTable();
                //dt = ExecuteReader("SELECT * FROM pg_catalog.pg_tables WHERE schemaname != 'pg_catalog' AND schemaname != 'information_schema';");
                dt = ExecuteReader("SELECT tablename FROM pg_catalog.pg_tables WHERE schemaname != 'pg_catalog' AND schemaname != 'information_schema';");
                return dt == null ? null : AsEnumerable(dt).Select(r => r.ItemArray[0].ToString()).ToArray();
            }
        }
        #endregion

        #region Constructor
        public PostGreAdapter()
        {
            Init();
        }
        public PostGreAdapter(InterfaceInfra intInfra)
        {
            _parent = intInfra;
            Init();
        }
        #endregion

        #region Methods public
        public void ExecuteFileScript(string scriptFile)
        {
            try
            {
                string connstring = String.Format(CONNECTIONSTRING, Host, Port, Login, Password, Database);
                _conn = new NpgsqlConnection(connstring);

                FileInfo file = new FileInfo(scriptFile);
                string script = file.OpenText().ReadToEnd();
                var m_createdb_cmd = new NpgsqlCommand(script, _conn);
                _conn.Open();
                m_createdb_cmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception(e.Message);
            }
            finally
            {
                _conn?.Close();
            }
        }
        public void ExecuteCommand(string query)
        {
            try
            {
                string connstring = String.Format(CONNECTIONSTRING, Host, Port, Login, Password, Database);
                _conn = new NpgsqlConnection(connstring);


                NpgsqlCommand RsBem = _conn.CreateCommand();
                RsBem.CommandText = query;

                _conn.Open();
                RsBem.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception(e.Message);
            }
            finally
            {
                _conn?.Close();
            }
        }
        public DataTable ExecuteReader(string query)
        {
            try
            {
                string connstring = String.Format(CONNECTIONSTRING, Host, Port, Login, Password, Database);
                _conn = new NpgsqlConnection(connstring);
                _conn.Open();
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(query, _conn);
                Dataset.Reset();
                da.Fill(Dataset);
                _datatable = Dataset.Tables[0];
                return _datatable;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception(e.Message);
            }
            finally
            {
                _conn?.Close();
            }
        }
        public string ToTransaction(List<string> scripts)
        {
            string transaction = "BEGIN; ";

            foreach (string script in scripts)
            {
                using (StreamReader sr = new StreamReader(script))
                {
                    transaction += sr.ReadToEnd();
                    transaction += " ";
                }
            }

            return transaction += " COMMIT;";
        }

        public override void GoAction(string action)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Methods private
        private void Init()
        {
            Dataset = new DataSet();
            _techno = TECHNO.POSTGRE;
            _type = AdapterType.PostGreAdapter;
        }
        protected override string BuildPanelCustom()
        {
            string html = string.Format(MONITORINGHTML, Online ? "componentOnline" : "componentOffline", "id123", "styleposition", (string.IsNullOrEmpty(_name) ? _techno.ToString() : _name));
            return html;
        }
        public static IEnumerable<DataRow> AsEnumerable(DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                yield return table.Rows[i];
            }
        }
        #endregion
    }
}
