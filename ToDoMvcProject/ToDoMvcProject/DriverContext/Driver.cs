//using BoDi;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium.Firefox;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using ToDoMvcProject.SpecflowHooks;

//namespace ToDoMvcProject.DriverContext
//{
//    //public enum Browser
//    //{
//    //    Chrome,
//    //    Firefox
//    //}
//    public class Driver
//    {
//        public IWebDriver driver;
//        private readonly IObjectContainer _objectContainer;
        

//        public Driver(IObjectContainer objectContainer)
//        {
//            _objectContainer = objectContainer;
            
//        }


//        //public void SetDriver(string browserName)
//        //{
//        //    switch (browserName)
//        //    {
//        //        case ("Chrome"):
//        //            {
//        //                driver = new ChromeDriver();
//        //                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);
//        //                driver.Manage().Cookies.DeleteAllCookies();
//        //                driver.Manage().Window.Maximize();
//        //                _objectContainer.RegisterInstanceAs<IWebDriver>(driver);
//        //                break;
//        //            }
//        //        case ("Firefox"):
//        //            {
//        //                var opt = new FirefoxOptions
//        //                {
//        //                    BrowserExecutableLocation = @"c:\program files\mozilla firefox\firefox.exe"
//        //                };
//        //                driver = new FirefoxDriver(opt);
//        //                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);
//        //                driver.Manage().Cookies.DeleteAllCookies();
//        //                driver.Manage().Window.Maximize();
//        //                break;
//        //            }
//        //        default:
//        //            {
//        //                driver = new FirefoxDriver();
//        //                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
//        //                driver.Manage().Cookies.DeleteAllCookies();
//        //                driver.Manage().Window.Maximize();
//        //                break;
//        //            }
//        //    }

//        //}
//        ////public static void goToUrl()
//        ////{

//        ////    driver.Navigate().GoToUrl((Constants.Constants.ToDOMvcHomePage));
//        ////}
//        //public void CloseDriver()
//        //{
//        //    driver.Close();
//        //    driver.Quit();
//        //}

//        public void SetDriver(BrowerType browserType)
//        {
//            switch (browserType)
//            {
//                case (BrowerType.Chrome):
//                    {
//                        driver = new ChromeDriver();
//                        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);
//                        driver.Manage().Cookies.DeleteAllCookies();
//                        driver.Manage().Window.Maximize();
//                        _objectContainer.RegisterInstanceAs<IWebDriver>(driver);
//                        break;
//                    }
//                case (BrowerType.Firefox):
//                    {
//                        var opt = new FirefoxOptions
//                        {
//                            BrowserExecutableLocation = @"c:\program files\mozilla firefox\firefox.exe"
//                        };
//                        driver = new FirefoxDriver(opt);
//                        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(6);
//                        driver.Manage().Cookies.DeleteAllCookies();
//                        driver.Manage().Window.Maximize();
//                        _objectContainer.RegisterInstanceAs<IWebDriver>(driver);
//                        break;

//                    }
//                default:
//                    {
//                        driver = new FirefoxDriver();
//                        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
//                        driver.Manage().Cookies.DeleteAllCookies();
//                        driver.Manage().Window.Maximize();
//                        break;
//                    }
//            }
//        }

//        public void CloseDriver()
//        {
//            driver.Close();
//            driver.Quit();
//        }

//    }
//}

