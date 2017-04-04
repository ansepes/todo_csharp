using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libs.Domain;
using TodoApp.Domains.Entity;

namespace TodoApp.Domains.Repository
{
    public class TodoRepository : IRepository<TodoModel, TodoList>
    {

        private TodoList todos = new TodoList();

        public TodoList AsEntitiesList()
        {
            return todos.Clone();
        }

        public bool Contains(TodoModel entity)
        {
            return Contains(entity.GetIdentifier());
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

        private bool Exists(IEntityIdentifier<TodoModel> identifier)
        {
            TodoModel todo = Resolve(identifier);
            return todo == null;
        }

        public void Store(TodoModel entity)
        {
            if (! Exists(entity.GetIdentifier()))
            {
                todos.Add(entity);
                return;
            }

            Update(entity);

        }

        private void Update(TodoModel entity)
        {
            int idx = this.todos.IndexOf(entity);
            if (idx < 0) return;

            todos[idx] = entity;
        }
    }
}
