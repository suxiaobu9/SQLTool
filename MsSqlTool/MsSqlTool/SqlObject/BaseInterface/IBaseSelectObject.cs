using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsSqlTool.SqlObject.BaseInterface
{
    public interface IBaseSelectObject<TDerive> : IBaseObject<TDerive>, IReserved<TDerive>
    {
    }
}
