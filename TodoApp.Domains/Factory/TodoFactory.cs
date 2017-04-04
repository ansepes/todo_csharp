using Libs.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Domains.Entity;

namespace TodoApp.Domains.Factory
{
    public class TodoFactory
    {

        public TodoModel Create(string title)
        {
            return new TodoModel(DefaultEntityIdentifier<TodoModel>.CreateNewInstance(), title);
        }

        public TodoModel Create(string title, string id)
        {
            Guid _guid = Guid.Parse(id);
            DefaultEntityIdentifier<TodoModel> identifire = new DefaultEntityIdentifier<TodoModel>(typeof(TodoModel), _guid);

            return new TodoModel(identifire, title);
        }
    }
}
