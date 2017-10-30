using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoMvcProject.Helpers
{
    public class Screenshots
    {
        public static string TakeScreenshot(IWebDriver driver)
        {
            string id = Guid.NewGuid().ToString();
            string fileName = Constants.Constants.ReportingFolder + id + ".png";
            Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            ss.SaveAsFile(fileName, ScreenshotImageFormat.Png);
            Console.WriteLine($"SCREENSHOT[ file:///{fileName} ]SCREENSHOT");
            return fileName;
        }

    }
}
