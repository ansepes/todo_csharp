using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TodoApp.Domains.Entity;
using TodoApp.Domains.Repository;
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

        [TestMethod]
        public void ToggleStatus()
        {
            TodoModel todo = new TodoModel(DefaultEntityIdentifier<TodoModel>.CreateNewInstance(), "aaa");
            Assert.AreEqual(false, todo.Finished());
            todo.ToggleState();
            Assert.AreEqual(true, todo.Finished());
            todo.ToggleState();
            Assert.AreEqual(false, todo.Finished());
        }

        [TestMethod]
        public void GetMessage()
        {
            const string MESSAGE = "abcd";
            TodoModel todo = new TodoModel(DefaultEntityIdentifier<TodoModel>.CreateNewInstance(), MESSAGE);
            Assert.AreEqual(MESSAGE, todo.Message());
        }

        [TestMethod]
        public void Store()
        {
            TodoRepository repository = new TodoRepository();

            TodoModel todoA = new TodoModel(DefaultEntityIdentifier<TodoModel>.CreateNewInstance(), "aaa");
            repository.Store(todoA);
            var list1 = repository.AsEntitiesList();

            TodoModel todoB = new TodoModel(DefaultEntityIdentifier<TodoModel>.CreateNewInstance(), "bbb");
            repository.Store(todoB);
            var list2 = repository.AsEntitiesList();

            Assert.AreEqual(1, list1.Count);
            Assert.AreEqual("aaa", list1[0].Message());
            Assert.AreEqual(2, list2.Count);
            Assert.AreEqual("bbb", list2[1].Message());
        }
    }
}
