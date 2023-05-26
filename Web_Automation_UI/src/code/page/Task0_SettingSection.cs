using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using Web_Automation_UI.src.code.control;

namespace Web_Automation_UI.src.code.page
{
    internal class Task0_SettingSection
    {
        public Button settingConfiguration = new Button(By.XPath("//a[text()='Settings']"));
        public TextBox nameUser = new TextBox(By.Id("FullNameInput"));
        public Button setConfiguration = new Button(By.XPath("//span[text()='Ok']"));

        public void nameChange(String name)
        {
            nameUser.SetText(name);
        }

        public Boolean NameDisplayed(String nameValue)
        {
            Label nameProject = new Label(By.Id("FullNameInput"));
            return nameProject.IsControlDisplayed();
        }
    }
}
