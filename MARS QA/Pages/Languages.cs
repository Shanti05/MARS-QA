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
        
        public void AddLanguage(IWebDriver driver, string Language, string Level)
        {

            IWebElement languagesTab = driver.FindElement(By.LinkText("Languages"));
            languagesTab.Click();
           

            IWebElement AddNewButton = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
            AddNewButton.Click();
            


            IWebElement addLanguage = driver.FindElement(By.Name("name"));
            addLanguage.SendKeys(Language);
            

            SelectElement dropDown = new SelectElement(driver.FindElement(By.Name("level")));
            dropDown.SelectByValue(Level);
            


            IWebElement AddButton = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[3]/input[1]"));
            AddButton.Click();
            Thread.Sleep(2500);

        }

        public string GetLanguageTableDetails(IWebDriver driver)
        {
            Thread.Sleep(2500);
            IWebElement newLanguage = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]"));
            return newLanguage.GetAttribute("outerText").ToString();

        }

        public void EditLanguage(IWebDriver driver, string Language, string Level)
        {
            Thread.Sleep(1500);
            //click on languages tab
            IWebElement languagesTab = driver.FindElement(By.LinkText("Languages"));
            languagesTab.Click();

            Thread.Sleep(2000);
            //Edit Language functionality//
            IWebElement EditLanguage = driver.FindElement(By.XPath("//tbody/tr[1]/td[3]/span[1]/i[1]"));
            EditLanguage.Click();
            Thread.Sleep(3000);

            //Edit language text box
            IWebElement EditlanguageTextBox = driver.FindElement(By.Name("name"));
            EditlanguageTextBox.Click();
            EditlanguageTextBox.Clear();
            EditlanguageTextBox.SendKeys(Language);
            Thread.Sleep(2500);

            //select level from dropdown menu
            SelectElement dropDown = new SelectElement(driver.FindElement(By.Name("level")));
            dropDown.SelectByValue(Level);
            Thread.Sleep(2500);

            //Click on Update button
            IWebElement UpdateTextbox = driver.FindElement(By.XPath("//input[@value='Update']"));
            UpdateTextbox.Click();
            Thread.Sleep(2000);
        }
        public string GeteditLanguageTableDetails(IWebDriver driver)
        {
            Thread.Sleep(3000);
            IWebElement updatedLanguage = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]"));
            return updatedLanguage.GetAttribute("outerText").ToString();
        }

        public void deleteLanguage(IWebDriver driver)
        {
            IWebElement languagesTab = driver.FindElement(By.LinkText("Languages"));
            languagesTab.Click();
            Thread.Sleep(3000);

            //delete the record
            Thread.Sleep(2500);
            IWebElement deleteLanguage = driver.FindElement(By.XPath("//tbody[2]//tr[1]//td[3]//span[2]//i[1]"));
            Thread.Sleep(2500);

            deleteLanguage.Click();
            Thread.Sleep(3000);

        }
        public string DeleteLanguageAssertion(IWebDriver driver)
        {
            Thread.Sleep(3000);
            IWebElement deleteLanguage = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]"));
            return deleteLanguage.GetAttribute("outerText").ToString();
        }

        public void BlankLanguage(IWebDriver driver)
        {
            IWebElement languagesTab = driver.FindElement(By.LinkText("Languages"));
            languagesTab.Click();
            Thread.Sleep(3000);
            IWebElement AddNewButton = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
            AddNewButton.Click();



            IWebElement addLanguage = driver.FindElement(By.Name("name"));
            addLanguage.SendKeys("");


            SelectElement dropDown = new SelectElement(driver.FindElement(By.Name("level")));
            dropDown.SelectByValue("");



            IWebElement AddButton = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[3]/input[1]"));
            AddButton.Click();
            Thread.Sleep(2500);

        }
        public string GetBlankTableLanguageDetails(IWebDriver driver)
        {
            Thread.Sleep(2500);
            IWebElement BlankDetails = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]"));
            return BlankDetails.GetAttribute("outerText").ToString();

        }
    }
    
}