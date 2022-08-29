
using MARS_QA.Pages;
using MARS_QA.Utilities;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using System;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace MARS_QA.StepDefinition
{
    [Binding]
    public class LanguagesStepDefinitions : CommonDriver
    {

        LoginPage loginPageObj = new LoginPage(driver);
        Languages LanguagesPageObj = new Languages(driver);


        [Given(@"I logged into Mars portal successfully")]
        public void GivenILoggedIntoMarsPortalSuccessfully()
        {
            driver = new ChromeDriver();
            loginPageObj.LoginActions(driver);
        }

        [When(@"I navigate to Profile Page")]
        public void WhenINavigateToProfilePage()
        {
            loginPageObj.goToProfilePage(driver);
        }

        [Given(@"I Add language details '([^']*)','([^']*)'")]
        public void WhenIAddLanguageDetails(string p0, string p1)
        {
            LanguagesPageObj.AddLanguage(driver, p0, p1);
        }

        [Then(@"the new record for language should be created with '([^']*)','([^']*)' successfully")]
        public void ThenTheNewRecordForLanguageShouldBeCreatedWithSuccessfully(string p0, string p1)
        {
            
            string newLanguage = LanguagesPageObj.GetLanguageTableDetails(driver);
            string newlevel = LanguagesPageObj.GetLanguageTableDetails(driver);

            Assert.That(newLanguage.Contains(p0),"Acutal code and expected code do not match");
            Assert.That(newlevel.Contains(p1),"Acutal code and expected code do not match");
            driver.Quit();
        }
        [Given(@"I successfully able  to loggin into website")]
        public void GivenISuccessfullyAbleToLogginIntoWebsite()
        {
            loginPageObj.goToProfilePage(driver);
        }

        [When(@"I edit language '([^']*)','([^']*)' details")]
        public void WhenIEditLanguageDetails(string p0, string p1)
        {
            LanguagesPageObj.EditLanguage(driver, p0, p1);
        }

        
        [Then(@"The existing record for '([^']*)','([^']*)' should be updated successfully")]
        public void ThenTheExistingRecordForShouldBeUpdatedSuccessfully(string p0, string p1)
        {
            string updatedLanguage = LanguagesPageObj.GeteditLanguageTableDetails(driver);
            string newlevel = LanguagesPageObj.GeteditLanguageTableDetails(driver);

            Assert.That(updatedLanguage.Contains(p0),"Acutal code and expected code do not match");
            Assert.That(newlevel.Contains(p1),"Acutal code and expected code do not match");
            driver.Quit();
        }

        [Given(@"I successfully logged into the website")]
        public void GivenISuccessfullyLoggedIntoTheWebsite()
        {
            loginPageObj.goToProfilePage(driver);
        }

        [When(@"I click on delete language")]
        public void WhenIClickOnDeleteLanguage()
        {
            LanguagesPageObj.deleteLanguage(driver);
        }

        [Then(@"The record of language should be deleted successfully")]
        public void ThenTheRecordOfLanguageShouldBeDeletedSuccessfully()
        {
            string deleteLanguage = LanguagesPageObj.DeleteLanguageAssertion(driver);
            string deletelevel = LanguagesPageObj.DeleteLanguageAssertion(driver);

            Assert.That(deleteLanguage != "p0", "Acutal code and expected code do not match");
            Assert.That(deletelevel !="p1", "Acutal code and expected code do not match");
            driver.Quit();
        }
        [Given(@"I left language field as blank")]
        public void GivenILeftLanguageFieldAsBlank()
        {
            LanguagesPageObj.BlankLanguage(driver);
        }

        [Then(@"An Error message should be displayed")]
        public void ThenAnErrorMessageShouldBeDisplayed()
        {
            string BlankLanguage = LanguagesPageObj.GetBlankTableLanguageDetails(driver);
            string Blanklevel = LanguagesPageObj.GetBlankTableLanguageDetails(driver);

            Assert.That(BlankLanguage != "p0", "Acutal code and expected code do not match");
            Assert.That(Blanklevel != "p1", "Acutal code and expected code do not match");
            driver.Quit();
        }

    }
}
