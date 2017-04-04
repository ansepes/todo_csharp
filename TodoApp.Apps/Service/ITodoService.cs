using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TodoApp.Domains.Entity;
using TodoApp.Domains.Repository;

namespace TodoApp.Apps.Service
{
    public interface ITodoService
    {
        TodoList GetAll();

        TodoModel Create(string title);

        void Store(TodoModel todo);

        void Delete(TodoModel todo);
    }
}
