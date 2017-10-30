using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoMvcProject.POM
{
    public abstract class BasePage
    {
        public IWebDriver driver { get; set; }
        public BasePage(IWebDriver _driver)
        {
            driver = _driver;
            PageFactory.InitElements(_driver, this);

        }
    }
}
