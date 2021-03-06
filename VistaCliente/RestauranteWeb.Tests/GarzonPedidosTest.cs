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
public class GarzonPedidosTest {
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
  public void garzonPedidos() {
    driver.Navigate().GoToUrl("http://localhost:50386/garzon");
    driver.Manage().Window.Size = new System.Drawing.Size(974, 1040);
    driver.FindElement(By.Id("rut")).Click();
    driver.FindElement(By.Id("rut")).SendKeys("129675523");
    driver.FindElement(By.Id("PASSWORD_USUARIO")).Click();
    driver.FindElement(By.Id("PASSWORD_USUARIO")).SendKeys("hcarrasco27");
    driver.FindElement(By.CssSelector(".btn")).Click();
    driver.FindElement(By.CssSelector(".column:nth-child(2) .btn")).Click();
    driver.FindElement(By.CssSelector("#\\31 29 > .btn-warning")).Click();
    driver.FindElement(By.LinkText("Volver")).Click();
    driver.FindElement(By.CssSelector("#\\31 29 > #btnDelete")).Click();
    driver.FindElement(By.CssSelector("#\\31 28 > .btn-warning")).Click();
    driver.FindElement(By.LinkText("Marcar Pedido Entregado")).Click();
  }
}
