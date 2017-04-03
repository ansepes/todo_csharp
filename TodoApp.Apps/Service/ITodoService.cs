using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TodoApp.Domains.Entity;
using TodoApp.Domains.Repository;

namespace TodoApp.Apps.Service
{
    interface ITodoService
    {
        TodoList GetAll();

        TodoModel Create(string message);

        void Store(TodoModel todo);

        void Delete(TodoModel todo);
    }
}
