using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs.Domain
{
    public interface IRepository<T, L>
    {
        T Resolve(IEntityIdentifier<T> identifier);

        L AsEntitiesList();

        bool Contains(IEntityIdentifier<T> identifier);

        bool Contains(T entity);

        void Store(T entity);

        void Delete(IEntityIdentifier<T> identifier);

        void Delete(T entity);



    }
}
