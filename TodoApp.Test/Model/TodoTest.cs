using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodoApp.Domains.Model;
using Libs.Domain;

namespace TodoApp.Test
{
    [TestClass]
    public class TodoTest
    {
        [TestMethod]
        public void CreateObject()
        {
            TodoModel todoA = new TodoModel(DefaultEntityIdentifier<TodoModel>.CreateNewInstance(), "");
            TodoModel todoB = new TodoModel(DefaultEntityIdentifier<TodoModel>.CreateNewInstance(), "");
            Assert.AreEqual(todoA, todoA.Clone());
            Assert.AreNotEqual(todoA, todoB);
        }
    }
}
