using System;
using BrowserTest;
using NUnit.Framework;
using OpenQA.Selenium;

namespace BrowserTest
{
    [TestFixture]
    [Parallelizable]
    public class Firefoxtesting : Hooks
    {
        public Firefoxtesting():base(BrowserType.Firefox)
        {

        }
        [Test]
        public void FirefoxGoogleTest()
        {
            Driver.Navigate().GoToUrl("https://banqueprivee.oddo.fr/Authentification/Login_Particuliers_OBP.aspx?ReturnUrl=%2f");
            System.Threading.Thread.Sleep(50000);
            //Driver.FindElement(By.Name("q")).SendKeys("ODDO-BHF");
            //Driver.FindElement(By.Name("BtnG")).Click();
            //Assert.That(Driver.PageSource.Contains("ODDO-BHF"), Is.EqualTo(true), "the text selenium does not exist ");
        }
    }
}
[TestFixture]
[Parallelizable]
public class Chrometesting : Hooks
{
    public Chrometesting() : base(BrowserType.Chrome)
    {
    }

    [Test]
    public void ChromeGoogleTest()
    {
        Driver.Navigate().GoToUrl("https://banqueprivee.oddo.fr/Authentification/Login_Particuliers_OBP.aspx?ReturnUrl=%2f");
        //Driver.FindElement(By.Name("q")).SendKeys("ExecuteAutomation");
        //Driver.FindElement(By.Name("BtnG")).Click();
        //Assert.That(Driver.PageSource.Contains("ExecuteAutomation"), Is.EqualTo(true), "the text selenium does not exist ");
    }
}
