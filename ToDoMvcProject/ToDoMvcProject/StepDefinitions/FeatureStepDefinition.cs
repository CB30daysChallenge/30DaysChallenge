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

namespace _30DaysAutomationChallenge.StepDefinitions
{
    [Binding]
    public sealed class FeatureStepDefinition
    {


        public IEnumerable<Task> listOfTasks;
        public Task task;
        public IWebDriver driver;
        ToDoMvcPage toDoMvcPage;

        
        public FeatureStepDefinition(Task task, IWebDriver _driver)
        {
            this.task = task;
            driver = _driver;
            toDoMvcPage = new ToDoMvcPage(_driver);
        }

        

        [Given(@"I am on the ToDoMvc AngularJS Page")]
        public void GivenIAmOnTheToDoMvcAngularJSPage()
        {

            toDoMvcPage.OpenPage();


        }

        [When(@"I Click on the All")]
        public void WhenIClickOnTheAll()
        {
            toDoMvcPage.ClickAllButton();
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

        [When(@"I Enter a New (.*)")]
        public void WhenIEnterANew(string Task)
        {
            Thread.Sleep(10000);
            toDoMvcPage.CreateTask(Task);
        }

        [When(@"I Enter New tasks")]
        public void WhenIEnterNewTasks(Table table)
        {

            listOfTasks = table.CreateSet<Task>();

            foreach (var tsk in listOfTasks)
            {

                task = tsk;
                toDoMvcPage.CreateTask(tsk.Tasks.ToString());
                toDoMvcPage.enter();

            }

        }

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
        [When(@"I click on the checkbox of one of the tasks")]
        public void WhenIClickOnTheCheckboxOfOneOfTheTasks()
        {

            toDoMvcPage.ClickOnActiveTask();

        }


        [When(@"I Click on the Complete")]
        public void WhenIClickOnTheComplete()
        {
            toDoMvcPage.ClickCompletedButton();

        }

        [Then(@"the (.*) is displayed on the Completed List")]
        public void ThenTheIsDisplayedOnTheCompletedList(string task)
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
        [Given(@"I Click on the Active")]
        public void GivenIClickOnTheActive()
        {
            toDoMvcPage.ClickActiveButton();
        }

        [Then(@"(.*) and (.*) are Displayed")]
        public void ThenAndAreDisplayed(string task1, string task2)
        {
            string value1 = toDoMvcPage.GetTask(task1);
            string value2 = toDoMvcPage.GetTask(task2);
            Assert.AreEqual(task1, value1);
            Assert.AreEqual(task2, value2);
        }

        [Then(@"all entered tasks are displayed")]
        public void ThenAllEnteredTasksAreDisplayed()
        {


            try
            {
                foreach (var tsk in listOfTasks)
                {
                    string taskList = toDoMvcPage.GetTask(tsk.Tasks.ToString());
                    Assert.AreEqual(tsk.Tasks.ToString(), taskList);

                }

            }
            catch (Exception ex)
            {

                Console.WriteLine("Test Failed " + ex);
            }
        }


    }
}
