//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ToDoMvcProject.Reports
//{
//    public class ToDoMvcReport
//    {
//        public ExtentReports extent;
//        public static ExtentHtmlReporter htmlReporter;
//        public static ExtentTest test;
//        public static string path = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
//        public static string actualPath = path.Substring(0, path.LastIndexOf("bin"));
//        public static string projectPath = new Uri(actualPath).LocalPath;
//        public static string reportPath = projectPath + "Reports\\ToDoMvcReport.html";
//        //public static string reportPath = @"C:\AutomationProjects\30DaysAutomationChallenge\30DaysAutomationChallenge\30DaysAutomationChallenge\Reports" + "Reports\\ToDoMvcReport.html";

//        public void SetupReport()
//        {

//            extent = new ExtentReports();
//            htmlReporter = new ExtentHtmlReporter(reportPath);
//            htmlReporter.Configuration().Theme = Theme.Dark;
//            htmlReporter.Configuration().DocumentTitle = "ToDoMvc Report";
//            htmlReporter.Configuration().ReportName = "ToDoNMvc Report";
//            extent.AttachReporter(htmlReporter);


//        }
//    }
//}
