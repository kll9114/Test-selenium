using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Tests
{
    public class Tests
    {
 

        [Test]
        public void Test1()
        {
        IWebDriver driver = new ChromeDriver(@"C:\Users\Utilisateur\Documents\Visual Studio 2015\Projects\Onlystore\packages\WebDriver.ChromeDriver.win32.76.0.3809.68\content");
        driver.Url = ("http://toolsqa.com/Automation-practice-form/");


        // Type Name in the FirstName text box      
        driver.FindElement(By.Name("firstname")).SendKeys("Lakshay");
        driver.FindElement(By.Name("firstname")).SendKeys("Lakshay");

            // Type Name in the FirstName text box      


        }
    }
}