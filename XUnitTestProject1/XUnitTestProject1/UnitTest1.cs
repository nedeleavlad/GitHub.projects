using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using Microsoft.VisualBasic;


namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void LoginSucceed()
        {
            var driver = new ChromeDriver(@"D:\Vladuuuut\GITHUB\JuniorMind_projects\XUnitTestProject1\XUnitTestProject1\bin\Debug\netcoreapp2.0");
            driver.Url= "http://win-h96lo6s37fc/";
            Thread.Sleep(5000);

            IWebElement username = driver.FindElement(By.Id("textfield-1013-inputEl"));
            username.SendKeys("sa");

            IWebElement pass = driver.FindElement(By.Id("textfield-1014-inputEl"));
            pass.SendKeys("sa");

             var click = driver.FindElement(By.Id("button-1016-btnInnerEl"));
             click.Click();

            driver.Quit();
        }


        [Fact]
        public void LoginFail()
        {
            var driver = new ChromeDriver(@"D:\Vladuuuut\GITHUB\JuniorMind_projects\XUnitTestProject1\XUnitTestProject1\bin\Debug\netcoreapp2.0");
            driver.Url = "http://win-h96lo6s37fc/";
            Thread.Sleep(5000);

            IWebElement username = driver.FindElement(By.Id("textfield-1013-inputEl"));
            username.SendKeys("sasasass");

            IWebElement pass = driver.FindElement(By.Id("textfield-1014-inputEl"));
            pass.SendKeys("sa");

            var click = driver.FindElement(By.Id("button-1016-btnInnerEl"));
            click.Click();


            driver.Quit();
        }

        [Fact]
        public void FillWithSpecialCharacters()
        {
            var driver = new ChromeDriver(@"D:\Vladuuuut\GITHUB\JuniorMind_projects\XUnitTestProject1\XUnitTestProject1\bin\Debug\netcoreapp2.0");
            driver.Url = "http://win-h96lo6s37fc/";
            Thread.Sleep(5000);

            IWebElement username = driver.FindElement(By.Id("textfield-1013-inputEl"));
            username.SendKeys("sasasass??????####%%%%");

            IWebElement pass = driver.FindElement(By.Id("textfield-1014-inputEl"));
            pass.SendKeys("%%%%ggg>>");

            var click = driver.FindElement(By.Id("button-1016-btnInnerEl"));
            click.Click();

            driver.Quit();
        }

       


    }
}
