using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libs.Util;

namespace Libs.Domain
{
    public interface IEntity<T> : ICloneable
    {
        IEntityIdentifier<T> GetIdentifier();

        bool Equals(Object that);

        int GetHashCode();

    }

    public abstract class AbstractEntity<T> : IEntity<T>
    {
        private IEntityIdentifier<T> identifier;

        protected AbstractEntity(IEntityIdentifier<T> identifier)
        {
            Validate.NotNull(identifier);
            this.identifier = identifier;

        }
        public IEntityIdentifier<T> GetIdentifier()
        {
            return identifier;
        }

        public object Clone()
        {
            return (IEntity<T>) base.MemberwiseClone();

        }

        public override int GetHashCode()
        {
            return identifier.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            if (this == obj) {
                return true;
            }
            if (obj == null || obj is IEntity<T> == false) {
                return false;
            }

            return identifier.Equals(((IEntity<T>)obj).GetIdentifier());
        }
    }


}
