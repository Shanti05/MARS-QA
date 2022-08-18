using MARS_QA.Pages;
using MARS_QA.Utilities;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MARS_QA.StepDefinition
{
    [Binding]
    public class ProfileStepDefinitions : CommonDriver
    {
        LoginPage LoginPageobj = new LoginPage();
        ProfilePage ProfilePageobj = new ProfilePage();

        [Given(@"Login with valid email-id and password")]
        public void GivenLoginWithValidEmail_IdAndPassword()
        {
            driver = new ChromeDriver();
            LoginPageobj.LoginActions(driver);

        }

        [Then(@"The customer name should appear in the Profile page")]
        public static void ThenTheCustomerNameShouldAppearInTheProfilePage()
        {
            
        }

        [Given(@"Logging in with invalid credentials")]
        public void GivenLoggingInWithInvalidCredentials()
        {
            throw new PendingStepException();
        }

        [Given(@"The customer can see ""([^""]*)""")]
        public void GivenTheCustomerCanSee(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"Error message should be displayed")]
        public void ThenErrorMessageShouldBeDisplayed()
        {
            throw new PendingStepException();
        }

        [Given(@"I successfully logged into website")]
        public void GivenISuccessfullyLoggedIntoWebsite()
        {
            throw new PendingStepException();
        }

        [When(@"I navigate to language tab in the profile")]
        public void WhenINavigateToLanguageTabInTheProfile()
        {
            throw new PendingStepException();
        }

        [When(@"I create language details with '([^']*)'")]
        public void WhenICreateLanguageDetailsWith(string language)
        {
            throw new PendingStepException();
        }

        [Then(@"the new record for language should be created with '([^']*)' successfully")]
        public void ThenTheNewRecordForLanguageShouldBeCreatedWithSuccessfully(string language)
        {
            throw new PendingStepException();
        }

        [When(@"I edit '([^']*)' details")]
        public void WhenIEditDetails(string language)
        {
            throw new PendingStepException();
        }

        [Then(@"The existing record for '([^']*)' should be updated successfully")]
        public void ThenTheExistingRecordForShouldBeUpdatedSuccessfully(string language)
        {
            throw new PendingStepException();
        }

        [When(@"I delete language datails")]
        public void WhenIDeleteLanguageDatails()
        {
            throw new PendingStepException();
        }

        [Then(@"The record of language should be deleted successfully")]
        public void ThenTheRecordOfLanguageShouldBeDeletedSuccessfully()
        {
            throw new PendingStepException();
        }

        [When(@"I navigate to Skills tab in the profile")]
        public void WhenINavigateToSkillsTabInTheProfile()
        {
            throw new PendingStepException();
        }

        [When(@"I add skill details with '([^']*)'")]
        public void WhenIAddSkillDetailsWith(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"the new record for skill should be created with '([^']*)' successfully")]
        public void ThenTheNewRecordForSkillShouldBeCreatedWithSuccessfully(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"I successfully logged  into website")]
        public void GivenISuccessfullyLoggedIntoWebsite()
        {
            throw new PendingStepException();
        }

        [When(@"I edit '([^']*)' details")]
        public void WhenIEditDetails(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"The existing record for '([^']*)' should be updated successfully")]
        public void ThenTheExistingRecordForShouldBeUpdatedSuccessfully(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@": I successfully logged into website")]
        public void GivenISuccessfullyLoggedIntoWebsite()
        {
            throw new PendingStepException();
        }

        [When(@": I navigate to skills tab in the profile")]
        public void WhenINavigateToSkillsTabInTheProfile()
        {
            throw new PendingStepException();
        }

        [When(@":I delete Skill details")]
        public void WhenIDeleteSkillDetails()
        {
            throw new PendingStepException();
        }

        [Then(@":The record of Skills should be deleted successfully")]
        public void ThenTheRecordOfSkillsShouldBeDeletedSuccessfully()
        {
            throw new PendingStepException();
        }

        [Given(@": I successfully  logged  into website")]
        public void GivenISuccessfullyLoggedIntoWebsite()
        {
            throw new PendingStepException();
        }

        [When(@":  I navigate to Education tab in the profile")]
        public void WhenINavigateToEducationTabInTheProfile()
        {
            throw new PendingStepException();
        }

        [When(@": I add Education details with '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)'")]
        public void WhenIAddEducationDetailsWith(string p0, string p1, string p2, string btech, string p4)
        {
            throw new PendingStepException();
        }

        [Then(@":The new record for Education is created with '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)' successfully")]
        public void ThenTheNewRecordForEducationIsCreatedWithSuccessfully(string p0, string p1, string p2, string btech, string p4)
        {
            throw new PendingStepException();
        }

        [Given(@":  I successfully  logged  into website")]
        public void GivenISuccessfullyLoggedIntoWebsite()
        {
            throw new PendingStepException();
        }

        [When(@": I navigate to Education tab in the profile")]
        public void WhenINavigateToEducationTabInTheProfile()
        {
            throw new PendingStepException();
        }

        [When(@": I edit Education details with '([^']*)','([^']*)'")]
        public void WhenIEditEducationDetailsWith(string p0, string p1)
        {
            throw new PendingStepException();
        }

        [Then(@": The existing record for Education is updated with '([^']*)','([^']*)' successfully")]
        public void ThenTheExistingRecordForEducationIsUpdatedWithSuccessfully(string p0, string p1)
        {
            throw new PendingStepException();
        }

        [When(@": I delete Education details")]
        public void WhenIDeleteEducationDetails()
        {
            throw new PendingStepException();
        }

        [Then(@": The record of Education should be deleted successfully")]
        public void ThenTheRecordOfEducationShouldBeDeletedSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
