using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libs.Domain;

namespace TodoApp.Domains.Entity
{
    public class TodoList : List<TodoModel>
    {
        public TodoList Clone()
        {
            TodoList newList = new TodoList();

            this.ForEach((todo) => todo.Clone());

            return newList;
        }
    }
}
