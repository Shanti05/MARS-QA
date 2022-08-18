using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;




//open chrome browser
IWebDriver driver = new ChromeDriver();

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

    //Identify password textbox and enter valid password
    IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
    passwordTextbox.SendKeys("Anketa$99");

    //identify login button and click on it
    IWebElement LoginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
    LoginButton.Click();
    Thread.Sleep(2500);
}
catch (Exception ex)
{


    Assert.Fail("Turnup portal homepage did not launch", ex.Message);
}


        