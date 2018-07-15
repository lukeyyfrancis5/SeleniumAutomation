using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Selenium
{
    class Program
    {
        // Create the reference for Browser
        IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
           
        }


        [SetUp]
        public void Intialize()
        {
            // Navigate to Google page
            driver.Navigate().GoToUrl("executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            Console.WriteLine("Open URL");
        }


        [Test]
        public void ExecuteTest()
        {
            // Find the Element
            IWebElement element = driver.FindElement(By.Name("q"));

            // Preform Ops
            element.SendKeys("execute automation");
            Console.WriteLine("Execute Test");
        }

        [Test]
        public void NextTest()
        {
            Console.WriteLine("Next Method");
        }

        [TearDown]
        public void Cleanup()
        {
            // Quit
            driver.Close();
            Console.WriteLine("Close Browser");

        }
    }
}
