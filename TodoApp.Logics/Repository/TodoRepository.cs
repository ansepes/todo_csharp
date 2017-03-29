using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libs.Domain;
using TodoApp.Domains.Model;

namespace TodoApp.Domains.Repository
{
    class TodoRepository : IRepository<TodoModel, TodoList>
    {

        private TodoList todos = new TodoList();

        public TodoList AsEntitiesList()
        {
            return todos.Clone();
        }

        public bool Contains(TodoModel entity)
        {
            return todos.Exists((todo) => todo.Equals(entity));
        }

        public bool Contains(IEntityIdentifier<TodoModel> identifier)
        {
            return todos.Exists((todo) => todo.GetIdentifier().Equals(identifier));
        }

        public void Delete(TodoModel entity)
        {
            todos.Remove(entity);
        }

        public void Delete(IEntityIdentifier<TodoModel> identifier)
        {
            Delete(Resolve(identifier));
        }

        public TodoModel Resolve(IEntityIdentifier<TodoModel> identifier)
        {
            return todos.Find((todo) => todo.GetIdentifier().Equals(identifier));
        }

        public void Store(TodoModel entity)
        {
            todos.Add(entity);
        }
    }
}
