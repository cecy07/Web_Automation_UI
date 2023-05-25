using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Web_Automation_UI.src.code.control;

namespace Web_Automation_UI.src.code.page
{
    public class Task1_MainPage
    {
        public Button loginButton = new Button(By.CssSelector("div#refreshbut > button"));
        public TextBox emailTxtBox = new TextBox(By.Id("login"));


        public void Login(String mail)
        {
            emailTxtBox.SetText(mail);
            loginButton.Click();
        }
    }
}