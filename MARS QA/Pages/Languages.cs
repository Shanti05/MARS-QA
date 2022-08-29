using MARS_QA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARS_QA.Pages
{
    public class Languages
    {
        IWebDriver Driver;
        public Languages(IWebDriver driver)
        {
            Driver = driver;
        }

        public void AddLanguage(IWebDriver driver, string Language, string Level)
        {

            
            IWebElement languagesTab = driver.FindElement(By.LinkText("Languages"));
            languagesTab.Click();
           

            IWebElement AddNewButton = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
            AddNewButton.Click();
            WaitHelpers.WaitToBeClickable(driver, 20, "XPath", "/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]");


            IWebElement addLanguage = driver.FindElement(By.Name("name"));
            addLanguage.SendKeys(Language);
            

            SelectElement dropDown = new SelectElement(driver.FindElement(By.Name("level")));
            dropDown.SelectByValue(Level);
            


            IWebElement AddButton = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[3]/input[1]"));
            AddButton.Click();
            //WaitHelpers.WaitToBeClickable(driver, 40, "XPath", "/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[3]/input[1]");
            
        }

        public string GetLanguageTableDetails(IWebDriver driver)
        {
            WaitHelpers.WaitIsVisible(driver, 10, "XPath", "//div[@class='ns-box-inner']");
            IWebElement newLanguage = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]"));
            return newLanguage.GetAttribute("outerText").ToString();

           

        }

        public void EditLanguage(IWebDriver driver, string Language, string Level)
        {
            
            
            IWebElement languagesTab = driver.FindElement(By.LinkText("Languages"));
            languagesTab.Click();

            
            IWebElement EditLanguage = driver.FindElement(By.XPath("//tbody/tr[1]/td[3]/span[1]/i[1]"));
            EditLanguage.Click();
            WaitHelpers.WaitToBeClickable(driver, 20, "XPath", "//tbody/tr[1]/td[3]/span[1]/i[1]");

          
            IWebElement EditlanguageTextBox = driver.FindElement(By.Name("name"));
            EditlanguageTextBox.Click();
            EditlanguageTextBox.Clear();
            EditlanguageTextBox.SendKeys(Language);
            

            
            SelectElement dropDown = new SelectElement(driver.FindElement(By.Name("level")));
            dropDown.SelectByValue(Level);
           

            IWebElement UpdateTextbox = driver.FindElement(By.XPath("//input[@value='Update']"));
            UpdateTextbox.Click();
            //WaitHelpers.WaitToBeClickable(driver, 40, "XPath", "//input[@value='Update']");
        }
        public string GeteditLanguageTableDetails(IWebDriver driver)
        {
            WaitHelpers.WaitIsVisible(driver, 10, "XPath", "//div[@class='ns-box-inner']");
            IWebElement updatedLanguage = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]"));
            return updatedLanguage.GetAttribute("outerText").ToString();
           
        }

        public void deleteLanguage(IWebDriver driver)
        {
            IWebElement languagesTab = driver.FindElement(By.LinkText("Languages"));
            languagesTab.Click();
            
            IWebElement deleteLanguage = driver.FindElement(By.XPath("//tbody[2]//tr[1]//td[3]//span[2]//i[1]"));
            deleteLanguage.Click();
 

        }
        public string DeleteLanguageAssertion(IWebDriver driver)
        {
            WaitHelpers.WaitIsVisible(driver, 10, "XPath", "//div[@class='ns-box-inner']");
            IWebElement deleteLanguage = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]"));
            return deleteLanguage.GetAttribute("outerText").ToString();

            
        }

        public void BlankLanguage(IWebDriver driver)
        {
            IWebElement languagesTab = driver.FindElement(By.LinkText("Languages"));
            languagesTab.Click();
          
            IWebElement AddNewButton = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
            AddNewButton.Click();



            IWebElement addLanguage = driver.FindElement(By.Name("name"));
            addLanguage.SendKeys("");


            SelectElement dropDown = new SelectElement(driver.FindElement(By.Name("level")));
            dropDown.SelectByValue("");



            IWebElement AddButton = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[3]/input[1]"));
            AddButton.Click();
            //WaitHelpers.WaitToBeClickable(driver, 20, "XPath", "/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[3]/input[1]");

        }
        public string GetBlankTableLanguageDetails(IWebDriver driver)
        {
            WaitHelpers.WaitIsVisible(driver, 10, "XPath", "//div[@class='ns-box-inner']");
            IWebElement BlankDetails = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]"));
            return BlankDetails.GetAttribute("outerText").ToString();
           
        }
    }
    
}