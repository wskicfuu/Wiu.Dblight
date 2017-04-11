using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiu.Dblight
{
    public interface IDbSession
    {
        DatabaseInfo DatabaseInfo { get; }
    }
}
