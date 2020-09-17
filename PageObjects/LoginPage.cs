using OpenQA.Selenium;
using System;

namespace NUnitTestMy7N.PageObjects
{
    public class LoginPage

    {
        public LoginPage(IWebDriver driver, string url) : this(driver)
        {
            _loginUrl = url;
        }

        internal LoginPage(IWebDriver driver) : base(driver)
        {
            
        }

        private string _loginUrl;

        private IWebElement _usernameField => driver.FindElement(By.CssSelector("#userNameInput"));
        private IWebElement _passwordField => driver.FindElement(By.CssSelector("#passwordInput"));
        private IWebElement _submitButton => driver.FindElement(By.CssSelector("#submitButton"));
        private IWebElement _forgotPasswordButton => driver.FindElement(By.XPath("//*[@id='introduction']/p[1]/a"));


        //TO DO: wyszukiwanie po tekscie komunikatu, bo jest jeden selektor dla 2 różnych rzeczy
        //Errors
        private readonly By _emptyUsernameErrorBy = By.CssSelector("#errorText");
        private IWebElement _emptyUsernameError => driver.FindElement(_emptyUsernameErrorBy);

        private readonly By _passwordRequiredErrorBy = By.CssSelector("#errorText");
        private IWebElement _passwordRequiredError => driver.FindElement(_passwordRequiredErrorBy);

        
        /// <summary>
        /// Go to page with login 
        /// </summary>
        public override void GoTo()
        {
            driver.GoToUrl(_loginUrl);
        }

        /// <summary>
        /// Enter the username.
        /// </summary>
        public void ProvideUsername(string username)
        {
            _usernameField.SendKeys(username);
        }

        /// <summary>
        /// Enter the password.
        /// </summary>
        public void ProvidePassword(string password)
        {
            _passwordField.SendKeys(password);
        }

        public void SubmitUsername()
        {
            _passwordField.Click();
        }

        public DashboardPage SubmitPassword()
        {
            _submitButton.Click();
            return new DashboardPage(driver);
        }

        /// <summary>
        /// Login attempt method with correct user name and password.
        /// </summary>
        public void LogInWithCredentials(string username, string password)
        {
            if (!driver.Url.Contains("authorize"))
                return;
            ProvideUsername(username);
            SubmitUsername();
            ProvidePassword(password);
            SubmitPassword();

            {
                GoTo();
                LogInWithCredentials(username, password);
            }
        }

        /// <summary>
        /// Method used to clear the user field
        /// </summary>
        private void ClearUsername()
        {
            _usernameField.Clear();
        }

        // <summary>
        /// Login attempt method with empty user field
        /// </summary>
        public void LogInWithEmptyUsername()
        {
            ClearUsername();
            _submitButton.Click();
        }

        /// <summary>
        /// Get the text of the error when the username is empty.
        /// </summary>
        public string EmptyUsernameError
        {
            get
            {
                driver.Wait().ForElementDisplayed(_emptyUsernameErrorBy);
                return _emptyUsernameError.Text;
            }
        }

            /// <summary>
            /// Get the text of the error when the password is empty.
            /// </summary>
        public string PasswordRequiredError
        {
            get
            {
                driver.Wait().ForElementDisplayed(_passwordRequiredErrorBy);
                return _passwordRequiredError.Text;
            }
        }

        
        }

    }
    
    



