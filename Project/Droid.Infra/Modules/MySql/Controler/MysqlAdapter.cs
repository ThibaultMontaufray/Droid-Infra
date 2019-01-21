using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Droid.Infra
{


    // flush privileges;
    // SET PASSWORD FOR 'TOBI'@'localhost' = 'pws';
    // flush privileges;

    public class MysqlAdapter : InfraAdapter
    {
        #region Attributes
        private const string CONNECTIONSTRING = "Server={0};Port={1};User Id={2};Password={3};Database={4};";
        
        public static DataSet Dataset;
        public static DataTable _datatable;
        public static NpgsqlConnection _conn;

        public static string Login;
        public static string Port;
        public static string Password;
        public static string Database;
        public static string Host;
        #endregion

        #region Properties
        public static bool IsConnected
        {
            get
            {
                try
                {
                    _conn = new NpgsqlConnection(String.Format(CONNECTIONSTRING, Host, Port, Login, Password, Database));
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
        public static string[] GetUsers
        {
            get
            {
                DataTable dt = new DataTable();
                try
                {
                    _conn = new NpgsqlConnection(String.Format(CONNECTIONSTRING, Host, Port, Login, Password, Database));
                    _conn.Open();
                    //dt = ExecuteReader("select * from mysql.user;");
                    dt = ExecuteReader("select User from mysql.user;");
                    _conn.Close();
                    return dt == null ? null : AsEnumerable(dt).Select(r => r.ItemArray[0].ToString()).ToArray();
                }
                catch (Exception e)
                {
                    Console.WriteLine("No connection on " + Host + "/" + Database + " : " + e.Message);
                    return null;
                }
            }
        }
        public static string[] ShowTables
        {
            get
            {
                DataTable dt = new DataTable();
                dt = ExecuteReader("show tables;");
                return dt == null ? null : AsEnumerable(dt).Select(r => r[0].ToString()).ToArray();
            }
        }
        #endregion

        #region Constructor
        static MysqlAdapter()
        {
            //_type = AdapterType.MysqlAdapter;
            Dataset = new DataSet();
        }
        public MysqlAdapter()
        {
            _techno = TECHNO.MYSQL;
            Dataset = new DataSet();
        }
        public MysqlAdapter(InterfaceInfra intInfra)
        {
            _techno = TECHNO.MYSQL;
            //_type = AdapterType.MysqlAdapter;
            _parent = intInfra;
            Dataset = new DataSet();
        }
        #endregion

        #region Methods public
        public static void ExecuteFileScript(string scriptFile)
        {
        }
        public static void ExecuteCommand(string query)
        {
        }
        public static DataTable ExecuteReader(string query)
        {
            return null;
        }
        public static string ToTransaction(List<string> scripts)
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
        #endregion

        #region Methods private
        public static IEnumerable<DataRow> AsEnumerable(DataTable table)
        {
            for (int i = 0; i < table.Rows.Count; i++)
            {
                yield return table.Rows[i];
            }
        }
        protected override string BuildPanelCustom()
        {
            string html = string.Format(MONITORINGHTML, Online ? "componentOnline" : "componentOffline", "id123", "styleposition", (string.IsNullOrEmpty(_name) ? _techno.ToString() : _name));
            return html;
        }
        #endregion
    }
}
