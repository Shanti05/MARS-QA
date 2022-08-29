
using MARS_QA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V102.Network;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace MARS_QA.Pages
{
    public class LoginPage 

    {
        IWebDriver Driver;
        public LoginPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void LoginActions(IWebDriver driver)    
          {
            driver.Manage().Window.Maximize();

            //Launch the turnup portal
            driver.Navigate().GoToUrl("http://192.168.1.142:5000/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(60);
            try
            {
                // Click on sign in button
                IWebElement clickOnSignInButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
                clickOnSignInButton.Click();
               


                //Identify username textbox and enter valid username
                IWebElement usernameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                usernameTextbox.SendKeys("itshanti05@gmail.com");
              
                IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                passwordTextbox.SendKeys("Anketa$99");

                IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                LoginButton.Click();
               

            }
            catch (Exception ex)
            {
                Assert.Fail("Unable to launch MARS portal", ex.Message);
            }

            
        }


        public void goToProfilePage(IWebDriver driver)
        {

           
            IWebElement profilePage = driver.FindElement(By.LinkText("Profile"));
            profilePage.Click();
           

        }
       
    }
}
