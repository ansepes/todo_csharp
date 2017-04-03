using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libs.Domain;

namespace TodoApp.Domains.Entity
{
    public class TodoModel : AbstractEntity<TodoModel>
    {
        string message = "";
        bool finished;

        public TodoModel(IEntityIdentifier<TodoModel> identifier, string message) : base(identifier)
        {
            this.message = message;
            this.finished = false;
        }

        public string Message()
        {
            return message;
        }

        public bool Finished()
        {
            return finished;
        }

        public void ToggleState()
        {
            finished = !finished;
        }
    }

}
