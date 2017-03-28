using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libs.Util;

namespace Libs.Domain
{
    public interface IEntityIdentifier<IEntity> : IValueObject
    {
        String GetKind();
        Guid ToGUID();
    }

    public sealed class DefaultEntityIdentifier<IEntity> : IEntityIdentifier<IEntity>
    {

        private String kind;
        private Guid guid;

        public DefaultEntityIdentifier(Type t, Guid guid) : this(t.Name, guid) {  
        }

        public DefaultEntityIdentifier(string kind, Guid guid)
        {
            Validate.NotNull(kind);
            Validate.NotNull(guid);
            this.kind = kind;
            this.guid = guid;
        }

        public string GetKind()
        {
            return kind;
        }

        public Guid ToGUID()
        {
            return guid;
        }

        public override int GetHashCode()
        {
            int result = kind != null ? kind.GetHashCode() : 0;
            return 31 * result + (guid != null ? guid.GetHashCode() : 0);
        }

        public override bool Equals(Object o)
        {
            if (this == o)
            {
                return true;
            }
            if (o == null || o is DefaultEntityIdentifier<IEntity>) {
                return false;
            }

            DefaultEntityIdentifier<IEntity> that = (DefaultEntityIdentifier<IEntity>) o;
            if (kind.Equals(that.kind) == false)
            {
                return false;
            }
            if (guid.Equals(that.guid) == false)
            {
                return false;
            }
            return true;
        }

        
    }
}
