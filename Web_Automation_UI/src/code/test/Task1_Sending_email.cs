using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Web_Automation_UI.src.code.page;

namespace Web_Automation_UI.src.code.test
{
    [TestClass]
    public class Task1_Sending_email : Task1_TestBase
    {

        Task1_MainPage mainPage = new Task1_MainPage();
        Task1_EmailPage mailPage = new Task1_EmailPage();


        [TestMethod]
        public void sending_email()
        {
            string email_sender = "emailtest@yopmail.com";
            string receiver = "emailtest2@yopmail.com";
            string subject = "Test";
            string body = "This is a test";


            mainPage.emailTxtBox.SetText(email_sender);
            mainPage.loginButton.Click();
            Assert.AreEqual(email_sender, mailPage.LoginLabel.getText(), "ERROR: The login was not successful.");

            mailPage.newEmailButton.Click();
            session.Session.Instance().GetBrowser().SwitchTo().Frame("ifmail");
            mailPage.fillEmail(receiver, subject, body);

            Assert.IsTrue(mailPage.sendButton.IsControlDisplayed(), "ERROR: The send button is not enabled.");
            mailPage.sendButton.Click();

            Assert.IsNotNull(mailPage.SuccessLabel.getText(), "ERROR: Email not sent");

        }
    }
}