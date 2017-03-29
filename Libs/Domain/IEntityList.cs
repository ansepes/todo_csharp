using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs.Domain
{
    public interface IEntityList<T> : IList<T>
    {
        IEntityList<T> Clone();
    }

 }
