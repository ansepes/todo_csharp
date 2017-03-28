using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodoApp.Logics.Model;
using Libs.Domain;

namespace TodoApp.Test
{
    [TestClass]
    public class TodoTest
    {
        [TestMethod]
        public void CreateObject()
        {
            TodoModel todo = new TodoModel(new DefaultEntityIdentifier<TodoModel>( typeof(TodoModel), Guid.NewGuid()));
            int aa = todo.GetHashCode();
            //int a = 0;
        }
    }
}
