using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs.Domain
{
    public interface IValueObject
    {
        bool Equals(Object that);

        int GetHashCode();
    }
}
