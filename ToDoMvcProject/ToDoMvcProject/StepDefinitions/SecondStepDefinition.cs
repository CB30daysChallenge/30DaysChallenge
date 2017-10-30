using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using ToDoMvcProject.POM;
using ToDoMvcProject.Task;

namespace ToDoMvcProject.StepDefinitions
{
    [Binding]
    public sealed class SecondStepDefinition
    {
        // For additional details on SpecFlow step definitions see http://go.specflow.org/doc-stepdef
        //public IEnumerable<Task> taskLists;
        public IEnumerable<Task.Task> listOfTasks;
        public Task.Task task;
        public IWebDriver driver;
        ToDoMvcPage toDoMvcPage;

        public SecondStepDefinition(Task.Task task, IWebDriver _driver)
        {
            this.task = task;
            driver = _driver;
            toDoMvcPage = new ToDoMvcPage(_driver);
        }


        [When(@"I Click on the Completed")]
        public void WhenIClickOnTheCompleted()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"completedUS Racing are displayed")]
        public void ThenCompletedUSRacingAreDisplayed()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I Click on the Active")]
        public void WhenIClickOnTheActive()
        {
            Thread.Sleep(15000);
            toDoMvcPage.ClickActiveButton();
        }

        //[When(@"I Enter a New (.*)")]
        //public void WhenIEnterANew(string Task)
        //{
        //    toDoMvcPage.CreateTask(Task);
        //}


        [Then(@"active(.*) are displayed")]
        public void ThenActiveAreDisplayed(string task)
        {

            string value = toDoMvcPage.GetTask(task);
            try
            {
                Assert.AreEqual(task, value);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Test Failed " + ex);
            }

        }


        [When(@"I click on Checkbox of Acive (.*)")]
        public void WhenIClickOnCheckboxOfAcive(string task)
        {
            toDoMvcPage.ClickOnActiveTask();

        }


        [When(@"I press Enter")]
        public void WhenIPressEnter()
        {
            toDoMvcPage.enter();
        }

        [Then(@"the new (.*) is populated on the List")]
        public void ThenTheNewIsPopulatedOnTheList(string task)
        {
            string value = toDoMvcPage.GetTask(task);
            try
            {
                Assert.AreEqual(task, value);

            }
            catch (Exception ex)
            {

                Console.WriteLine("Test Failed " + ex);
            }
        }

        [When(@"I Click on Checkbox of '(.*)' one of Active tasks")]
        public void WhenIClickOnCheckboxOfOneOfActiveTasks(string tasks)
        {
            string value = toDoMvcPage.GetTask(tasks);
            foreach (var tsk in listOfTasks)
            {
                if (value == tasks)
                {
                    toDoMvcPage.ClickOnActiveTask(tasks);
                    break;
                }
            }
        }

        [When(@"I click on the checkbox '(.*)' one of the Completed tasks")]
        public void WhenIClickOnTheCheckboxOneOfTheCompletedTasks(string tasks)
        {
            toDoMvcPage.clickOnCompletedtTask(tasks);
        }

        [Then(@"only '(.*)' is displayed in")]
        public void ThenOnlyIsDisplayedIn(string tasks)
        {
            string value = toDoMvcPage.GetTask(tasks);
            foreach (var tsk in listOfTasks)
            {
                if (value == tasks)
                {
                    toDoMvcPage.ClickOnActiveTask(tasks);
                    break;
                }
            }
        }

        [When(@"I Click on the ClearCompleted")]
        public void WhenIClickOnTheClearCompleted()
        {
            toDoMvcPage.ClickClearAllButton();
        }



        [Then(@"only (.*) is Displayed")]
        public void ThenOnlyIsDisplayed(string task2)
        {


            string value = toDoMvcPage.GetTask(task2);
            try
            {
                Assert.AreEqual(task2, value);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Test Failed " + ex);
            }

        }

        [Then(@"(.*) is not Displayed")]
        public void ThenIsNotDisplayed(string task1)
        {
            string value = toDoMvcPage.GetTask(task1);
            try
            {
                Assert.AreNotEqual(task1, null);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Test Failed " + ex);
            }


        }
        [Then(@"(.*) and (.*) are Displayed")]
        public void ThenAndAreDisplayed(string task1, string task2)
        {
            string value1 = toDoMvcPage.GetTask(task1);
            string value2 = toDoMvcPage.GetTask(task2);
            Assert.AreEqual(task1, value1);
            Assert.AreEqual(task2, value2);
        }

    }
}
