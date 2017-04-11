using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiu.Dblight
{
    public class SqlDialect
    {
        /// <summary>
        /// 查询参数格式
        /// </summary>
        public string DbParameterConstant { get; set; }

        /// <summary>
        /// 查询表结构sql，使用properytocol映射
        /// </summary>
        public string SchemaSql { get; set; }
    }
}
