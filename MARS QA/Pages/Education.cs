using MARS_QA.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARS_QA.Pages
{
    public class Education
    {
        IWebDriver Driver;
        public Education(IWebDriver driver)
        {
            Driver = driver;
        }
        public void AddEducation(IWebDriver driver, string Country, string University, string Title, string Degree, string Year)
        {

            IWebElement EducationTab = driver.FindElement(By.LinkText("Education"));
            EducationTab.Click();


            IWebElement AddNewButton = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[6]/div[1]"));
            AddNewButton.Click();

            IWebElement UniversityName = driver.FindElement(By.Name("instituteName"));
            UniversityName.SendKeys(University);

            SelectElement dropDown = new SelectElement(driver.FindElement(By.Name("country")));
            dropDown.SelectByValue(Country);

            SelectElement dropDownTitle = new SelectElement(driver.FindElement(By.Name("title")));
            dropDownTitle.SelectByValue(Title);

            IWebElement degreeName = driver.FindElement(By.Name("degree"));
            degreeName.SendKeys(Degree);

            SelectElement dropDownYear = new SelectElement(driver.FindElement(By.Name("yearOfGraduation")));
            dropDownYear.SelectByValue(Year);

            IWebElement AddButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]"));
            AddButton.Click();
            WaitHelpers.WaitToBeClickable(driver, 40, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/div/div[3]/div/input[1]");

        }
        public string GetEducationTableDetails(IWebDriver driver)
        {
            WaitHelpers.WaitIsVisible(driver, 30, "XPath", "//div[@class='ns-box-inner']");
            IWebElement newEducation = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]"));
            return newEducation.GetAttribute("outerText").ToString();

        }
        public void EditEducation(IWebDriver driver, string Country, string University, string Title, string Degree, string Year)
        {

            IWebElement EducationTab = driver.FindElement(By.LinkText("Education"));
            EducationTab.Click();


            IWebElement AddNewButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[1]/i"));
            AddNewButton.Click();

            IWebElement UniversityName = driver.FindElement(By.Name("instituteName"));
            UniversityName.Click();
            UniversityName.Clear();
            UniversityName.SendKeys(University);

            SelectElement dropDown = new SelectElement(driver.FindElement(By.Name("country")));
            dropDown.SelectByValue(Country);

            SelectElement dropDownTitle = new SelectElement(driver.FindElement(By.Name("title")));
            dropDownTitle.SelectByValue(Title);

            IWebElement degreeName = driver.FindElement(By.Name("degree"));
            degreeName.Click();
            degreeName.Clear();
            degreeName.SendKeys(Degree);

            SelectElement dropDownYear = new SelectElement(driver.FindElement(By.Name("yearOfGraduation")));
            dropDownYear.SelectByValue(Year);

            IWebElement UpdateTextBox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td/div[3]/input[1]"));
            UpdateTextBox.Click();
            //WaitHelpers.WaitToBeClickable(driver, 10, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody[1]/tr/td/div[3]/input[1]");

        }
        public string GetEditedEducationTableDetails(IWebDriver driver)
        {
            WaitHelpers.WaitIsVisible(driver, 10, "XPath", "//div[@class='ns-box-inner']");
            IWebElement newEducation = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]"));
            return newEducation.GetAttribute("outerText").ToString();

        }
        public void deleteEducation(IWebDriver driver)
        {
            IWebElement EducationTab = driver.FindElement(By.LinkText("Education"));
            EducationTab.Click();
            

            //delete the record
            Thread.Sleep(2500);
            IWebElement deleteEducation = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i"));
            

            deleteEducation.Click();
            //WaitHelpers.WaitToBeClickable(driver, 40, "XPath", "//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[4]/div/div[2]/div/table/tbody/tr/td[6]/span[2]/i");

        }
        public string DeleteEducationAssertion(IWebDriver driver)
        {
            WaitHelpers.WaitIsVisible(driver, 10, "XPath", "//div[@class='ns-box-inner']");
            IWebElement deleteEducation = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]"));
            return deleteEducation.GetAttribute("outerText").ToString();
        }
    } 
}
