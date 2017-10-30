using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using ToDoMvcProject.POM;

namespace ToDoMvcProject
{
    [TestClass]
    public class UnitTest1
    {
        //public IEnumerable<Task> listOfTasks;
        public Task.Task task;
        //ToDoMvcPage toDoMvcPage = new ToDoMvcPage();

        [TestInitialize]
        public void Initialize()
        {
            //toDoMvcPage.OpenPage();
        }
        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestCleanup]
        public void Cleanup()
        {
        }
    }
}
