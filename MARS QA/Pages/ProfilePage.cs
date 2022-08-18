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
    public class ProfilePage
    {

        public void addLanguage(IWebDriver driver, string language, string level)
        {

            IWebElement languagesTab = driver.FindElement(By.LinkText("Languages"));
            languagesTab.Click();

            IWebElement AddNewButton = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
            AddNewButton.Click();
            Thread.Sleep(1500);


            IWebElement addLanguage = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]"));
            addLanguage.SendKeys(language);

            SelectElement dropDown = new SelectElement(driver.FindElement(By.Name("level")));
            dropDown.SelectByValue(level);


            IWebElement AddButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            AddButton.Click();

            Thread.Sleep(2500);

        }

        public string GetLanguageTableDetails(IWebDriver driver)
        {
            IWebElement languageTableDetails = driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target']//div[@class='form-wrapper']"));
            return languageTableDetails.Text;

        }



        public void EditLanguage(IWebDriver driver, string language, string level)
        {
            //click on languages tab
            IWebElement languagesTab = driver.FindElement(By.LinkText("Languages"));
            languagesTab.Click();

            Thread.Sleep(2000);
            //Edit Language functionality//
            IWebElement EditLanguage = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]/span[1]/i[1]"));
            EditLanguage.Click();
            Thread.Sleep(3000);

            //Edit language text box
            IWebElement EditlanguageTextBox = driver.FindElement(By.Name("name"));
            EditLanguage.Click();
            EditLanguage.Clear();
            EditlanguageTextBox.SendKeys(language);

            //select level from dropdown menu
            SelectElement dropDown = new SelectElement(driver.FindElement(By.Name("level")));
            dropDown.SelectByValue(level);


            //Click on Update button
            IWebElement UpdateTextbox = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/span[1]/input[1]"));
            UpdateTextbox.Click();
            Thread.Sleep(2000);


        }
        public string GeteditLanguageTableDetails(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement editLanguageTableDetails = driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment tooltip-target active']//div[@class='form-wrapper']"));
            return editLanguageTableDetails.Text;
        }

        public void deleteLanguage(IWebDriver driver)
        {
            IWebElement languagesTab = driver.FindElement(By.LinkText("Languages"));
            languagesTab.Click();

            //delete the record
            Thread.Sleep(2500);
            IWebElement deleteLanguage = driver.FindElement(By.XPath("//i[@class='remove icon']"));
            Thread.Sleep(2500);

            deleteLanguage.Click();
            Thread.Sleep(3000);

        }
        public void deleteLanguageAssertion(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement deleteLanguage = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr[last()]/td[1]"));
            Assert.That(deleteLanguage.Text != "Hindi", "Record has not been deleted");
        }
        public void addSkill(IWebDriver driver, string Skill, string level)
        {
            IWebElement addNewSkill = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
            addNewSkill.Click();

            IWebElement addSkill = driver.FindElement(By.Name("name"));
            addSkill.SendKeys(Skill);

            SelectElement dropDown = new SelectElement(driver.FindElement(By.Name("level")));
            dropDown.SelectByValue(level);

            IWebElement addSkillButton = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/span[1]/input[1]"));
            addSkillButton.Click();
        }
        public string getSkillsTableDetails(IWebDriver driver)
        {
            IWebElement getSkillsTableDetails = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]"));
            return getSkillsTableDetails.Text;
        }
        public void EditSkills(IWebDriver driver, string Skill, string level)
        {
            //click on Skills tab
            IWebElement SkillsTab = driver.FindElement(By.LinkText("Skills"));
            SkillsTab.Click();

            Thread.Sleep(2000);
            //Edit Skills functionality//
            IWebElement EditSkill = driver.FindElement(By.XPath("//td[@class='right aligned']//i[@class='outline write icon']"));
            EditSkill.Click();
            Thread.Sleep(3000);

            //Edit Skills text box
            IWebElement EditSkillTextBox = driver.FindElement(By.Name("name"));
            EditSkillTextBox.Click();
            EditSkillTextBox.Clear();
            EditSkillTextBox.SendKeys(Skill);

            //select level from dropdown menu
            SelectElement dropDown = new SelectElement(driver.FindElement(By.Name("level")));
            dropDown.SelectByValue(level);

            //Click on Update button
            IWebElement UpdateTextbox = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[1]/span[1]/input[1]"));
            UpdateTextbox.Click();
            Thread.Sleep(2000);
        }

        public string GetEditSkillTableDetails(IWebDriver driver)

        {
            Thread.Sleep(2000);
            IWebElement GetEditSkillTableDetails = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]"));
            return GetEditSkillTableDetails.Text;
        }
        public void deleteSkill(IWebDriver driver)
        {
            IWebElement SkillsTab = driver.FindElement(By.LinkText("Skills"));
            SkillsTab.Click();

            //delete the record
            Thread.Sleep(2500);
            IWebElement deleteSkill = driver.FindElement(By.XPath("//i[@class='remove icon']"));
            Thread.Sleep(2500);

            deleteSkill.Click();
            Thread.Sleep(3000);

        }
        public void deleteSkillAssertion(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement deleteSkill = driver.FindElement(By.XPath("//th[contains(text(),'Skill')]"));
            Assert.That(deleteSkill.Text != "Cycling", "Record has not been deleted");
        }
        public void addEducation(IWebDriver driver, string CollegeName, string country, string title, string degree, string yearOfGraduation)
        {
            //Navigate to Education tab
            IWebElement educationTab = driver.FindElement(By.LinkText("Education"));
            educationTab.Click();

            //Click on new botton
            IWebElement AddNewButton = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[6]/div[1]"));
            AddNewButton.Click();
            Thread.Sleep(1500);

            //Identify College/University name text box click on it
            IWebElement collegeNameTextBox = driver.FindElement(By.Name("instituteName"));
            collegeNameTextBox.SendKeys(CollegeName);

            //select country from dropdown box
            SelectElement countrydropDown = new SelectElement(driver.FindElement(By.Name("country")));
            countrydropDown.SelectByValue(country);

            //select  title from dropdown box
            SelectElement titledropDown = new SelectElement(driver.FindElement(By.Name("title")));
            titledropDown.SelectByValue(title);

            //Identidy degree text box and click on it
            IWebElement degreeTextBox = driver.FindElement(By.Name("degree"));
            degreeTextBox.SendKeys(degree);

            //select  year of degree from dropdown box
            SelectElement yearOfDegreedropDown = new SelectElement(driver.FindElement(By.Name("yearOfGraduation")));
            yearOfDegreedropDown.SelectByValue(yearOfGraduation);

            //click on add button
            IWebElement AddButton = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[3]/div[1]/input[1]"));
            AddButton.Click();

            Thread.Sleep(2500);

        }

        public string GetEducationTableDetails(IWebDriver driver)
        {
            IWebElement GetEducationTableDetails = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]"));
            return GetEducationTableDetails.Text;

        }



        public void EditEducation(IWebDriver driver, string instituteName, string country, string title, string degree, string yearOfGraduation)
        {
            //click on Education  tab
            IWebElement educationTab = driver.FindElement(By.Name("Education"));
            educationTab.Click();

            Thread.Sleep(2000);
            //Edit Education nfunctionality//
            IWebElement EditEducation = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[6]/span[1]/i[1]"));
            EditEducation.Click();
            Thread.Sleep(3000);

            //navigate to college text box
            IWebElement EditCollegeTextBox = driver.FindElement(By.Name("instituteName"));
            EditCollegeTextBox.Click();
            EditCollegeTextBox.Clear();
            EditCollegeTextBox.SendKeys(instituteName);

            //select  college from dropdown box
            SelectElement countrydropDown = new SelectElement(driver.FindElement(By.Name("country")));
            countrydropDown.SelectByValue(country);


            //select  title from dropdown box
            SelectElement editTitledropDown = new SelectElement(driver.FindElement(By.Name("title")));
            editTitledropDown.SelectByValue(title);

            //Identidy degree text box and click on it
            IWebElement degreeTextBox = driver.FindElement(By.Name("degree"));
            degreeTextBox.SendKeys(degree);

            //select  year of degree from dropdown box
            SelectElement editYearOfDegreedropDown = new SelectElement(driver.FindElement(By.Name("yearOfGraduation")));
            editYearOfDegreedropDown.SelectByValue(yearOfGraduation);

            //click on update button
            IWebElement updateButton = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[1]/div[3]/input[1]"));
            updateButton.Click();
            Thread.Sleep(2500);


        }
        public string GetEditedEducationTableDetails(IWebDriver driver)
        {
            Thread.Sleep(2000);
            IWebElement editedEducationTableDetails = driver.FindElement(By.TagName("td"));
            return editedEducationTableDetails.Text;
        }

        public void deleteEducation(IWebDriver driver)
        {
            IWebElement educationTab = driver.FindElement(By.LinkText("Languages"));
            educationTab.Click();

            //delete the record
            Thread.Sleep(2500);
            IWebElement deleteEducation = driver.FindElement(By.XPath("//i[@class='remove icon']"));
            deleteEducation.Click();
            Thread.Sleep(3000);

        }
        //public void deleteEducationAssertion(IWebDriver driver)
        //{
        // Thread.Sleep(2000);
        //IWebElement deleteEducation = driver.FindElement(By.XPath("//td[contains(text(),'Australia')]"));
        //Assert.That(deleteEducation.Text != "", "Record has not been deleted");
        //}//
    }
}
    

