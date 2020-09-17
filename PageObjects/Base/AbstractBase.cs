using OpenQA.Selenium;
using System;

namespace NUnitTestMy7N.PageObjects.Base
{
    public abstract class AbstractBase
    {
        protected IWebDriver driver;

        protected By ByToWaitForWhenStaleOccurs => By.XPath("//*[@id='main-container']/div/timeline/layout-container/div/div");
        //*[@id="main-container"]/div/timeline/layout-container/div/div
        private readonly By _blockOverlayBy = By.CssSelector(".blockOverlay");

        public AbstractBase(IWebDriver driver)
        {
            
        }

        //protected bool WaitForBlockOverlayToAppearSilently()
        //{
        //    return driver.Wait().AndIgnoreTimeout(ExpectedConditions.ElementIsVisible(_blockOverlayBy), TimeSpan.FromMilliseconds(500));
        //}

        //protected bool WaitForBlockOverLayToDisappearSilently() => WaitForBlockOverLayToDisappearSilently(driver.DefaultWaitTime);

        //protected bool WaitForBlockOverLayToDisappearSilently(TimeSpan timeout)
        //{
        //    return driver.Wait().AndIgnoreTimeout(FindBlockOverlay, timeout, "Waiting for blockOverlay to not exist silently");
        //}

        //protected bool WaitForBlockOverlayToDisappear() => WaitForBlockOverlayToDisappear(driver.DefaultWaitTime);

        //protected bool WaitForBlockOverlayToDisappear(TimeSpan timeout)
        //{
        //    driver.Wait().For(FindBlockOverlay, timeout, "Waiting for blockOverlay to not exist");
        //    return true;
        //}

        private Func<IWebDriver, bool> FindBlockOverlay => (driver) =>
        {
            try
            {
                driver.FindElement(_blockOverlayBy);
                return false;
            }
            catch (NoSuchElementException)
            {
                return true;
            }
            catch (StaleElementReferenceException)
            {
                return true;
            }
        };

        
    }
}
