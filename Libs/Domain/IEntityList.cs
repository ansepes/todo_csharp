using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs.Domain
{
    public interface IEntityList<T> : IList<IEntity<T>>
    {
        IEntityList<T> Clone();
    }

    public class AbstractEntityList<T> : List<IEntity<T>>, IEntityList<T>
    {
        public IEntityList<T> Clone()
        {
            IEntityList<T> newList = new AbstractEntityList<T>();

            this.ForEach((entity) => newList.Add((IEntity<T>)entity.Clone()));

            return newList;
        }
    }

}
