using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;
using OpenQA.Selenium.Support.UI;
using System.Threading;
using System.IO;
using System.Reflection;
using Microsoft.Extensions.Configuration;

namespace XUnitTestProject1
{

    public class UnitTest1
    {
        private const string userInputId = "textfield-1013-inputEl";
        private const string passInputId = "textfield-1014-inputEl";
        private const string logInId = "button-1016-btnInnerEl";

        private readonly IWebElement username;
        private readonly IWebElement pass;
        private readonly ChromeDriver driver;
        private readonly IWebElement submit;

        public UnitTest1()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("configs.json")
                .Build();

            //Given
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Url = config["url"];

            var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            username = wait.Until(drv => drv.FindElement(By.Id(userInputId)));
            pass = wait.Until(drv => drv.FindElement(By.Id(passInputId)));
            submit = wait.Until(drv => drv.FindElement(By.Id(logInId)));
        }

        [Fact]
        public void LoginSucceed()
        {   //When
            username.SendKeys("sa");
            pass.SendKeys("sa");
            submit.Click();

            WebDriverWait waitLogIn = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            waitLogIn.Until(drv => drv.FindElement(By.Id("button-1030-btnIconEl")));


            //Then
            Assert.True(driver.FindElement(By.Id("button-1041-btnIconEl")).Displayed);
        }


        [Fact]
        public void LoginFail()
        {   //When
            username.SendKeys("sasasass");
            pass.SendKeys("sa");
            submit.Click();

            WebDriverWait waitLogIn = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            waitLogIn.Until(drv => drv.FindElement(By.Id("messagebox-1001_header-title-textEl")));

            //Then
            Assert.True(driver.FindElement(By.Id("messagebox-1001_header-title-textEl")).Displayed);
        }

        [Fact]
        public void FillWithSpecialCharacters()
        { 
            //When
            username.SendKeys("sasasass??????####%%%%");
            pass.SendKeys("%%%%ggg>>");
            submit.Click();
            WebDriverWait waitLogIn = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            waitLogIn.Until(drv => drv.FindElement(By.Id("messagebox-1001_header-title-textEl")));

            //Then
            Assert.True(driver.FindElement(By.Id("messagebox-1001_header-title-textEl")).Displayed);
        }

        [Fact]
        public void LargeNumberOfCharacters()
        {   
            //When
            string st = new string('t', 1000);
            username.SendKeys(st);
            pass.SendKeys("%%%%ggg>>");
            submit.Click();

            WebDriverWait waitLogIn = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            waitLogIn.Until(drv => drv.FindElement(By.Id("messagebox-1001_header-title-textEl")));

            //Then
            Assert.True(driver.FindElement(By.Id("messagebox-1001_header-title-textEl")).Displayed);
        }
    }
}
