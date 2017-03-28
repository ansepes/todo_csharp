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
        public TodoModel(IEntityIdentifier<TodoModel> identifier) : base(identifier)
        {
            
        }
    }

}
