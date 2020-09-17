using OpenQA.Selenium;

namespace NUnitTestMy7N.PageObjects
{
    public class ReferralsPage
    {
        public ReferralsPage(IWebDriver driver)
        {
           
        }

        private IWebElement _submitAReferralButton => driver.FindElement(By.XPath("//*[@id='sub-navbar']/referrals-submenu/div/div/button"));


        //Step 1/3
        //Candidate’s personal details

        private IWebElement _titleField => driver.FindElement(By.XPath(""));
        private IWebElement _firstNameField => driver.FindElement(By.CssSelector("#mat-input-0"));
        private IWebElement _lastNameField => driver.FindElement(By.CssSelector("#mat-input-1"));
        private IWebElement _cityField => driver.FindElement(By.CssSelector("#mat-input-2"));
        private IWebElement _emailField => driver.FindElement(By.CssSelector("#mat-input-9"));
        private IWebElement _phoneField => driver.FindElement(By.CssSelector("#mat-input-10"));


        //Candidate’s career  details

        private IWebElement _areaField => driver.FindElement(By.CssSelector(""));
        private IWebElement _uploadFile => driver.FindElement(By.XPath("//*[@id='mat-radio-5']/label/div[1]/div[2]"));
        private IWebElement _addLink => driver.FindElement(By.XPath("//*[@id='mat-radio-6']/label/div[1]/div[2]"));
        private IWebElement _linkedInProfileField => driver.FindElement(By.CssSelector("#mat-input-14"));
        private IWebElement _addFiles => driver.FindElement(By.CssSelector(""));
        private IWebElement _jobOfferField => driver.FindElement(By.CssSelector("#mat-input-11"));


        //Button next and submit referral

        private IWebElement _nextStepSubmitButton => driver.FindElement(By.XPath("//*[@id='sub-navbar']/stepper-navigation/div/div[1]/div[3]/button"));


        //Step 2/3
        //Connection with this person

        private IWebElement _formerCoworker => driver.FindElement(By.XPath("//*[@id='mat-radio-30']/label/div[1]/div[1]"));
        private IWebElement _fromSchool => driver.FindElement(By.XPath("//*[@id='mat-radio-31']/label/div[1]/div[1]"));
        private IWebElement _friend => driver.FindElement(By.XPath("//*[@id='mat-radio-32']/label/div[1]/div[1]"));
        private IWebElement _other => driver.FindElement(By.XPath("//*[@id='mat-radio-33']/label/div[1]/div[1]"));
        private IWebElement _twoYears => driver.FindElement(By.XPath("//*[@id='mat-radio-34']/label/div[1]/div[1]"));
        private IWebElement _fiveYears => driver.FindElement(By.XPath("//*[@id='mat-radio-35']/label/div[1]/div[1]"));
        private IWebElement _moreThanFiveYears => driver.FindElement(By.XPath("//*[@id='mat-radio-36']/label/div[1]/div[1]"));
        private IWebElement _recommmendationMessageField => driver.FindElement(By.CssSelector("#mat-input-7"));


        //Step 3/3

        private IWebElement _declareCheckbox => driver.FindElement(By.XPath("//*[@id='mat-checkbox-785']/label/div"));



    }

}
