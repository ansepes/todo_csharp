using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libs.Domain;
using TodoApp.Logics.Model;

namespace TodoApp.Logics.Repository
{
    class TodoRepository : IRepository<TodoModel>
    {
        public List<TodoModel> asEntitiesList()
        {
            throw new NotImplementedException();
        }

        public bool contains(TodoModel entity)
        {
            throw new NotImplementedException();
        }

        public bool contains(IEntityIdentifier<TodoModel> identifier)
        {
            throw new NotImplementedException();
        }

        public void delete(TodoModel entity)
        {
            throw new NotImplementedException();
        }

        public void delete(IEntityIdentifier<TodoModel> identifier)
        {
            throw new NotImplementedException();
        }

        public TodoModel resolve(IEntityIdentifier<TodoModel> identifier)
        {
            throw new NotImplementedException();
        }

        public void store(TodoModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
