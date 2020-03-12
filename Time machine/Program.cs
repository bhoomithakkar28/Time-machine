using Flurl;
using java.awt;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Winium;
using System;


namespace Time_machine
{
    class Program
    {
        public static DesiredCapabilities WINIUM_CAPABILITIES { get; private set; }
        public static char ICommandExecutor { get; private set; }
        public static DesiredCapabilities DesiredCapabilities { get; private set; }

        static void Main(string[] args)
        {

            var dc = new DesiredCapabilities();
            dc.SetCapability("app", @"\\deimos.contrado.local\Users\bhoomikat\Desktop\Application Files\ContradoStaff_1_0_0_6\ContradoStaff.exe");

            var driver = new RemoteWebDriver(new Uri("http://localhost:9999"), dc,TimeSpan.FromMinutes(2));

          //  String appPath = "\\deimos.contrado.local\Users\bhoomikat\Desktop\Application Files\ContradoStaff_1_0_0_6\ContradoStaff.exe";

            //driver.FindElementByName("Run").Click();
            // Robot robot= new Robot();
            // System.Threading.Thread.Sleep(7000);
            //robot.keyPress(keycode: java.awt.@event.KeyEvent.VK_LEFT);
            //  robot.keyPress(keycode: java.awt.@event.KeyEvent.VK_ENTER);

            //driver.FindElementByClassName("Button").Click();
            driver.FindElementById("2").Click();
        }
    }
}

