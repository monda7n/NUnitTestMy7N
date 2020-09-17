using OpenQA.Selenium;

namespace NUnitTestMy7N.PageObjects
{
    public class DashboardPage

    {
        public DashboardPage(IWebDriver driver)
        {
           
        }

        private IWebElement _home => driver.FindElement(By.XPath("//*[@id='tabs']/nav/div[2]/div/div/a[1]"));
        private IWebElement _consultans => driver.FindElement(By.XPath("//*[@id='tabs']/nav/div[2]/div/div/a[2]"));
        private IWebElement _events => driver.FindElement(By.XPath("//*[@id='tabs']/nav/div[2]/div/div/a[3]"));
        private IWebElement _referrals => driver.FindElement(By.XPath("//*[@id='tabs']/nav/div[2]/div/div/a[4]"));

        //[FindsBy(How = How.XPath, Using = "//*[@id='tabs']/nav/div[2]/div/div/a[4]")]
        //public IWebElement _referrals { get; set; }

        public void NavigateToHomeSection()
        {
            _home.Click();
        }

        public void NavigateToConsultansSection()
        {
            _consultans.Click();
        }

        public void NavigateToEventsSection()
        {
            _events.Click();
        }

        public Referrals NavigateToReferralsSection()
        {
            _referrals.Click();
            return new ReferralsPage();
        }

    }

}
