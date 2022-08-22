


using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MARS_QA.Pages
{
    public class LoginPage

    {
        public void LoginActions(IWebDriver driver)
        {

            driver.Manage().Window.Maximize();

            //Launch the turnup portal
            driver.Navigate().GoToUrl("http://192.168.1.106:5000/Home");
            Thread.Sleep(1000);

            try
            {
                // Click on sign in button
                IWebElement clickOnSignInButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
                clickOnSignInButton.Click();
                Thread.Sleep(2500);

                //Identify username textbox and enter valid username
                IWebElement usernameTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
                usernameTextbox.SendKeys("itshanti05@gmail.com");
                Thread.Sleep(2500);

                //Identify password textbox and enter valid password
                IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
                passwordTextbox.SendKeys("Anketa$99");
                Thread.Sleep(2500);

                //identify login button and click on it
                IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
                LoginButton.Click();
                Thread.Sleep(2500);
            }
            catch (Exception ex)
            {
                Assert.Fail("Unable to launch MARS portal", ex.Message);
            }


        }
        public void goToProfilePage(IWebDriver driver)
        {
            Thread.Sleep(2500);
            // Navigate to profile and click on it
            IWebElement profilePage = driver.FindElement(By.LinkText("Profile"));
            profilePage.Click();
            Thread.Sleep(2500);
        }

       
    }
}
