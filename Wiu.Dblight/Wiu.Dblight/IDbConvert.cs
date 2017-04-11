using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;

namespace Wiu.Dblight
{
    public interface IDbConvert
    {
        void AddParams(DbCommand command, IDictionary<string, object> dbParams);

        DbParameter CreateParamter(DbCommand command, string key, object value);

        DbType GetDbType(object value);

        string ToDbSqlString(object value);
    }
}
