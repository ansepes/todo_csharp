using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs.Domain
{
    public interface IRepository<IEntity>
    {
        IEntity resolve(IEntityIdentifier<IEntity> identifier);

        List<IEntity> asEntitiesList();

        bool contains(IEntityIdentifier<IEntity> identifier);

        bool contains(IEntity entity);

        void store(IEntity entity);

        void delete(IEntityIdentifier<IEntity> identifier);

        void delete(IEntity entity);



    }
}
