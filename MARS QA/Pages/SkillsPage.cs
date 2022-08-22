using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using OpenQA.Selenium.Support.UI;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MARS_QA.Pages
{
    public class SkillsPage
    {
        public void AddSkill(IWebDriver driver, string Skill, string Level)
       {
           
              // Navigate to skills tab
              IWebElement SkillsTab = driver.FindElement(By.LinkText("Skills"));
              SkillsTab.Click();

              //Click on add new button
              IWebElement AddNewButton = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]"));
              AddNewButton.Click();
            


              IWebElement addSkill = driver.FindElement(By.Name("name"));
              addSkill.SendKeys(Skill);
            

              SelectElement dropDown = new SelectElement(driver.FindElement(By.Name("level")));
              dropDown.SelectByValue(Level);
            


              IWebElement AddButton = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
              AddButton.Click();
              Thread.Sleep(2500);
        }

           public string GetSkillsTableDetails(IWebDriver driver)
           {
               Thread.Sleep(2500);
               IWebElement newSkill = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]"));
               return newSkill.GetAttribute("outerText").ToString();

           }

        public void EditSkill(IWebDriver driver, string Skill, string Level)
        {
            Thread.Sleep(1500);
            //click on skills tab
            IWebElement SkillsTab = driver.FindElement(By.LinkText("Skills"));
            SkillsTab.Click();

            Thread.Sleep(2000);
            //Edit Skills functionality//
            IWebElement EditSkill = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            EditSkill.Click();
            Thread.Sleep(3000);

            //Edit Skill text box
            IWebElement EditSkillTextBox = driver.FindElement(By.Name("name"));
            EditSkillTextBox.Click();
            EditSkillTextBox.Clear();
            EditSkillTextBox.SendKeys(Skill);
            Thread.Sleep(2500);

            //select level from dropdown menu
            SelectElement dropDown = new SelectElement(driver.FindElement(By.Name("level")));
            dropDown.SelectByValue(Level);
            Thread.Sleep(2500);

            //Click on Update button
            IWebElement UpdateTextbox = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            UpdateTextbox.Click();
            Thread.Sleep(2000);
        }

        public string GeteditSkillsTableDetails(IWebDriver driver)
        {
            Thread.Sleep(3000);
            IWebElement updatedSkill = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]"));
            return updatedSkill.GetAttribute("outerText").ToString();
        }
        public void deleteSkills(IWebDriver driver)
        {
            IWebElement SkillsTab = driver.FindElement(By.LinkText("Skills"));
            SkillsTab.Click();
            Thread.Sleep(3000);

            //delete the record
            Thread.Sleep(2500);
            IWebElement deleteSkills = driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            Thread.Sleep(2500);

            deleteSkills.Click();
            Thread.Sleep(3000);

        }
        public string DeleteSkillsAssertion(IWebDriver driver)
        {
            Thread.Sleep(3000);
            IWebElement deleteSkills = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]"));
            return deleteSkills.GetAttribute("outerText").ToString();
        }

        public void BlankSkills(IWebDriver driver)
        {
            IWebElement SkillsTab = driver.FindElement(By.LinkText("Languages"));
            SkillsTab.Click();
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

        public string GetBlankTableSkillsDetails(IWebDriver driver)
        {
            Thread.Sleep(2500);
            IWebElement BlankDetails = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[2]/div[1]/div[2]/div[1]/table[1]"));
            return BlankDetails.GetAttribute("outerText").ToString();

        }
    }

}











