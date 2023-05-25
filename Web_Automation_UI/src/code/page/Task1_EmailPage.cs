using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Web_Automation_UI.src.code.control;


namespace Web_Automation_UI.src.code.page
{
    public class Task1_EmailPage
    {
        public Label LoginLabel = new Label(By.ClassName("bname"));

        public Button newEmailButton = new Button(By.Id("newmail"));

        public TextBox emailReceiverTxtBox = new TextBox(By.Id("msgto"));
        public TextBox emailSubjectTxtBox = new TextBox(By.Id("msgsubject"));
        public TextBox emailBodyTxtBox = new TextBox(By.Id("msgbody"));
        public Button sendButton = new Button(By.Id("msgsend"));
        public Label SuccessLabel = new Label(By.Id("msgpop"));


        public void fillEmail(String receiver, String subject, String body)
        {
            emailReceiverTxtBox.SetText(receiver);
            emailSubjectTxtBox.SetText(subject);
            emailBodyTxtBox.SetText(body);
        }


    }
}
