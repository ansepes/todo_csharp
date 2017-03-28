using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs.Util
{
    public abstract class Validate
    {
        public static void NotNull(Object target)
        {
            if(target == null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
