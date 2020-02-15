using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Entities;

namespace Todo.Domain.Tests.EntityTests
{
    [TestClass]
    public class TodoItemTests
    {
        private readonly TodoItem todo = new TodoItem("Titulo aqui", "wanderson", DateTime.Now);
        [TestMethod]
        public void Dao_um_novo_todo_o_mesmo_nao_pode_ser_concluido()
        {
            Assert.AreEqual(todo.Done, false);
        }
    }
}