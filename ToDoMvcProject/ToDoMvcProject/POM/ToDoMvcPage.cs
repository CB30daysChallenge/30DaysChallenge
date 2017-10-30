using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoMvcProject.POM
{
    public class ToDoMvcPage:BasePage
    {
        
        
        private const string xpathofTextbox = "//*[@id=\"new-todo\"]";
        private const string xpathofClearCompleted = "//*[@id=\"clear-completed\"]";
        private const string linkTextActive = "Active";
        private const string linkTextCompleted = "Completed";
        private const string listClassView = "view";
        private const string allLinkText = "All";

        public ToDoMvcPage(IWebDriver driver) : base(driver)
        {
            
        }
        [FindsBy(How = How.ClassName, Using = listClassView)]
        public IList<IWebElement> CheckboxList;

        [FindsBy(How = How.XPath, Using = xpathofTextbox)]
        public IWebElement NewToDoXPath { get; set; }

        [FindsBy(How = How.LinkText, Using = linkTextActive)]
        public IWebElement Active { get; set; }

        [FindsBy(How = How.LinkText, Using = linkTextCompleted)]
        public IWebElement Completed { get; set; }

        [FindsBy(How = How.LinkText, Using = allLinkText)]
        public IWebElement All { get; set; }

        [FindsBy(How = How.XPath, Using = xpathofClearCompleted)]
        public IWebElement ClearCompleted { get; set; }

        [FindsBy(How = How.ClassName, Using = listClassView)]
        public IList<IWebElement> ListTasks { get; set; }

        public void OpenPage()
        {
            try
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);

                driver.Navigate().GoToUrl(Constants.Constants.ToDOMvcHomePage);
                string file = Helpers.Screenshots.TakeScreenshot(driver);
            }
            catch (ElementNotVisibleException ex)
            {
                Console.WriteLine("Unable to Find the Element " + ex);
                string file = Helpers.Screenshots.TakeScreenshot(driver);
                throw ex;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to Find the Element " + ex);
                string file = Helpers.Screenshots.TakeScreenshot(driver);
                throw ex;
            }
        }
        public void ClearCheckBox()
        {
            NewToDoXPath.Clear();
        }
        public void ClearList()
        {

            try
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                for (int i = 0; i < CheckboxList.Count; i++)
                {
                    CheckboxList.ElementAt(i).Clear();
                    string file = Helpers.Screenshots.TakeScreenshot(driver);
                }
            }
            catch (ElementNotVisibleException ex)
            {
                Console.WriteLine("Unable to Find the Element " + ex);
                string file = Helpers.Screenshots.TakeScreenshot(driver);
                throw ex;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to Find the Element " + ex);
                string file = Helpers.Screenshots.TakeScreenshot(driver);
                throw ex;
            }
        }

        public void ClickAllButton()
        {
            All.Click();
        }
        public void ClickClearAllButton()
        {

            try
            {
                ClearCompleted.Click();
            }
            catch (ElementNotVisibleException ex)
            {
                Console.WriteLine("Unable to Find the Element " + ex);
                throw ex;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to Find the Element " + ex);
                //string file=Helpers.Screenshots.TakeScreenshot(driver);
                throw ex;

            }
        }
        public void ClickCompletedButton()
        {

            try
            {
                Completed.Click();
            }

            catch (Exception ex)
            {
                Console.WriteLine("Unable to Find the Complete Button " + ex);
                string file = Helpers.Screenshots.TakeScreenshot(driver);
                throw ex;
            }
        }
        public void ClickActiveButton()
        {

            try
            {
                Active.Click();
                string file = Helpers.Screenshots.TakeScreenshot(driver);
            }
            catch (ElementNotVisibleException ex)
            {
                Console.WriteLine("Unable to Find/click the Active Button  " + ex);
                Helpers.Screenshots.TakeScreenshot(driver);
                throw ex;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to Find/click the Active Button  " + ex);
                Helpers.Screenshots.TakeScreenshot(driver);
                throw ex;
            }
        }
        public ToDoMvcPage CreateTask(string newTask)
        {

            try
            {
                string file = Helpers.Screenshots.TakeScreenshot(driver);
                NewToDoXPath.SendKeys(newTask);

            }
            catch (ElementNotVisibleException ex)
            {
                Console.WriteLine("Unable to Find the Textbox " + ex);
                string file = Helpers.Screenshots.TakeScreenshot(driver);
                throw ex;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to Find the Textbox " + ex);
                string file = Helpers.Screenshots.TakeScreenshot(driver);
                throw ex;
            }
            return this;
        }

        public string GetTask(string task)
        {

            IWebElement element = null;
            int size = ListTasks.Count();
            try
            {

                for (int i = 0; i < size; i++)
                {

                    element = ListTasks.ElementAt(i);
                    if (element.Text == task)
                    {

                        break;


                    }
                }
            }
            catch (ElementNotVisibleException ex)
            {
                Console.WriteLine("Unable to Find the Task " + ex);
                string file = Helpers.Screenshots.TakeScreenshot(driver);
                throw ex;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to Find the Task " + ex);
                string file = Helpers.Screenshots.TakeScreenshot(driver);
                throw ex;
            }

            return element.Text;

        }
        public void enter()
        {
            try
            {
                NewToDoXPath.SendKeys(Keys.Enter);

            }
            catch (ElementNotVisibleException ex)
            {
                Console.WriteLine("Unable to Find the Element " + ex);
                string file = Helpers.Screenshots.TakeScreenshot(driver);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to Find the Element " + ex);
                string file = Helpers.Screenshots.TakeScreenshot(driver);

            }

        }
        public void ClickOnActiveTask()
        {
            CheckboxList = driver.FindElements(By.ClassName("view"));

            int size = CheckboxList.Count();
            try
            {

                if (size == 1)
                {
                    IWebElement element = driver.FindElement(By.CssSelector("#todo-list > li > div > input"));
                    element.Click();
                    string file = Helpers.Screenshots.TakeScreenshot(driver);
                }
                else if (size > 1)
                {

                    for (int i = 1; i <= size; i++)
                    {

                        IWebElement element = driver.FindElement(By.CssSelector("#todo-list > li:nth-child(" + i + ") > div > input"));
                        element.Click();
                        string file = Helpers.Screenshots.TakeScreenshot(driver);

                    }
                }

            }
            catch (ElementNotVisibleException ex)
            {

                Console.WriteLine("Unable to Find the Element " + ex);
                string file = Helpers.Screenshots.TakeScreenshot(driver);

            }
            catch (Exception ex)
            {

                string file = Helpers.Screenshots.TakeScreenshot(driver);
                Console.WriteLine("Unable to Find the Element " + ex);

            }

        }

        public void ClickOnActiveTask(string task)
        {

            CheckboxList = driver.FindElements(By.ClassName("view"));

            int size = CheckboxList.Count();
            try
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                if (size == 1)
                {
                    IWebElement element = driver.FindElement(By.CssSelector("#todo-list > li > div > input"));
                    if (element.GetAttribute(task) == task)
                    {
                        element.Click();

                    }

                }
                else if (size > 1)
                {

                    for (int i = 1; i <= size; i++)
                    {

                        IWebElement element = driver.FindElement(By.CssSelector("#todo-list > li:nth-child(" + i + ") > div > input"));
                        IWebElement ele = driver.FindElement(By.CssSelector("#todo-list > li:nth-child(" + i + ") > div > label"));
                        string text = element.Text.ToString();
                        if (ele.Text == task)
                        {
                            element.Click();
                            string file = Helpers.Screenshots.TakeScreenshot(driver);

                        }

                    }
                }

            }
            catch (ElementNotVisibleException ex)
            {
                string file = Helpers.Screenshots.TakeScreenshot(driver);
                Console.WriteLine("Unable to find elements " + ex);

            }
            catch (Exception ex)
            {
                Console.WriteLine("Unable to find elements " + ex);
                string file = Helpers.Screenshots.TakeScreenshot(driver);
            }

        }

        public void clickOnCompletedtTask()
        {
            CheckboxList = driver.FindElements(By.ClassName("view"));

            int size = CheckboxList.Count();
            try
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
                if (size == 1)
                {
                    IWebElement element = driver.FindElement(By.CssSelector("#todo-list > li > div > input"));
                    element.Click();
                    string file = Helpers.Screenshots.TakeScreenshot(driver);
                }
                else if (size > 1)
                {

                    for (int i = 1; i <= size - 1; i++)
                    {

                        IWebElement element = driver.FindElement(By.CssSelector("#todo-list > li:nth-child(" + i + ") > div > input"));
                        element.Click();
                        string file = Helpers.Screenshots.TakeScreenshot(driver);

                    }
                }

            }
            catch (ElementNotVisibleException ex)
            {
                Console.WriteLine("Unable to Find the Element " + ex);
                string file = Helpers.Screenshots.TakeScreenshot(driver);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Unable to find elements " + ex);
                string file = Helpers.Screenshots.TakeScreenshot(driver);

            }

        }

        public void clickOnCompletedtTask(string task)
        {
            CheckboxList = driver.FindElements(By.ClassName("view"));
            IWebElement element = null;


            int size = CheckboxList.Count();
            try
            {
                if (size == 1)
                {
                    for (int i = 0; i < size; i++)
                    {

                        element = ListTasks.ElementAt(i);
                        if (element.Text == task)
                        {
                            element.Click();
                            string file = Helpers.Screenshots.TakeScreenshot(driver);

                        }
                    }
                }
                else if (size > 1)
                {

                    for (int i = 1; i <= size - 1; i++)
                    {

                             if (element.Text == task)
                        {
                            element.Click();
                            string file = Helpers.Screenshots.TakeScreenshot(driver);

                        }

                    }
                }

            }
            catch (ElementNotVisibleException ex)
            {
                Console.WriteLine("Unable to Find the Element " + ex);
                string file = Helpers.Screenshots.TakeScreenshot(driver);

            }

            catch (Exception ex)
            {
                Console.WriteLine("Unable to Find the Element " + ex);
                string file = Helpers.Screenshots.TakeScreenshot(driver);

            }

        }

    }
}
