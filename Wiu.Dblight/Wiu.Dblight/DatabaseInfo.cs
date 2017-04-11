using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiu.Dblight
{
    public class DatabaseInfo
    {
        private string connectionString;
        private SqlDialect sqlDialect;

        public DatabaseInfo(string connectionString, SqlDialect sqlDialect)
        {
            this.connectionString = connectionString;
            this.sqlDialect = sqlDialect;
        }

        public string ConnectionString
        {
            get { return connectionString; }
            set { connectionString = value; }
        }

        public SqlDialect SqlDialect
        {
            get { return sqlDialect; }
            set { sqlDialect = value; }
        }
    }
}
