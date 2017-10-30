using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using TechTalk.SpecFlow;
//using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ToDoMvcProject.SpecflowHooks
{

    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        //public string browserName = System.Configuration.ConfigurationSettings.AppSettings["browser"];
        private readonly IObjectContainer _objectContainer;
        private IWebDriver driver;
        public BrowerType _browserType;
        
        

        public Hooks(IObjectContainer objectContainer)
        {
            _objectContainer = objectContainer;
        }


        [BeforeScenario]
        public void Initialize()
        {
            //var browserType = TestContext.Parameters.Get("Browser");
            //_browserType = (BrowerType)Enum.Parse(typeof(BrowerType), browserType);


            SetDriver(_browserType);
            //SetDriver(browserName);


        }

        [AfterScenario]
        public void AfterScenario()
        {
            CloseDriver();
        }


        //public void SetDriver(BrowerType browserType)
        public void SetDriver(BrowerType browserType)
        {

            switch (browserType)
            {
                case (BrowerType.Chrome):
                    {
                        var opt = new ChromeOptions
                        {
                            BinaryLocation = @"C:\AutomationProjects\newGrid\chromedriver.exe"
                        };
                        driver = new ChromeDriver();
                        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);
                        driver.Manage().Cookies.DeleteAllCookies();
                        driver.Manage().Window.Maximize();
                        _objectContainer.RegisterInstanceAs<IWebDriver>(driver);
                        break;
                    }
                case (BrowerType.Firefox):
                    {
                        var opt = new FirefoxOptions
                        {
                            BrowserExecutableLocation = @"c:\program files\mozilla firefox\firefox.exe"
                        };
                        driver = new FirefoxDriver(opt);
                        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);
                        driver.Manage().Cookies.DeleteAllCookies();
                        driver.Manage().Window.Maximize();
                        _objectContainer.RegisterInstanceAs<IWebDriver>(driver);
                        break;

                    }
                default:
                    {

                        break;

                    }
            }

            }

        public void CloseDriver()
        {
            driver.Close();
            driver.Quit();
        }


    }
    public enum BrowerType
    {

        Firefox,
        Chrome
    }
}
