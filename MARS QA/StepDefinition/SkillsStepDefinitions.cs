using MARS_QA.Pages;
using MARS_QA.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MARS_QA
{
    [Binding]
    public class SkillsStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage(driver);
        SkillsPage SkillsPageObj = new SkillsPage(driver);

        [Given(@"I add skill details with '([^']*)','([^']*)' details")]
        public void GivenIAddSkillDetailsWithDetails(string p0, string p1)
        {
            SkillsPageObj.AddSkill(driver, p0, p1);
        }

        [Then(@"the new record for skill should be created with '([^']*)','([^']*)' successfully")]
        public void ThenTheNewRecordForSkillShouldBeCreatedWithSuccessfully(string p0, string p1)
        {
            string newSkill = SkillsPageObj.GetSkillsTableDetails(driver);
            string newlevel = SkillsPageObj.GetSkillsTableDetails(driver);

            Assert.That(newSkill.Contains(p0), "Acutal code and expected code do not match");
            Assert.That(newlevel.Contains(p1), "Acutal code and expected code do not match");
            driver.Quit();
        }
        

        [Given(@"I edit '([^']*)','([^']*)' details")]
        public void GivenIEditDetails(string p0, string p1)
        {
            SkillsPageObj.EditSkill(driver, p0, p1);
        }

        [Then(@"existing record for '([^']*)','([^']*)' should be updated successfully")]
        public void WhenExistingRecordForShouldBeUpdatedSuccessfully(string p0, string p1)
        {
            string updatedSkills = SkillsPageObj.GeteditSkillsTableDetails(driver);
            string updatedlevel = SkillsPageObj.GeteditSkillsTableDetails(driver);

            Assert.That(updatedSkills.Contains(p0), "Acutal code and expected code do not match");
            Assert.That(updatedlevel.Contains(p1), "Acutal code and expected code do not match");
            driver.Quit();
        }

        [Given(@"I click on delete Skills")]
        public void WhenIClickOnDeleteSkills()
        {
            SkillsPageObj.deleteSkills(driver);

        }

        [Then(@"The record of Skills should be deleted successfully")]
        public void ThenTheRecordOfSkillsShouldBeDeletedSuccessfully()
        {
            string deleteSkills = SkillsPageObj.DeleteSkillsAssertion(driver);
            string deletelevel = SkillsPageObj.DeleteSkillsAssertion(driver);

            Assert.That(deleteSkills != "p0", "Acutal code and expected code do not match");
            Assert.That(deletelevel != "p1", "Acutal code and expected code do not match");
            driver.Quit();

          

        }
        [Given(@"I left Skills details as blank")]
        public void GivenILeftSkillsDetailsAsBlank()
        {
            SkillsPageObj.BlankSkills(driver);
        }
        [Then(@"An Error message is thrown")]
        public void ThenAnErrorMessageIsThrown()
        {
            string BlankSkills = SkillsPageObj.GetBlankTableSkillsDetails(driver);
            string Blanklevel = SkillsPageObj.GetBlankTableSkillsDetails(driver);

            Assert.That(BlankSkills !="p0", "Acutal code and expected code do not match");
            Assert.That(Blanklevel != "p1", "Acutal code and expected code do not match");
            driver.Quit();
        }


    }
}
