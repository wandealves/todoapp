using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Todo.Domain.Entities;
using Todo.Domain.Queries;

namespace Todo.Domain.Tests.QueryTests
{
    [TestClass]
    public class TodoQueryTests
    {
        private List<TodoItem> _items;

        public TodoQueryTests()
        {
            _items = new List<TodoItem>();
            _items.Add(new TodoItem("Tarefa 01", "Usuario 01", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 02", "Wanderson", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 03", "Usuario 03", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 04", "Wanderson", DateTime.Now));
            _items.Add(new TodoItem("Tarefa 05", "Usuario 05", DateTime.Now));
        }

        [TestMethod]
        public void Dada_a_consulta_deve_retornar_tarefas_apenas_do_usuario_wanderson()
        {
            var result = _items.AsQueryable().Where(TodoQueries.GetAll("Wanderson"));

            Assert.AreEqual(2, result.Count());
        }
    }
}