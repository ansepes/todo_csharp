using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libs.Domain;

namespace TodoApp.Logics.Model
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

        public string GetMessage()
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
