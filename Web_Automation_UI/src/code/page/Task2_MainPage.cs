using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Web_Automation_UI.src.code.control;

namespace Web_Automation_UI.src.code.page
{
    internal class Task2_MainPage
    {
        public Button loginButton = new Button(By.CssSelector("a[href='/auth/login']"));
        public TextBox emailTxtBox = new TextBox(By.CssSelector("input[placeholder='Enter your email...']"));
        public TextBox pswTxtBox = new TextBox(By.CssSelector("input[placeholder='Enter your password...']"));
        public Button submitButton = new Button(By.CssSelector("button[data-gtm-id=\"start-email-login\"]"));

        public void Login(String mail, String password)
        {
            emailTxtBox.SetText(mail);
            pswTxtBox.SetText(password);
            submitButton.Click();
        }
    }
}
