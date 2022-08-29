using MARS_QA.Pages;
using MARS_QA.Utilities;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace MARS_QA.StepDefinition
{
    [Binding]
    public class EducationStepDefinitions : CommonDriver
    {
        LoginPage loginPageObj = new LoginPage(driver);
        Education EducationObj = new Education(driver);

        [Given(@"I add Education details with '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)'")]

        public void GivenIAddEducationDetailsWith(string p0, string p1, string p2, string p3, string p4)
        {
            EducationObj.AddEducation(driver, p0, p1, p2, p3, p4);
        }

        [Then(@"The new record for Education is created with '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)' successfully")]
        public void ThenTheNewRecordForEducationIsCreatedWithSuccessfully(string p0, string p1, string p2, string p3, string p4)
        {
            string newUniversity = EducationObj.GetEducationTableDetails(driver);
            string newCountry = EducationObj.GetEducationTableDetails(driver);
            string newTitle = EducationObj.GetEducationTableDetails(driver);
            string newDegree = EducationObj.GetEducationTableDetails(driver);
            string newYear = EducationObj.GetEducationTableDetails(driver);

            Assert.That(newUniversity.Contains(p0), "Acutal code and expected code do not match");
            Assert.That(newCountry.Contains(p1), "Acutal code and expected code do not match");
            Assert.That(newTitle.Contains(p2), "Acutal code and expected code do not match");
            Assert.That(newDegree.Contains(p3), "Acutal code and expected code do not match");
            Assert.That(newYear.Contains(p4), "Acutal code and expected code do not match");
            driver.Quit();
        }
        [Given(@"I edit Education details with '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)'")]
        public void GivenIEditEducationDetailsWith(string p0, string p1, string p2, string p3, string p4)
        {
            EducationObj.EditEducation(driver, p0, p1, p2, p3, p4);
        }

        [Then(@"The existing record for Education is updated with '([^']*)','([^']*)','([^']*)','([^']*)','([^']*)' successfully")]
        public void ThenTheExistingRecordForEducationIsUpdatedWithSuccessfully(string p0, string p1, string p2, string p3, string p4)
        {
            string newUniversity = EducationObj.GetEditedEducationTableDetails(driver);
            string newCountry = EducationObj.GetEditedEducationTableDetails(driver);
            string newTitle = EducationObj.GetEditedEducationTableDetails(driver);
            string newDegree = EducationObj.GetEditedEducationTableDetails(driver);
            string newYear = EducationObj.GetEditedEducationTableDetails(driver);

            Assert.That(newUniversity.Contains(p0), "Acutal code and expected code do not match");
            Assert.That(newCountry.Contains(p1), "Acutal code and expected code do not match");
            Assert.That(newTitle.Contains(p2), "Acutal code and expected code do not match");
            Assert.That(newDegree.Contains(p3), "Acutal code and expected code do not match");
            Assert.That(newYear.Contains(p4), "Acutal code and expected code do not match");
            driver.Quit();
        }



        [Given(@"I delete Education details")]
        public void WhenIDeleteEducationDetails()
        {
            EducationObj.deleteEducation(driver);
        }

        [Then(@"The record of Education should be deleted successfully")]
        public void ThenTheRecordOfEducationShouldBeDeletedSuccessfully()
        {
            string deleteUniversity = EducationObj.DeleteEducationAssertion(driver);
            string deleteCountry = EducationObj.DeleteEducationAssertion(driver);
            string deleteTitle = EducationObj.GetEditedEducationTableDetails(driver);
            string deleteDegree = EducationObj.GetEditedEducationTableDetails(driver);
            string deleteYearOfGraduation = EducationObj.GetEditedEducationTableDetails(driver);

            Assert.That(deleteUniversity != "p0", "Acutal code and expected code do not match");
            Assert.That(deleteCountry != "p1", "Acutal code and expected code do not match");
            Assert.That(deleteTitle != "p2", "Acutal code and expected code do not match");
            Assert.That(deleteDegree != "p3", "Acutal code and expected code do not match");
            Assert.That(deleteYearOfGraduation != "p4", "Acutal code and expected code do not match");

            driver.Quit();
        }
    }
}
