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

        public TodoList() {}

        public TodoList(List<TodoModel> list)
        {
            list.ForEach((todo) => this.Add(todo));
        }

        public TodoList Clone()
        {
            return new TodoList(this.ConvertAll((todo) => (TodoModel)todo.Clone()));
        }
    }
}
