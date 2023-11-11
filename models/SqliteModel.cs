using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace bpjsclient.models
{
    internal class SqliteModel
    {
        public SqliteModel()
        {

        }

        static SqliteConnection createConnection()
        {
            SqliteConnection sqliteConn;
            sqliteConn = new SqliteConnection("Data Source=bpjsclient.db; Version = 3; New = True; Compress = True;");
            return sqliteConn;
        }
    }
}
