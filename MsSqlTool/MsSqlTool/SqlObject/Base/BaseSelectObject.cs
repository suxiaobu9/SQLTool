using MsSqlTool.SqlObject.BaseInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsSqlTool.SqlObject.Base
{
    public abstract class BaseSelectObject<TDerive> : BaseObject<TDerive>, IBaseSelectObject<TDerive>
    {
    }
}
