// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class LoginClienteTest {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void loginCliente() {
    driver.Navigate().GoToUrl("http://localhost:50386/");
    driver.Manage().Window.Size = new System.Drawing.Size(974, 1040);
    driver.FindElement(By.LinkText("ENTRAR")).Click();
    driver.FindElement(By.Id("rut")).Click();
    driver.FindElement(By.Id("rut")).Click();
    driver.FindElement(By.Id("rut")).SendKeys("175264472");
    driver.FindElement(By.Id("PASSWORD_CLIENTE")).Click();
    driver.FindElement(By.Id("PASSWORD_CLIENTE")).SendKeys("jazgut");
    driver.FindElement(By.CssSelector(".btn:nth-child(5)")).Click();
  }
}
